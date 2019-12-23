using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetCurrentMinutes());
        }

        public static int GetCurrentMinutes()
        {

            return (int)DateTime.Now.Minute;
        }


    }

    
}
