using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n1 = 0; n1 <= 8; n1++)
            {
                for (int n2 = n1; n2 <= 9; n2++)
                {
                    if (n1 != n2)
                    {
                        Console.Write($"{n1}{n2}");
                        if (n1 != 8)
                        {
                            Console.Write(", ");
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                    }

                }
            }
        }
    }
}
