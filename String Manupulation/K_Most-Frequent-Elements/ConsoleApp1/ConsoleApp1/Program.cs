using System;
using System.Diagnostics;

namespace ConsoleApp1
{
	class Program
	{
		static int[] arrayToCheck = { 1, 6, 2, 1, 6, 1, 6, 6, 3, 3, 3, 3, 3, 3 };
		static int howMany = 3;

		// Find couple max values in array of integers
		static void Main(string[] args)
		{
			int[] freqArray = getFreqArray(Program.arrayToCheck);
	      
			// Find max value and set it to 0 in array
			// Another way is to do a buble sort, but it cold take more time
			int count = 0;
			while (count++ < howMany)
			{
				int maxValue = findMaxValue(freqArray);
				Console.WriteLine(maxValue);
				freqArray[maxValue] = 0;
			}
		
			Console.ReadLine();
		}

		static int[] getFreqArray(int[] input)
		{
			// Create an array with the lengh of input array, 
			// as it could be that each member of array is unique
			int[] output = new int[input.Length];

			// Fill array with count of numbers. 
			// If number 2 is present 3 times, first cell (2-1) will be set to 3  
			foreach (int i in input)
			{
				output[i]++;
			}

			return output;
		}

		static int findMaxValue(int[] input)
		{
			var maxFreqValue = 0;
			var maxValue = 0;
	
			for (int i = 0; i< input.Length; i++)
			{
				if (input[i] > maxFreqValue) 
				{
					maxFreqValue = input[i];
					maxValue = i;
				}
			}

			return maxValue;
		}

		

	}
}
