using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {

            FileHelpers fileHelpers = new FileHelpers();

            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"\ShipmentData.json"));
            
            //data creation
            Customer cust1 = new Customer();
            cust1.CustomerName = "test03";
            cust1.CustomerId = Guid.NewGuid();

            List<Order> orders = new List <Order>();
            Order order1 = new Order();
            order1.OrderId = _helpers.OrderNumber++;
            order1.Type = "kittens";
            order1.Quantity = 6;
            order1.Customer = cust1;

            Order order2 = new Order();
            order2.OrderId = _helpers.OrderNumber++;
            order2.Type = "More kittens";
            order2.Quantity = 4;
            order2.Customer = cust1;

            orders.Add(order1);
            orders.Add(order2);

            Shipment ship1 = new Shipment();
            ship1.Name = "Init_Data_02";
            ship1.Adress = "1601_Pennsylvania_Avenue";
            ship1.Id = ship1.Name.Substring(0, 4) + ship1.Adress.Substring(0, 4);
            ship1.Orders = orders;
            List<Shipment> shipmentList = new List<Shipment>();
            shipmentList.Add(ship1);
            //data processing
            
            string jsonString = "";

            Invoice invoice = fileHelpers.FromJsonToInvoice(fileHelpers.ReadJsonFile());

            invoice.PrintInvoice(false);
            invoice.Shipments.Add(ship1);

            jsonString = JsonConvert.SerializeObject(invoice, Formatting.Indented);

            //fileHelpers.WriteFile(jsonString);

            Invoice invoiceXML = fileHelpers.readXMLInvoice();

            fileHelpers.CreateXMLInvoice(invoiceXML);



        }
    }
}
