using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using OC.Domain.ViewModels.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.BranchesAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CellGroupsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<CellGroup> _unitOfWork;
        private IUnitOfWork<CellGroupHost> _unitOfWorkHost;
        private readonly IMapper _mapper;

        public CellGroupsController(IMapper mapper, IUnitOfWork<CellGroup> unitOfWork, IUnitOfWork<CellGroupHost> unitOfWorkHost, ILogger<CellGroupsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _unitOfWorkHost = unitOfWorkHost;
            _logger = logger;
        }

        /// <summary>
        /// Get all cellGroup
        /// </summary>
        /// <returns>List of cellGroup</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellGroupMiniViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetCellGroups()
        {
            var allCellGroups = _unitOfWork.Entity.GetAll();
            return Ok(_mapper.Map<IEnumerable<CellGroupMiniViewModel>>(allCellGroups));
        }

        /// <summary>
        /// Get all cellGroup
        /// </summary>
        /// <returns>List of cellGroup</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellGroupMiniViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activecellGroups")]
        public IActionResult GetActiveCellGroups()
        {
            var allCellGroups = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<CellGroupMiniViewModel>>(allCellGroups));
        }

        /// <summary>
        /// Get cellGroup by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellGroupViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetCellGroup([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cellGroup = _unitOfWork.Entity.GetSingle(m => m.Id == id, c => c.Members, c => c.CellLeaderships).FirstOrDefault();

            if (cellGroup == null)
            {
                throw new NotFoundException($"CellGroup Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<CellGroupViewModel>(cellGroup));
        }

        /// <summary>
        /// Update a cell group
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cellGroup"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCellGroup([FromRoute] long id, [FromBody] CellGroupNewViewModel cellGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the CellGroup to edit
            var _cellGroup = await _unitOfWork.Entity.GetSingle(id);

            if (id != _cellGroup.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _cellGroup.BranchId = cellGroup.BranchId;
                _cellGroup.Name = cellGroup.Name;
                _cellGroup.MeetingDay = cellGroup.MeetingDay;
                _cellGroup.MeetingTime = cellGroup.MeetingTime;
                _cellGroup.IsActive = cellGroup.IsActive;
            }
            // Implement state management of entities _context.Entry(cellGroup).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_cellGroup);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CellGroupExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("PutCellGroup", new { id = _cellGroup.Id }, _cellGroup);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedCellGroupIsActive(long id, bool isActive = false)
        {
            var cellGroup = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (cellGroup == null)
                throw new NotFoundException("CellGroup not found");

            cellGroup.IsActive = isActive;

            // save 
            _unitOfWork.Entity.Update(cellGroup);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = cellGroup.Id }, cellGroup);
        }
        /// <summary>
        /// Create a new Cell Group
        /// </summary>
        /// <param name="cellGroup"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostCellGroup([FromBody] CellGroupNewViewModel cellGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newCellGroup = _mapper.Map<CellGroup>(cellGroup);
     
            _unitOfWork.Entity.Add(newCellGroup);
            await _unitOfWork.SaveChangesAsync();

            // Create a new host based on input
            var newCellGroupHost = new CellGroupHost
            {
                CellGroupId = newCellGroup.Id,
                MemberId = cellGroup.HostMemberId,
            };

            // Commit host details 
            _unitOfWorkHost.Entity.Add(newCellGroupHost);
            await _unitOfWorkHost.SaveChangesAsync();

            return CreatedAtAction("PostCellGroup", new { id = newCellGroup.Id }, newCellGroup);
        }

        // DELETE: api/CellGroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCellGroup([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cellGroup = await _unitOfWork.Entity.GetSingle(id);  // _context.CellGroups.FindAsync(id);
            if (cellGroup == null)
            {
                return NotFound();
            }

            /*_unitOfWork.Entity.Delete(cellGroup);
            await _unitOfWork.SaveChangesAsync();*/

            return Ok(cellGroup);
        }

        private bool CellGroupExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
