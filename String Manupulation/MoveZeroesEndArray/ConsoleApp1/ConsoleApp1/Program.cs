using System;
using System.Diagnostics;

namespace ConsoleApp1
{
	class Program
	{
		static int[] arrayToMoveZeroes = { 1, 0, 2, 1, 0, 1, 6, 6, 3, 11, 0, 2, 3, 4 };
	
		static void Main(string[] args)
		{
			int[] orderedArray = moveZeroes(Program.arrayToMoveZeroes);

			foreach (int i in orderedArray)
			{
				Console.Write(i);
				Console.Write(" ");
			}

			Console.ReadLine();
		}

		static int[] moveZeroes(int[] input)
		{
			int startPos = 0;

			for (int j = 0; j < input.Length - 1; j ++ )
			{
				if (j != startPos)
				{
					continue;
				}

				startPos = 0;

				for (int i = j; i < input.Length - 1; i++)
				{
					if (input[i] == 0)
					{
						if (startPos == 0)
						{
							startPos = i;
						}
						var tmp = input[i + 1];
						input[i + 1] = input[i];
						input[i] = tmp;
					}
				}
			}

			return input;
		}

	}
}
