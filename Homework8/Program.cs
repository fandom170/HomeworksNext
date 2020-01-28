using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Order> orders = new List<Order>();
            List<Shipment> shipments = new List<Shipment>();
            List<Customer> customers = new List<Customer>();

            Invoice inv = new Invoice();

            string jsonString = orders.ToJSON();
        }
    }
}
