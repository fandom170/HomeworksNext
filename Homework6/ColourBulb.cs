using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class ColourBulb : BlankBulb
    {
        public string BulbColour {get; set;}

        public ColourBulb(string colour) 
        {
            this.BulbColour = colour;
        }

    }
}
