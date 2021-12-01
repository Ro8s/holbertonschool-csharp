using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return(null);
        }
        if (size == 0)
        {
            var emp = new List<int> {};
            Console.WriteLine();
            return(emp);
        }

        var lista = new List<int>();
        for (int i = 0; i < size; i++)
        {
            if (i + 1 == size)
            {
                Console.WriteLine("{0}", i);
                lista.Add(i);
            }
            else
            {
                Console.Write("{0} ", i);
                lista.Add(i);
            }
        }
        return(lista);
    }
}
