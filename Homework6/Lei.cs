using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public abstract class Lei<T> where T : BlankBulb
    {
        private int _bulbCount;
        private T [] _garland;
        protected Boolean color = false;

        public Lei() { }

        //public Lei(int bulbCount) 
        //{
        //    _garland = BuildGarland(bulbCount);
        //}

        //protected abstract T [] BuildGarland(int bulbscount);
        
        //public Lei(Boolean color, int bulbCount) 
        //{
        //    this.BulbCount = bulbCount;
        //    this._garland = new T[bulbCount];
        //    Garland = new T[bulbCount];
        //}

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

        public string BulbColorSelect(int i)
        {
            string currentBulbColor = "";
            int count = Enum.GetValues(typeof(Colors)).Length;
            int rest = i % count;

            foreach (int j in Enum.GetValues(typeof(Colors)))
            {
                if (j == rest)
                {
                    currentBulbColor = Enum.GetName(typeof(Colors), rest);
                    break;
                }
            }

            return currentBulbColor;
        }

        public void SetLampState(T [] garland) 
        {
            //Boolean minutes = ((int)DateTime.Now.Minute)%2 == 0? true : false;

            int count = Enum.GetNames(typeof(LampStates)).Length;
            for(int i = 0; i < Garland.Length; i++) 
            {
                LampStates state = (LampStates)(i % count);
                //garland[i].LampState = (minutes ^ (i % 2 == 1)); 
                Garland[i].EnumLampState = state;
            }
        }

        

        public void printGarland (String type) 
        {
            for (int i = 0; i < Garland.Length; i++) 
            {
                Console.WriteLine("{0} garland {1} lamp #{2} is turned {2} now",
                    type, Garland[i].BulbColor/*return color depends on lampstate method should be here*/, 
                    Garland[i].LampState);
            }
        }
    }
}