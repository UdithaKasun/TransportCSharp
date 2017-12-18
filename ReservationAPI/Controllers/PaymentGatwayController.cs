using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Models;

namespace ReservationAPI.Controllers
{
    private const string API_PAYMENT_BASE = "http://localhost:59731/api/payment";
    private const string API_PAYMENT_RESOURCE = "";
    private const string API_SMS_BASE = "http://localhost:59731/api/sms";
    private const string API_SMS_RESOURCE = "";

    [Route("api/payment")]
    public class PaymentGatwayController : Controller
    {
        [HttpPost]
        public IActionResult ProcessPayment([FromBody]Payment payment)
        {
            return Ok();
        }
    }
}
