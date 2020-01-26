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
        private T[] _garland;
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

        public T[] Garland
        {
            get { return _garland; }
            set { _garland = value; }
        }

        public int BulbCount
        {
            get { return _bulbCount; }
            set { _bulbCount = value; }
        }

        //abstract public void printGarland(String type);

        public void PrintGarland(String type)
        {
            for (int i = 0; i < Garland.Length; i++)
            {
                //this.GetBulbColor(i);
                Console.WriteLine("{0} garland {1} lamp #{2} is turned {3} now",
                    type, //0
                    Garland[i].BulbColor,/*1*/
                    (i + 1), //2
                    Garland[i].EnumLampState); //3
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
        }

        public void SetLampState()
        {
            Boolean minutes = ((int)DateTime.Now.Minute)%2 == 0? true : false; //only odd and even minutes are taken into account
            int count = Enum.GetNames(typeof(LampStates)).Length;
            
            for (int i = 0; i < Garland.Length; i++)
            {
                int rest = i % count;
                if (minutes) 
                {
                    rest = (rest + 1 + count) % count;
                }
                //Garland[i].LampState = (LampStates)rest;
                Garland[i].EnumLampState = (LampStates)rest;
            }
        }
    }
}