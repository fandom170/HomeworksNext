using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class BlankBulb
    {
        private int _lampState;
        
        private string _bulbColor = "";

        private LampStates _enumLampState;
        
        
        
        public LampStates EnumLampState
            {
                get {return _enumLampState;}
                set {_enumLampState = value;}
            }
        
        public string BulbColor 
        {
            get {return _bulbColor;}
        }

        public int LampState 
        {
            get { return _lampState; }
            set 
            { 
                _lampState = value;
            }
        }

    }
}
