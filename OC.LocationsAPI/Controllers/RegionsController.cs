using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Locations;
using OC.Domain.ViewModels.Locations;
using System.Data.Entity.Infrastructure;

namespace OC.LocationsAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Region> _unitOfWork;
        private readonly IMapper _mapper;

        public RegionsController(IMapper mapper, IUnitOfWork<Region> unitOfWork, ILogger<RegionsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all regions
        /// </summary>
        /// <returns>List of regions</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RegionViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetRegions()
        {
            var allRegions = _unitOfWork.Entity.GetAll();
            return Ok(_mapper.Map<IEnumerable<RegionViewModel>>(allRegions));
        }

        /// <summary>
        /// Get all regions
        /// </summary>
        /// <returns>List of regions</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RegionViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeregions")]
        public IActionResult GetActiveRegions()
        {
            var allRegions = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<RegionViewModel>>(allRegions));
        }

        /// <summary>
        /// Get region by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>region == entered Id</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RegionViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetRegion([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var region = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (region == null)
            {
                throw new NotFoundException($"Region Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<RegionViewModel>(region));
        }

        // PUT: api/Regions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegion([FromRoute] long id, [FromBody] RegionViewModel region)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Region to edit
            var _region = await _unitOfWork.Entity.GetSingle(id);

            if (id != _region.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _region.Name = region.Name;
                _region.IsActive = region.IsActive;
            }
            // Implement state management of entities _context.Entry(region).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_region);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("RegionsUpdate", new { id = _region.Id }, _region);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="regionViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedRegionIsActive(long id, [FromBody] RegionViewModel regionViewModel)
        {
            var region = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (region == null)
                throw new NotFoundException("Region not found");

            region.IsActive = regionViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(region);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = region.Id }, region);
        }
        // POST: api/Regions
        [HttpPost]
        public async Task<IActionResult> PostRegion([FromBody] RegionViewModel region)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newRegion = _mapper.Map<Region>(region);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.RegionExists(region.Id))
                throw new BadRequestException("This region exists!!");

            _unitOfWork.Entity.Add(newRegion);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetRegion", new { id = newRegion.Id }, newRegion);
        }

        // DELETE: api/Regions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegion([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var region = await _unitOfWork.Entity.GetSingle(id);  // _context.Regions.FindAsync(id);
            if (region == null)
            {
                return NotFound();
            }

            /*_unitOfWork.Entity.Delete(region);
            await _unitOfWork.SaveChangesAsync();*/

            return Ok(region);
        }

        private bool RegionExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
