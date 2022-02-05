using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Common;

namespace SQLdatabase.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 1,
                    Name = "Dream City",
                    AreaCode = "000"
                },
                new City()
                {
                    Id = 2,
                    Name = "Gotham City",
                    AreaCode = "666"
                }
                );
        }
    }
}
