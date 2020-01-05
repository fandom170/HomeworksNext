﻿using System;
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
            string csvPath = "C:\\Users\\ПК\\source\\repos\\HomeworksC\\Homework7\\Countries.csv";
            string newCountry = "Ukraine";
            Boolean newSupportStatus = false; //for new country
            string country1forUpdate = "Denmark";
            string country2forUpdate = "Hungary";
            int countryId;
            Boolean newTelenorSupport = true;//for existing countries

            DictionaryWorks dw = new DictionaryWorks(csvPath);
            Console.WriteLine(dw.AddCountry(newCountry, newSupportStatus));
            countryId = dw.GetCountryIdByName(country1forUpdate);
            dw.UpdateCountry(newTelenorSupport, countryId);
            countryId = dw.GetCountryIdByName(country2forUpdate);
            dw.UpdateCountry(newTelenorSupport, countryId);

            dw.WriteFile();
            dw.PrintCountries(false);
        }

       
    }

    

    
}
