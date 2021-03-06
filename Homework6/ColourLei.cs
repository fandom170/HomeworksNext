﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class ColourLei : Lei<ColourBulb>
    {

        public ColourLei(int bulbCount)
        {
            this.BulbCount = bulbCount;
            Garland = new List<ColourBulb>(bulbCount);
            for (int i = 0; i < bulbCount; i++)
            {
                Colors colour = BulbColorSelect(i);
                Garland.Add(new ColourBulb(colour));
            }
        }

        new public void PrintGarland(String type)
        {
            for (int i = 0; i < Garland.Count; i++)
            {
                GetColor(i, Garland[i].EnumLampState);
                Console.WriteLine("{0} garland {1} lamp #{2} is turned {2} now",
                    type, Garland[i].BulbColor,
                    Garland[i].EnumLampState);
            }
        }

        public void GetColor(int i, LampStates state)
        {
            if (state == LampStates.ON)
            {
                switch (Garland[i].BulbColor)
                {
                    case Colors.RED:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Colors.YELLOW:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Colors.GREEN:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Colors.BLUE:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Colors.PURPLE:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case Colors.CYAN:
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

        public Colors BulbColorSelect(int i)
        {
            int count = Enum.GetValues(typeof(Colors)).Length;

            return (Colors)(i % count);
        }

    }
}