using System;
using System.Collections.Generic;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        Console.Write("1 ");
                        matriz[2,2] = 1;
                    }
                    else if (j == 4)
                    {
                        Console.WriteLine("0");
                        matriz[i,j] = 0;
                    }
                    else
                    {
                        Console.Write("0 ");
                        matriz[i,j] = 0;
                    }
                }
            }  
        }
    }
}
