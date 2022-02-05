using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Country : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<City> Cities { get; set; }
        public List<TotalCases> covidCasesPerDay { get; set; }
    }
}
