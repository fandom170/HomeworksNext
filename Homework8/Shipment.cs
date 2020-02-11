using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Shipment
    {
        public void PrintShipment(Boolean printOrders) 
        {
            Console.WriteLine("Shipment ID is = {0}", this.Id);
            Console.WriteLine("Shipment name is = {0}", this.Name);
            Console.WriteLine("Shipment address is = {0}", this.Adress);
            if (printOrders) 
            { 
                foreach (Order order in Orders) 
                {
                    order.PrintOrder();
                }
            }


        }
        
        [JsonProperty("shipmentId")]
        public string Id { get; set; }
        [JsonProperty("shipmentName")]
        public string Name { get; set; }
        [JsonProperty("shipmentAddress")]
        public string Adress { get; set; }
        [JsonProperty("ordersList")]
        public List <Order> Orders { get; set; }
    }
}
