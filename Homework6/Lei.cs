using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
        public abstract class Lei
        {
            public int bulbCount;
            BlankBulb[] garlandBlank;
            ColourBulb[] garlandColour;
            public int[] garState;

            public int[] turnState()
            {
                garState = new int[bulbCount];
                int currentSec = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
                int odd, even;

                if ((currentSec % 10) % 2 == 0)
                {
                    odd = 1;
                    even = 0;
                }
                else
                {
                    odd = 0;
                    even = 1;
                }


                for (int i = 0; i < bulbCount; i++)
                {
                    if (i % 2 == 0)
                    {
                        garState[i] = odd;
                    }
                    else
                    {
                        garState[i] = even;
                    }
                }

                return garState;
            }


        }
  
}
