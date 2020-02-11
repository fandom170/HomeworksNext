using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Order     {

        public void PrintOrder() 
        {
            Console.WriteLine("Order Id is = {0}", this.OrderId);
            Console.WriteLine("Amount of product is = {0}", this.Quantity);
            Console.WriteLine("Name of product is = {0}", this.Type);
            this.Customer.PrintCustomer();
        }
        
        
        [JsonProperty(PropertyName = "orderId")]
        public int OrderId { get; set; }
        [JsonProperty(PropertyName = "productQuantity")]
        public int Quantity { get; set; }
        [JsonProperty(PropertyName = "productType")]
        public string Type { get; set; }
        [JsonProperty(PropertyName = "customer")]
        public Customer Customer { get; set; }
    }
}
