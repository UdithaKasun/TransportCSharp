using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Models;

namespace ReservationAPI.Controllers
{
    [Route("api/message")]
    public class SMSController : Controller
    {
        [HttpPost]
        public IActionResult ProcessPayment([FromBody]Message message)
        {
            return Ok();
        }
    }
}