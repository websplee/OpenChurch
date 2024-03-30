using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Members;
using System.Data.Entity.Infrastructure;

namespace OC.MembersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EducationLevelsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<EducationLevel> _unitOfWork;
        private readonly IMapper _mapper;

        public EducationLevelsController(IMapper mapper, IUnitOfWork<EducationLevel> unitOfWork, ILogger<EducationLevelsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all educationLevel
        /// </summary>
        /// <returns>List of educationLevel</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<EducationLevel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetEducationLevels()
        {
            var allEducationLevels = _unitOfWork.Entity.GetAll();
            return Ok(allEducationLevels);
        }

        /// <summary>
        /// Get all educationLevel
        /// </summary>
        /// <returns>List of educationLevel</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<EducationLevel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeeducationLevels")]
        public IActionResult GetActiveEducationLevels()
        {
            var allEducationLevels = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allEducationLevels);
        }

        /// <summary>
        /// Get educationLevel by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<EducationLevel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetEducationLevel([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var educationLevel = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (educationLevel == null)
            {
                throw new NotFoundException($"EducationLevel Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<EducationLevel>(educationLevel));
        }

        // PUT: api/EducationLevel/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducationLevel([FromRoute] long id, [FromBody] EducationLevel educationLevel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the EducationLevel to edit
            var _educationLevel = await _unitOfWork.Entity.GetSingle(id);

            if (id != _educationLevel.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _educationLevel.Name = educationLevel.Name;
                _educationLevel.IsActive = educationLevel.IsActive;
            }
            // Implement state management of entities _context.Entry(educationLevel).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationLevelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("EducationLevelUpdate", new { id = _educationLevel.Id }, _educationLevel);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="educationLevelViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedEducationLevelIsActive(long id, [FromBody] EducationLevel educationLevelViewModel)
        {
            var educationLevel = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (educationLevel == null)
                throw new NotFoundException("EducationLevel not found");

            educationLevel.IsActive = educationLevelViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(educationLevel);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = educationLevel.Id }, educationLevel);
        }
        // POST: api/EducationLevels
        [HttpPost]
        public async Task<IActionResult> PostEducationLevel([FromBody] EducationLevel educationLevel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newEducationLevel = educationLevel;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.EducationLevelExists(educationLevel.Id))
                throw new BadRequestException("This educationLevel exists!!");

            _unitOfWork.Entity.Add(newEducationLevel);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetEducationLevel", new { id = newEducationLevel.Id }, newEducationLevel);
        }

        // DELETE: api/EducationLevels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducationLevel([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var educationLevel = await _unitOfWork.Entity.GetSingle(id);  // _context.EducationLevels.FindAsync(id);
            if (educationLevel == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(educationLevel);
            await _unitOfWork.SaveChangesAsync();

            return Ok(educationLevel);
        }

        private bool EducationLevelExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
