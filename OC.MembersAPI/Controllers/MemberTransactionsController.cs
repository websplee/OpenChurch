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
    public class MemberTransactionsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<MemberTransaction> _unitOfWork;
        private readonly IMapper _mapper;

        public MemberTransactionsController(IMapper mapper, IUnitOfWork<MemberTransaction> unitOfWork, ILogger<MemberTransactionsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all memberTransaction
        /// </summary>
        /// <returns>List of memberTransaction</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MemberTransaction>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetMemberTransactions()
        {
            var allMemberTransactions = _unitOfWork.Entity.GetAll();
            return Ok(allMemberTransactions);
        }

        /// <summary>
        /// Get all memberTransaction
        /// </summary>
        /// <returns>List of memberTransaction</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MemberTransaction>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activememberTransactions")]
        public IActionResult GetActiveMemberTransactions()
        {
            var allMemberTransactions = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allMemberTransactions);
        }

        /// <summary>
        /// Get memberTransaction by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MemberTransaction>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetMemberTransaction([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var memberTransaction = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (memberTransaction == null)
            {
                throw new NotFoundException($"MemberTransaction Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<MemberTransaction>(memberTransaction));
        }

        // PUT: api/MemberTransaction/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMemberTransaction([FromRoute] long id, [FromBody] MemberTransaction memberTransaction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the MemberTransaction to edit
            var _memberTransaction = await _unitOfWork.Entity.GetSingle(id);

            if (id != _memberTransaction.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _memberTransaction.MemberId = memberTransaction.MemberId;
                _memberTransaction.TransactionTypeId = memberTransaction.TransactionTypeId;
                _memberTransaction.Amount = memberTransaction.Amount;
                _memberTransaction.Purpose = memberTransaction.Purpose;
                _memberTransaction.Narration = memberTransaction.Narration;
                _memberTransaction.TransactionDateTime = memberTransaction.TransactionDateTime;
                _memberTransaction.IsActive = memberTransaction.IsActive;
            }
            // Implement state management of entities _context.Entry(memberTransaction).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(memberTransaction);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemberTransactionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("MemberTransactionUpdate", new { id = _memberTransaction.Id }, _memberTransaction);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="memberTransactionViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedMemberTransactionIsActive(long id, [FromBody] MemberTransaction memberTransactionViewModel)
        {
            var memberTransaction = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (memberTransaction == null)
                throw new NotFoundException("MemberTransaction not found");

            memberTransaction.IsActive = memberTransactionViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(memberTransaction);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = memberTransaction.Id }, memberTransaction);
        }
        // POST: api/MemberTransactions
        [HttpPost]
        public async Task<IActionResult> PostMemberTransaction([FromBody] MemberTransaction memberTransaction)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newMemberTransaction = memberTransaction;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.MemberTransactionExists(memberTransaction.Id))
                throw new BadRequestException("This memberTransaction exists!!");

            _unitOfWork.Entity.Add(newMemberTransaction);
            await _unitOfWork.SaveChangesAsync();

            var insertedRec = _unitOfWork.Entity.GetSingle(m => m.Id == newMemberTransaction.Id, m => m.Member, m => m.TransactionType);

            return CreatedAtAction("GetMemberTransaction", new { id = newMemberTransaction.Id }, insertedRec);
        }

        // DELETE: api/MemberTransactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMemberTransaction([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var memberTransaction = await _unitOfWork.Entity.GetSingle(id);  // _context.MemberTransactions.FindAsync(id);
            if (memberTransaction == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(memberTransaction);
            await _unitOfWork.SaveChangesAsync();

            return Ok(memberTransaction);
        }

        private bool MemberTransactionExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
