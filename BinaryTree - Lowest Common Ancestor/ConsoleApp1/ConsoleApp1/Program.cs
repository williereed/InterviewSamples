using System;
using System.Diagnostics;

namespace BinarySearchTree
{
	class Node
	{
		public Node (int data)
		{
			this.Data = data;
		}

		public int Data;
		public Node Left;
		public Node Right;
	}

	class Tree
	{

		public Node Root;

		private bool lowestCommonAncestorFound = false;

		public void Insert(int data)
		{
			if (Root == null)
			{
				Root = new Node(data);
			}
			else
			{
				Root = Insert(Root, data);
			}
		}

		private Node Insert(Node node, int data)
		{
			if (node == null)
			{
				node = new Node(data);
			}
			else
			{
				if (node.Data > data)
				{
					node.Left = Insert(node.Left, data);
				}
				else
				{
					node.Right = Insert(node.Right, data);
				}
			}

			return node;
		}

		public void Traverse(Node node, int key1, int key2)
		{
			if (node == null)
			{
				return;
			}

			if (!lowestCommonAncestorFound && node.Data > key1 && node.Data < key2)
			{
				Console.WriteLine("Found! " + node.Data);
				lowestCommonAncestorFound = true;
			}

			if (!lowestCommonAncestorFound)
			{
				Console.WriteLine(node.Data);

				Traverse(node.Left, key1, key2);
				Traverse(node.Right, key1, key2);
			}
		}
	}


	class BinarySearchTree
	{
		static void Main(string[] args)
		{
			int[] a = { 20, 8, 22, 12, 4, 14, 10 };

			Tree tree = new Tree();
		
			for (int i = 0; i < a.Length; i++)
			{
				tree.Insert(a[i]);
			}

			tree.Traverse(tree.Root, 4, 14);

			Console.WriteLine("Done!");


			Console.ReadKey();
		}
	}
}