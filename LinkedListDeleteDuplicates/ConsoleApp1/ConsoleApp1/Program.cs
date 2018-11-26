using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = new MyList();
			list.AddNode(3);
			list.AddNode(3);
			list.AddNode(5);
			list.AddNode(2);
			list.AddNode(1);
			list.AddNode(5);
			list.AddNode(3);
			//list.Print();
			list.removeAllDuplicates();
			list.Print();
		}
	}

	public class Node
	{
		public int data;
		public Node next;

		public Node(int data)
		{
			this.data = data;
		} 
	
		public void AddNode(int data)
		{
			if (this.next == null)
			{
				next = new Node(data);
			}
			else
			{
				next.AddNode(data);
			}
		}

		public void Remove(int data)
		{
			if (next == null)
			{
				return;
			}

			if (next.data == data)
			{
				next = next.next;
			}
			else
			{
				next.Remove(data);
			}
		}

		public void Print()
		{
			Console.WriteLine(data);
			if (next != null)
			{
				next.Print();
			}
		}
	}

	public class MyList
	{
		public Node headNode;

		public void AddNode(int data)
		{
			if (headNode == null)
			{
				headNode = new Node(data);
			}
			else
			{
				headNode.AddNode(data);
			}
		}

		public void removeAllDuplicates()
		{
			if (headNode == null)
			{
				return;
			}

			Node current = headNode;

			while (current.next != null)
			{
				current.Remove(current.data);
				current = current.next;
			}
		}

		public void Print()
		{
			if (headNode != null)
			{
				headNode.Print();
			}
			Console.Read();
		}
	}
}
