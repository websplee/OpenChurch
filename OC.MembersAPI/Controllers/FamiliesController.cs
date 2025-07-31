using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Members;
using OC.Domain.ViewModels.Locations;
using OC.Domain.ViewModels.Members;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OC.MembersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class FamiliesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Family> _unitOfWork;
        private readonly IMapper _mapper;

        public FamiliesController(IMapper mapper, IUnitOfWork<Family> unitOfWork, ILogger<FamiliesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all family
        /// </summary>
        /// /// <param name="filter"></param>
        /// <returns>List of family</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<FamilyViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetFamilies([FromQuery] LocationFilterViewModel? filter)
        {
            var query = _unitOfWork.Entity.AllIncludingQueryable(f => f.Administrator, f => f.Members);

            // Apply filters
            if (filter.BranchId.HasValue)
                query = query.Where(x => x.Administrator.BranchId == filter.BranchId);

            // Convert to view model
            var allFamilies = query.Select(f => _mapper.Map<FamilyViewModel>(f)).ToList();

            return Ok(allFamilies);
        }

        /// <summary>
        /// Get all family
        /// </summary>
        /// /// /// <param name="filter"></param>
        /// <returns>List of family</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<FamilyViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activefamilys")]
        public IActionResult GetActiveFamilies([FromQuery] LocationFilterViewModel? filter)
        {
            var query = _unitOfWork.Entity.AllIncludingQueryable(f => f.Administrator, f => f.Members)
                .Where(f => f.IsActive == true);

            // Apply filters
            if (filter.BranchId.HasValue)
                query = query.Where(x => x.Administrator.BranchId == filter.BranchId);

            // Convert to view model
            var allFamilies = query.Select(f => _mapper.Map<FamilyViewModel>(f)).ToList();

            return Ok(allFamilies);
        }

        /// <summary>
        /// Get family by Id
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<FamilyViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetFamily([FromRoute] long id, [FromQuery] LocationFilterViewModel? filter )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var query = _unitOfWork.Entity.GetSingle(m => m.Id == id, f => f.Administrator, f => f.Members);

            if (query == null)
            {
                throw new NotFoundException($"Family Id {id} did not bring up any records!!");
            }

            // Apply filters
            if (filter.BranchId.HasValue)
                query = query.Where(x => x.Administrator.BranchId == filter.BranchId);

            return Ok(_mapper.Map<FamilyViewModel>(query));
        }

        /// <summary>
        /// Update family
        /// </summary>
        /// <param name="id"></param>
        /// <param name="family"></param>
        /// <returns></returns>
        // PUT: api/Family/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFamily([FromRoute] long id, [FromBody] FamilyViewModel family)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Family to edit
            var _family = await _unitOfWork.Entity.GetSingle(id);

            if (id != _family.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _family.FamilyAdminId = family.FamilyAdminId;
                _family.Name = family.Name;
                _family.IsActive = family.IsActive;
            }
            // Implement state management of entities _context.Entry(family).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_family);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FamilyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("FamilyUpdate", new { id = _family.Id }, _family);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="familyViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedFamilyIsActive(long id, [FromBody] FamilyViewModel familyViewModel)
        {
            var family = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (family == null)
                throw new NotFoundException("Family not found");

            family.IsActive = familyViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(family);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = family.Id }, family);
        }
        // POST: api/Families
        [HttpPost]
        public async Task<IActionResult> PostFamily([FromBody] FamilyNewViewModel family)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newFamily = _mapper.Map<Family>(family);
        
            _unitOfWork.Entity.Add(newFamily);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("PostFamily", new { id = newFamily.Id }, newFamily);
        }

        // DELETE: api/Families/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFamily([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var family = await _unitOfWork.Entity.GetSingle(id);  // _context.Families.FindAsync(id);
            if (family == null)
            {
                return NotFound();
            }

            /*_unitOfWork.Entity.Delete(family);
            await _unitOfWork.SaveChangesAsync();*/

            return Ok(family);
        }

        private bool FamilyExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }

        /*private IQueryable<Family> GetFamiliesQueryable(LocationFilterViewModel filter)
        {
            var query = _unitOfWork.Entity.AllIncludingQueryable(f => f.Administrator, f => f.Members);

            if (filter.ContinentId.HasValue)
                query = query.Where(x => x.Administrator.BranchId == filter.ContinentId);

            if (filter.CountryId.HasValue)
                query = query.Where(x => x.CountryId == filter.CountryId);

            if (filter.RegionId.HasValue)
                query = query.Where(x => x.RegionId == filter.RegionId);

            if (filter.BranchId.HasValue)
                query = query.Where(x => x.BranchId == filter.BranchId);
        }*/
    }
}
