using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            string colour;
            string type;
 
            Console.WriteLine("Please enter desired garland type (Color/Blank) or word \"Both\" if you need to see both variants");
            Console.WriteLine("Entering of any other value will lead to stop  of program execution");
            DataValiadation dv = new DataValiadation();
            type = Console.ReadLine().ToLower();

            if (type.Equals("both"))
            {
                colour = "Color";
                ColourLei  leiColour = new ColourLei(dv.GetLeiLength(colour));
                leiColour.SetLampState(leiColour.Garland);
                leiColour.PrintGarland(colour);

                colour = "Blank";
                BlankLei leiBlank = new BlankLei(dv.GetLeiLength(colour));
                Console.Clear();

            }
            /*else if (type.Equals("blank"))
            {
                colour = "Blank";
                Console.Clear();
                BlankLei leiBlank = new BlankLei(dv.GetLeiLength(colour));
                leiBlank.GetState();
            }
            else if (type.Equals("color"))
            {
                Console.Clear();
                colour = "Colour";
                ColourLei leiColour = new ColourLei(dv.GetLeiLength(colour));
                leiColour.GetState();
            }*/
            else
            {
                //ColourLei cl = new Lei<ColourLei>(dv.GetLeiLength(colour));
                Environment.Exit(-1);
            }
        }
    }
}
