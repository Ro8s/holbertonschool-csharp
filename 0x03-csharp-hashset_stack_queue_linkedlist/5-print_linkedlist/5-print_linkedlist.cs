using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        List<int> lista = new List<int>();
        LinkedList<int> empty = new LinkedList<int>();
        if (size < 0)
        {
            return(empty);
        }
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("{0}", i);
            lista.Add(i);
        }
        LinkedList<int> numbers = new LinkedList<int>(lista);
        return(numbers);

    }
}
