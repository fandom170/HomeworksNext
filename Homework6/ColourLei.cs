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
            Garland = new ColourBulb[bulbCount];
            //Garland = BuildGarland(bulbCount);
            for (int i = 0; i < bulbCount; i++)
            {
                string colour = BulbColorSelect(i);
                Garland[i] = new ColourBulb(colour);
            }
        }

        new public void PrintGarland(String type)
        {
            for (int i = 0; i < Garland.Length; i++)
            {
                GetBulbColor(i);
                Console.WriteLine("{0} garland {1} lamp #{2} is turned {3} now",
                    type, //0
                    Garland[i].BulbColor,/*1 */
                    (i + 1), //2
                    Garland[i].EnumLampState); //3
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
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

        public void GetBulbColor(int i)
        {

            if (Garland[i].EnumLampState.Equals(LampStates.ON))
            {
                switch (Garland[i].BulbColor.ToString())
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

        //protected override ColourBulb[] BuildGarland(int bulbCount)
        //{
        //    return new ColourBulb[bulbCount];
        //}
    }
}