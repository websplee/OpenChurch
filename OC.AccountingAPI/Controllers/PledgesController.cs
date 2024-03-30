using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Accounting;
using System.Data.Entity.Infrastructure;

namespace OC.AccountingAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class PledgesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Pledge> _unitOfWork;
        private readonly IMapper _mapper;

        public PledgesController(IMapper mapper, IUnitOfWork<Pledge> unitOfWork, ILogger<PledgesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all pledge
        /// </summary>
        /// <returns>List of pledge</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Pledge>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetPledges()
        {
            var allPledges = _unitOfWork.Entity.AllIncluding(p => p.Member, p => p.Ministry);
            return Ok(allPledges);
        }

        /// <summary>
        /// Get all pledge
        /// </summary>
        /// <returns>List of pledge</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Pledge>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activepledges")]
        public IActionResult GetActivePledges()
        {
            var allPledges = _unitOfWork.Entity.AllIncluding(p => p.Member, p => p.Ministry).Where(m => m.IsActive == true);
            return Ok(allPledges);
        }

        /// <summary>
        /// Get pledge by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Pledge>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetPledge([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pledge = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (pledge == null)
            {
                throw new NotFoundException($"Pledge Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<Pledge>(pledge));
        }

        // PUT: api/Pledge/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPledge([FromRoute] long id, [FromBody] Pledge pledge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Pledge to edit
            var _pledge = await _unitOfWork.Entity.GetSingle(id);

            if (id != _pledge.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _pledge.MinistryId = pledge.MinistryId;
                _pledge.Description = pledge.Description;
                _pledge.MemberId = pledge.MemberId;
                _pledge.PaidAmount = pledge.PaidAmount;
                _pledge.Amount = pledge.Amount;
                _pledge.PaymentDate = pledge.PaymentDate;
                _pledge.PaidAmount = pledge.PaidAmount;
                _pledge.IsActive = pledge.IsActive;
            }
            // Implement state management of entities _context.Entry(pledge).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PledgeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("PledgeUpdate", new { id = _pledge.Id }, _pledge);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pledgeViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedPledgeIsActive(long id, [FromBody] Pledge pledgeViewModel)
        {
            var pledge = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (pledge == null)
                throw new NotFoundException("Pledge not found");

            pledge.IsActive = pledgeViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(pledge);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = pledge.Id }, pledge);
        }
        // POST: api/Pledges
        [HttpPost]
        public async Task<IActionResult> PostPledge([FromBody] Pledge pledge)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newPledge = pledge;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.PledgeExists(pledge.Id))
                throw new BadRequestException("This pledge exists!!");

            _unitOfWork.Entity.Add(newPledge);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetPledge", new { id = newPledge.Id }, newPledge);
        }

        // DELETE: api/Pledges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePledge([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pledge = await _unitOfWork.Entity.GetSingle(id);  // _context.Pledges.FindAsync(id);
            if (pledge == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(pledge);
            await _unitOfWork.SaveChangesAsync();

            return Ok(pledge);
        }

        private bool PledgeExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
