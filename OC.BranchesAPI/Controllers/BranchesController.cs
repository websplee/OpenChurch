using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using OC.Domain.Models.Locations;
using OC.Domain.ViewModels.Branches;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace OC.BranchesAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Branch> _unitOfWork;
        private readonly IMapper _mapper;

        public BranchesController(IMapper mapper, IUnitOfWork<Branch> unitOfWork, ILogger<BranchesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all branch
        /// </summary>
        /// <returns>List of branch</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetBranches()
        {
            var allBranches = _unitOfWork.Entity.AllIncluding(f => f.Members, f => f.CellGroups, f => f.ChurchProgramSessions);
               

            var branchViewModels = _mapper
                .Map<IEnumerable<BranchMiniViewModel>>(allBranches);
                

            return Ok(branchViewModels);
        }

        /// <summary>
        /// Get all branch
        /// </summary>
        /// <returns>List of branch</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activebranchs")]
        public IActionResult GetActiveBranches()
        {
            var allBranches = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<BranchViewModel>>(allBranches));
        }

        /// <summary>
        /// Get branch by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetBranch([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branch = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (branch == null)
            {
                throw new NotFoundException($"Branch Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<BranchViewModel>(branch));
        }

        // PUT: api/Branch/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranch([FromRoute] long id, [FromBody] BranchViewModel branch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Branch to edit
            var _branch = await _unitOfWork.Entity.GetSingle(id);

            if (id != _branch.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _branch.RegionId = branch.RegionId;
                _branch.Name = branch.Name;
                _branch.PhysicalAddress = branch.PhysicalAddress;
                _branch.Phone1 = branch.Phone1;
                _branch.Phone2 = branch.Phone2;
                _branch.Email = branch.Email;
                _branch.Latitude = branch.Latitude;
                _branch.Longitude = branch.Longitude;
                _branch.OwnBuilding = branch.OwnBuilding;
                _branch.IsActive = branch.IsActive;
            }
            // Implement state management of entities _context.Entry(branch).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_branch);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BranchExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("BranchUpdate", new { id = _branch.Id }, _branch);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="branchViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedBranchIsActive(long id, [FromBody] BranchViewModel branchViewModel)
        {
            var branch = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (branch == null)
                throw new NotFoundException("Branch not found");

            branch.IsActive = branchViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(branch);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = branch.Id }, branch);
        }


        /// <summary>
        /// Create a new branch
        /// </summary>
        /// <param name="branch"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        [HttpPost]
        public async Task<IActionResult> PostBranch([FromBody] BranchNewViewModel branch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newBranch = _mapper.Map<Branch>(branch);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.BranchExists(branch.Id))
                throw new BadRequestException("This branch exists!!");

            _unitOfWork.Entity.Add(newBranch);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("PostBranch", new { id = newBranch.Id }, newBranch);
        }

        // DELETE: api/Branches/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranch([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branch = await _unitOfWork.Entity.GetSingle(id);  // _context.Branches.FindAsync(id);
            if (branch == null)
            {
                return NotFound();
            }

            /*_unitOfWork.Entity.Delete(branch);
            await _unitOfWork.SaveChangesAsync();*/

            return Ok(branch);
        }

        private bool BranchExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
