/*using AutoMapper;
using CrystalBLCore.BusinessServices;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Users;
using OC.Domain.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OC.UsersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserRolesController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IdentityUserRole< identity;
        private readonly IMapper _mapper;
        private readonly long _currentUserClientId;

        public UserRolesController(IMapper mapper, IUnitOfWork<UserRight> unitOfWork, ILogger<UserRolesController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
            // _currentUserClientId = UserService.CurrentUserClientId();
        }

        /// <summary>
        /// Get all user rights - This is only accessible to admin module
        /// </summary>
        /// <returns>List of user rights</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserRightViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        [Authorize(Roles = "admin_admin")]
        public IActionResult GetUserRights()
        {
            var allUserRights = _unitOfWork.Entity.AllIncluding(u => u.Role, u => u.Module, u => u.User);
            return Ok(_mapper.Map<IEnumerable<UserRightViewModel>>(allUserRights));
        }        
       

        /// <summary>
        /// Get user right by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User right == entered Id</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserRightViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        [Authorize(Roles = "admin_admin")]
        public IActionResult GetById([FromRoute] long id)
        {           
            var userRight = _unitOfWork.Entity.GetSingle(u => u.Id == id, u => u.Role, u => u.Module, u => u.User).FirstOrDefault();

            if (userRight == null)
            {
                throw new NotFoundException($"UserRight Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<UserRightViewModel>(userRight));
        }

        /// <summary>
        /// Get a list of user rights given a user Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List of </returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserRightViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("userid/{id}")]
        public IActionResult GetUserRightsByUserId([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRights = _unitOfWork.Entity.AllIncluding(u => u.Role, u => u.Module, u => u.User).Where(u => u.UserId == id);

            if (userRights == null)
            {
                throw new NotFoundException($"User Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IEnumerable<UserRightViewModel>>(userRights));
        }

        /// <summary>
        /// Get a list of user rights given to a certain role Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserRightViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("roleId/{id}")]
        public IActionResult GetUserRightsByRoleId([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRights = _unitOfWork.Entity.AllIncluding(u => u.Role, u => u.Module, u => u.User).Where(u => u.RoleId == id);

            if (userRights == null)
            {
                throw new NotFoundException($"Role Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IEnumerable<UserRightViewModel>>(userRights));
        }

        /// <summary>
        /// Get a list of users given to a certain role Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("users/roleId/{id}")]
        public IActionResult GetUsersByRoleId([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var users = _unitOfWork.Entity.AllIncluding(u => u.Role, u => u.Module, u => u.User)
                .Where(u => u.RoleId == id)
                .Select(u => new User
                {
                    Id = u.UserId,
                    Username = u.User.Username,
                    Fullname = u.User.Fullname,
                    Email = u.User.Email,
                    Description = u.User.Description,
                    IsActive = u.User.IsActive,
                });

            if (users == null)
            {
                throw new NotFoundException($"Role Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IEnumerable<UserViewModel>>(users));
        }

        /// <summary>
        /// Get a list of user rights given to a certain module Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserRightViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("moduleId/{id}")]
        public IActionResult GetUserRightsByModuleId([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRights = _unitOfWork.Entity.AllIncluding(u => u.Role, u => u.Module, u => u.User).Where(u => u.ModuleId == id);

            if (userRights == null)
            {
                throw new NotFoundException($"Module Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IEnumerable<UserRightViewModel>>(userRights));
        }

        /// <summary>
        /// Get a list of users given to a certain module Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("users/moduleId/{id}")]
        public IActionResult GetUsersByModuleId([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var users = _unitOfWork.Entity.AllIncluding(u => u.Role, u => u.Module, u => u.User)
                .Where(u => u.ModuleId == id)
                .Select(u => new User
                {
                    Id = u.UserId,
                    Username = u.User.Username,
                    Fullname = u.User.Fullname,
                    Email = u.User.Email,
                    Description = u.User.Description,
                    IsActive = u.User.IsActive,
                });

            if (users == null)
            {
                throw new NotFoundException($"module Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<IEnumerable<UserViewModel>>(users));
        }

        /// <summary>
        /// Edit a UserRight object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userRight"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(UserRightViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        [Authorize(Roles = "admin,admin_admin")]
        public async Task<IActionResult> PutUserRight([FromRoute] long id, [FromBody] UserRightViewModel userRight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the UserRight to edit
            var _userRight = await _unitOfWork.Entity.GetSingle(id);

            if (id != _userRight.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _userRight.RoleId = userRight.RoleId;
                _userRight.ModuleId = userRight.ModuleId;
            }
            // Implement state management of entities _context.Entry(userRight).State = EntityState.Modified;

            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await UserRightExists(userRight.RoleId, userRight.ModuleId, userRight.UserId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("PutUserRight", new { id = _userRight.Id }, _userRight);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userRightViewModel"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(UserRightViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("updateisactive/{id}")]
        [Authorize(Roles = "admin,admin_admin")]
        public async Task<IActionResult> UpdateUserRightIsActive(long id, [FromBody] UserRightViewModel userRightViewModel)
        {
            var userRight = await _unitOfWork.Entity.GetSingle(x => x.Id == id).FirstOrDefaultAsync();

            if (userRight == null)
                throw new NotFoundException("User Right not found");

            userRight.IsActive = userRightViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(userRight);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UpdateUserRightIsActive", new { id = userRight.Id }, userRight);            
        }


        /// <summary>
        /// Create a new UserRight object
        /// </summary>
        /// <param name="userRight"></param>
        /// <returns></returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(UserRightViewModel))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPost]
        public async Task<IActionResult> PostUserRight([FromBody] UserRight userRight)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newUserRight = userRight;
            newUserRight.IsActive = true;
            // ADD OTHER DEFAULT VALUES HERE
            if (await UserRightExists(userRight.RoleId, userRight.ModuleId, userRight.UserId))
                throw new BadRequestException("This combination of user, role and module exists!!");

            _unitOfWork.Entity.Add(newUserRight);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("PostUserRight", new { id = newUserRight.Id }, newUserRight);
        }

        /// <summary>
        /// Delete User Right - Must not be used
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRight([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userRight = await _unitOfWork.Entity.GetSingle(id);  // _context.UserRights.FindAsync(id);
            if (userRight == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(userRight);
            await _unitOfWork.SaveChangesAsync();

            return Ok(userRight);
        }

        private async Task<bool> UserRightExists(long roleId, long moduleId, long userId)
        {
            return await _unitOfWork.Entity.GetSingle(e => e.RoleId == roleId && e.ModuleId == moduleId && e.UserId == userId).CountAsync() > 0 ? true : false;
        }
    }
}*/