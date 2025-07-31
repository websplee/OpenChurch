using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Members;
using OC.Domain.ViewModels.Members;
using System.Data.Entity.Infrastructure;

namespace OC.MembersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class LeadershipRolesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<LeadershipRole> _unitOfWork;
        private readonly IMapper _mapper;

        public LeadershipRolesController(IMapper mapper, IUnitOfWork<LeadershipRole> unitOfWork, ILogger<LeadershipRolesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all leadershipRole
        /// </summary>
        /// <returns>List of leadershipRole</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<LeadershipRoleViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetLeadershipRoles()
        {
            var allLeadershipRoles = _unitOfWork.Entity.GetAll();
            return Ok(allLeadershipRoles);
        }

        /// <summary>
        /// Get all leadershipRole
        /// </summary>
        /// <returns>List of leadershipRole</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<LeadershipRoleViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeleadershipRoles")]
        public IActionResult GetActiveLeadershipRoles()
        {
            var allLeadershipRoles = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allLeadershipRoles);
        }

        /// <summary>
        /// Get leadershipRole by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<LeadershipRoleViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetLeadershipRole([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var leadershipRole = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (leadershipRole == null)
            {
                throw new NotFoundException($"LeadershipRole Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<LeadershipRoleViewModel>(leadershipRole));
        }

        // PUT: api/LeadershipRole/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLeadershipRole([FromRoute] long id, [FromBody] LeadershipRoleViewModel leadershipRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the LeadershipRole to edit
            var _leadershipRole = await _unitOfWork.Entity.GetSingle(id);

            if (id != _leadershipRole.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _leadershipRole.ShortName = leadershipRole.ShortName;
                _leadershipRole.Name = leadershipRole.Name;
                _leadershipRole.Description = leadershipRole.Description;
                _leadershipRole.IsActive = leadershipRole.IsActive;
            }
            // Implement state management of entities _context.Entry(leadershipRole).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_leadershipRole);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeadershipRoleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("LeadershipRoleUpdate", new { id = _leadershipRole.Id }, _leadershipRole);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="leadershipRoleViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedLeadershipRoleIsActive(long id, [FromBody] LeadershipRoleViewModel leadershipRoleViewModel)
        {
            var leadershipRole = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (leadershipRole == null)
                throw new NotFoundException("LeadershipRole not found");

            leadershipRole.IsActive = leadershipRoleViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(leadershipRole);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = leadershipRole.Id }, leadershipRole);
        }
        // POST: api/LeadershipRoles
        [HttpPost]
        public async Task<IActionResult> PostLeadershipRole([FromBody] LeadershipRoleViewModel leadershipRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newLeadershipRole = _mapper.Map<LeadershipRole>(leadershipRole);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.LeadershipRoleExists(leadershipRole.Id))
                throw new BadRequestException("This leadershipRole exists!!");

            _unitOfWork.Entity.Add(newLeadershipRole);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetLeadershipRole", new { id = newLeadershipRole.Id }, newLeadershipRole);
        }

        // DELETE: api/LeadershipRoles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeadershipRole([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var leadershipRole = await _unitOfWork.Entity.GetSingle(id);  // _context.LeadershipRoles.FindAsync(id);
            if (leadershipRole == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(leadershipRole);
            await _unitOfWork.SaveChangesAsync();

            return Ok(leadershipRole);
        }

        private bool LeadershipRoleExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
