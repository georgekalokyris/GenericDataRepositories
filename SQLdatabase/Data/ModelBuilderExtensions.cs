using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Common;
using System.IO;
using SQLdatabase.Data.CountriesJSON;
using static SQLdatabase.Data.CountriesJSON.CountriesJSON;
using Newtonsoft.Json;

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
        
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            string json = File.ReadAllText(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "./Data/CountriesJSON/countries.json"));

            List<CountryJSON> countries = new List<CountryJSON>();

            countries = JsonConvert.DeserializeObject<List<CountryJSON>>(json);

            
            for (int i = 0; i < countries.Count; i++)
            {
                modelBuilder.Entity<Country>().HasData
                (
                    new Country() { Id = i+1, Name = countries[i].name.common, Continent = countries[i].continents[0] }
                );
            }
        }
    }
}
