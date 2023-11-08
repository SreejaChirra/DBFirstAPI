using DBFirstAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace DBFirstAPI.PersonRepo
{
    public interface IPersonRepo
    {
        Task<ActionResult<IEnumerable<Person>>>GetUsers();
        //Task<ActionResult<IEnumerable<Person>>> GetRegisterUser(int id);
        Task<ActionResult<Person>> PostRegisterUser(Person p);
       Task<ActionResult<Person>>DeleteRegisterUser(int id);



    }
}
