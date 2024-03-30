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
    public class BranchStaffStaffsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<BranchStaff> _unitOfWork;
        private readonly IMapper _mapper;

        public BranchStaffStaffsController(IMapper mapper, IUnitOfWork<BranchStaff> unitOfWork, ILogger<BranchStaffStaffsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all branchStaff
        /// </summary>
        /// <returns>List of branchStaff</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchStaff>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetBranchStaffStaffs()
        {
            var allBranchStaffStaffs = _unitOfWork.Entity.GetAll();
            return Ok(allBranchStaffStaffs);
        }

        /// <summary>
        /// Get all branchStaff
        /// </summary>
        /// <returns>List of branchStaff</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchStaff>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activebranchStaffs")]
        public IActionResult GetActiveBranchStaffStaffs()
        {
            var allBranchStaffStaffs = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allBranchStaffStaffs);
        }

        /// <summary>
        /// Get branchStaff by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchStaff>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetBranchStaff([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branchStaff = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (branchStaff == null)
            {
                throw new NotFoundException($"BranchStaff Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<BranchStaff>(branchStaff));
        }

        // PUT: api/BranchStaff/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranchStaff([FromRoute] long id, [FromBody] BranchStaff branchStaff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the BranchStaff to edit
            var _branchStaff = await _unitOfWork.Entity.GetSingle(id);

            if (id != _branchStaff.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _branchStaff.EmployeeNumber = branchStaff.EmployeeNumber;
                _branchStaff.BranchId = branchStaff.BranchId;
                _branchStaff.Firstname = branchStaff.Firstname;
                _branchStaff.Lastname = branchStaff.Lastname;
                _branchStaff.DateOfBirth = branchStaff.DateOfBirth;
                _branchStaff.Address = branchStaff.Address;
                _branchStaff.Position = branchStaff.Position;
                _branchStaff.IsActive = branchStaff.IsActive;
            }
            // Implement state management of entities _context.Entry(branchStaff).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BranchStaffExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("BranchStaffUpdate", new { id = _branchStaff.Id }, _branchStaff);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="branchStaffViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedBranchStaffIsActive(long id, [FromBody] BranchStaff branchStaffViewModel)
        {
            var branchStaff = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (branchStaff == null)
                throw new NotFoundException("BranchStaff not found");

            branchStaff.IsActive = branchStaffViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(branchStaff);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = branchStaff.Id }, branchStaff);
        }
        // POST: api/BranchStaffStaffs
        [HttpPost]
        public async Task<IActionResult> PostBranchStaff([FromBody] BranchStaff branchStaff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newBranchStaff = branchStaff;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.BranchStaffExists(branchStaff.Id))
                throw new BadRequestException("This branchStaff exists!!");

            _unitOfWork.Entity.Add(newBranchStaff);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetBranchStaff", new { id = newBranchStaff.Id }, newBranchStaff);
        }

        // DELETE: api/BranchStaffStaffs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranchStaff([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branchStaff = await _unitOfWork.Entity.GetSingle(id);  // _context.BranchStaffStaffs.FindAsync(id);
            if (branchStaff == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(branchStaff);
            await _unitOfWork.SaveChangesAsync();

            return Ok(branchStaff);
        }

        private bool BranchStaffExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
