using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using OC.Domain.ViewModels.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.ChurchProgramSessionAttendancesAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ChurchProgramSessionAttendancesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<ChurchProgramSessionAttendance> _unitOfWork;
        private readonly IMapper _mapper;

        public ChurchProgramSessionAttendancesController(IMapper mapper, IUnitOfWork<ChurchProgramSessionAttendance> unitOfWork, ILogger<ChurchProgramSessionAttendancesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all churchProgramSessionAttendance
        /// </summary>
        /// <returns>List of churchProgramSessionAttendance</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramSessionAttendanceViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetChurchProgramSessionAttendances()
        {
            var allChurchProgramSessionAttendances = _unitOfWork.Entity.AllIncluding(c => c.ChurchProgramSession);
            return Ok(_mapper.Map<IEnumerable<ChurchProgramSessionAttendanceViewModel>>(allChurchProgramSessionAttendances));
        }

        /// <summary>
        /// Get all churchProgramSessionAttendance
        /// </summary>
        /// <returns>List of churchProgramSessionAttendance</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramSessionAttendanceViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activechurchProgramSessionAttendances")]
        public IActionResult GetActiveChurchProgramSessionAttendances()
        {
            var allChurchProgramSessionAttendances = _unitOfWork.Entity.AllIncluding(c => c.ChurchProgramSession).Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<ChurchProgramSessionAttendanceViewModel>>(allChurchProgramSessionAttendances));
        }

        /// <summary>
        /// Get churchProgramSessionAttendance by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramSessionAttendanceViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetChurchProgramSessionAttendance([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var churchProgramSessionAttendance = _unitOfWork.Entity.GetSingle(m => m.Id == id, c => c.ChurchProgramSession).FirstOrDefault();

            if (churchProgramSessionAttendance == null)
            {
                throw new NotFoundException($"ChurchProgramSessionAttendance Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<ChurchProgramSessionAttendanceViewModel>(churchProgramSessionAttendance));
        }

        // PUT: api/ChurchProgramSessionAttendance/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChurchProgramSessionAttendance([FromRoute] long id, [FromBody] ChurchProgramSessionAttendanceViewModel churchProgramSessionAttendance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the ChurchProgramSessionAttendance to edit
            var _churchProgramSessionAttendance = await _unitOfWork.Entity.GetSingle(id);

            if (id != _churchProgramSessionAttendance.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _churchProgramSessionAttendance.IsActive = churchProgramSessionAttendance.IsActive;
                _churchProgramSessionAttendance.TotalBoys = churchProgramSessionAttendance.TotalBoys;
                _churchProgramSessionAttendance.TotalGirls = churchProgramSessionAttendance.TotalGirls;
                _churchProgramSessionAttendance.TotalMen = churchProgramSessionAttendance.TotalMen;
                _churchProgramSessionAttendance.TotalWomen = churchProgramSessionAttendance.TotalWomen;
                _churchProgramSessionAttendance.TotalYouthMen = churchProgramSessionAttendance.TotalYouthMen;
                _churchProgramSessionAttendance.TotalYouthWomen = churchProgramSessionAttendance.TotalYouthWomen;
            }
            // Implement state management of entities _context.Entry(churchProgramSessionAttendance).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_churchProgramSessionAttendance);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChurchProgramSessionAttendanceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("ChurchProgramSessionAttendanceUpdate", new { id = _churchProgramSessionAttendance.Id }, _churchProgramSessionAttendance);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="churchProgramSessionAttendanceViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedChurchProgramSessionAttendanceIsActive(long id, [FromBody] ChurchProgramSessionAttendanceViewModel churchProgramSessionAttendanceViewModel)
        {
            var churchProgramSessionAttendance = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (churchProgramSessionAttendance == null)
                throw new NotFoundException("ChurchProgramSessionAttendance not found");

            churchProgramSessionAttendance.IsActive = churchProgramSessionAttendanceViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(churchProgramSessionAttendance);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = churchProgramSessionAttendance.Id }, churchProgramSessionAttendance);
        }
        // POST: api/ChurchProgramSessionAttendances
        [HttpPost]
        public async Task<IActionResult> PostChurchProgramSessionAttendance([FromBody] ChurchProgramSessionAttendanceViewModel churchProgramSessionAttendance)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newChurchProgramSessionAttendance = _mapper.Map< ChurchProgramSessionAttendance>(churchProgramSessionAttendance);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.ChurchProgramSessionAttendanceExists(churchProgramSessionAttendance.Id))
                throw new BadRequestException("This churchProgramSessionAttendance exists!!");

            _unitOfWork.Entity.Add(newChurchProgramSessionAttendance);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetChurchProgramSessionAttendance", new { id = newChurchProgramSessionAttendance.Id }, newChurchProgramSessionAttendance);
        }

        // DELETE: api/ChurchProgramSessionAttendances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChurchProgramSessionAttendance([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var churchProgramSessionAttendance = await _unitOfWork.Entity.GetSingle(id);  // _context.ChurchProgramSessionAttendances.FindAsync(id);
            if (churchProgramSessionAttendance == null)
            {
                return NotFound();
            }

           /* _unitOfWork.Entity.Delete(churchProgramSessionAttendance);
            await _unitOfWork.SaveChangesAsync();
*/
            return Ok(churchProgramSessionAttendance);
        }

        private bool ChurchProgramSessionAttendanceExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
