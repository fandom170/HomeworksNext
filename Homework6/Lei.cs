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
        protected Boolean color = false;

        public Lei() { }

        public Lei(int bulbCount) 
        {
            _garland = BuildGarland();
        }

        protected abstract T [] BuildGarland(int bulbscount);
        
        public Lei(Boolean color, int bulbCount) 
        {
            this.BulbCount = bulbCount;
            this._garland = new T[bulbCount];
            Garland = new T[bulbCount];

            if (color == true)
            {
                for (int i = 0; i < bulbCount; i++)
                {
                    string colour = BulbColorSelect(i);
                    _garland[i] = new ColourBulb(colour);
                }
            }

            else 
            {
                for (int i = 0; i < bulbCount; i++)
                {
                    _garland[i] = new BlankBulb();
                }
            }
        }

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

        public void GetState()
        {
            string state = "";
            Boolean minutes = GetCurrentMinutesState();
            for (int i = 0; i < Garland.Length; i++)
            {
                if (minutes ^ (i % 2 == 0))
                {
                    state = "off";
                }
                else
                {
                    state = "on";
                }
                Console.WriteLine("Blank garland lamp # {0} is turned {1} now.\n", (i + 1), state);
            }
        }

        public Boolean GetCurrentMinutesState()
        {
            return ((int)DateTime.Now.Minute)%2 == 0? true : false;
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
    }
}