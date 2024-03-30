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
    public class ExpensesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Expense> _unitOfWork;
        private readonly IMapper _mapper;

        public ExpensesController(IMapper mapper, IUnitOfWork<Expense> unitOfWork, ILogger<ExpensesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all expense
        /// </summary>
        /// <returns>List of expense</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Expense>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetExpenses()
        {
            var allExpenses = _unitOfWork.Entity.GetAll();
            return Ok(allExpenses);
        }

        /// <summary>
        /// Get all expense
        /// </summary>
        /// <returns>List of expense</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Expense>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeexpenses")]
        public IActionResult GetActiveExpenses()
        {
            var allExpenses = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allExpenses);
        }

        /// <summary>
        /// Get expense by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Expense>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetExpense([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var expense = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (expense == null)
            {
                throw new NotFoundException($"Expense Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<Expense>(expense));
        }

        // PUT: api/Expense/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpense([FromRoute] long id, [FromBody] Expense expense)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Expense to edit
            var _expense = await _unitOfWork.Entity.GetSingle(id);

            if (id != _expense.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _expense.BranchId = expense.BranchId;
                _expense.ChurchProgramSessionId = expense.ChurchProgramSessionId;
                _expense.MemberId = expense.MemberId;
                _expense.ExpenseTypeId = expense.ExpenseTypeId;
                _expense.TrxDate = expense.TrxDate;
                _expense.Amount = expense.Amount;
                _expense.Reference = expense.Reference;
                _expense.Description = expense.Description;
                _expense.IsActive = expense.IsActive;
            }
            // Implement state management of entities _context.Entry(expense).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("ExpenseUpdate", new { id = _expense.Id }, _expense);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expenseViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedExpenseIsActive(long id, [FromBody] Expense expenseViewModel)
        {
            var expense = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (expense == null)
                throw new NotFoundException("Expense not found");

            expense.IsActive = expenseViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(expense);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = expense.Id }, expense);
        }
        // POST: api/Expenses
        [HttpPost]
        public async Task<IActionResult> PostExpense([FromBody] Expense expense)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newExpense = expense;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.ExpenseExists(expense.Id))
                throw new BadRequestException("This expense exists!!");

            _unitOfWork.Entity.Add(newExpense);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetExpense", new { id = newExpense.Id }, newExpense);
        }

        // DELETE: api/Expenses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpense([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var expense = await _unitOfWork.Entity.GetSingle(id);  // _context.Expenses.FindAsync(id);
            if (expense == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(expense);
            await _unitOfWork.SaveChangesAsync();

            return Ok(expense);
        }

        private bool ExpenseExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
