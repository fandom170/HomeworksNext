using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class DataValiadation
    {
        public int getLeiLength(String colour)
        {
            int leiLength = 0;
            Boolean validData;
            Console.WriteLine("Enter the length of the (0) garland, please.\n", colour);
            String strLeiLength = Console.ReadLine();

            try
            {
                leiLength = Int32.Parse(strLeiLength);
                validData = true;
            }
            catch (Exception e)
            {
                validData = false;
                Console.WriteLine("Wrong value was entered, length will be set randomly from  50 to 100");
                
                
            }

            if (!validData)
            {
                Random r = new Random();
                leiLength = r.Next(50, 100);
                Console.WriteLine("New {0} garland lenth will be set to {1}", colour, leiLength);
            }

            return leiLength;
        }
    }
}
