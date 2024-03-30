using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Members;
using System.Data.Entity.Infrastructure;

namespace OC.MembersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class TransactionTypesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<TransactionType> _unitOfWork;
        private readonly IMapper _mapper;

        public TransactionTypesController(IMapper mapper, IUnitOfWork<TransactionType> unitOfWork, ILogger<TransactionTypesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all transactionType
        /// </summary>
        /// <returns>List of transactionType</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<TransactionType>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetTransactionTypes()
        {
            var allTransactionTypes = _unitOfWork.Entity.GetAll();
            return Ok(allTransactionTypes);
        }

        /// <summary>
        /// Get all transactionType
        /// </summary>
        /// <returns>List of transactionType</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<TransactionType>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activetransactionTypes")]
        public IActionResult GetActiveTransactionTypes()
        {
            var allTransactionTypes = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allTransactionTypes);
        }

        /// <summary>
        /// Get transactionType by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<TransactionType>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetTransactionType([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var transactionType = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (transactionType == null)
            {
                throw new NotFoundException($"TransactionType Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<TransactionType>(transactionType));
        }

        // PUT: api/TransactionType/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransactionType([FromRoute] long id, [FromBody] TransactionType transactionType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the TransactionType to edit
            var _transactionType = await _unitOfWork.Entity.GetSingle(id);

            if (id != _transactionType.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _transactionType.Name = transactionType.Name;
                _transactionType.IsActive = transactionType.IsActive;
            }
            // Implement state management of entities _context.Entry(transactionType).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("TransactionTypeUpdate", new { id = _transactionType.Id }, _transactionType);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="transactionTypeViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedTransactionTypeIsActive(long id, [FromBody] TransactionType transactionTypeViewModel)
        {
            var transactionType = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (transactionType == null)
                throw new NotFoundException("TransactionType not found");

            transactionType.IsActive = transactionTypeViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(transactionType);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = transactionType.Id }, transactionType);
        }
        // POST: api/TransactionTypes
        [HttpPost]
        public async Task<IActionResult> PostTransactionType([FromBody] TransactionType transactionType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newTransactionType = transactionType;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.TransactionTypeExists(transactionType.Id))
                throw new BadRequestException("This transactionType exists!!");

            _unitOfWork.Entity.Add(newTransactionType);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetTransactionType", new { id = newTransactionType.Id }, newTransactionType);
        }

        // DELETE: api/TransactionTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionType([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var transactionType = await _unitOfWork.Entity.GetSingle(id);  // _context.TransactionTypes.FindAsync(id);
            if (transactionType == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(transactionType);
            await _unitOfWork.SaveChangesAsync();

            return Ok(transactionType);
        }

        private bool TransactionTypeExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
