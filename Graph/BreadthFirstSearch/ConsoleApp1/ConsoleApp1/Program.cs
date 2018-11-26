using System;
using System.Collections.Generic;
using System.Linq;

namespace DFS
{
	class Graph
	{
		private int size;
		LinkedList<int>[] graph;

		public Graph(int size)
		{
			//Size of graph depends on how many vertices
			graph = new LinkedList<int>[size];

			//Each member will have corresponding edges
			for (int i = 0; i < graph.Length; i++)
			{
				graph[i] = new LinkedList<int>();
			}

			this.size = size;
		}

		public void AddEdge(int v, int w)
		{
			graph[v].AddLast(w);
		}

		public void BreadthFirstSearch(int s)
		{
			bool[] visited = new bool[size];
			
			// Create a queue for BFS
			LinkedList<int> queue = new LinkedList<int>();

			visited[s] = true;
			queue.AddLast(s);

			while (queue.Any())
			{
				// Dequeue a vertex from queue and print it
				s = queue.First();
				Console.Write(s + " ");
				queue.RemoveFirst();

				LinkedList<int> list = graph[s];

				foreach (var val in list)
				{
					if (!visited[val])
					{
						visited[val] = true;
						queue.AddLast(val);
						Console.WriteLine("Add to queue: " + val);
					}
				}
			}
		}

	}

	class Program
	{
		static void Main(string[] args)
		{
			Graph g = new Graph(7);
			g.AddEdge(0, 1);
			g.AddEdge(0, 2);
			g.AddEdge(0, 3);
			g.AddEdge(1, 0);
			g.AddEdge(1, 5);
			g.AddEdge(2, 5);
			g.AddEdge(3, 0);
			g.AddEdge(3, 4);
			g.AddEdge(4, 6);
			g.AddEdge(5, 1);
			g.AddEdge(6, 5);

			Console.Write("Breadth First Traversal from vertex 5:\n");
			g.BreadthFirstSearch(5);
			Console.Read();
		}
	}
}