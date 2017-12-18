using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationAPI.Models
{
    public class Payment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiryDate { get; set; }
        public string CardCSVNumber { get; set; }
    }
}
