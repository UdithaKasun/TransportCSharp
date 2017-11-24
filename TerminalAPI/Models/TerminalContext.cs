using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerminalAPI.Models.Card;

namespace TerminalAPI.Models
{
    public class TerminalContext : DbContext
    {
        public TerminalContext(DbContextOptions<TerminalContext> options)
            : base(options)
        {
        }

        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<TravelCard> TravelCards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TourCard>();
            builder.Entity<RegularCard>();

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
