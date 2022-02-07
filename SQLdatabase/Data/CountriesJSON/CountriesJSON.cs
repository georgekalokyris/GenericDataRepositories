using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLdatabase.Data.CountriesJSON
{
    public class CountriesJSON
    {
        public class CountryJSON
        {
            public name name { get; set; }
            public List<string> continents { get; set; }
        }

        public class name
        {
            public string common { get; set; }
        }
    }
}
