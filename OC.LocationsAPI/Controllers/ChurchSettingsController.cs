using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.Repositories.Interfaces;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Locations;
using OC.Domain.ViewModels.Locations;

namespace OC.LocationsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChurchSettingsController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<ChurchSettings> _unitOfWork;        
        private readonly IMapper _mapper;

        public ChurchSettingsController(IMapper mapper, IUnitOfWork<ChurchSettings> unitOfWork, ILogger<ChurchSettingsController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get churchSettings by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ChurchSettings</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ChurchSettingsViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetChurchSettings([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var churchSettings = _unitOfWork.Entity.GetSingle(m => m.Id == id, c => c.Branch).FirstOrDefault();

            if (churchSettings == null)
            {
                throw new NotFoundException($"ChurchSettings Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<ChurchSettingsViewModel>(churchSettings));
        }

        // PUT: api/ChurchSettingss/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChurchSettings([FromRoute] long id, [FromBody] ChurchSettingsViewModel churchSettings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the ChurchSettings to edit
            var _churchSettings = await _unitOfWork.Entity.GetSingle(id);

            if (id != _churchSettings.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _churchSettings.Name = churchSettings.Name;
                _churchSettings.Description = churchSettings.Description;
                _churchSettings.BranchId = churchSettings.BranchId;
                _churchSettings.FounderDetails = churchSettings.FounderDetails;
                _churchSettings.FoundingDate = churchSettings.FoundingDate;
                _churchSettings.IsActive = churchSettings.IsActive;
            }
            // Implement state management of entities _context.Entry(churchSettings).State = EntityState.Modified;
            
            _unitOfWork.Entity.Update(_churchSettings);
            await _unitOfWork.SaveChangesAsync();            

            return CreatedAtAction("ChurchSettingssUpdate", new { id = _churchSettings.Id }, _churchSettings);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="churchSettingsViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedChurchSettingsIsActive(long id, [FromBody] ChurchSettingsViewModel churchSettingsViewModel)
        {
            var churchSettings = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (churchSettings == null)
                throw new NotFoundException("ChurchSettings not found");

            churchSettings.IsActive = churchSettingsViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(churchSettings);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = churchSettings.Id }, _mapper.Map<ChurchSettingsViewModel>(churchSettings));
        }
        // POST: api/ChurchSettingss
        [HttpPost]
        public async Task<IActionResult> PostChurchSettings([FromBody] ChurchSettingsViewModel churchSettings)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newChurchSettings = _mapper.Map<ChurchSettings>(churchSettings);
       
            _unitOfWork.Entity.Add(newChurchSettings);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("PostChurchSettings", new { id = newChurchSettings.Id }, newChurchSettings);
        }
    }
}
