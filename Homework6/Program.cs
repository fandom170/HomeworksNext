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
            Console.Clear();
            
            if (type.Equals("both"))
            {
                colour = "Color";
                ColourLei  leiColour = new ColourLei(dv.GetLeiLength(colour));
                leiColour.SetLampState();
                leiColour.PrintGarland(colour);

                colour = "Blank";
                BlankLei leiBlank = new BlankLei(dv.GetLeiLength(colour));
                leiBlank.SetLampState();
                leiBlank.PrintGarland(colour);
            }
            else if (type.Equals("blank"))
            {
                colour = "Blank";
                Console.Clear();
                BlankLei leiBlank = new BlankLei(dv.GetLeiLength(colour));
                leiBlank.SetLampState();
                leiBlank.PrintGarland(colour);
            }
            else if (type.Equals("color"))
            {
                Console.Clear();
                colour = "Colour";
                ColourLei leiColour = new ColourLei(dv.GetLeiLength(colour));
                leiColour.SetLampState();
                leiColour.PrintGarland(colour); ;
            }
            else
            {
                Environment.Exit(-1);
            }
        }
    }
}
