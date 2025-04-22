using DI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solide.Data.Entities;
using Solide.Service;

namespace Solide.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewController : ControllerBase
    {
        private IMyLogger _myLogger;
        UserService _userService;

        public NewController(IMyLogger logger)
        {
            _myLogger = logger;
            _userService = new UserService();
        }




        // GET: api/<PersoneController>
        [HttpGet]
        public List<User> Get()
        {
            //  return _userService.GetAllUsers();
            var x = _userService.GetAllUsers();
            if (x == null)
            {
                _myLogger.printWarning("empty");
            }
            else
            {
                _myLogger.printMessage("GOOD");
            }
            return x;

        }

        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }


        // POST api/<PersoneController>
        [HttpPost]
        public User Post([FromBody] User user)
        {
            return _userService.AddUser(user);
        }


        // PUT api/<PersoneController>/5
        [HttpPut("{id}")]
        public User Put(int id, [FromBody] User user)
        {
            return _userService.UpdateUser(id, user);
        }



        // DELETE api/<PersoneController>/5
        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            return _userService.DeleteUser(id);
        }





    }
}
