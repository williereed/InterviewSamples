using System;
using System.Diagnostics;

namespace ConsoleApp1
{
	public class MyList
	{
		private Node headNode;
		//private Node currentNode;

		public void AddToEnd(int data)
		{
			if (headNode == null)
			{
				headNode = new Node(data);
			}
			else
			{
				headNode.AddToEnd(data);
			}
		}

		public void Remove  (int data)
		{
			if (headNode != null && headNode.data == data)
			{
				headNode = headNode.next;
			}
			else
			{
				headNode.Remove(data);
			}
		}

		public void AddToBeginning(int data)
		{
			var node = new Node(data);
			node.next = this.headNode;
			this.headNode = node;
		}

		public void AddSorted(int data)
		{
			if (headNode == null)
			{
				headNode = new Node(data);
			}
			else if (data < headNode.data)
			{
				AddToBeginning(data);
			}
			else
			{
				headNode.AddSorted(data);
			}
		}

		public void Reverse()
		{
			if (headNode == null)
			{
				return;
			}

			Node prev = null;
			Node current = headNode;
			Node next = null;

			while (current != null)
			{
				next = current.next;
				current.next = prev;
				prev = current;
				current = next;
			}

			headNode = prev;
		}


		public void Print()
		{
			if (headNode != null)
			{
				headNode.Print();
			}
		}
	}

	public class Node
	{
		public int data;
		public Node next;

		public Node(int i)
		{
			data = i;
			next = null;
		}

		public void AddToEnd(int data)
		{
			if (this.next == null)
			{
				next = new Node(data);
			}
			else
			{
				next.AddToEnd(data);
			}
		}

		public void Remove(int data)
		{
			if (this.next.data == data)
			{
				this.next = this.next.next;
			} 
			else
			{
				next.Remove(data);
			}
		}

		public void AddSorted(int data)
		{
			if (this.next == null)
			{
				next = new Node(data);
			}
			else
			{
				if (data < next.data)
				{
					var temp = new Node(data);
					temp.next = this.next;
					this.next = temp;
				}
				else
				{
					next.AddSorted(data);
				}
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


	class Program
	{
		static void Main(string[] args)
		{
			Node node = new Node(7);
			var list = new MyList();
			list.AddToEnd(1);
			list.AddToEnd(3);
			list.AddToEnd(5);
			list.AddToEnd(10);
			list.Print();
			Console.WriteLine(" ");
			list.Reverse();
			list.Print();
			Console.Read();

		}
	}
}
