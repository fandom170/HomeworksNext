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

        public void PrintInvoice(Boolean printShipments = true) 
        {
            foreach (Shipment shipment in Shipments) 
            {
                shipment.PrintShipment(printShipments);
            }
        }
        
        [JsonProperty(PropertyName = "shipments")]
        public List <Shipment> Shipments { get; set; }
    }
}
