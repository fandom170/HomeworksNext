using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class ColourLei : Lei
    {
        private ColourBulb[] garland;

        public ColourLei (int bulbCount)
        {
            this.bulbCount = bulbCount;
            garland = new ColourBulb[bulbCount];
            for (int i = 0; i < bulbCount; i++)
            {
                String colour = Colours.colors[i % (Colours.colors.Length - 1)];
                garland[i] = new ColourBulb(i, colour);
            }
        }

        public void GetState ()
        {

            string state = "";
            string lampState = "";
            int[] garState = turnState();
            TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            int minutes = (int)(t.TotalSeconds) / (60 * 1000);
            String odd, even, ansiColor;

            if (minutes % 2 == 0)
            {
                odd = "turned off";
                even = "turned on";
            }
            else
            {
                odd = "turned on";
                even = "turned off";
            }

            

            for (int i = 0; i < garland.Length; i++)
            {
                if (garland[i].GetBulbNumber() % 2 == 0)
                {
                    lampState = odd;
                }
                else
                {
                    lampState = even;
                }
                state = "Color garland lamp #" + (garland[i].GetBulbNumber() + 1) + " is " +
                        garland[i].GetBulbColour() + " and " + lampState + " now.\n";
                GetColor(i, lampState);
                Console.WriteLine(state);
                Console.ResetColor();
            }
        }

        public void GetColor (int i, String lampState)
        {
            String ansiColor;
            if(lampState.Equals("turned on"))
            {
                switch (garland[i].GetBulbColour())
                {
                    case "RED":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "YELLOW":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "GREEN":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "BLUE":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "PURPLE":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "CYAN":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
