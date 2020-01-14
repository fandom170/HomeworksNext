using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public abstract class Lei<T>
    {
        private int _bulbCount;
        private T [] _garland;




        public T [] Garland 
            {
                get { return _garland; }
                set { _garland = value; }
            }


        public int BulbCount 
            {
                get {return _bulbCount;}
                set { _bulbCount = value; }
            }

        public abstract void GetState();

        public Boolean GetCurrentMinutesState()
        {
            return ((int)DateTime.Now.Minute)%2 == 0? true : false;
        }
    }
}
