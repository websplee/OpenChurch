using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Locations;
using OC.Domain.ViewModels.Locations;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace OC.LocationsAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Country> _unitOfWork;
        private readonly IMapper _mapper;

        public CountriesController(IMapper mapper, IUnitOfWork<Country> unitOfWork, ILogger<CountriesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all countries
        /// </summary>
        /// <returns>List of countries</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CountryViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetCountries()
        {
            var allCountries = _unitOfWork.Entity.AllIncluding(c => c.Continent, c => c.Regions);
            return Ok(_mapper.Map<IEnumerable<CountryViewModel>>(allCountries));
        }

        /// <summary>
        /// Get all countries
        /// </summary>
        /// <returns>List of countries</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Country>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activecountries")]
        public IActionResult GetActiveCountries()
        {
            var allCountries = _unitOfWork.Entity.AllIncluding(c => c.Continent, c => c.Regions).Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<CountryViewModel>>(allCountries));
        }

        /// <summary>
        /// Get country by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Country == entered Id</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Country>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetCountry([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var country = _unitOfWork.Entity.GetSingle(c => c.Id == id, c => c.Continent).FirstOrDefault();

            if (country == null)
            {
                throw new NotFoundException($"Country Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<CountryViewModel>(country));
        }

        // PUT: api/Countries/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry([FromRoute] long id, [FromBody] Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Country to edit
            var _country = await _unitOfWork.Entity.GetSingle(id);

            if (id != _country.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _country.Name = country.Name;
                _country.ContinentId = country.ContinentId;
                _country.IsActive = country.IsActive;
            }
            // Implement state management of entities _context.Entry(country).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("CountriesUpdate", new { id = _country.Id }, _country);
        }


        /// <summary>
        /// Update country
        /// </summary>
        /// <param name="id"></param>
        /// <param name="countryViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedCountryIsActive(long id, [FromBody] Country countryViewModel)
        {
            var country = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (country == null)
                throw new NotFoundException("Country not found");

            country.IsActive = countryViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(country);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = country.Id }, country);
        }
        // POST: api/Countries
        [HttpPost]
        public async Task<IActionResult> PostCountry([FromBody] Country country)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newCountry = country;
            // ADD OTHER DEFAULT VALUES HERE
            newCountry.Continent = null;

            if (this.CountryExists(country.Id))
                throw new BadRequestException("This country exists!!");

            _unitOfWork.Entity.Add(newCountry);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetCountry", new { id = newCountry.Id }, newCountry);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var country = await _unitOfWork.Entity.GetSingle(id);  // _context.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(country);
            await _unitOfWork.SaveChangesAsync();

            return Ok(country);
        }

        private bool CountryExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
