using Microsoft.EntityFrameworkCore;
using ReservationAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationAPI
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Tables { get; set; }
        public DbSet<FoodOrder> FoodOrders { get; set; }
    }
}
