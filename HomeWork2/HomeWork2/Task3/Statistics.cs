using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork2.Task3
{

	class Statistics
	{
		public static void AnalyzeNumbers(int first, ref int second, out int third)
		{
			Console.WriteLine($"First number inside method: {first}");

			second = second * second;

			third = first + second;
		}
	}

}
