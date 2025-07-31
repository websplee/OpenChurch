using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using OC.Domain.ViewModels.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.BranchesAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CellLeadershipsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<CellLeadership> _unitOfWork;
        private readonly IMapper _mapper;

        public CellLeadershipsController(IMapper mapper, IUnitOfWork<CellLeadership> unitOfWork, ILogger<CellLeadershipsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all cellLeadership
        /// </summary>
        /// <returns>List of cellLeadership</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellLeadershipViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetCellLeaderships()
        {
            var allCellLeaderships = _unitOfWork.Entity.GetAll();
            return Ok(_mapper.Map<IEnumerable<CellLeadershipViewModel>>(allCellLeaderships));
        }

        /// <summary>
        /// Get all cellLeadership
        /// </summary>
        /// <returns>List of cellLeadership</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellLeadershipViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activecellLeaderships")]
        public IActionResult GetActiveCellLeaderships()
        {
            var allCellLeaderships = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<CellLeadershipViewModel>>(allCellLeaderships));
        }

        /// <summary>
        /// Get cellLeadership by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellLeadershipViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetCellLeadership([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cellLeadership = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (cellLeadership == null)
            {
                throw new NotFoundException($"CellLeadership Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<CellLeadershipViewModel>(cellLeadership));
        }

        // PUT: api/CellLeadership/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCellLeadership([FromRoute] long id, [FromBody] CellLeadershipViewModel cellLeadership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the CellLeadership to edit
            var _cellLeadership = await _unitOfWork.Entity.GetSingle(id);

            if (id != _cellLeadership.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _cellLeadership.CellGroupId = cellLeadership.CellGroupId;
                _cellLeadership.LeadershipRoleId = cellLeadership.LeadershipRoleId;
                _cellLeadership.MemberId = cellLeadership.MemberId;
                _cellLeadership.IsActive = cellLeadership.IsActive;
            }
            // Implement state management of entities _context.Entry(cellLeadership).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_cellLeadership);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CellLeadershipExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("CellLeadershipUpdate", new { id = _cellLeadership.Id }, _cellLeadership);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cellLeadershipViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedCellLeadershipIsActive(long id, [FromBody] CellLeadershipViewModel cellLeadershipViewModel)
        {
            var cellLeadership = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (cellLeadership == null)
                throw new NotFoundException("CellLeadership not found");

            cellLeadership.IsActive = cellLeadershipViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(cellLeadership);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = cellLeadership.Id }, cellLeadership);
        }
        // POST: api/CellLeaderships
        [HttpPost]
        public async Task<IActionResult> PostCellLeadership([FromBody] CellLeadershipViewModel cellLeadership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newCellLeadership = _mapper.Map<CellLeadership>(cellLeadership);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.CellLeadershipExists(cellLeadership.Id))
                throw new BadRequestException("This cellLeadership exists!!");

            _unitOfWork.Entity.Add(newCellLeadership);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetCellLeadership", new { id = newCellLeadership.Id }, newCellLeadership);
        }

        // DELETE: api/CellLeaderships/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCellLeadership([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cellLeadership = await _unitOfWork.Entity.GetSingle(id);  // _context.CellLeaderships.FindAsync(id);
            if (cellLeadership == null)
            {
                return NotFound();
            }

            /*_unitOfWork.Entity.Delete(cellLeadership);
            await _unitOfWork.SaveChangesAsync();*/

            return Ok(cellLeadership);
        }

        private bool CellLeadershipExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
