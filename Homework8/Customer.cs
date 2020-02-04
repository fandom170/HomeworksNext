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
        //[JsonProperty(PropertyName ="customer")]
        
        //[JsonIgnore]
        public Guid CustomerId { get; set; }
        [JsonProperty(PropertyName ="Customer")]
        public string CustomerName { get; set; }
    }
}
