using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Customer//: Item<Guid>
    {
        private string _customerName;
        private Guid _id;

        public Customer(String name) 
        {
            this._id = Guid.NewGuid();
            this._customerName = name;
            //Console.WriteLine(Id);
        }

        public string CustomerName 
        { 
            get { return _customerName; }
            set { _customerName = value; }
        }

        [JsonProperty("customer")]
        public Guid CustomerId 
        { 
            get { return _id; }
            set { _id = value; }
        }

    }
}
