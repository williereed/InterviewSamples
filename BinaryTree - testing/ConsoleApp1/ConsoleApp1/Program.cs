using System;

namespace ConsoleApp1
{
	public class Node
	{
		public Node next;
		public int data;

		public Node(int data)
		{
			this.data = data;
		}
	}

	public class LinkedList
	{
		Node head;

		public void AddToEnd(int data)
		{
			if (head == null)
			{
				head = new Node(data);
			}
			else
			{
				AddToEnd(head, data);
			}
			
		}

		public void AddToEnd(Node root, int data)
		{
			if (root.next == null)
			{
				root.next = new Node(data);
			}
			else
			{
				root = root.next;
				AddToEnd(root, data);
			}
		}

		public void Traverse()
		{
			if (head == null)
			{
				return;
			} 
			else
			{
				Traverse(head);
			}
		}

		public void Traverse(Node root)
		{
			Console.WriteLine(root.data);
			if (root.next == null)
			{
				return;
			}
			else
			{
				Traverse(root.next);
			}
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var list = new LinkedList();
			list.AddToEnd(5);
			list.AddToEnd(6);
			list.AddToEnd(7);
			list.AddToEnd(3);
			list.Traverse();
			Console.Read();
		}
	}
}
