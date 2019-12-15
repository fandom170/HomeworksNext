using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class BlankBulb
    {
        private int orderNo;
        public BlankBulb(int orderNo) 
        {
            this.orderNo = orderNo;
        }

        public void SetNumber (int k)
        {
            orderNo = k;
        }

        public int GetNumber() 
        {
            return orderNo;
        }
    }
}
