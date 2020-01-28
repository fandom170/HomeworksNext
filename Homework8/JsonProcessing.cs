using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Homework8
{
    internal class JsonProcessing
    {
        public Invoice ToJSON(this string obj)
        {
            Invoice inv = JsonConvert.DeserializeObject<Invoice>(obj);
            return inv;
        }

        public string FromJSON(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }




    }
}
