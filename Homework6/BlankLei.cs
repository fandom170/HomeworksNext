using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class BlankLei : Lei<BlankBulb>
    {
        public BlankLei(int bulbCount)         
        {
            this.BulbCount = bulbCount;
            Garland  = new List<BlankBulb>();
            for (int i = 0; i < bulbCount; i++)
            {
                Garland.Add(new BlankBulb());
            }
        }
   }
}