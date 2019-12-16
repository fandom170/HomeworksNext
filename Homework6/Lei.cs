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
            public Boolean[] garState;

            public Boolean[] turnState()
            {
                garState = new Boolean[bulbCount];
                TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
                int currentSec = (int)(t.TotalSeconds)/(60);
                Boolean odd, even;
                if ((currentSec) % 2 == 0)
                {
                    odd = true;
                    even = false;
                }
                else
                {
                    odd = false;
                    even = true;
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
