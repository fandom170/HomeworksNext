using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class ColourLei : Lei
    {
        private Bulb<ColourBulb>[] garland;

        public ColourLei (int bulbCount)
        {
            this.BulbCount = bulbCount;
            garland = new Bulb<ColourBulb>[bulbCount];
            for (int i = 0; i < bulbCount; i++)
            {
                string colour = BulbColorSelect(i);
                garland[i] = new Bulb<ColourBulb>(colour);
            }
        }

        override public void GetState ()
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
                    state = i % 2 == 0 ? "is turned on" : "is turned off";
                }

                GetColor(i, state);
                Console.WriteLine("Color garland lamp #{0} is {1} and {2} now.\n", (i + 1), garland[i].BulbColour , state);
                Console.ResetColor();
            }
        }

        public void GetColor (int i, String state)
        {
            if(state.Equals("is turned on"))
            {
                switch (garland[i].BulbColour.ToString())
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

        public string BulbColorSelect(int i) {
            string currentBulbColor = "";
            int count = Enum.GetValues(typeof(Colors)).Length;
            int rest = i % count;

            foreach (int j in Enum.GetValues(typeof(Colors)))
            {
                if (j == rest) 
                {

                    currentBulbColor = Enum.GetName(typeof(Colors),rest);
                    break;
                }
            }

            return currentBulbColor;
        }
    }
}
