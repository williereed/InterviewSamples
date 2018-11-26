using System;

public class Node
{
	public int data { get; set; }
	public Node Next { get; set; }
	public Node(int data)
	{
		this.data = data;
	}
}

public class Queue
{
	public Node Head;
	public Node Tail;
	private int Count = 0;

	public Queue() { }

	public void Enqueue(int data)
	{
		Console.WriteLine("En " + data);
		Node newNode = new Node(data);
		if (Head == null)
		{
			Head = newNode;
			Tail = Head;
		}
		else
		{
			Tail.Next = newNode;
			Tail = Tail.Next;
		}
		Count++;
	}

	public int Dequeue()
	{
		if (Head == null)
		{
			throw new Exception("Queue is Empty");
		}

		int data = Head.data;
		Head = Head.Next;
		Console.WriteLine("De " + data);
		return data;
	}
}

class Program
{
	static void Main(string[] args)
	{
		var queue = new Queue();
		queue.Enqueue(5);
		queue.Enqueue(7);
		queue.Enqueue(2);
		queue.Enqueue(9);
		queue.Dequeue();
		queue.Dequeue();
		Console.Read();
	}
}