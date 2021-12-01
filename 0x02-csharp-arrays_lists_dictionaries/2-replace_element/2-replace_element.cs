using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (array.Length - 1 < index)
        {
            Console.WriteLine("Index out of range");
            return(array);
        }
        array[index] = n;
        return(array);
    }
}
