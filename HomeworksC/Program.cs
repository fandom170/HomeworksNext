using System;

namespace HomeworksC
{
    class Program
    {
        static void Main(string[] args)
        {
            int startPoint;
            int endPoint;
            Validations dv = new Validations();

            Console.WriteLine("Please enter Start and End points less than 1000. \n Make sure, please that start point should be less than end point and " +
                "difference between them should be more than 10");

            startPoint = dv.CheckData("Start point");
            endPoint = dv.CheckData("End point", startPoint);

            ArrayWorks array = new ArrayWorks(startPoint, endPoint);

            Console.WriteLine("Total amount of digits in array which can be divided by 3 and cannot be divided by 5 is {0}", array.GetTotal());

        }
    }
}
