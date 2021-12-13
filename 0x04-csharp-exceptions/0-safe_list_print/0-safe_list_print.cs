using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int pichu = 0;
        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                pichu++;
            }
        }
        catch (System.ArgumentOutOfRangeException)
        {
            return(pichu);
        }
        return(pichu);
    }
}
