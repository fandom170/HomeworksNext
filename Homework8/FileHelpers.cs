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
        private string _address = "HomeWork8.";


        public void WriteFile(String dataString, string fileExtension) 
        {
            string fileName = _address + fileExtension;

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
            string fileName = _address + ".xml";

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
            string fileName = _address + fileType;
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
}
