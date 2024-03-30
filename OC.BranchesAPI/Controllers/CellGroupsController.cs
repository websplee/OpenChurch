using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.BranchesAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CellGroupsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<CellGroup> _unitOfWork;
        private readonly IMapper _mapper;

        public CellGroupsController(IMapper mapper, IUnitOfWork<CellGroup> unitOfWork, ILogger<CellGroupsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all cellGroup
        /// </summary>
        /// <returns>List of cellGroup</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellGroup>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetCellGroups()
        {
            var allCellGroups = _unitOfWork.Entity.GetAll();
            return Ok(allCellGroups);
        }

        /// <summary>
        /// Get all cellGroup
        /// </summary>
        /// <returns>List of cellGroup</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellGroup>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activecellGroups")]
        public IActionResult GetActiveCellGroups()
        {
            var allCellGroups = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allCellGroups);
        }

        /// <summary>
        /// Get cellGroup by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellGroup>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetCellGroup([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cellGroup = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (cellGroup == null)
            {
                throw new NotFoundException($"CellGroup Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<CellGroup>(cellGroup));
        }

        // PUT: api/CellGroup/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCellGroup([FromRoute] long id, [FromBody] CellGroup cellGroup)
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
                _cellGroup.IsActive = cellGroup.IsActive;
            }
            // Implement state management of entities _context.Entry(cellGroup).State = EntityState.Modified;

            try
            {
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

            return CreatedAtAction("CellGroupUpdate", new { id = _cellGroup.Id }, _cellGroup);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cellGroupViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedCellGroupIsActive(long id, [FromBody] CellGroup cellGroupViewModel)
        {
            var cellGroup = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (cellGroup == null)
                throw new NotFoundException("CellGroup not found");

            cellGroup.IsActive = cellGroupViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(cellGroup);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = cellGroup.Id }, cellGroup);
        }
        // POST: api/CellGroups
        [HttpPost]
        public async Task<IActionResult> PostCellGroup([FromBody] CellGroup cellGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newCellGroup = cellGroup;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.CellGroupExists(cellGroup.Id))
                throw new BadRequestException("This cellGroup exists!!");

            _unitOfWork.Entity.Add(newCellGroup);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetCellGroup", new { id = newCellGroup.Id }, newCellGroup);
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

            _unitOfWork.Entity.Delete(cellGroup);
            await _unitOfWork.SaveChangesAsync();

            return Ok(cellGroup);
        }

        private bool CellGroupExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
