using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public abstract class Lei<T> where T : BlankBulb
    {
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

        public List<T> Garland { get; set; }

        public int BulbCount { get; set; }

        public void SetLampState(List<T> garland) 
        {
            int count = Enum.GetNames(typeof(LampStates)).Length;
            for(int i = 0; i < Garland.Count; i++) 
            {
                Garland[i].EnumLampState = (LampStates)(i % count);
            }
        }

        

        public void PrintGarland (String type) 
        {
            for (int i = 0; i < Garland.Count; i++) 
            {
                Console.WriteLine("{0} garland {1} lamp #{2} is turned {2} now",
                    type, Garland[i].BulbColor, 
                    Garland[i].EnumLampState);
            }
        }
    }
}