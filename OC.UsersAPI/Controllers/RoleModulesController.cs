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
    public class RoleModulesController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<RoleModule> _unitOfWork;
        private readonly IMapper _mapper;
        private readonly long _currentUserClientId;

        public RoleModulesController(IMapper mapper, IUnitOfWork<RoleModule> unitOfWork, ILogger<RoleModulesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            // _currentUserClientId = UserService.CurrentUserClientId();
        }

        /// <summary>
        /// Get all user modules - This is only accessible to admin module
        /// </summary>
        /// <returns>List of user modules</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RoleModuleViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult GetRoleModules()
        {
            var allRoleModules = _unitOfWork.Entity.AllIncluding(u => u.Role, u => u.Module);
            return Ok(_mapper.Map<IEnumerable<RoleModuleViewModel>>(allRoleModules));
        }


        /// <summary>
        /// Get user module by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User module == entered Id</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RoleModuleViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        [Authorize(Roles = "admin")]
        public IActionResult GetById([FromRoute] long id)
        {
            var roleModule = _unitOfWork.Entity.GetSingle(u => u.Id == id, u => u.Role, u => u.Module).FirstOrDefault();

            if (roleModule == null)
            {
                throw new NotFoundException($"RoleModule Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<RoleModuleViewModel>(roleModule));
        }

        /// <summary>
        /// Get a list of user modules given to a certain role Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RoleModuleViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("roleId/{id}")]
        public IActionResult GetRoleModulesByRoleId([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roleModules = _unitOfWork.Entity.AllIncluding(u => u.Role, u => u.Module).Where(u => u.RoleId == id);

            if (roleModules == null)
            {
                throw new NotFoundException($"Role Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IEnumerable<RoleModuleViewModel>>(roleModules));
        }

        /// <summary>
        /// Get a list of user modules given to a certain module Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RoleModuleViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("moduleId/{id}")]
        public IActionResult GetRoleModulesByModuleId([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roleModules = _unitOfWork.Entity.AllIncluding(u => u.Role, u => u.Module).Where(u => u.ModuleId == id);

            if (roleModules == null)
            {
                throw new NotFoundException($"Module Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IEnumerable<RoleModuleViewModel>>(roleModules));
        }

        /// <summary>
        /// Edit a RoleModule object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roleModule"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(RoleModuleViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        [Authorize(Roles = "admin,admin")]
        public async Task<IActionResult> PutRoleModule([FromRoute] long id, [FromBody] RoleModuleViewModel roleModule)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the RoleModule to edit
            var _roleModule = await _unitOfWork.Entity.GetSingle(id);

            if (id != _roleModule.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _roleModule.RoleId = roleModule.RoleId;
                _roleModule.ModuleId = roleModule.ModuleId;
                _roleModule.CanAddEdit = roleModule.CanAddEdit;
                _roleModule.CanApprove = roleModule.CanApprove;
                _roleModule.CanDelete = roleModule.CanDelete;
                _roleModule.CanView = roleModule.CanView;
                _roleModule.IsActive = roleModule.IsActive;
            }

            _unitOfWork.Entity.Update(_roleModule);

            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("PutRoleModule", new { id = _roleModule.Id }, _roleModule);
        }


        /// <summary>
        /// Toggle IsActive true/false
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roleModuleViewModel"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(RoleModuleViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("updateisactive/{id}")]
        [Authorize(Roles = "admin,admin")]
        public async Task<IActionResult> UpdateRoleModuleIsActive(long id, [FromBody] RoleModuleViewModel roleModuleViewModel)
        {
            var roleModule = await _unitOfWork.Entity.GetSingle(x => x.Id == id).FirstOrDefaultAsync();

            if (roleModule == null)
                throw new NotFoundException("User Module not found");

            roleModule.IsActive = roleModuleViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(roleModule);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UpdateRoleModuleIsActive", new { id = roleModule.Id }, roleModule);
        }


        /// <summary>
        /// Create a new RoleModule object
        /// </summary>
        /// <param name="roleModuleModel"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(RoleModuleViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPost]
        public async Task<IActionResult> PostRoleModule([FromBody] RoleModuleViewModel roleModuleModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roleModule = _unitOfWork.Entity.GetSingle(rm => rm.RoleId == roleModuleModel.RoleId && rm.ModuleId == roleModuleModel.ModuleId).FirstOrDefault();

            if (!(roleModule == null))
                return BadRequest($"A record exists for role Id {roleModuleModel.RoleId} and module Id {roleModuleModel.ModuleId}");
            else
            {
                // Create the entity based on the View Model
                var newRoleModule = _mapper.Map<RoleModule>(roleModuleModel);
                newRoleModule.IsActive = true;
                _unitOfWork.Entity.Add(newRoleModule);
                await _unitOfWork.SaveChangesAsync();

                return CreatedAtAction("PostRoleModule", new { id = newRoleModule.Id }, newRoleModule);
            }
        }

        /// <summary>
        /// Remove a RoleModule object
        /// </summary>
        /// <param name="roleModuleModel"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(RoleModuleViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPost("removerolemodule")]
        public async Task<IActionResult> RemoveRoleModule([FromBody] RoleModuleViewModel roleModuleModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roleModule = _unitOfWork.Entity.GetSingle(rm => rm.RoleId == roleModuleModel.RoleId && rm.ModuleId == roleModuleModel.ModuleId).FirstOrDefault();

            if (!(roleModule == null))
                return BadRequest($"A record exists for role Id {roleModuleModel.RoleId} and module Id {roleModuleModel.ModuleId}");
            else
            {
                _unitOfWork.Entity.Delete(roleModule);
                await _unitOfWork.SaveChangesAsync();

                return CreatedAtAction("PostRoleModule", new { id = roleModule.Id }, roleModule);
            }
        }

        /// <summary>
        /// Delete User Module - Must not be used
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleModule([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var roleModule = await _unitOfWork.Entity.GetSingle(id);  // _context.RoleModules.FindAsync(id);
            if (roleModule == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(roleModule);
            await _unitOfWork.SaveChangesAsync();

            return Ok(roleModule);
        }
    }
}