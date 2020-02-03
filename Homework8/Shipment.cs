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
        private string _name;
        private string _address;

        public Shipment (string name, string address) 
        {
            this.Id = name.Substring(0,4) + address.Substring(0, 4);
            this._name = name;
            this._address = address;

        }

        [JsonProperty("shipment")]

        public string Id { get; set; }
        
        public string Name 
        {
            get { return _name; }
            set { Name = value; }
        }

        public string Adress 
        {
            get { return _address; }
            set { _address = value; }
        }
       
        public List <Order> Orders { get; set; }


    }
}
