using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using OC.Domain.ViewModels.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.OutgoingTransfersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OutgoingTransfersController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<OutgoingTransfer> _unitOfWork;
        private readonly IMapper _mapper;

        public OutgoingTransfersController(IMapper mapper, IUnitOfWork<OutgoingTransfer> unitOfWork, ILogger<OutgoingTransfersController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all outgoingTransfer
        /// </summary>
        /// <returns>List of outgoingTransfer</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<OutgoingTransferViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetOutgoingTransfers()
        {
            var allOutgoingTransfers = _unitOfWork.Entity.GetAll();
            return Ok(_mapper.Map<IEnumerable<OutgoingTransferViewModel>>(allOutgoingTransfers));
        }

        /// <summary>
        /// Get all outgoingTransfer
        /// </summary>
        /// <returns>List of outgoingTransfer</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<OutgoingTransferViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activeoutgoingTransfers")]
        public IActionResult GetActiveOutgoingTransfers()
        {
            var allOutgoingTransfers = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<OutgoingTransferViewModel>>(allOutgoingTransfers));
        }

        /// <summary>
        /// Get outgoingTransfer by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<OutgoingTransferViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetOutgoingTransfer([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var outgoingTransfer = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (outgoingTransfer == null)
            {
                throw new NotFoundException($"OutgoingTransfer Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<OutgoingTransferViewModel>(outgoingTransfer));
        }

        // PUT: api/OutgoingTransfer/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOutgoingTransfer([FromRoute] long id, [FromBody] OutgoingTransferViewModel outgoingTransfer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the OutgoingTransfer to edit
            var _outgoingTransfer = await _unitOfWork.Entity.GetSingle(id);

            if (id != _outgoingTransfer.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _outgoingTransfer.BranchId = outgoingTransfer.BranchId;
                _outgoingTransfer.OldBranchName = outgoingTransfer.OldBranchName;
                _outgoingTransfer.MemberId = outgoingTransfer.MemberId;
                _outgoingTransfer.Notes = outgoingTransfer.Notes;
                _outgoingTransfer.IsAccepted = outgoingTransfer.IsAccepted;
                _outgoingTransfer.IsActive = outgoingTransfer.IsActive;
            }
            // Implement state management of entities _context.Entry(outgoingTransfer).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_outgoingTransfer);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OutgoingTransferExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("OutgoingTransferUpdate", new { id = _outgoingTransfer.Id }, _outgoingTransfer);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="outgoingTransferViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedOutgoingTransferIsActive(long id, [FromBody] OutgoingTransferViewModel outgoingTransferViewModel)
        {
            var outgoingTransfer = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (outgoingTransfer == null)
                throw new NotFoundException("OutgoingTransfer not found");

            outgoingTransfer.IsActive = outgoingTransferViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(outgoingTransfer);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = outgoingTransfer.Id }, outgoingTransfer);
        }
        // POST: api/OutgoingTransfers
        [HttpPost]
        public async Task<IActionResult> PostOutgoingTransfer([FromBody] OutgoingTransferViewModel outgoingTransfer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newOutgoingTransfer = _mapper.Map<OutgoingTransfer>(outgoingTransfer);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.OutgoingTransferExists(outgoingTransfer.Id))
                throw new BadRequestException("This outgoingTransfer exists!!");

            _unitOfWork.Entity.Add(newOutgoingTransfer);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetOutgoingTransfer", new { id = newOutgoingTransfer.Id }, newOutgoingTransfer);
        }

        // DELETE: api/OutgoingTransfers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOutgoingTransfer([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var outgoingTransfer = await _unitOfWork.Entity.GetSingle(id);  // _context.OutgoingTransfers.FindAsync(id);
            if (outgoingTransfer == null)
            {
                return NotFound();
            }

            /*_unitOfWork.Entity.Delete(outgoingTransfer);
            await _unitOfWork.SaveChangesAsync();*/

            return Ok(outgoingTransfer);
        }

        private bool OutgoingTransferExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
