﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class BlankLei : Lei<BlankLei>
    {
        private BlankBulb[] garland;
        public BlankLei(int bulbCount)
        {
            this.BulbCount = bulbCount;
            garland = new BlankBulb[bulbCount];
            for (int i = 0; i < bulbCount; i++)
            {
                garland[i] = new BlankBulb();
            }
        }

        override public void GetState()
        {
            string state = "";
            Boolean minutes = GetCurrentMinutesState();
            for (int i = 0; i < garland.Length; i++)
            {
                if (minutes)
                {
                    state = i % 2 == 0 ? "is turned off" : "is turned on";
                }
                else
                {
                    state = i%2 == 0? "is turned on": "is turned off";
                }
                Console.WriteLine("Blank garland lamp # {0} is {1} now.\n", (i + 1), state);
            }
        }
    }
}
