using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            string newCountryName = "Ukraine";
          
            string country1forUpdate = "Denmark";
            string country2forUpdate = "Hungary";
            
            Helpers helpers = new Helpers();

            Country newCountry = new Country(newCountryName, false);

            Console.WriteLine(helpers.addCountryAsObject(newCountry));

            helpers.UpdateCountryByName(true, country1forUpdate);
            helpers.UpdateCountryByName(true, country2forUpdate);

            helpers.WriteFile();
            helpers.PrintCountries(false);
        }
    }
 
}