using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksC
{
	public class Validations
	{


		public int CheckData(String limit, int startPoint = -10)
		{
			int point;

			Console.WriteLine("Please enter {0} of desired numeric diapasone less than 1000", limit);
			Console.WriteLine("{0} should be positive value greater than zero", limit);
			Boolean valid = Int32.TryParse(Console.ReadLine(), out point);
			if (!valid || point <= 0 || point - startPoint < 10)
			{
				Console.WriteLine("Invalid value was entered. Appropriate value will be chosen randomly");
				point = GetPoint(startPoint);
				Console.WriteLine("New value of {0} is {1}", limit, point);
			}

			return point;

		}

		private int GetPoint(int startPoint)
		{
			int value;
			Random r = new Random();
			value = r.Next(startPoint + 11, 1000);
			return value;
		}




	}
}
