using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Homework8
{
    class FileHelpers
    {
        private string _path = "C:\\Users\\ПК\\source\\repos\\HomeworksNext\\Homework8\\ShipmentData.json";


        
        
        
        public void WriteFile(String dataString)//, string fileExtension) 
        {
            string fileName = _path;// + fileExtension;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@fileName))
                {
                    try
                    {
                        file.WriteLine(dataString);
                    }
                    catch (IOException)
                    {
                        Console.WriteLine("Wrote file IO Exception. work of program will be terminated.");
                        Environment.Exit(-1);
                    }
                }
        }

        public string ReadJsonFile () 
        {
            string dataString = "";
            using (StreamReader file = File.OpenText(_path))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject readJson = (JObject)JToken.ReadFrom(reader);
                    dataString = readJson.ToString();
                }
            }


                return dataString;
        }

        /*JSON file structure
         * [
         *  {
         *     "shipments":[
         *                    {
         *                    "id": "xxxx",
         *                    "address": "aaaa",
         *                    "orders": [
         *                                  "customer":"cccc",
         *                                  "goods": [
         *                                              {
         *                                                  "type":"tttt",
         *                                                  "qty":"qqqq"
         *                                              },
         *                                              {...}
         *                                              ]
         *                              ]
         *                    }, 
         *                    {...}
         *     ] 
         *  }
         * ]
         
             */

        public string ReadXmlFile() 
        {
            string dataString = "";
            string fileName = _path + ".xml";

            using (XmlReader reader = XmlReader.Create(@fileName)) 
            {
                while (reader.Read()) 
                { 
                    
                }
            }
                //XmlDocument doc = new XmlDocument();
                //doc.Load(@fileName);

                return dataString;
        }


        public void PrintShipment(String shipmentName, string fileType, Boolean printOrders) 
        {
            string fileName = _path + fileType;
            string dataString;
            if (fileType.Equals("xml"))
            {
                dataString = ReadXmlFile();
            }
            else 
            {
                dataString = ReadJsonFile();
            }
        }

        /*
         xml structure

        <?xml version="1.0" encoding="utf-8"?>  
        <shipments>
                <shipment>
                    <id> ... </id>                      //string
                    <address> ... </address>            //string
                        <order>
                            <id> ... </id>             //int
                            <customer> ... </customer> //Guid
                            <type>...</type>           //String
                            <qty>...<qty>              //int
                        </order>
                </shipment>
                <shipment>
                ...
                </shipment>
        </shipments>
         */
    }

    /*private SortedDictionary<Guid, Country> ReadFile()
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
    }*/
}
