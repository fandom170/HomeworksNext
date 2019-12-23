using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class ColourBulb
    {
        private string _bulbColour;
        private Boolean _lampState;

        public ColourBulb(string colour) 
        {
            
            this._bulbColour = colour;
        }

        public string BulbColour 
        {
            get { return _bulbColour; }
        }

        public Boolean LampState
        {
            get { return _lampState ; }
            set { _lampState = value; }
        }
    }
}
