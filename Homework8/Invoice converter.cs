using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Invoice_converter : JsonConverter
    {

            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(Invoice));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JObject jo = JObject.Load(reader);
                Invoice invoice = jo.ToObject<Invoice>();
                invoice.Shipments = jo.SelectToken("shipments").ToObject<List<Shipment>>();
                return invoice;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }









    }
}
