using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class ColourBulb
    {
        private int _orderNo;
        private String _bulbColour;

        public ColourBulb(int orderNo, String colour) 
        {
            this._orderNo = orderNo;
            this._bulbColour = colour;
        }

        public String BulbColour 
        {
            get { return _bulbColour; }
        }

        public int OrderNumber 
        {
            get { return _orderNo; }
        }
    }
}
