using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.BranchStaffResignationAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BranchStaffResignationController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<BranchStaffResignation> _unitOfWork;
        private readonly IMapper _mapper;

        public BranchStaffResignationController(IMapper mapper, IUnitOfWork<BranchStaffResignation> unitOfWork, ILogger<BranchStaffResignationController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all branchStaffResignation
        /// </summary>
        /// <returns>List of branchStaffResignation</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchStaffResignation>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetBranchStaffResignation()
        {
            var allBranchStaffResignation = _unitOfWork.Entity.GetAll();
            return Ok(allBranchStaffResignation);
        }

        /// <summary>
        /// Get all branchStaffResignation
        /// </summary>
        /// <returns>List of branchStaffResignation</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchStaffResignation>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activebranchStaffResignations")]
        public IActionResult GetActiveBranchStaffResignation()
        {
            var allBranchStaffResignation = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allBranchStaffResignation);
        }

        /// <summary>
        /// Get branchStaffResignation by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchStaffResignation>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetBranchStaffResignation([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branchStaffResignation = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (branchStaffResignation == null)
            {
                throw new NotFoundException($"BranchStaffResignation Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<BranchStaffResignation>(branchStaffResignation));
        }

        // PUT: api/BranchStaffResignation/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranchStaffResignation([FromRoute] long id, [FromBody] BranchStaffResignation branchStaffResignation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the BranchStaffResignation to edit
            var _branchStaffResignation = await _unitOfWork.Entity.GetSingle(id);

            if (id != _branchStaffResignation.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _branchStaffResignation.BranchStaffId = branchStaffResignation.BranchStaffId    ;
                _branchStaffResignation.ResignationDate = branchStaffResignation.ResignationDate;
                _branchStaffResignation.Reason = branchStaffResignation.Reason;
                _branchStaffResignation.IsActive = branchStaffResignation.IsActive;
            }
            // Implement state management of entities _context.Entry(branchStaffResignation).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BranchStaffResignationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("BranchStaffResignationUpdate", new { id = _branchStaffResignation.Id }, _branchStaffResignation);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="branchStaffResignationViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedBranchStaffResignationIsActive(long id, [FromBody] BranchStaffResignation branchStaffResignationViewModel)
        {
            var branchStaffResignation = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (branchStaffResignation == null)
                throw new NotFoundException("BranchStaffResignation not found");

            branchStaffResignation.IsActive = branchStaffResignationViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(branchStaffResignation);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = branchStaffResignation.Id }, branchStaffResignation);
        }
        // POST: api/BranchStaffResignation
        [HttpPost]
        public async Task<IActionResult> PostBranchStaffResignation([FromBody] BranchStaffResignation branchStaffResignation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newBranchStaffResignation = branchStaffResignation;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.BranchStaffResignationExists(branchStaffResignation.Id))
                throw new BadRequestException("This branchStaffResignation exists!!");

            _unitOfWork.Entity.Add(newBranchStaffResignation);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetBranchStaffResignation", new { id = newBranchStaffResignation.Id }, newBranchStaffResignation);
        }

        // DELETE: api/BranchStaffResignation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranchStaffResignation([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branchStaffResignation = await _unitOfWork.Entity.GetSingle(id);  // _context.BranchStaffResignation.FindAsync(id);
            if (branchStaffResignation == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(branchStaffResignation);
            await _unitOfWork.SaveChangesAsync();

            return Ok(branchStaffResignation);
        }

        private bool BranchStaffResignationExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
