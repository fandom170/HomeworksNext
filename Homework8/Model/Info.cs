using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Model
{
    public class Info
    {
        [JsonProperty(PropertyName = "shipments")]
        public List<Shipment> Shipments { get; set; }
    }
}
