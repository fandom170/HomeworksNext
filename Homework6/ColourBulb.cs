using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class ColourBulb
    {
        public string BulbColour {get;}
        private Boolean _lampState;
        private string _stringLampState;

        public ColourBulb(string colour) 
        {
            
            this.BulbColour = colour;
        }

        public string StringLampState 
        {
            get {return _stringLampState;}
        }

        public Boolean LampState
        {
            get { return _lampState ; }
            set 
            { 
                _lampState = value; 
                if(value) 
                {
                    _stringLampState = "on";
                }
                else 
                {
                    _stringLampState = "off";
                }
            }
        }
    }
}
