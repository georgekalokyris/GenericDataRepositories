using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DeserializeLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string json = File.ReadAllText(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "people.json"));

            //List<ShippingInfo> list = new List<ShippingInfo>();

            //list = JsonConvert.DeserializeObject<List<ShippingInfo>>(json);

            //Console.WriteLine(list[0].address.address1);


            string json2 = File.ReadAllText(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "countries.json"));

            List<CountryJSON> countries = new List<CountryJSON>();

            countries = JsonConvert.DeserializeObject<List<CountryJSON>>(json2);

            //Console.WriteLine(String.Concat(json2));
            foreach (var country in countries)
            {
                if (country.continents.Count > 2)
                {
                    Console.WriteLine(country.name.common);
                    foreach (var continent in country.continents)
                    {
                        Console.WriteLine(continent);
                    }
                    Console.WriteLine("--------------------------");
                }
            }

        }
    }
    public class ShippingInfo
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string gender { get; set; }

        public string address1 { get; set; }
        public address address { get; set; }
    }

    public class address
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
    }

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
