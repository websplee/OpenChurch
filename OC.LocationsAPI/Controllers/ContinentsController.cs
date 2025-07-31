using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OC.Data.Repositories.Interfaces;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Locations;
using OC.Domain.ViewModels.Locations;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OC.LocationsAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ContinentsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Continent> _unitOfWork;
        private readonly IReadOnlyProjectionRepository<Continent, ContinentViewModel> _repository;
        private readonly IMapper _mapper;

        public ContinentsController(IMapper mapper, IUnitOfWork<Continent> unitOfWork, ILogger<ContinentsController> logger, IReadOnlyProjectionRepository<Continent, ContinentViewModel> repository)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _repository = repository;
        }

        /// <summary>
        /// Get all continents
        /// </summary>
        /// <returns>List of con</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ContinentViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public async Task<IActionResult> GetContinents()
        {
            var allContinents = _unitOfWork.Entity.AllIncludingQueryable(c => c.Countries)
                .Include(c => c.Countries).ThenInclude(c => c.Regions).ThenInclude(c => c.Branches).ToList();

            return Ok(_mapper.Map<IEnumerable<ContinentViewModel>>(allContinents));
            /*var allContinents =  _repository.Query();
            return Ok(allContinents);*/
        }

        /// <summary>
        /// Get all continents
        /// </summary>
        /// <returns>List of continents</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ContinentViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activecontinents")]
        [AllowAnonymous]
        public IActionResult GetActiveContinents()
        {
            var allContinents = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<ContinentViewModel>>(allContinents));
        }

        /// <summary>
        /// Get continent by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Continent</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ContinentViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetContinent([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var continent = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (continent == null)
            {
                throw new NotFoundException($"Continent Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<ContinentViewModel>(continent));
        }

        // PUT: api/Continents/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContinent([FromRoute] long id, [FromBody] ContinentViewModel continent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Continent to edit
            var _continent = await _unitOfWork.Entity.GetSingle(id);

            if (id != _continent.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _continent.Name = continent.Name;
                _continent.IsActive = continent.IsActive;
            }
            // Implement state management of entities _context.Entry(continent).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_continent);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContinentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("ContinentsUpdate", new { id = _continent.Id }, _continent);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="continentViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedContinentIsActive(long id, [FromBody] ContinentViewModel continentViewModel)
        {
            var continent = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (continent == null)
                throw new NotFoundException("Continent not found");

            continent.IsActive = continentViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(continent);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = continent.Id }, _mapper.Map<ContinentViewModel>(continent));
        }
        // POST: api/Continents
        [HttpPost]
        public async Task<IActionResult> PostContinent([FromBody] ContinentViewModel continent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newContinent = _mapper.Map<Continent>(continent);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.ContinentExists(continent.Id))
                throw new BadRequestException("This continent exists!!");

            _unitOfWork.Entity.Add(newContinent);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetContinent", new { id = newContinent.Id }, newContinent);
        }

        // DELETE: api/Continents/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContinent([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var continent = await _unitOfWork.Entity.GetSingle(id);  // _context.Continents.FindAsync(id);
            if (continent == null)
            {
                return NotFound();
            }

            /*_unitOfWork.Entity.Delete(continent);
            await _unitOfWork.SaveChangesAsync();*/

            return Ok(continent);
        }

        private bool ContinentExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
