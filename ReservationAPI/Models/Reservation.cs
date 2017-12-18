using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationAPI.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string NoOfSeats { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
