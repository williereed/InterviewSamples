using System;

namespace ConsoleApp1
{
	class Program
	{
		// Given an unsorted array of integers, you have to produce an array in the "E1 < E2 > E3 < E4..." format.

		// 3, 9, 23, 1, 33, 5, 15 .  ---> 5, 33, 1, 23, 3, 15, 9

		static void Main(string[] args)
		{
			int[] input = { 3, 9, 15, 2, 33, 40, 15 };

			int[] output = ProduceArray(input);
		}

		static int[] ProduceArray(int[] input)
		{
			bool flag = true;

			for (int i = 1; i < input.Length; i++)
			{
				if (flag)
				{
					if (input[i] < input[i - 1] )
					{
						SwapInts(input, i, i - 1);
					}
				}
				else
				{
					if (input[i] > input[i - 1])
					{
						SwapInts(input, i, i - 1);
					}
				}

				flag = !flag;
			}

			return input;
		}

		private static void SwapInts(int[] input, int a, int b)
		{
			var temp = input[a];
			input[a] = input[b];
			input[b] = temp;
		}
	}
}
