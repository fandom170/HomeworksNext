using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class BlankBulb
    {
        private Boolean _lampState;
        private string _lampColour = "WHITE";
        private string _stringLampState;

        public Boolean LampState 
        {
            get { return _lampState; }
            set 
            { 
                _lampState = value; 
                _stringLampState = value? "on" : "off";
            }
        }

        public string LampColour 
        {
            get { return _lampColour; }
        }

        public string StringLampState 
        {
            get {return _stringLampState;}
        }
    }
}
