using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> myLList = new LinkedList<int>();
        LinkedListNode<int> current;

        myLList.AddLast(7);
        myLList.AddLast(11);
        myLList.AddLast(15);
        myLList.AddLast(19);
        myLList.AddLast(23);
        myLList.AddLast(27);
        myLList.AddLast(31);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }

        Console.WriteLine("------------------");
        LList.Insert(myLList, 3);

        current = myLList.First;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }
}
