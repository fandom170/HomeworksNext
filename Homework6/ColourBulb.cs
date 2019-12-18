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
        private string _bulbColour;

        public ColourBulb(int orderNo, string colour) 
        {
            this._orderNo = orderNo;
            this._bulbColour = colour;
        }

        public string BulbColour 
        {
            get { return _bulbColour; }
        }

        public int OrderNumber 
        {
            get { return _orderNo; }
        }
    }
}
