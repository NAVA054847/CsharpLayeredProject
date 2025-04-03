using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solide.Data.Entities;
using Solide.Service;

namespace Solide.Api.Controllers
{
    public class UsersController : Controller
    {

        UserService _userService;

        public UsersController()
        {
            _userService = new UserService();
        }

        // GET: api/<PersoneController>
        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAllUsers();
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


















        // GET: UsersController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: UsersController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: UsersController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: UsersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
