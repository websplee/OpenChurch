using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Users;
using OC.Domain.ViewModels.Users;

namespace OC.UsersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class ModulesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Module> _unitOfWork;
        private readonly IMapper _mapper;

        public ModulesController(IMapper mapper, IUnitOfWork<Module> unitOfWork, ILogger<ModulesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all user modules
        /// </summary>
        /// <returns>List of user modules</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ModuleViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetModules()
        {
            var allModules = _unitOfWork.Entity.GetAll();
            return Ok(allModules);
        }

        /// <summary>
        /// Get all user modules
        /// </summary>
        /// <returns>List of user modules</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ModuleViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activemodules")]
        public IActionResult GetActiveModules()
        {
            var allModules = _unitOfWork.Entity.GetAll().Where(m => m.IsActive == true);
            return Ok(allModules);
        }

        /// <summary>
        /// Get user module by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User module == entered Id</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ModuleViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetModule([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var module = _unitOfWork.Entity.GetSingle(m => m.Id == id).FirstOrDefault();

            if (module == null)
            {
                throw new NotFoundException($"Module Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<ModuleViewModel>(module));
        }

        /// <summary>
        /// Get a list of user modules given a user Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of </returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ModuleViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("userid/{id}")]
        public IActionResult GetModuleByUserId([FromRoute] long id)
        { // TODO: Not working
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var module = _unitOfWork.Entity.AllIncluding(m => m.RoleModules);

            if (module == null)
            {
                throw new NotFoundException($"User Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IEnumerable<ModuleViewModel>>(module));
        }

        /// <summary>
        /// Get a list of user modules given to a certain role Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ModuleViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("roleId/{id}")]
        public IActionResult GetModuleByRoleId([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var module = _unitOfWork.Entity.AllIncluding(m => m.RoleModules);

            if (module == null)
            {
                throw new NotFoundException($"Role Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IEnumerable<ModuleViewModel>>(module));
        }

        /// <summary>
        /// Edit a module
        /// </summary>
        /// <param name="id"></param>
        /// <param name="module"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModule([FromRoute] long id, [FromBody] ModuleViewModel module)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Module to edit
            var _module = await _unitOfWork.Entity.GetSingle(id);

            if (id != _module.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _module.Name = module.Name;
                _module.IsActive = module.IsActive;
            }
            // Implement state management of entities _context.Entry(module).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("ModulesUpdate", new { id = _module.Id }, _module);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="moduleViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedModuleIsActive(long id, [FromBody] ModuleViewModel moduleViewModel)
        {
            var module = _unitOfWork.Entity.GetSingle(x => x.Id == id).First();

            if (module == null)
                throw new NotFoundException("User module not found");

            module.IsActive = moduleViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(module);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = module.Id }, module);
        }


        /// <summary>
        /// Create a new module
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        /// <exception cref="BadRequestException"></exception>
        [HttpPost]
        public async Task<IActionResult> PostModule([FromBody] Module module)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newModule = module;
            // ADD OTHER DEFAULT VALUES HERE
            if (this.ModuleExists(module.Id))
                throw new BadRequestException("This module exists!!");

            _unitOfWork.Entity.Add(newModule);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetModule", new { id = newModule.Id }, newModule);
        }

        /// <summary>
        /// Delete a module by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModule([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var module = await _unitOfWork.Entity.GetSingle(id);  // _context.Modules.FindAsync(id);
            if (module == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(module);
            await _unitOfWork.SaveChangesAsync();

            return Ok(module);
        }

        private bool ModuleExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}