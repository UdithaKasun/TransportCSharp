using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationAPI.Models;
using System.Web.Script.Serialization;

namespace ReservationAPI.Controllers
{
    public class ReservationController : Controller
    {

        private readonly DBContext _context;
        private const string PAYMENT_GATEWAY = "http://localhost:59731/api/payment";
        private const string SMS_GATEWAY = "http://localhost:59731/api/payment";

        public ReservationController(DBContext context)
        {
            this._context = context;
        }

        [Route("api/reserve/table")]
        [HttpPost]
        public IActionResult reserveTable([FromBody]Reservation reservation)
        {
            this._context.Tables.Add(reservation);
            this._context.SaveChanges();
            Message message= new Message();
            message.Number = reservation.UserId;
            message.Content = "Your Table is Reseved for Date : " + reservation.Date;
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(SMS_GATEWAY);
                var response = client.PostAsync("", new System.Net.Http.StringContent(
   new JavaScriptSerializer().Serialize(message), System.Text.Encoding.UTF8, "application/json")).Result;
                if (response.IsSuccessStatusCode)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
        }

        [Route("api/reserve/food")]
        [HttpPost]
        public IActionResult reserveFood([FromBody]FoodOrder order)
        {
            if(order.PaymentMethod == "CASH")
            {
                this._context.FoodOrders.Add(order);
                this._context.SaveChanges();
                return Ok();
            }
            else if(order.PaymentMethod == "CARD")
            {
                this._context.FoodOrders.Add(order);
                this._context.SaveChanges();
                using (var client = new System.Net.Http.HttpClient())
                {
                    Payment p = new Payment();
                    p.CardHolderName = order.CardHolderName;
                    p.CardNumber = order.CardNumber;
                    p.CardExpiryDate = order.CardExpiryDate;
                    p.CardCSVNumber = order.CardCSVNumber;

                    client.BaseAddress = new Uri(PAYMENT_GATEWAY);
                    var response = client.PostAsync("", new System.Net.Http.StringContent(
       new JavaScriptSerializer().Serialize(p), System.Text.Encoding.UTF8, "application/json")).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return Ok();
                    }
                    else
                    {
                        return BadRequest();
                    }
                }
            }
            return BadRequest();
        }
    }
}