using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {

            FileHelpers fileHelpers = new FileHelpers();

            
            Customer cust1 = new Customer("test");
            Customer customer2 = new Customer("Test 002");

            List<Order> orders = new List <Order>();
            int orderId = _helpers.OrderNumber++;
            string type = "Bomb";
            int qty = 10;
            Guid custId = cust1.CustomerId;
            Order order1 = new Order(custId, orderId, qty, type);

            orders.Add(order1);

            orderId = _helpers.OrderNumber++;
            type = "one more bomb";
            qty = 2;
            Order order2 = new Order(custId, orderId, qty, type);
            orders.Add(order2);
          

            custId = customer2.CustomerId;
            orderId = _helpers.OrderNumber++;
            type = "kittens";
            qty = 8;
            Order order3 = new Order(custId, orderId, qty, type);
            orders.Add(order3);




            string Name = "Init_Data_01";
            string Adress = "1600_Pennsylvania_Avenue";
            Shipment ship1 = new Shipment(Name, Adress);
            ship1.Orders = orders;

            List <Shipment> shipmentList = new List<Shipment>();
            Invoice invoice1 = new Invoice();
            shipmentList.Add(ship1);
            invoice1.Shipments = shipmentList;

            String jsonString = JsonConvert.SerializeObject(invoice1, Formatting.Indented);
            fileHelpers.WriteFile(jsonString);

            Invoice inv1 = null;
            using (StreamReader fs = new StreamReader(File.OpenRead("C:\\Users\\ПК\\source\\repos\\HomeworksNext\\Homework8\\ShipmentData.json")))
            {
                string docLine = fs.ReadToEnd();
                inv1 = JsonSerializer.Deserialize<Invoice>(docLine);
            }

            Console.WriteLine(inv1.ToString());



        }
    }
}
