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
    public class BranchMinistryLeadershipsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<BranchMinistryLeadership> _unitOfWork;
        private readonly IMapper _mapper;

        public BranchMinistryLeadershipsController(IMapper mapper, IUnitOfWork<BranchMinistryLeadership> unitOfWork, ILogger<BranchMinistryLeadershipsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all branchMinistryLeadership
        /// </summary>
        /// <returns>List of branchMinistryLeadership</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchMinistryLeadership>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetBranchMinistryLeaderships()
        {
            var allBranchMinistryLeaderships = _unitOfWork.Entity.AllIncluding(m => m.BranchMinistry, m => m.LeadershipRole, m => m.Member);
            return Ok(allBranchMinistryLeaderships);
        }

        /// <summary>
        /// Get all branchMinistryLeadership
        /// </summary>
        /// <returns>List of branchMinistryLeadership</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchMinistryLeadership>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activebranchMinistryLeaderships")]
        public IActionResult GetActiveBranchMinistryLeaderships()
        {
            var allBranchMinistryLeaderships = _unitOfWork.Entity.AllIncluding(m => m.BranchMinistry, m => m.LeadershipRole, m => m.Member);// .Where(m => m.IsActive == true);
            return Ok(allBranchMinistryLeaderships);
        }

        /// <summary>
        /// Get branchMinistryLeadership by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BranchMinistryLeadership>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetBranchMinistryLeadership([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branchMinistryLeadership = _unitOfWork.Entity.GetSingle(m => m.Id == id, m => m.BranchMinistry, m => m.LeadershipRole, m => m.Member).FirstOrDefault();

            if (branchMinistryLeadership == null)
            {
                throw new NotFoundException($"BranchMinistryLeadership Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<BranchMinistryLeadership>(branchMinistryLeadership));
        }

        // PUT: api/BranchMinistryLeadership/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranchMinistryLeadership([FromRoute] long id, [FromBody] BranchMinistryLeadership branchMinistryLeadership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the BranchMinistryLeadership to edit
            var _branchMinistryLeadership = _unitOfWork.Entity.GetSingle(m => m.Id == id, m => m.BranchMinistry, m => m.LeadershipRole, m => m.Member).FirstOrDefault();

            if (id != _branchMinistryLeadership.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _branchMinistryLeadership.BranchMinistryId = branchMinistryLeadership.BranchMinistryId;
                _branchMinistryLeadership.LeadershipRoleId = branchMinistryLeadership.LeadershipRoleId;
                _branchMinistryLeadership.MemberId = branchMinistryLeadership.MemberId;
                _branchMinistryLeadership.IsActive = branchMinistryLeadership.IsActive;
            }
            // Implement state management of entities _context.Entry(branchMinistryLeadership).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BranchMinistryLeadershipExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("BranchMinistryLeadershipUpdate", new { id = _branchMinistryLeadership.Id }, _branchMinistryLeadership);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="branchMinistryLeadershipViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedBranchMinistryLeadershipIsActive(long id, [FromBody] BranchMinistryLeadership branchMinistryLeadershipViewModel)
        {
            var branchMinistryLeadership = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (branchMinistryLeadership == null)
                throw new NotFoundException("BranchMinistryLeadership not found");

            branchMinistryLeadership.IsActive = branchMinistryLeadershipViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(branchMinistryLeadership);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = branchMinistryLeadership.Id }, branchMinistryLeadership);
        }
        // POST: api/BranchMinistryLeaderships
        [HttpPost]
        public async Task<IActionResult> PostBranchMinistryLeadership([FromBody] BranchMinistryLeadership branchMinistryLeadership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newBranchMinistryLeadership = branchMinistryLeadership;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.BranchMinistryLeadershipExists(branchMinistryLeadership.Id))
                throw new BadRequestException("This branchMinistryLeadership exists!!");

            _unitOfWork.Entity.Add(newBranchMinistryLeadership);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetBranchMinistryLeadership", new { id = newBranchMinistryLeadership.Id }, newBranchMinistryLeadership);
        }

        // DELETE: api/BranchMinistryLeaderships/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranchMinistryLeadership([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var branchMinistryLeadership = await _unitOfWork.Entity.GetSingle(id);  // _context.BranchMinistryLeaderships.FindAsync(id);
            if (branchMinistryLeadership == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(branchMinistryLeadership);
            await _unitOfWork.SaveChangesAsync();

            return Ok(branchMinistryLeadership);
        }

        private bool BranchMinistryLeadershipExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
