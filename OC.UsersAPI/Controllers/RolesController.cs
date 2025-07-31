using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OC.Domain.ViewModels.Users;

namespace OC.UsersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public RolesController(IMapper mapper, RoleManager<IdentityRole> roleManager, ILogger<RolesController> logger)
        {
            _mapper = mapper;
            _roleManager = roleManager;
            _logger = logger;
        }

        /// <summary>
        /// Get all roles
        /// </summary>
        /// <returns>List of user rights</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RoleViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetRoles()
        {
            var allRoles = _roleManager.Roles.ToList();
            return Ok(allRoles);
        }

        /// <summary>
        /// Get role by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>User right == entered Id</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<RoleViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetRole([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var role = _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                throw new NotFoundException($"Role Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<RoleViewModel>(role));
        }


        /// <summary>
        /// Edit a role by Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRole([FromRoute] string id, [FromBody] RoleViewModel role)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Role to edit
            var _role = await _roleManager.FindByIdAsync(id);

            if (id != _role.Id)
            {
                return BadRequest();
            }
            else
            {
                // Assign new values
                _role.Name = role.Name;
                _role.NormalizedName = role.Name.ToUpper();
            }
            // Implement state management of entities _context.Entry(role).State = EntityState.Modified;

            await _roleManager.UpdateAsync(_role);


            return CreatedAtAction("PutRole", new { id = _role.Id }, _role);
        }

        /// <summary>
        /// Create a new role
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostRole([FromBody] string roleName)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(roleName));
                if (result.Succeeded)
                {
                    return Ok("Role successfully created.");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return BadRequest(ModelState);
                }
            }

            return Ok();
        }

        /// <summary>
        /// Delete a role by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var role = await _roleManager.FindByIdAsync(id);

            if (role == null)
            {
                return BadRequest($"Role Id {id} did not bring up any records!!");
            }
            else
            {
                await _roleManager.DeleteAsync(role);
                return Ok();
            }
        }
    }
}