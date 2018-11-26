using System;
using System.Diagnostics;

namespace ConsoleApp1
{
	class Program
	{
		public static int FindNumber(int n)
		{
			if ((n == 0) || (n == 1))
			{
				// If first or second, just return value
				return n;
			}
			else
			{
				// New value = sum of 2 last numbers
				var number = FindNumber(n - 1) + FindNumber(n - 2);
				return number;
			}
		}

		public static void Main(string[] args)
		{
			
			// First is 0, second is 1, everything else, summary of 2 last
			// 0,1,1,2,3,5,8,13,21
			Console.Write("Enter the nth number of the Fibonacci Series: ");
			int number = Convert.ToInt32(Console.ReadLine());
			//We have to decrement the length because the series starts with 0  

			for (int i = 0; i < number; i++)
			{
				Console.WriteLine(FindNumber(i));
			}

			Console.ReadKey();
		}
	}
}
