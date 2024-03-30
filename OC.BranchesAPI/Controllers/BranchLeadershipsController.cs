using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.BranchLeadershipsAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BranchLeadershipsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<BranchLeadership> _unitOfWork;
        private readonly IMapper _mapper;

        public BranchLeadershipsController(IMapper mapper, IUnitOfWork<BranchLeadership> unitOfWork, ILogger<BranchLeadershipsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all branchLeadership
        /// </summary>
        /// <returns>List of branchLeadership</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchLeadership>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetBranchLeaderships()
        {
            var allBranchLeaderships = _unitOfWork.Entity.AllIncluding(b => b.Branch, b => b.Member, b => b.LeadershipRole);
            return Ok(allBranchLeaderships);
        }

        /// <summary>
        /// Get all branchLeadership
        /// </summary>
        /// <returns>List of branchLeadership</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchLeadership>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activebranchLeaderships")]
        public IActionResult GetActiveBranchLeaderships()
        {
            var allBranchLeaderships = _unitOfWork.Entity.AllIncluding(b => b.Branch, b => b.Member, b => b.LeadershipRole).Where(m => m.IsActive == true);
            return Ok(allBranchLeaderships);
        }

        /// <summary>
        /// Get branchLeadership by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchLeadership>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetBranchLeadership([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branchLeadership = _unitOfWork.Entity.GetSingle(m => m.Id == id, b => b.Branch, b => b.Member, b => b.LeadershipRole).FirstOrDefault();

            if (branchLeadership == null)
            {
                throw new NotFoundException($"BranchLeadership Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<BranchLeadership>(branchLeadership));
        }

        // PUT: api/BranchLeadership/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranchLeadership([FromRoute] long id, [FromBody] BranchLeadership branchLeadership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the BranchLeadership to edit
            var _branchLeadership = await _unitOfWork.Entity.GetSingle(id);

            if (id != _branchLeadership.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _branchLeadership.BranchId = branchLeadership.BranchId;
                _branchLeadership.LeadershipRoleId = branchLeadership.LeadershipRoleId;
                _branchLeadership.MemberId = branchLeadership.MemberId;
                _branchLeadership.IsActive = branchLeadership.IsActive;
            }
            // Implement state management of entities _context.Entry(branchLeadership).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BranchLeadershipExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("BranchLeadershipUpdate", new { id = _branchLeadership.Id }, _branchLeadership);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="branchLeadershipViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedBranchLeadershipIsActive(long id, [FromBody] BranchLeadership branchLeadershipViewModel)
        {
            var branchLeadership = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (branchLeadership == null)
                throw new NotFoundException("BranchLeadership not found");

            branchLeadership.IsActive = branchLeadershipViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(branchLeadership);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = branchLeadership.Id }, branchLeadership);
        }
        // POST: api/BranchLeaderships
        [HttpPost]
        public async Task<IActionResult> PostBranchLeadership([FromBody] BranchLeadership branchLeadership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newBranchLeadership = branchLeadership;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.BranchLeadershipExists(branchLeadership.Id))
                throw new BadRequestException("This branchLeadership exists!!");

            _unitOfWork.Entity.Add(newBranchLeadership);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetBranchLeadership", new { id = newBranchLeadership.Id }, newBranchLeadership);
        }

        // DELETE: api/BranchLeaderships/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranchLeadership([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branchLeadership = await _unitOfWork.Entity.GetSingle(id);  // _context.BranchLeaderships.FindAsync(id);
            if (branchLeadership == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(branchLeadership);
            await _unitOfWork.SaveChangesAsync();

            return Ok(branchLeadership);
        }

        private bool BranchLeadershipExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
