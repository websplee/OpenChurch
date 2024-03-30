using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.ChurchProgramSessionVisitorsAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ChurchProgramSessionVisitorsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<ChurchProgramSessionVisitor> _unitOfWork;
        private readonly IMapper _mapper;

        public ChurchProgramSessionVisitorsController(IMapper mapper, IUnitOfWork<ChurchProgramSessionVisitor> unitOfWork, ILogger<ChurchProgramSessionVisitorsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all churchProgramSessionVisitor
        /// </summary>
        /// <returns>List of churchProgramSessionVisitor</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramSessionVisitor>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetChurchProgramSessionVisitors()
        {
            var allChurchProgramSessionVisitors = _unitOfWork.Entity.GetAll();
            return Ok(allChurchProgramSessionVisitors);
        }

        /// <summary>
        /// Get all churchProgramSessionVisitor
        /// </summary>
        /// <returns>List of churchProgramSessionVisitor</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramSessionVisitor>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activechurchProgramSessionVisitors")]
        public IActionResult GetActiveChurchProgramSessionVisitors()
        {
            var allChurchProgramSessionVisitors = _unitOfWork.Entity.AllIncluding(c => c.ChurchProgramSession).Where(m => m.IsActive == true);
            return Ok(allChurchProgramSessionVisitors);
        }

        /// <summary>
        /// Get churchProgramSessionVisitor by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramSessionVisitor>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetChurchProgramSessionVisitor([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var churchProgramSessionVisitor = _unitOfWork.Entity.GetSingle(m => m.Id == id, c => c.ChurchProgramSession).FirstOrDefault();

            if (churchProgramSessionVisitor == null)
            {
                throw new NotFoundException($"ChurchProgramSessionVisitor Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<ChurchProgramSessionVisitor>(churchProgramSessionVisitor));
        }

        // PUT: api/ChurchProgramSessionVisitor/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChurchProgramSessionVisitor([FromRoute] long id, [FromBody] ChurchProgramSessionVisitor churchProgramSessionVisitor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the ChurchProgramSessionVisitor to edit
            var _churchProgramSessionVisitor = await _unitOfWork.Entity.GetSingle(id);

            if (id != _churchProgramSessionVisitor.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _churchProgramSessionVisitor.ChurchProgramSessionId = churchProgramSessionVisitor.ChurchProgramSessionId;
                _churchProgramSessionVisitor.IsActive = churchProgramSessionVisitor.IsActive;
                _churchProgramSessionVisitor.Name = churchProgramSessionVisitor.Name;
                _churchProgramSessionVisitor.MobileNumber = churchProgramSessionVisitor.MobileNumber;
                _churchProgramSessionVisitor.Email = churchProgramSessionVisitor.Email;
                _churchProgramSessionVisitor.Address = churchProgramSessionVisitor.Address;
                _churchProgramSessionVisitor.DateToVisit = churchProgramSessionVisitor.DateToVisit;
                _churchProgramSessionVisitor.DateVisited = churchProgramSessionVisitor.DateVisited;
                _churchProgramSessionVisitor.Comments = churchProgramSessionVisitor.Comments;
            }
            // Implement state management of entities _context.Entry(churchProgramSessionVisitor).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChurchProgramSessionVisitorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("ChurchProgramSessionVisitorUpdate", new { id = _churchProgramSessionVisitor.Id }, _churchProgramSessionVisitor);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="churchProgramSessionVisitorViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedChurchProgramSessionVisitorIsActive(long id, [FromBody] ChurchProgramSessionVisitor churchProgramSessionVisitorViewModel)
        {
            var churchProgramSessionVisitor = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (churchProgramSessionVisitor == null)
                throw new NotFoundException("ChurchProgramSessionVisitor not found");

            churchProgramSessionVisitor.IsActive = churchProgramSessionVisitorViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(churchProgramSessionVisitor);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = churchProgramSessionVisitor.Id }, churchProgramSessionVisitor);
        }
        // POST: api/ChurchProgramSessionVisitors
        [HttpPost]
        public async Task<IActionResult> PostChurchProgramSessionVisitor([FromBody] ChurchProgramSessionVisitor churchProgramSessionVisitor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newChurchProgramSessionVisitor = churchProgramSessionVisitor;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.ChurchProgramSessionVisitorExists(churchProgramSessionVisitor.Id))
                throw new BadRequestException("This churchProgramSessionVisitor exists!!");

            _unitOfWork.Entity.Add(newChurchProgramSessionVisitor);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetChurchProgramSessionVisitor", new { id = newChurchProgramSessionVisitor.Id }, newChurchProgramSessionVisitor);
        }

        // DELETE: api/ChurchProgramSessionVisitors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChurchProgramSessionVisitor([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var churchProgramSessionVisitor = await _unitOfWork.Entity.GetSingle(id);  // _context.ChurchProgramSessionVisitors.FindAsync(id);
            if (churchProgramSessionVisitor == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(churchProgramSessionVisitor);
            await _unitOfWork.SaveChangesAsync();

            return Ok(churchProgramSessionVisitor);
        }

        private bool ChurchProgramSessionVisitorExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
