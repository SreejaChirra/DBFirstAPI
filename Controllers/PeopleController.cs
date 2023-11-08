using DBFirstAPI.PersonRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DBFirstAPI.Models;
using Microsoft.CodeAnalysis.Operations;

namespace DBFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonRepo _personRepo;
        public PeopleController(IPersonRepo personRepo)
        {
            _personRepo = personRepo;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetUsers()
        {
            return await _personRepo.GetUsers();
        }
        [HttpPost]
        public async Task<ActionResult<Person>>PostRegisterUser(Person p)
        {
            await _personRepo.PostRegisterUser(p);
            //return CreatedAtAction("GetRegisterUser", new {id = p.Id}, p);
            return Ok();
            
        }
        [HttpDelete]
        public async Task<ActionResult<Person>>DeleteRegisterUSer(int id)
        {
            try
            {
                return await _personRepo.DeleteRegisterUser(id);

            }
            catch (Exception ex)
            {
                return NotFound();

            }
        }
    }
}
