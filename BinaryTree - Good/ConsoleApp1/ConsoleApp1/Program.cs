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

		public void Insert(int data)
		{
			if (Root == null)
			{
				Root = new Node(data);
			}
			else
			{
				this.Root = Insert(this.Root, data);
			}
		}

		private Node Insert(Node tree, int data)
		{
			if (tree == null)
			{
				tree = new Node(data);
			}
			else
			{
				if (tree.Data > data)
				{
					tree.Left = Insert(tree.Left, data);
				}
				else
				{
					tree.Right = Insert(tree.Right, data);
				}
			}

			return tree;
		}

		public void Traverse(Node node)
		{
			if (node == null)
			{
				return;
			}

			Console.WriteLine(node.Data);

			Traverse(node.Left);
			Traverse(node.Right);
		}
	}


	class BinarySearchTree
	{
		static void Main(string[] args)
		{
			int[] a = { 24, 25, 26, 27, 7, 17, 1 };

			Tree tree = new Tree();
		
			for (int i = 0; i < a.Length; i++)
			{
				tree.Insert(a[i]);
			}

			tree.Traverse(tree.Root);

			Console.WriteLine("Done!");


			Console.ReadKey();
		}
	}
}