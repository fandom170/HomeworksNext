using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class DictionaryWorks
    {
        private string _csvPath;
        private SortedDictionary<int, Country> _countryList = null;

        public SortedDictionary<int, Country> CountryList
        {
            get { return _countryList; }
            //set { _countryList = value; }
        }

        public DictionaryWorks(String csvPath)
        {
            this.CsvPath = csvPath;
            this._countryList = ReadFile();
        }

        public string CsvPath
        {
            get { return _csvPath; }
            set { _csvPath = value; }

        }

        private SortedDictionary<int, Country> ReadFile()
        {
            SortedDictionary<int, Country> readFileData = new SortedDictionary<int, Country>();
            int orderNumber = 0;

            using (StreamReader csvReader = new StreamReader(File.OpenRead(_csvPath)))
            {
                while (!csvReader.EndOfStream)
                {
                    orderNumber++;
                    string docLine;
                    try
                    {
                        docLine = csvReader.ReadLine();
                        if (docLine.Equals("") || docLine.Equals(" ")) { break; }
                        string[] line = docLine.Trim().Split(',');
                        string telenorSupport = line[1];
                        Boolean support = telenorSupport.Equals(true) ? true : false;
                        Country country = new Country(line[0], support);
                        readFileData.Add(orderNumber, country);
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Read file IO Exception at line {0}", orderNumber);
                        Environment.Exit(-1);
                    }
                }
            }

            return readFileData;

        }

        public void WriteFile()
        {
            using (StreamWriter file = new StreamWriter(CsvPath))
            {
                foreach (KeyValuePair<int, Country> entry in _countryList)
                {
                    Country tempCountry = entry.Value;
                    string line = tempCountry.Name.ToString() + "," + (tempCountry.IsTelenorsupported ? "true" : "false");

                    try
                    {
                        
                        file.WriteLine(line);
                        Console.WriteLine(line);

                        
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Wrote file IO Exception at line {0}", entry.Key);
                        Environment.Exit(-1);
                    }

                }


            }
        }

        public void PrintCountries(Boolean support)
        {
            foreach (KeyValuePair<int, Country> entry in _countryList)
            {
                Country tempCountry = entry.Value;
                if (tempCountry.IsTelenorsupported == support)
                {
                    Console.WriteLine("For {0} current status of Telenor support is {1}", tempCountry.Name, tempCountry.IsTelenorsupported);
                }
            }
        }

        public string AddCountry(String country, Boolean telenorSupport)
        {

            int orderNo = _countryList.Count + 1;
            foreach (KeyValuePair<int, Country> entry in _countryList)
            {
                Country tempCountry = entry.Value;
                if (tempCountry.Name.Equals(country)) 
                {
                    return "Country already exists in the list";
                }
            }


            Country newCountry = new Country(country, telenorSupport);
            try 
            {
                
                _countryList.Add(orderNo, newCountry);
                return "Country has been added successfully";
            }
            catch (ArgumentException) 
            {
                Console.WriteLine("Argument already exists");
                return "Error";
            }
            
            
        }

        public int GetCountryIdByName(string name) 
        {
            int index = -1;
            foreach (KeyValuePair<int, Country> entry in _countryList) 
            {
                Country tempCountry = entry.Value;
                if (tempCountry.Name.Equals(name)) 
                {
                    index = entry.Key;
                    break;
                }
            }
                return index;
        }

        public void UpdateCountry(Boolean isTelenorSupported, int countryId)
        {
            Country tempCountry = null;
            int orderNo = 0;

            foreach (KeyValuePair<int, Country> entry in _countryList)
            {
                orderNo = entry.Key;
                if (orderNo == countryId)
                {
                    tempCountry = entry.Value;
                    tempCountry.IsTelenorsupported = isTelenorSupported;
                    break;
                }
            }
            if (orderNo > 0 && tempCountry != null)
            {
                _countryList.Remove(orderNo);
                _countryList.Add(orderNo, tempCountry);
            }
            else 
            {
                Console.WriteLine("No such country");
            }
        }
    }
}
