using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Common
{
    public class City : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public string AreaCode { get; set; }
        
        public List<TotalCases> covidCasesPerDay { get; set; }

        public Country country { get; set; }
    }
}
