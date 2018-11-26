using System;

namespace ConsoleApp1
{
	class Program
	{
		// Find max value - just loop over all values in array and store max in variable
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			int[] input = { 1, 4, 3, 34, 8 };

			var maxValue = 0;

			foreach (int i in input )
			{
				if ( i > maxValue)
				{
					maxValue = i;
				}
			}

			Console.Write(maxValue);
			Console.Read();
		}
	}
}
