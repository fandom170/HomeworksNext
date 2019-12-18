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

        public void GetState()
        {
            string state = "", temp;
            Boolean[] garState = turnState();

            for (int i = 0; i < garland.Length; i++)
            {
                if (!garState[i])
                {
                    temp = "is turned off";
                }
                else
                {
                    temp = "is turned on";
                }
                state = "Blank garland lamp #" + (garland[i].OrderNumber + 1) + "is " + temp + " now.\n";
                Console.WriteLine(state);

            }
        }
    }
}
