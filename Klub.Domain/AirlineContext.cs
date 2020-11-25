using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airline.Domain
{
    public class AirlineContext: DbContext

    {
        public DbSet<Airlines> Airlines { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Pilot> Pilots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=AirlinesDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pilot>().OwnsMany(f => f.Flights); 
        }
    }


}
