using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using OC.Domain.ViewModels.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.ChurchProgramsAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ChurchProgramsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<ChurchProgram> _unitOfWork;
        private readonly IMapper _mapper;

        public ChurchProgramsController(IMapper mapper, IUnitOfWork<ChurchProgram> unitOfWork, ILogger<ChurchProgramsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all churchProgram
        /// </summary>
        /// <returns>List of churchProgram</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetChurchPrograms()
        {
            var allChurchPrograms = _unitOfWork.Entity.GetAll();
            return Ok(_mapper.Map<IEnumerable<ChurchProgramViewModel>>(allChurchPrograms));
        }

        /// <summary>
        /// Get all churchProgram
        /// </summary>
        /// <returns>List of churchProgram</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activechurchPrograms")]
        public IActionResult GetActiveChurchPrograms()
        {
            var allChurchPrograms = _unitOfWork.Entity.AllIncluding(c => c.ChurchProgramSessions).Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<ChurchProgramViewModel>>(allChurchPrograms));
        }

        /// <summary>
        /// Get churchProgram by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ChurchProgramViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetChurchProgram([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var churchProgram = _unitOfWork.Entity.GetSingle(m => m.Id == id, c => c.ChurchProgramSessions).FirstOrDefault();

            if (churchProgram == null)
            {
                throw new NotFoundException($"ChurchProgram Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<ChurchProgramViewModel>(churchProgram));
        }

        // PUT: api/ChurchProgram/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChurchProgram([FromRoute] long id, [FromBody] ChurchProgramViewModel churchProgram)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the ChurchProgram to edit
            var _churchProgram = await _unitOfWork.Entity.GetSingle(id);

            if (id != _churchProgram.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _churchProgram.IsActive = churchProgram.IsActive;
                _churchProgram.Name = churchProgram.Name;
                _churchProgram.Description = churchProgram.Description;
            }
            // Implement state management of entities _context.Entry(churchProgram).State = EntityState.Modified;

            try
            {
                _unitOfWork.Entity.Update(_churchProgram);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChurchProgramExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("ChurchProgramUpdate", new { id = _churchProgram.Id }, _churchProgram);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="churchProgramViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedChurchProgramIsActive(long id, [FromBody] ChurchProgramViewModel churchProgramViewModel)
        {
            var churchProgram = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (churchProgram == null)
                throw new NotFoundException("ChurchProgram not found");

            churchProgram.IsActive = churchProgramViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(churchProgram);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = churchProgram.Id }, churchProgram);
        }
        // POST: api/ChurchPrograms
        [HttpPost]
        public async Task<IActionResult> PostChurchProgram([FromBody] ChurchProgramViewModel churchProgram)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newChurchProgram = _mapper.Map<ChurchProgram>(churchProgram);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.ChurchProgramExists(churchProgram.Id))
                throw new BadRequestException("This churchProgram exists!!");

            _unitOfWork.Entity.Add(newChurchProgram);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetChurchProgram", new { id = newChurchProgram.Id }, newChurchProgram);
        }

        // DELETE: api/ChurchPrograms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChurchProgram([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var churchProgram = await _unitOfWork.Entity.GetSingle(id);  // _context.ChurchPrograms.FindAsync(id);
            if (churchProgram == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(churchProgram);
            await _unitOfWork.SaveChangesAsync();

            return Ok(churchProgram);
        }

        private bool ChurchProgramExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
