using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationAPI.Models
{
    public class FoodOrder
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string MealId { get; set; }
        public int OrderCount { get; set; }
        public string Address { get; set; }
        public float TotalCost { get; set; }
        public string PaymentMethod { get; set; }
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string CardExpiryDate { get; set; }
        public string CardCSVNumber { get; set; }
    }
}
