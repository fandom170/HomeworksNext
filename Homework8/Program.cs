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

            
            Customer cust1 = new Customer();
            cust1.CustomerName = "test";
            cust1.CustomerId = Guid.NewGuid();
            //Customer cust2 = new Customer();
            //cust2.CustomerName = "test001";
            //cust2.CustomerId = Guid.NewGuid();

            List<Order> orders = new List <Order>();
            Order order1 = new Order();
            order1.orderId = _helpers.OrderNumber++;
            order1.type = "Bomb";
            order1.qty = 10;
            Console.WriteLine(cust1.CustomerName + " " + cust1.CustomerId);
            order1.customer = cust1;
            //order1.Customer = new List<Customer>();
            //order1.Customer.Add(cust1);
            //order1.customer.CustomerId = cust1.CustomerId;
            //order1.customer.CustomerName = "aaa";
            orders.Add(order1);


            /*Order order2 = new Order();
            order2.orderId = _helpers.OrderNumber++;
            order2.type = "One more Bomb";
            order2.qty = 3;
            order2.customer = cust2;
            orders.Add(order2);

            Order order3 = new Order();
            order3.orderId = _helpers.OrderNumber++;
            order3.type = "kittens";
            order3.qty = 1;
            order3.customer = cust2;
            orders.Add(order3);*/

            Shipment ship1 = new Shipment();
            ship1.Name = "Init_Data_01";
            ship1.Adress = "1600_Pennsylvania_Avenue";
            ship1.Id = ship1.Name.Substring(0, 4) + ship1.Adress.Substring(0, 4);

            ship1.Orders = orders;

            List<Shipment> shipmentList = new List<Shipment>();
            Invoice invoice1 = new Invoice();
            //shipmentList.Add(ship1);
            //invoice1.Shipments = shipmentList;
            string jsonString = "";

            //jsonString = JsonConvert.SerializeObject(invoice1, Formatting.Indented);
            //fileHelpers.WriteFile(jsonString);

            /*jsonString = @"{'shipments': [{'shipment': 'Init1600','Name': 'Init_Data_01','Adress': '1600_Pennsylvania_Avenue',
                            'Orders': [{'order': 0,'qty': 10,'type': 'Bomb','customer': {'CustomerId': '0026c5a1-828b-4bdb-9abb-fe01373155de',
                            'Customer': 'test'}}]}]}";*/


            jsonString = File.ReadAllText("C:\\Users\\ПК\\source\\repos\\HomeworksNext\\Homework8\\ShipmentData.json");
            Invoice invoice = JsonConvert.DeserializeObject<Invoice>(jsonString, new Invoice_converter());

            invoice.Shipments.Add(ship1);

            jsonString = JsonConvert.SerializeObject(invoice, Formatting.Indented);
            fileHelpers.WriteFile(jsonString);

            Console.WriteLine(invoice.Shipments[0].Adress);




        }
    }
}
