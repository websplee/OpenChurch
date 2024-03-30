using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Branches;
using System.Data.Entity.Infrastructure;

namespace OC.BranchesAPI.Properties
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CellGroupHostsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<CellGroupHosts> _unitOfWork;
        private readonly IMapper _mapper;

        public CellGroupHostsController(IMapper mapper, IUnitOfWork<CellGroupHosts> unitOfWork, ILogger<CellGroupHostsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all cellGroupHost
        /// </summary>
        /// <returns>List of cellGroupHost</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellGroupHosts>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetCellGroupHosts()
        {
            var allCellGroupHosts = _unitOfWork.Entity.GetAll();
            return Ok(allCellGroupHosts);
        }

        /// <summary>
        /// Get all cellGroupHost
        /// </summary>
        /// <returns>List of cellGroupHost</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellGroupHosts>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activecellGroupHosts")]
        public IActionResult GetActiveCellGroupHosts()
        {
            var allCellGroupHosts = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allCellGroupHosts);
        }

        /// <summary>
        /// Get cellGroupHost by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CellGroupHosts>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetCellGroupHost([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cellGroupHost = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (cellGroupHost == null)
            {
                throw new NotFoundException($"CellGroupHost Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<CellGroupHosts>(cellGroupHost));
        }

        // PUT: api/CellGroupHost/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCellGroupHost([FromRoute] long id, [FromBody] CellGroupHosts cellGroupHost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the CellGroupHost to edit
            var _cellGroupHost = await _unitOfWork.Entity.GetSingle(id);

            if (id != _cellGroupHost.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _cellGroupHost.CellGroupId = cellGroupHost.CellGroupId;
                _cellGroupHost.MemberId = cellGroupHost.MemberId;
                _cellGroupHost.IsActive = cellGroupHost.IsActive;
            }
            // Implement state management of entities _context.Entry(cellGroupHost).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CellGroupHostExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("CellGroupHostUpdate", new { id = _cellGroupHost.Id }, _cellGroupHost);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cellGroupHostViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedCellGroupHostIsActive(long id, [FromBody] CellGroupHosts cellGroupHostViewModel)
        {
            var cellGroupHost = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (cellGroupHost == null)
                throw new NotFoundException("CellGroupHost not found");

            cellGroupHost.IsActive = cellGroupHostViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(cellGroupHost);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = cellGroupHost.Id }, cellGroupHost);
        }
        // POST: api/CellGroupHosts
        [HttpPost]
        public async Task<IActionResult> PostCellGroupHost([FromBody] CellGroupHosts cellGroupHost)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newCellGroupHost = cellGroupHost;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.CellGroupHostExists(cellGroupHost.Id))
                throw new BadRequestException("This cellGroupHost exists!!");

            _unitOfWork.Entity.Add(newCellGroupHost);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetCellGroupHost", new { id = newCellGroupHost.Id }, newCellGroupHost);
        }

        // DELETE: api/CellGroupHosts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCellGroupHost([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cellGroupHost = await _unitOfWork.Entity.GetSingle(id);  // _context.CellGroupHosts.FindAsync(id);
            if (cellGroupHost == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(cellGroupHost);
            await _unitOfWork.SaveChangesAsync();

            return Ok(cellGroupHost);
        }

        private bool CellGroupHostExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
