using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.IncomingTransfersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class IncomingTransfersController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<IncomingTransfer> _unitOfWork;
        private readonly IMapper _mapper;

        public IncomingTransfersController(IMapper mapper, IUnitOfWork<IncomingTransfer> unitOfWork, ILogger<IncomingTransfersController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all incomingTransfer
        /// </summary>
        /// <returns>List of incomingTransfer</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<IncomingTransfer>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetIncomingTransfers()
        {
            var allIncomingTransfers = _unitOfWork.Entity.GetAll();
            return Ok(allIncomingTransfers);
        }

        /// <summary>
        /// Get all incomingTransfer
        /// </summary>
        /// <returns>List of incomingTransfer</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<IncomingTransfer>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeincomingTransfers")]
        public IActionResult GetActiveIncomingTransfers()
        {
            var allIncomingTransfers = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allIncomingTransfers);
        }

        /// <summary>
        /// Get incomingTransfer by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<IncomingTransfer>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetIncomingTransfer([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var incomingTransfer = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (incomingTransfer == null)
            {
                throw new NotFoundException($"IncomingTransfer Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IncomingTransfer>(incomingTransfer));
        }

        // PUT: api/IncomingTransfer/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncomingTransfer([FromRoute] long id, [FromBody] IncomingTransfer incomingTransfer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the IncomingTransfer to edit
            var _incomingTransfer = await _unitOfWork.Entity.GetSingle(id);

            if (id != _incomingTransfer.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _incomingTransfer.BranchId = incomingTransfer.BranchId;
                _incomingTransfer.OldBranchName = incomingTransfer.OldBranchName;
                _incomingTransfer.MemberId = incomingTransfer.MemberId;
                _incomingTransfer.Notes = incomingTransfer.Notes;
                _incomingTransfer.IsAccepted = incomingTransfer.IsAccepted;
                _incomingTransfer.IsActive = incomingTransfer.IsActive;
            }
            // Implement state management of entities _context.Entry(incomingTransfer).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncomingTransferExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("IncomingTransferUpdate", new { id = _incomingTransfer.Id }, _incomingTransfer);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="incomingTransferViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedIncomingTransferIsActive(long id, [FromBody] IncomingTransfer incomingTransferViewModel)
        {
            var incomingTransfer = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (incomingTransfer == null)
                throw new NotFoundException("IncomingTransfer not found");

            incomingTransfer.IsActive = incomingTransferViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(incomingTransfer);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = incomingTransfer.Id }, incomingTransfer);
        }
        // POST: api/IncomingTransfers
        [HttpPost]
        public async Task<IActionResult> PostIncomingTransfer([FromBody] IncomingTransfer incomingTransfer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newIncomingTransfer = incomingTransfer;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.IncomingTransferExists(incomingTransfer.Id))
                throw new BadRequestException("This incomingTransfer exists!!");

            _unitOfWork.Entity.Add(newIncomingTransfer);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetIncomingTransfer", new { id = newIncomingTransfer.Id }, newIncomingTransfer);
        }

        // DELETE: api/IncomingTransfers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIncomingTransfer([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var incomingTransfer = await _unitOfWork.Entity.GetSingle(id);  // _context.IncomingTransfers.FindAsync(id);
            if (incomingTransfer == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(incomingTransfer);
            await _unitOfWork.SaveChangesAsync();

            return Ok(incomingTransfer);
        }

        private bool IncomingTransferExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
