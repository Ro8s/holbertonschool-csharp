using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    if (i == 3 && j == 3)
                    {
                        Console.Write("1 ");
                    }
                    else if (j == 5)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
            }
        }
    }
}
