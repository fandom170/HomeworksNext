using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Order     {

        [JsonProperty(PropertyName = "order")]
        
        public int orderId { get; set; }
        public int qty { get; set; }
        public string type { get; set; }
        public Customer customer { get; set; }

    }

    
}
