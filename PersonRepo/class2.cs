using DBFirstAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DBFirstAPI.PersonRepo
{
    public class class2 : IPersonRepo
    {
        private readonly API_DemoContext _demoContext;
        public class2(API_DemoContext demoContext)
        {
            _demoContext = demoContext;
        }
        public async Task<ActionResult<IEnumerable<Person>>> GetUsers()
        {
            return await _demoContext.People.Where(x =>x.Age>20).ToListAsync();

        }
        public async Task<ActionResult<Person>>PostRegisterUser(Person p)
        {
            _demoContext.People.Add(p);
            await _demoContext.SaveChangesAsync();
            return p;

        }
        public async Task<ActionResult<Person>>DeleteRegisterUser(int id)
        {
            var registerUser = await _demoContext.People.FindAsync(id);
            if (registerUser == null)
            {
                throw new NullReferenceException("Sorry, No user Found");
            }
            else
            {
                _demoContext.People.Remove(registerUser);
                await _demoContext.SaveChangesAsync();
                return registerUser;
            }

        }
        
    }
}
