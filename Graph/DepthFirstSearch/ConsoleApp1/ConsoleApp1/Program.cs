using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DFS
{
	class Graph
	{
		private int size;
		LinkedList<int>[] graph;

		public Graph(int size)
		{
			graph = new LinkedList<int>[size];

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

		public void DepthFirstSearch(int v)
		{
			// Mark all the vertices as not visited
			bool[] visited = new bool[size];
		
			// Call the recursive helper function to print DFS traversal
			DFSUtil(v, visited);
		}

		private void DFSUtil(int v, bool[] visited)
		{
			// Mark the current node as visited and print it
			visited[v] = true;
			Console.Write(v + " ");

			// Recur for all the vertices adjacent to this vertex
			LinkedList<int> list = graph[v];

			foreach (var val in list)
			{
				if (!visited[val])
					DFSUtil(val, visited);
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

			Console.Write("Depth First Traversal from vertex 2:\n");
			g.DepthFirstSearch(2);
		}
	}
}