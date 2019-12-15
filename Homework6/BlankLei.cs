using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class BlankLei : Lei
    {
        private BlankBulb[] garland;
        public BlankLei(int bulbCount)
        {
            this.bulbCount = bulbCount;
            garland = new BlankBulb[bulbCount];
            for (int i = 0; i < bulbCount; i++)
            {
                garland[i] = new BlankBulb(i);
            }


        }

        public String getState()
        {
            string state = "", temp;
            int[] garState = turnState();

            for (int i = 0; i < garland.Length; i++)
            {
                BlankBulb bl = garland[i];
                if (garState[i] == 0)
                {
                    temp = "Lamp #" + (i + 1) + " is turned off\n";
                }
                else
                {
                    temp = "Lamp #" + (i + 1) + " is turned on\n";
                }

                state += temp;
            }


            return state;
        }
    }
}
