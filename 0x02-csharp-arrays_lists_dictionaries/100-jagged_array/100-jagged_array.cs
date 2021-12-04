using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];
            jarray[0] = new int[4] {0, 1, 2, 3};
            jarray[1] = new int[7] {0, 1, 2, 3, 4, 5, 6};
            jarray[2] = new int[2] {0, 1};
            for (int i = 0; i < jarray.Length; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    if (j == jarray[i].Length - 1)
                    {
                        Console.WriteLine("{0}", jarray[i][j]);
                    }
                    else
                    {
                        Console.Write("{0} ", jarray[i][j]);
                    }
                }
            }
        }
    }
}
