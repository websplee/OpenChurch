using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.MinistriesAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MinistriesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Ministry> _unitOfWork;
        private readonly IMapper _mapper;

        public MinistriesController(IMapper mapper, IUnitOfWork<Ministry> unitOfWork, ILogger<MinistriesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all ministry
        /// </summary>
        /// <returns>List of ministry</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Ministry>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetMinistries()
        {
            var allMinistries = _unitOfWork.Entity.GetAll();
            return Ok(allMinistries);
        }

        /// <summary>
        /// Get all ministry
        /// </summary>
        /// <returns>List of ministry</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Ministry>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeministrys")]
        public IActionResult GetActiveMinistries()
        {
            var allMinistries = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allMinistries);
        }

        /// <summary>
        /// Get ministry by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Ministry>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetMinistry([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ministry = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (ministry == null)
            {
                throw new NotFoundException($"Ministry Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<Ministry>(ministry));
        }

        // PUT: api/Ministry/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMinistry([FromRoute] long id, [FromBody] Ministry ministry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Ministry to edit
            var _ministry = await _unitOfWork.Entity.GetSingle(id);

            if (id != _ministry.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _ministry.ShortName = ministry.ShortName;
                _ministry.Name = ministry.Name;
                _ministry.Description = ministry.Description;
                _ministry.IsActive = ministry.IsActive;
            }
            // Implement state management of entities _context.Entry(ministry).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MinistryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("MinistryUpdate", new { id = _ministry.Id }, _ministry);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ministryViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedMinistryIsActive(long id, [FromBody] Ministry ministryViewModel)
        {
            var ministry = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (ministry == null)
                throw new NotFoundException("Ministry not found");

            ministry.IsActive = ministryViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(ministry);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = ministry.Id }, ministry);
        }
        // POST: api/Ministries
        [HttpPost]
        public async Task<IActionResult> PostMinistry([FromBody] Ministry ministry)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newMinistry = ministry;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.MinistryExists(ministry.Id))
                throw new BadRequestException("This ministry exists!!");

            _unitOfWork.Entity.Add(newMinistry);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetMinistry", new { id = newMinistry.Id }, newMinistry);
        }

        // DELETE: api/Ministries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMinistry([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ministry = await _unitOfWork.Entity.GetSingle(id);  // _context.Ministries.FindAsync(id);
            if (ministry == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(ministry);
            await _unitOfWork.SaveChangesAsync();

            return Ok(ministry);
        }

        private bool MinistryExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
