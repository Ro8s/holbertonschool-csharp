using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index > myList.Count - 1 || index < 0)
        {
            Console.WriteLine("Index is out of range");
            return(-1);
        }
        myList.Remove(myList[index]);
        return(myList);
    }
}
