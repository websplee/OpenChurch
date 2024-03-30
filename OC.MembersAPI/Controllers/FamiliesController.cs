using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using OC.Domain.Models.Members;
using System.Data.Entity.Infrastructure;

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
        /// <returns>List of family</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Family>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetFamilies()
        {
            var allFamilies = _unitOfWork.Entity.GetAll();
            return Ok(allFamilies);
        }

        /// <summary>
        /// Get all family
        /// </summary>
        /// <returns>List of family</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Family>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activefamilys")]
        public IActionResult GetActiveFamilies()
        {
            var allFamilies = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allFamilies);
        }

        /// <summary>
        /// Get family by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Family>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetFamily([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var family = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (family == null)
            {
                throw new NotFoundException($"Family Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<Family>(family));
        }

        // PUT: api/Family/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFamily([FromRoute] long id, [FromBody] Family family)
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
        public IActionResult UpdatedFamilyIsActive(long id, [FromBody] Family familyViewModel)
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
        public async Task<IActionResult> PostFamily([FromBody] Family family)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newFamily = family;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.FamilyExists(family.Id))
                throw new BadRequestException("This family exists!!");

            _unitOfWork.Entity.Add(newFamily);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetFamily", new { id = newFamily.Id }, newFamily);
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

            _unitOfWork.Entity.Delete(family);
            await _unitOfWork.SaveChangesAsync();

            return Ok(family);
        }

        private bool FamilyExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
