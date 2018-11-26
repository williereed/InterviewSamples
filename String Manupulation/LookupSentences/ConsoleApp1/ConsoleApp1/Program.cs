using System;

namespace ConsoleApp1
{
	class Program
	{
		static string[] sentences = { "Luke likes that song",
							 "Luke does not like that song",
							 "Luke likes the song Tom sings",
							 "Tom sings the song"
						   };
		static string[] keySeries = { "Luke song",
							 "Luke Tom",
							 "Song sings",
							 "Tom song",
							 "Tom does not like"
						   };


		public static bool  LookupKeywords(string sentence, string[] keys)
		{

			foreach (string key in keys)
			{
				if (sentence.IndexOf(key) == -1)
				{
					return false;
				}
			}

			Console.WriteLine(sentence);
			return true;
		}

		static void Main(string[] args)
		{
	
			foreach (string keyString in Program.keySeries) 
			{
				Console.WriteLine("Keystring: " + keyString);
				string[] keys = keyString.Split(' ');

				bool keyFound = false;

				foreach (string sentence in Program.sentences)
				{
					if (LookupKeywords(sentence, keys))
					{
						keyFound = true;
					}
				}

				if (!keyFound)
				{
					Console.WriteLine("< No such sentence >");
				}
			}

			Console.Read();
		}
	}
}
