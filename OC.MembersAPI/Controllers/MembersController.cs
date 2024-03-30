using AutoMapper;
using CrystalBLCore.BusinessServices.CustomExceptions.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models.Members;
using OC.Domain.ViewModels.Members;
using System.Data.Entity.Infrastructure;

namespace OC.MembersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly ILogger _logger;
        private IUnitOfWork<Member> _unitOfWork;
        private readonly IMapper _mapper;

        public MembersController(IMapper mapper, IUnitOfWork<Member> unitOfWork, ILogger<MembersController> logger)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        /// <summary>
        /// Get all member
        /// </summary>
        /// <returns>List of member</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MemberViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet]
        public IActionResult GetMembers()
        {
            var allMembers = _unitOfWork.Entity.AllIncluding(m => m.Branch, m => m.CellGroup, m => m.Spouse, m => m.Family, m => m.User, m => m.BranchMinistryLeaderships, m => m.Pledges);
            return Ok(_mapper.Map<IEnumerable<MemberViewModel>>(allMembers));
        }

        /// <summary>
        /// Get all member
        /// </summary>
        /// <returns>List of member</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MemberViewModel>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpGet("activemembers")]
        public IActionResult GetActiveMembers()
        {
            var allMembers = _unitOfWork.Entity.AllIncluding(m => m.Branch, m => m.CellGroup, m => m.Spouse, m => m.Family, m => m.User, m => m.BranchMinistryLeaderships, m => m.Pledges)
                .Where(m => m.IsActive == true);
            return Ok(_mapper.Map<IEnumerable<MemberViewModel>>(allMembers));
        }

        /// <summary>
        /// Get member by Id
        /// </summary>
        /// <param name="id"></param>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<MemberViewModel>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult GetMember([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var member = _unitOfWork.Entity.GetSingle(m => m.Id == id, m => m.Branch, m => m.CellGroup, m => m.Spouse, m => m.Family, m => m.User, m => m.BranchMinistryLeaderships, m => m.Pledges).FirstOrDefault();

            if (member == null)
            {
                throw new NotFoundException($"Member Id {id} did not bring up any records!!");
            }

            return Ok(_mapper.Map<MemberViewModel>(member));
        }

        // PUT: api/Member/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMember([FromRoute] long id, [FromBody] MemberViewModel member)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // THIS LOGIC NEEDS TO BE VETTED 
            // Get the Member to edit
            var _member = _mapper.Map<Member>(member);

            
            try
            {
                await _unitOfWork.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MemberExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("MemberUpdate", new { id = _member.Id }, _member);
        }


        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="memberViewModel"></param>
        /// <returns></returns>
        [HttpPut("updateisactive/{id}")]
        public IActionResult UpdatedMemberIsActive(long id, [FromBody] MemberViewModel memberViewModel)
        {
            var member = _unitOfWork.Entity.GetSingle(x => x.Id == id, m => m.Branch, m => m.CellGroup, m => m.Spouse, m => m.Family, m => m.User, m => m.BranchMinistryLeaderships, m => m.Pledges).First();

            if (member == null)
                throw new NotFoundException("Member not found");

            member.IsActive = memberViewModel.IsActive;

            // save 
            _unitOfWork.Entity.Update(member);
            _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("UserDeactivated", new { id = member.Id }, member);
        }
        // POST: api/Members
        [HttpPost]
        public async Task<IActionResult> PostMember([FromBody] MemberViewModel member)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create the entity based on the View Model
            var newMember = _mapper.Map<Member>(member);
            // ADD OTHER DEFAULT VALUES HERE
            if (this.MemberExists(member.Id))
                throw new BadRequestException("This member exists!!");

            _unitOfWork.Entity.Add(newMember);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction("GetMember", new { id = newMember.Id }, newMember);
        }

        // DELETE: api/Members/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMember([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var member = await _unitOfWork.Entity.GetSingle(id);  // _context.Members.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }

            _unitOfWork.Entity.Delete(member);
            await _unitOfWork.SaveChangesAsync();

            return Ok(member);
        }

        private bool MemberExists(long id)
        {
            return _unitOfWork.Entity.GetSingle(m => m.Id == id).Any();
        }
    }
}
