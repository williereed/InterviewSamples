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

public class Stack
{
	public Node Head;

	public Stack() { }

	internal void Push(int data)
	{
		Node newNode = new Node(data);
		if (Head != null)
		{
			newNode.Next = Head;
		}

		Head = newNode;
		Console.WriteLine("{0} pushed to stack", data);
	}

	public int Pop()
	{
		if (Head == null)
		{
			throw new Exception("Stack is Empty");
		}

		int data = Head.data;
		Head = Head.Next;
		Console.WriteLine("{0} popped from stack", data);
		return data;
	}
}

class Program
{
	static void Main(string[] args)
	{
		var stack = new Stack();
		stack.Push(5);
		stack.Push(7);
		stack.Push(2);
		stack.Push(9);
		stack.Pop();
		stack.Pop();
		Console.Read();
	}
}