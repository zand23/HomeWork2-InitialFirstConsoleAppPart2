using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Task4
{
    internal class ArrayAnalyzer
    {
		public static void AnalyzeArray(int[] numbers, ref int max, out double average)
		{

			if (numbers.Length == 0)
			{
				max = 0;
				average = 0.0;
				return;
			}

			int sum = 0;
			max = numbers[0];

			foreach (int num in numbers)
			{
				sum += num;

				if (num > max)
					max = num;
			}

			average = (double)sum / numbers.Length;
		}
	}
}
