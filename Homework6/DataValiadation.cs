using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class DataValiadation
    {
        public int GetLeiLength(String colour)
        {
            int leiLength = 0;
            Boolean validData;
            Console.WriteLine("Enter the length of the {0} garland, please.", colour);
            String strLeiLength = Console.ReadLine();
            validData = Int32.TryParse(strLeiLength, out leiLength);
            if (!validData)
            {
                Console.WriteLine("Wrong value was entered, length will be set randomly from  50 to 100");
                Random r = new Random();
                leiLength = r.Next(50, 100);
                Console.WriteLine("New {0} garland lenth will be set to {1}", colour, leiLength);
            }
            return leiLength;
        }
    }
}
