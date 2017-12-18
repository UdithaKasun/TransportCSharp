using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TerminalAPI.Models;
using TerminalAPI.Models.Card;

namespace TerminalAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private readonly TerminalContext _context;

        public ValuesController(TerminalContext context)
        {
            this._context = context;
        _context.TravelCards.Add(new TourCard { Card_Expiry_Date = "EE",Card_Balance = 4500 , Card_Issue_Date = "SS"});
            _context.TravelCards.Add(new RegularCard { Card_Balance = 7500, Card_Issue_Date = "SS" });
            _context.SaveChanges();
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Json(_context.TravelCards.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void saveReservation([FromBody]TravelCard card)
        {
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
