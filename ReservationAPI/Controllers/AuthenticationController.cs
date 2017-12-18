using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Models;

namespace ReservationAPI.Controllers
{
    public class AuthenticationController : Controller
    {

        private readonly DBContext _context;

        public AuthenticationController(DBContext context)
        {
            this._context = context;
        }

        //Register User
        [Route("api/user/register")]
        [HttpPost]
        public void RegisterUser([FromBody]User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        //Login User
        [Route("api/user/login")]
        [HttpPost]
        public IActionResult LoginUser([FromBody]User user)
        {
            var result = _context.Users.FirstOrDefault(t => t.MobileNumber == user.MobileNumber && t.Password == user.Password);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(); 
        }
    }
}