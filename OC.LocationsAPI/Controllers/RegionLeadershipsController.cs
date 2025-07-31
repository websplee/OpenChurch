using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Locations;
using OC.Domain.ViewModels.Locations;
using System.Data.Entity.Infrastructure;

namespace OC.LocationsAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RegionLeadershipsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<RegionLeadership> _unitOfWork;
        private readonly IMapper _mapper;

        public RegionLeadershipsController(IMapper mapper, IUnitOfWork<RegionLeadership> unitOfWork, ILogger<RegionLeadershipsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all region leaderships
        /// </summary>
        /// <returns>List of region leaderships</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RegionLeadershipViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetRegionLeaderships()
        {
            var allRegionLeaderships = _unitOfWork.Entity.GetAll();
            return Ok(_mapper.Map<IEnumerable<RegionLeadershipViewModel>>(allRegionLeaderships));
        }

        /// <summary>
        /// Get all regionleaderships
        /// </summary>
        /// <returns>List of region leaderships</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RegionLeadershipViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeregionLeaderships")]
        public IActionResult GetActiveRegionLeaderships()
        {
            var allRegionLeaderships = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<RegionLeadershipViewModel>>(allRegionLeaderships));
        }

        /// <summary>
        /// Get region leadership by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Region Leadership == entered Id</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RegionLeadershipViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetRegionLeadershipById([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regionLeadership = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (regionLeadership == null)
            {
                throw new NotFoundException($"RegionLeadership Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<RegionLeadership>(regionLeadership));
        }
        
        /// <summary>
        /// Get region leadership by region Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User right == entered Id</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RegionLeadership>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("[action]/{id}")]
        public IActionResult GetRegionLeadershipByRegionId([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regionLeadership = _unitOfWork.Entity.GetSingle(m => m.RegionId == id).FirstOrDefault();

            if (regionLeadership == null)
            {
                throw new NotFoundException($"RegionLeadership Region Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<RegionLeadership>(regionLeadership));
        }

        // PUT: api/RegionLeaderships/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegionLeadership([FromRoute] long id, [FromBody] RegionLeadershipViewModel regionLeadership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the RegionLeadership to edit
            var _regionLeadership = await _unitOfWork.Entity.GetSingle(id);

            if (id != _regionLeadership.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _regionLeadership.RegionId = regionLeadership.RegionId;
                _regionLeadership.LeadershipRoleId = regionLeadership.LeadershipRoleId;
                _regionLeadership.MemberId = regionLeadership.MemberId;
                _regionLeadership.IsActive = regionLeadership.IsActive;
            }
            // Implement state management of entities _context.Entry(regionLeadership).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_regionLeadership);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegionLeadershipExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("RegionLeadershipsUpdate", new { id = _regionLeadership.Id }, _mapper.Map<RegionLeadershipViewModel>(_regionLeadership));
        }


        /// <summary>
        /// Update region leadership
        /// </summary>
        /// <param name="id"></param>
        /// <param name="regionLeadershipViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedRegionLeadershipIsActive(long id, [FromBody] RegionLeadershipViewModel regionLeadershipViewModel)
        {
            var regionLeadership = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (regionLeadership == null)
                throw new NotFoundException("RegionLeadership not found");

            regionLeadership.IsActive = regionLeadershipViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(regionLeadership);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = regionLeadership.Id }, _mapper.Map<RegionLeadershipViewModel>(regionLeadership));
        }
        // POST: api/RegionLeaderships
        [HttpPost]
        public async Task<IActionResult> PostRegionLeadership([FromBody] RegionLeadershipViewModel regionLeadership)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newRegionLeadership = _mapper.Map<RegionLeadership>(regionLeadership);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.RegionLeadershipExists(regionLeadership.Id))
                throw new BadRequestException("This regionLeadership exists!!");

            _unitOfWork.Entity.Add(newRegionLeadership);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetRegionLeadership", new { id = newRegionLeadership.Id }, newRegionLeadership);
        }

        // DELETE: api/RegionLeaderships/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegionLeadership([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var regionLeadership = await _unitOfWork.Entity.GetSingle(id);  // _context.RegionLeaderships.FindAsync(id);
            if (regionLeadership == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(regionLeadership);
            await _unitOfWork.SaveChangesAsync();

            return Ok(regionLeadership);
        }

        private bool RegionLeadershipExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
