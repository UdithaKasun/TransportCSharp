﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
    }
}
