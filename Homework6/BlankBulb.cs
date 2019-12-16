using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class BlankBulb
    {
        private int _orderNo;
        public BlankBulb(int orderNo) 
        {
            this._orderNo = orderNo;
        }

        public int OrderNumber
        {
            get { return _orderNo; }
        }
    }
}
