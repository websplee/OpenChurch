using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Accounting;
using System.Data.Entity.Infrastructure;

namespace OC.AccountingAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class ExpenseTypesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<ExpenseType> _unitOfWork;
        private readonly IMapper _mapper;

        public ExpenseTypesController(IMapper mapper, IUnitOfWork<ExpenseType> unitOfWork, ILogger<ExpenseTypesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all expenseType
        /// </summary>
        /// <returns>List of expenseType</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ExpenseType>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetExpenseTypes()
        {
            var allExpenseTypes = _unitOfWork.Entity.GetAll();
            return Ok(allExpenseTypes);
        }

        /// <summary>
        /// Get all expenseType
        /// </summary>
        /// <returns>List of expenseType</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ExpenseType>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeexpenseTypes")]
        public IActionResult GetActiveExpenseTypes()
        {
            var allExpenseTypes = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allExpenseTypes);
        }

        /// <summary>
        /// Get expenseType by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ExpenseType>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetExpenseType([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var expenseType = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (expenseType == null)
            {
                throw new NotFoundException($"ExpenseType Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<ExpenseType>(expenseType));
        }

        // PUT: api/ExpenseType/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpenseType([FromRoute] long id, [FromBody] ExpenseType expenseType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the ExpenseType to edit
            var _expenseType = await _unitOfWork.Entity.GetSingle(id);

            if (id != _expenseType.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _expenseType.Name = expenseType.Name;
                _expenseType.Description = expenseType.Description;
                _expenseType.IsActive = expenseType.IsActive;
            }
            // Implement state management of entities _context.Entry(expenseType).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("ExpenseTypeUpdate", new { id = _expenseType.Id }, _expenseType);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expenseTypeViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedExpenseTypeIsActive(long id, [FromBody] ExpenseType expenseTypeViewModel)
        {
            var expenseType = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (expenseType == null)
                throw new NotFoundException("ExpenseType not found");

            expenseType.IsActive = expenseTypeViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(expenseType);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = expenseType.Id }, expenseType);
        }
        // POST: api/ExpenseTypes
        [HttpPost]
        public async Task<IActionResult> PostExpenseType([FromBody] ExpenseType expenseType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newExpenseType = expenseType;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.ExpenseTypeExists(expenseType.Id))
                throw new BadRequestException("This expenseType exists!!");

            _unitOfWork.Entity.Add(newExpenseType);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetExpenseType", new { id = newExpenseType.Id }, newExpenseType);
        }

        // DELETE: api/ExpenseTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpenseType([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var expenseType = await _unitOfWork.Entity.GetSingle(id);  // _context.ExpenseTypes.FindAsync(id);
            if (expenseType == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(expenseType);
            await _unitOfWork.SaveChangesAsync();

            return Ok(expenseType);
        }

        private bool ExpenseTypeExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
