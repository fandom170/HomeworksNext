using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class BlankBulb
    {
        private Boolean _lampState;
        public BlankBulb() 
        {
            
        }

        public Boolean LampState 
        {
            get { return _lampState; }
            set { _lampState = value; }
        }
    }
}
