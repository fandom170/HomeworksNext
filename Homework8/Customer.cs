using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Customer
    {

        public void PrintCustomer()
        {
            Console.WriteLine("Customer ID is {0}", this.CustomerName);
            Console.WriteLine("Customer name is {0}", this.CustomerId);

        }
        //[JsonProperty(PropertyName ="customer")]
        //[JsonIgnore]
        [JsonProperty(PropertyName = "customerId")]
        public Guid CustomerId { get; set; }
        [JsonProperty(PropertyName ="customerName")]
        public string CustomerName { get; set; }
    }
}
