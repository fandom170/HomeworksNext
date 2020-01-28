using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Shipment : Item <string>
    {
        private string _name;
        private string _address;

        [JsonProperty("orders")]
        public Order[] Orders { get; set; }


    }
}
