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
            Garland  = new BlankBulb[BulbCount];
            for (int i = 0; i < bulbCount; i++)
            {
                Garland[i] = new BlankBulb();
            }
        }
    }
}