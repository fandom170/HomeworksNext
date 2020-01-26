using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class BlankBulb 
    {
        private string _bulbColor = Colors.WHITE.ToString(); //values has been added for consistency only and is used in ColorBulb class
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
    }
}
