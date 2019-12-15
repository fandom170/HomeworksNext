using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class ColourBulb
    {
        private int orderNo;
        private String bulbColour;

        public ColourBulb(int orderNo, String colour) 
        {
            this.orderNo = orderNo;
            this.bulbColour = colour;
        }

        public String GetBulbColour() 
        {
            return bulbColour;
        }

        public int GetBulbNumber ()
        {
            return orderNo;
        }
    }
}
