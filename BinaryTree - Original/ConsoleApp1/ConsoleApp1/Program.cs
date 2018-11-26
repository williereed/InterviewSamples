using System;
using System.Diagnostics;

namespace BinarySearchTree
{
	class Node
	{
		public int value;
		public Node left;
		public Node right;
	}

	class Tree
	{
		public Node Insert(Node node, int data)
		{
			if (node == null)
			{
				node = new Node();
				node.value = data;
			}
			else if (data < node.value)
			{
				node.left = Insert(node.left, data);
			}
			else
			{
				node.right = Insert(node.right, data);
			}

			return node;
		}

		public void Traverse(Node node)
		{
			if (node == null)
			{
				return;
			}

			Console.WriteLine(node.value);

			Traverse(node.left);
			Traverse(node.right);
		}
	}


	class BinarySearchTree
	{
		static void Main(string[] args)
		{
			Node root = null;
			Tree tree = new Tree();
			int[] a = { 24, 12, 3, 50, 7 };

			for (int i = 0; i < a.Length; i++)
			{
				root = tree.Insert(root, a[i]);
			}

			tree.Traverse(root);

			Console.WriteLine("Done!");


			Console.ReadKey();
		}
	}
}