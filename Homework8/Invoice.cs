using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Invoice
    {

        [JsonProperty("Shipments")]
        public List <Shipment> Shipments { get; set; }
    }
}
