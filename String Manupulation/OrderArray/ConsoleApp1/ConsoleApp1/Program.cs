using System;
using System.Diagnostics;

namespace ConsoleApp1
{
	class Program
	{
		static int[] arrayToOrder = { 1, 6, 2, 1, 6, 1, 6, 6, 3, 11, 17, 2, 3, 4 };
	
		static void Main(string[] args)
		{
			string test = "mila";
			Test(test);


			int[] orderedArray = orderArray(Program.arrayToOrder);

			foreach (int i in orderedArray)
			{
				Console.Write(i);
				Console.Write(" ");
			}

			Console.ReadLine();
		}

		static void Test (string test)
		{
			test = "Alex"; 
		}



		static int[] orderArray(int[] input)
		{
			for (int j = 0;  j < input.Length - 1; j++ ) 
			{ 
				for (int i = input.Length - 1; i > j; i--)
				{
					if (input[i] > input[i - 1])
					{
						var tmp = input[i];
						input[i] = input[i - 1];
						input[i - 1] = tmp;
					}
				}
			}

			return input;
		}

	}
}
