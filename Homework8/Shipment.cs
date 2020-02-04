using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Shipment //: Item<string>
    {
        [JsonProperty("shipment")]
        public string Id { get; set; }
        
        public string Name { get; set; }
        public string Adress { get; set; }
        public List <Order> Orders { get; set; }


    }
}
