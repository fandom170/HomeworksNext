using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Homework8
{
    class FileHelpers
    {
        //private string _jsonPath = "C:\\Users\\ПК\\source\\repos\\HomeworksNext\\Homework8\\ShipmentData.json";
        //private string _xmlPath = "C:\\Users\\ПК\\source\\repos\\HomeworksNext\\Homework8\\ShipmentData.xml";
        private string _jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShipmentData.json");
        private string _xmlPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ShipmentData.xml");

        public void WriteJsonFile(String dataString)
        {
            string fileName = _jsonPath;

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

        public void CreateXMLInvoice (Invoice invoice) 
        {
            String path = _xmlPath;
            XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
            TextWriter writer = new StreamWriter(path);
            serializer.Serialize(writer, invoice);
            writer.Close();
        }

        public Invoice readXMLInvoice() 
        {
            String path = _xmlPath;
            XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
            serializer.UnknownNode += new
            XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new
            XmlAttributeEventHandler(serializer_UnknownAttribute);

            
            FileStream fs = new FileStream(path, FileMode.Open);
            Invoice invoice = null;
            try
            {
                invoice = (Invoice)serializer.Deserialize(fs);
                Console.WriteLine("Invoice data should be here");
            }
            catch (IOException) 
            { 
                Console.WriteLine("Some problems with file reading"); 
            }
            List <Shipment> shipments = invoice.Shipments;
            foreach (Shipment shipment in shipments) 
            {
                Console.WriteLine(shipment.Id);
                Console.WriteLine(shipment.Name);
                Console.WriteLine(shipment.Adress);
                List<Order> orderList = shipment.Orders;
                foreach (Order order in orderList) 
                {
                    Console.WriteLine(order.OrderId);
                    Console.WriteLine(order.Quantity);
                    Console.WriteLine(order.Type);
                    Customer customer = order.Customer;
                    Console.WriteLine(customer.CustomerId);
                    Console.WriteLine(customer.CustomerName);
                }
            }
            fs.Close();
            return invoice;
            
        }

        protected void serializer_UnknownNode (object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        protected void serializer_UnknownAttribute (object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }
    }
}