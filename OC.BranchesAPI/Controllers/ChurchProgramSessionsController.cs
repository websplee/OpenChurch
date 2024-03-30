using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.ChurchProgramSessionsAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ChurchProgramSessionsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<ChurchProgramSession> _unitOfWork;
        private readonly IMapper _mapper;

        public ChurchProgramSessionsController(IMapper mapper, IUnitOfWork<ChurchProgramSession> unitOfWork, ILogger<ChurchProgramSessionsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all churchProgramSession
        /// </summary>
        /// <returns>List of churchProgramSession</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramSession>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetChurchProgramSessions()
        {
            var allChurchProgramSessions = _unitOfWork.Entity.AllIncluding(c => c.ChurchProgramSessionAttendances, c => c.ChurchProgramSessionVisitors, 
                c => c.Expenses, c => c.Incomes, c => c.Pledges, c => c.ChurchProgram, c => c.Branch);
            return Ok(allChurchProgramSessions);
        }

        /// <summary>
        /// Get all churchProgramSession
        /// </summary>
        /// <returns>List of churchProgramSession</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramSession>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activechurchProgramSessions")]
        public IActionResult GetActiveChurchProgramSessions()
        {
            var allChurchProgramSessions = _unitOfWork.Entity.AllIncluding(c => c.ChurchProgramSessionAttendances, c => c.ChurchProgramSessionVisitors,
                c => c.Expenses, c => c.Incomes, c => c.Pledges, c => c.ChurchProgram, c => c.Branch).Where(m => m.IsActive == true);
            return Ok(allChurchProgramSessions);
        }

        /// <summary>
        /// Get churchProgramSession by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramSession>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetChurchProgramSession([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var churchProgramSession = _unitOfWork.Entity.GetSingle(m => m.Id == id, c => c.ChurchProgramSessionAttendances, c => c.ChurchProgramSessionVisitors,
                c => c.Expenses, c => c.Incomes, c => c.Pledges, c => c.ChurchProgram, c => c.Branch).FirstOrDefault();

            if (churchProgramSession == null)
            {
                throw new NotFoundException($"ChurchProgramSession Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<ChurchProgramSession>(churchProgramSession));
        }

        // PUT: api/ChurchProgramSession/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChurchProgramSession([FromRoute] long id, [FromBody] ChurchProgramSession churchProgramSession)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the ChurchProgramSession to edit
            var _churchProgramSession = await _unitOfWork.Entity.GetSingle(id);

            if (id != _churchProgramSession.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _churchProgramSession.BranchId = churchProgramSession.BranchId;
                _churchProgramSession.ChurchProgramId = churchProgramSession.ChurchProgramId;
                _churchProgramSession.Name = churchProgramSession.Name;
                _churchProgramSession.StartTime = churchProgramSession.StartTime;
                _churchProgramSession.EndTime = churchProgramSession.EndTime;
                _churchProgramSession.IsActive = churchProgramSession.IsActive;
            }
            // Implement state management of entities _context.Entry(churchProgramSession).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChurchProgramSessionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("ChurchProgramSessionUpdate", new { id = _churchProgramSession.Id }, _churchProgramSession);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="churchProgramSessionViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedChurchProgramSessionIsActive(long id, [FromBody] ChurchProgramSession churchProgramSessionViewModel)
        {
            var churchProgramSession = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (churchProgramSession == null)
                throw new NotFoundException("ChurchProgramSession not found");

            churchProgramSession.IsActive = churchProgramSessionViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(churchProgramSession);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = churchProgramSession.Id }, churchProgramSession);
        }
        // POST: api/ChurchProgramSessions
        [HttpPost]
        public async Task<IActionResult> PostChurchProgramSession([FromBody] ChurchProgramSession churchProgramSession)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newChurchProgramSession = churchProgramSession;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.ChurchProgramSessionExists(churchProgramSession.Id))
                throw new BadRequestException("This churchProgramSession exists!!");

            _unitOfWork.Entity.Add(newChurchProgramSession);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetChurchProgramSession", new { id = newChurchProgramSession.Id }, newChurchProgramSession);
        }

        // DELETE: api/ChurchProgramSessions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChurchProgramSession([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var churchProgramSession = await _unitOfWork.Entity.GetSingle(id);  // _context.ChurchProgramSessions.FindAsync(id);
            if (churchProgramSession == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(churchProgramSession);
            await _unitOfWork.SaveChangesAsync();

            return Ok(churchProgramSession);
        }

        private bool ChurchProgramSessionExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
