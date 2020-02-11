using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Homework8
{
    class FileHelpers
    {
        //private string _jsonPath = "C:\\Users\\ПК\\source\\repos\\HomeworksNext\\Homework8\\ShipmentData.json";
        //private string _xmlPath = "C:\\Users\\ПК\\source\\repos\\HomeworksNext\\Homework8\\ShipmentData.xml";
        private string _jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShipmentData.json");
        private string _xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShipmentData.xml");

        public void WriteFile(String dataString, string fileExtension = "json")
        {
            string fileName;
            if (fileExtension.Equals("json"))
            {
                fileName = _jsonPath;// + fileExtension;
            }
            else
            {
                fileName = _xmlPath;
            }

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

        public string ReadJsonFile()
        {
            string dataString = "";
            try
            {
                Console.WriteLine(_jsonPath);
                dataString = File.ReadAllText(_jsonPath);// + ".json");
            }
            catch (IOException)
            {
                Console.WriteLine("Problem with file reading.\n Progam execution will be terminated.");
                Environment.Exit(-2);
            }

            return dataString;
        }

        public Invoice FromJsonToInvoice(string jsonString)
        {
            Invoice invoice = JsonConvert.DeserializeObject<Invoice>(jsonString);
            return invoice;
        }

        public string ReadXmlFile()
        {
            string resultXml;
            XDocument xDoc = XDocument.Load(_xmlPath);
            resultXml = xDoc.Root.ToString();
            Console.WriteLine(resultXml);
            return resultXml;
        }

        public XmlDocument StringToXml(string dataString) 
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(dataString);
            return xmlDoc;
        }
    }
}