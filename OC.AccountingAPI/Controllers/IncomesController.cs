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
    public class IncomesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Income> _unitOfWork;
        private readonly IMapper _mapper;

        public IncomesController(IMapper mapper, IUnitOfWork<Income> unitOfWork, ILogger<IncomesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all income
        /// </summary>
        /// <returns>List of income</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Income>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetIncomes()
        {
            var allIncomes = _unitOfWork.Entity.GetAll();
            return Ok(allIncomes);
        }

        /// <summary>
        /// Get all income
        /// </summary>
        /// <returns>List of income</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Income>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeincomes")]
        public IActionResult GetActiveIncomes()
        {
            var allIncomes = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allIncomes);
        }

        /// <summary>
        /// Get income by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Income>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetIncome([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var income = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (income == null)
            {
                throw new NotFoundException($"Income Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<Income>(income));
        }

        // PUT: api/Income/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncome([FromRoute] long id, [FromBody] Income income)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Income to edit
            var _income = await _unitOfWork.Entity.GetSingle(id);

            if (id != _income.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _income.BranchId = income.BranchId;
                _income.ChurchProgramSessionId = income.ChurchProgramSessionId;
                _income.MemberId = income.MemberId;
                _income.IncomeTypeId = income.IncomeTypeId;
                _income.TrxDate = income.TrxDate;
                _income.Amount = income.Amount;
                _income.Reference = income.Reference;
                _income.Description = income.Description;
                _income.IsActive = income.IsActive;
            }
            // Implement state management of entities _context.Entry(income).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncomeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("IncomeUpdate", new { id = _income.Id }, _income);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="incomeViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedIncomeIsActive(long id, [FromBody] Income incomeViewModel)
        {
            var income = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (income == null)
                throw new NotFoundException("Income not found");

            income.IsActive = incomeViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(income);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = income.Id }, income);
        }
        // POST: api/Incomes
        [HttpPost]
        public async Task<IActionResult> PostIncome([FromBody] Income income)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newIncome = income;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.IncomeExists(income.Id))
                throw new BadRequestException("This income exists!!");

            _unitOfWork.Entity.Add(newIncome);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetIncome", new { id = newIncome.Id }, newIncome);
        }

        // DELETE: api/Incomes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncome([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var income = await _unitOfWork.Entity.GetSingle(id);  // _context.Incomes.FindAsync(id);
            if (income == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(income);
            await _unitOfWork.SaveChangesAsync();

            return Ok(income);
        }

        private bool IncomeExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
