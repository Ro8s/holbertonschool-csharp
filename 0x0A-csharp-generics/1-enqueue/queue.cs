using System;

/// <summary>
/// Queue class
/// </summary>
/// <typeparam name="T">Type of elements inside the queue</typeparam>
class Queue<T>
{
    public Node head { get; set; }
    public Node tail { get; set; }
    public int count;
    
    /// <summary>
    /// Function that returns the type that contains the queue
    /// </summary>
    /// <returns>Type of the element</returns>
	public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Node class that defines nodes
    /// </summary>
    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }

    }
    /// <summary>
    /// Enqueue method that enqueue an element into a queue
    /// </summary>
    /// <param name="element">element to add into the queue</param>
    public void Enqueue(T element)
    {
        Node node = new Node(element);
        node.value = element;
        if (head == null)
        {
            node.next = null;
            head = node;
            tail = node;
        }
        else
        {
            node.next = head;
            head = node;
        }
        count++;
    }
    /// <summary>
    /// Count method to count the elements into the queue
    /// </summary>
    /// <returns>Number of nodes</returns>
    public int Count()
    {
        return count;
    }
}
