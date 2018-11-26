using System;

namespace ConsoleApp1
{
	class Program
	{
		private static string[] ones = {
			"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
			"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen",
		};

		private static string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

		private static string[] thous = { "hundred", "thousand", "million", "billion", "trillion", "quadrillion" };

		//public static string ToWords(decimal number)
		//{
		//	if (number < 0)
		//		return "negative " + ToWords(Math.Abs(number));

		//	int intPortion = (int)number;
		//	int decPortion = (int)((number - intPortion) * (decimal)100);

		//	return string.Format("{0} dollars and {1} cents", ToWords(intPortion), ToWords(decPortion));
		//}

		private static string ToWords(int number, string appendScale = "")
		{
			string numString = "";
			if (number < 100)
			{
				if (number < 20)
					numString = ones[number];
				else
				{
					numString = tens[number / 10];
					if ((number % 10) > 0)
						numString += "-" + ones[number % 10];
				}
			}
			else
			{
				int pow = 0;
				string powStr = "";

				if (number < 1000) // number is between 100 and 1000
				{
					pow = 100;
					powStr = thous[0];
				}
				else // find the scale of the number
				{
					int log = (int)Math.Log(number, 1000);
					pow = (int)Math.Pow(1000, log);
					powStr = thous[log];
				}

				numString = string.Format("{0} {1}", ToWords(number / pow, powStr), ToWords(number % pow)).Trim();
			}

			return string.Format("{0} {1}", numString, appendScale).Trim();
		}



		static void Main(string[] args)
		{
			var output = ToWords(256);
			Console.WriteLine(output);
			Console.Read();
		}
	}
}
