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
            string leiState;
            string type;
            

            Console.WriteLine("Please enter desired garland type (Color/Blank) or word \"Both\" if you need to see both variants");
            Console.WriteLine("Entering of any other value will lead to stop  of program execution");
            DataValiadation dv = new DataValiadation();
            type = Console.ReadLine().ToLower();

            if (type.Equals("both"))
            {
                colour = "Colour";
                ColourLei leiColour = new ColourLei(dv.getLeiLength(colour));
                colour = "Blank";
                BlankLei leiBlank = new BlankLei(dv.getLeiLength(colour));

                //leiState = leiColour.GetState();
                leiColour.GetState();
                //Console.WriteLine(leiState);

                leiState = leiBlank.getState();
                //Console.WriteLine(leiState);

            }
            else if (type.Equals("blank"))
            {
                colour = "Blank";
                BlankLei leiBlank = new BlankLei(dv.getLeiLength(colour));
                leiState = leiBlank.getState();
                //Console.WriteLine(leiState);
            }
            else if (type.Equals("color"))
            {
                colour = "Colour";
                ColourLei leiColour = new ColourLei(dv.getLeiLength(colour));
                //leiState = leiColour.GetState();
                leiColour.GetState();
                //Console.WriteLine(leiState);
            }
            else
            {
                Environment.Exit(-1);
            }
        }
    }
}
