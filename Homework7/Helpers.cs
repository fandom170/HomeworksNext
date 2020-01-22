using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Helpers
    {
        private string _csvPath = @"Countries.csv";
        private SortedDictionary<Guid, Country> _countryDictionary = null;

        public Helpers()
        {
            this._countryDictionary = ReadFile();
        }

        private SortedDictionary<Guid, Country> ReadFile()
        {
            SortedDictionary<Guid, Country> readFileData = new SortedDictionary<Guid, Country>();

            using (StreamReader csvReader = new StreamReader(File.OpenRead(_csvPath)))
            {
                while (!csvReader.EndOfStream)
                {
                    string docLine;
                    //reading of several times have to be added
                    try
                    {
                        docLine = csvReader.ReadLine();
                        if (docLine.Equals("") || docLine.Equals(" "))
                        {
                            break;
                        }
                        string[] line = docLine.Trim().Split(',');
                        readFileData.Add(Guid.NewGuid(), new Country()
                        {
                            name = line[0],
                            telenorSupported = bool.Parse(line[1])
                        });
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Read file IO Exception");
                        Environment.Exit(-1);
                    }
                }
            }

            return readFileData;
        }

        public void WriteFile()
        {
            using (StreamWriter file = new StreamWriter(_csvPath))
            {
                foreach (KeyValuePair<Guid, Country> entry in _countryDictionary)
                {
                    string line = $"{entry.Value.Name},{entry.Value.IsTelenorsupported}";

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

        public void PrintCountries(Boolean supportStatus)
        {
            foreach (KeyValuePair<Guid, Country> entry in _countryDictionary)
            {
                Country tempCountry = entry.Value;
                if (tempCountry.IsTelenorsupported == supportStatus)
                {
                    Console.WriteLine("For {0} current status of Telenor support is {1}", tempCountry.Name, tempCountry.IsTelenorsupported);
                }
            }
        }

        //left for further use
        public string AddCountry(String country, Boolean telenorSupport)
        {

            foreach (KeyValuePair<Guid, Country> entry in _countryDictionary)
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

                _countryDictionary.Add(Guid.NewGuid(), newCountry);
                return "Country has been added successfully";
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Argument already exists");
                return "Error";
            }


        }

        public string addCountryAsObject(Country newCountry)
        {

            _countryDictionary.Add(Guid.NewGuid(), newCountry);
            return "Country has been added";

        }


        public void UpdateCountryByName(Boolean isTelenorSupported, string countryName)
        {
            Country tempCountry = null;
            Guid orderNo = Guid.Empty;
            foreach (KeyValuePair<Guid, Country> entry in _countryDictionary)
            {
                orderNo = entry.Key;
                tempCountry = entry.Value;
                if (tempCountry.Name.Equals(countryName))
                {

                    tempCountry = entry.Value;
                    tempCountry.IsTelenorsupported = isTelenorSupported;
                    break;
                }
            }
            if (tempCountry != null && !orderNo.Equals(Guid.Empty))
            {
                tempCountry.IsTelenorsupported = isTelenorSupported;
                _countryDictionary[orderNo] = tempCountry;
            }
            else
            {
                Console.WriteLine("No such country");
            }
        }
    }
}