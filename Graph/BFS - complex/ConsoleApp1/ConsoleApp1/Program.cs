using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	class Graph
	{
		private LinkedList<int>[] edges;
		private int[] nodes;
		public int Size { get; set; } = 0;

		public Graph()
		{
			edges = new LinkedList<int>[Size];
			nodes = new int[Size];
		}
	
		private void GrowList()
		{
			if (edges.Length == 0 )
			{
				edges = new LinkedList<int>[0];
				nodes = new int[0];
			}

			Array.Resize(ref edges, ++Size);
			Array.Resize(ref nodes, Size);
			edges[Size - 1] = new LinkedList<int>();
		}

		public void AddGraph (int node, int edge)
		{
			var pos = Array.IndexOf(nodes, node);

			if ( pos == -1 )
			{
				GrowList();
				nodes[Size - 1] = node;
				edges[Size - 1].AddLast(edge);

			}
			else
			{
				edges[pos].AddLast(edge);
			}
		}

		public void BreadFirstSearch(int s)
		{
			//Remember all visited nodes and edges
			var visited = new List<int>();

			//Put all nodes
			var queue = new LinkedList<int>();

			//Initial value to start from
			queue.AddLast(s);

			while (queue.Any())
			{
				s = queue.First();
				var pos = Array.IndexOf(nodes, s);
				if (pos == -1)
				{
					Console.WriteLine("Wrong data to search: " + s);
				}

				queue.RemoveFirst();
				CheckVisited(s, visited);

				var list = this.edges[pos];

				foreach (var val in list)
				{
					pos = Array.IndexOf(nodes, val);
					if (pos != -1)
					{
						queue.AddLast(val);
					}

					CheckVisited(val, visited);

				}
			}
		}

		private static void CheckVisited(int s, List<int> visited)
		{
			if (!visited.Contains(s))
			{
				Console.WriteLine(s);
				visited.Add(s);
			}
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var graph = new Graph();
			graph.AddGraph(5, 6);
			graph.AddGraph(5, 2);
			graph.AddGraph(2, 4);
			graph.AddGraph(6, 1);
			graph.AddGraph(1, 4);
			graph.AddGraph(1, 13);
			graph.AddGraph(1, 15);
			graph.AddGraph(15, 17);
			graph.AddGraph(4, 18);

			graph.BreadFirstSearch(5);
			Console.WriteLine("Done");
			Console.Read();
		}
	}
}
