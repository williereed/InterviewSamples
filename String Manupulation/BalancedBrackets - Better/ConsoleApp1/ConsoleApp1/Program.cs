using System;
using System.Collections;

namespace ConsoleApp1
{
	class Program
	{
		private static bool ValidateParetheses(string text)
		{
			var stack = new Stack();
			// Put left brackets into starParent array
			const string start = "({[";
			// Put right brackets into end array
			const string endParenth = ")}]";

			// Scan over input string
			foreach (char c in text)
			{
				if (startParenth.Contains(c) )
				{
					// Push into stack if character in Start array
					stack.Push(c);
				}
				else if (endParenth.Contains(c))
				{
					// Character in end array
					if (stack.Count == 0)
					{
						// If noting in stack, just return with false
						return false;
					}

					if (startParenth.Substring(endParenth.IndexOf(c), 1) != stack.Pop().ToString())
					{
						// check if corresponding character is in stack, if not, return false
						return false;
					}
				}
			}

			// After all loop is done, nothing 
			return stack.Count == 0;
		}


		static void Main(string[] args)
		{
			bool res = ValidateParetheses("({aa()}aa)");
			Console.WriteLine(res);
			Console.Read();
		}
	}
}
