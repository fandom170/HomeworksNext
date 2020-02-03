using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    public class Order //: Item<int>
    {
        private Guid _customer;
        

        public Order(Guid customer, int orderId, int qty, string type) 
        {
            this._customer = customer;
            this.orderId = orderId;
            this.qty = qty;
            this.type = type;
        }

        [JsonProperty("order")]

        
        
        public int orderId { get; set; }

        public int qty { get; set; }

        public string type { get; set; }

        public Guid CustomerId { get { return _customer; } }

    }

    
}
