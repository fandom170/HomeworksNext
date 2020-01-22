using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class ColourLei : Lei<ColourBulb>
    {

        public ColourLei (int bulbCount)
        {
            this.BulbCount = bulbCount;
            //Garland = new ColourBulb[bulbCount];
            for (int i = 0; i < bulbCount; i++)
            {
                string colour = BulbColorSelect(i);
                Garland[i] = new ColourBulb(colour);
            }
        }

        new public void GetState ()
        {
            
            string state = "";
            Boolean minutes = GetCurrentMinutesState();
            for (int i = 0; i < Garland.Length; i++)
            {
                if (minutes ^ (i % 2 == 0))
                {
                    state = "on";
                }
                else
                {
                    state = "off";
                }

                GetColor(i, state);
                Console.WriteLine("Color garland lamp #{0} is turned {1} and {2} now.\n", (i + 1), Garland[i].BulbColour , state);
                Console.ResetColor();
            }
        }

        public void GetColor (int i, String state)
        {
            if(state.Equals("on"))
            {
                switch (Garland[i].BulbColour.ToString())
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

        new public string BulbColorSelect(int i) {
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


        protected override ColourBulb[] BuildGarland(int bulbsCount)
        {
            return new ColourBulb[bulbCount];
        }
    }
}