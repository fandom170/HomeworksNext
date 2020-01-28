using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    class Customer: Item<Guid>
    {
        private string _customerName;

        public Customer(String name) 
        {
            this.Id = new Guid();
            this._customerName = name;
        }

        public string CustomerName 
        { 
            get { return _customerName; }
        }

    }
}
