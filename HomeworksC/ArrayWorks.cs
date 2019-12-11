using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworksC
{
    class ArrayWorks
    {
		private int startPoint;
		private int endPoint;
		private int[] arr = null;
		public ArrayWorks(int startPoint, int endPoint)
		{
			this.startPoint = startPoint;
			this.endPoint = endPoint;
			this.arr = new int[endPoint - startPoint + 1];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = i + startPoint;
			}
		}


		public int GetTotal()
		{
			int total = 0;

			foreach (int num in arr)
			{
				if (num % 5 != 0 && num % 3 == 0)
				{
					total += num;
				}
			}

			return total;

		}
	}
}
