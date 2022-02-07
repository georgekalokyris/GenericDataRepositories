using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Common;
using SQLdatabase.Data;

namespace SQLdatabase
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }

        public DbSet<Common.City> Cities { get; set; }
        public DbSet<Common.Country> Country { get; set; }
        public DbSet<Common.TotalCases> TotalCases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
            modelBuilder.SeedCountries();
        }
    }
}
