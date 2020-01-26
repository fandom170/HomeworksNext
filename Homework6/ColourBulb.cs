using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public class ColourBulb : BlankBulb
    {
        new public string BulbColor {get; set;}

        public ColourBulb(string colour) 
        {
            this.BulbColor = colour;
        }
    }
}
