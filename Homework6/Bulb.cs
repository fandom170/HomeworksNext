using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Bulb <T>
    {
        private string _bulbColour = "BLANK";

        public Bulb() {}
        public Bulb(String bulbColour) 
        {
            this._bulbColour = bulbColour;
        }

        public string BulbColour 
        {
            get { return _bulbColour; }
            set { _bulbColour = value; }
        }
    }
}
