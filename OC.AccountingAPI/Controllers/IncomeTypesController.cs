using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Accounting;
using System.Data.Entity.Infrastructure;

namespace OC.AccountingAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class IncomeTypesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<IncomeTypeViewModel> _unitOfWork;
        private readonly IMapper _mapper;

        public IncomeTypesController(IMapper mapper, IUnitOfWork<IncomeTypeViewModel> unitOfWork, ILogger<IncomeTypesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all incomeType
        /// </summary>
        /// <returns>List of incomeType</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<IncomeTypeViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetIncomeTypes()
        {
            var allIncomeTypes = _unitOfWork.Entity.GetAll();
            return Ok(allIncomeTypes);
        }

        /// <summary>
        /// Get all incomeType
        /// </summary>
        /// <returns>List of incomeType</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<IncomeTypeViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeincomeTypes")]
        public IActionResult GetActiveIncomeTypes()
        {
            var allIncomeTypes = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allIncomeTypes);
        }

        /// <summary>
        /// Get incomeType by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<IncomeTypeViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetIncomeType([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var incomeType = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (incomeType == null)
            {
                throw new NotFoundException($"IncomeType Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IncomeTypeViewModel>(incomeType));
        }

        // PUT: api/IncomeType/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncomeType([FromRoute] long id, [FromBody] IncomeTypeViewModel incomeType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the IncomeType to edit
            var _incomeType = await _unitOfWork.Entity.GetSingle(id);

            if (id != _incomeType.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _incomeType.Name = incomeType.Name;
                _incomeType.Description = incomeType.Description;
                _incomeType.IsActive = incomeType.IsActive;
            }
            // Implement state management of entities _context.Entry(incomeType).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncomeTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("IncomeTypeUpdate", new { id = _incomeType.Id }, _incomeType);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="incomeTypeViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedIncomeTypeIsActive(long id, [FromBody] IncomeTypeViewModel incomeTypeViewModel)
        {
            var incomeType = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (incomeType == null)
                throw new NotFoundException("IncomeType not found");

            incomeType.IsActive = incomeTypeViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(incomeType);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = incomeType.Id }, incomeType);
        }
        // POST: api/IncomeTypes
        [HttpPost]
        public async Task<IActionResult> PostIncomeType([FromBody] IncomeTypeViewModel incomeType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newIncomeType = incomeType;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.IncomeTypeExists(incomeType.Id))
                throw new BadRequestException("This incomeType exists!!");

            _unitOfWork.Entity.Add(newIncomeType);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetIncomeType", new { id = newIncomeType.Id }, newIncomeType);
        }

        // DELETE: api/IncomeTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncomeType([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var incomeType = await _unitOfWork.Entity.GetSingle(id);  // _context.IncomeTypes.FindAsync(id);
            if (incomeType == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(incomeType);
            await _unitOfWork.SaveChangesAsync();

            return Ok(incomeType);
        }

        private bool IncomeTypeExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
