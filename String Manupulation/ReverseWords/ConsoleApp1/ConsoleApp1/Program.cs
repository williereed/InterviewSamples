using System;

namespace ConsoleApp1
{
	class Program
	{
		static string input = "Do or do not, there is no try.";

		static void Main(string[] args)
		{
			string temp = ReverseWord(Program.input.ToCharArray());
			Console.WriteLine(temp);
			Console.Read();
		}

		static string ReverseWordsWithArray(string input)
		{
			string[] words = input.Split(" ");
			string output = "";
			for (int i = words.Length - 1; i >= 0; i--)
			{
				output = output + words[i] + " ";
			}

			return output.TrimEnd();
		}

		static string ReverseWords(string input)
		{
			string[] words = input.Split(" ");
			string output = "";
			for (int i = words.Length - 1; i >= 0; i--)
			{
				output = output + words[i] + " ";
			}

			return output.TrimEnd();
		}

		public static string ReverseWord(char[] word)
		{
			int start = 0;
			int end = word.Length - 1;

			while (start < end)
			{
				char temp = word[start];
				word[start] = word[end];
				word[end] = temp;
				start++;
				end--;
			}

			return new string(word);
		}
	}
}
