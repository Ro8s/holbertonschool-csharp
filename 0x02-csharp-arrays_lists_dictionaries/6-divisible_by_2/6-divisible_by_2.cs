using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        var lista = new List<bool>();
        foreach (var item in myList)
        {
            if (item % 2 == 0)
            {
                lista.Add(true);
            }
            else
            {
                lista.Add(false);
            }
        }
        return(lista);
    }
}

