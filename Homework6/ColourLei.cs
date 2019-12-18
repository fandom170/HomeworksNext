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
                string colour = BulbColorSelect(i);
                //String colour = Colours.colors[i % (Colours.colors.Length - 1)];
                garland[i] = new ColourBulb(i, colour);
            }
        }

        public void GetState ()
        {
            string state = "";
            string lampState = "";
            Boolean[] garState = turnState();

            for (int i = 0; i < garland.Length; i++)
            {
                if (garState[i])
                {
                    lampState = "turned on";

                }
                else 
                {
                    lampState = "turned off";
                }
                /*state = "Color garland lamp #" + (garland[i].OrderNumber + 1) + " is " +
                        garland[i].BulbColour.ToString() + " and " + lampState + " now.\n";*/
                state = "Color garland lamp #" + (garland[i].OrderNumber + 1) + " is " +
                        garland[i].BulbColour + " and " + lampState + " now.\n";
                GetColor(i, lampState);
                Console.WriteLine(state);
                Console.ResetColor();
            }
        }

        public void GetColor (int i, String lampState)
        {
            if(garState[i])
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
