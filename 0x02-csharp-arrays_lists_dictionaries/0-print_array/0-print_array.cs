using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size == 0)
        {
            int[] arr = new int[0];
            Console.WriteLine();
            return(arr);
        }
        else if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return(null);
        }
        int[] arr2 = new int[size];
        for (int i = 0; i < size; i++)
        {

            arr2[i] = i;
            Console.Write("{0}", i);
            if (i + 1 < size)
            {
                Console.Write(" ");
            }
            else
            {
                Console.WriteLine();
            }
        }
        return(arr2);
    }
}
