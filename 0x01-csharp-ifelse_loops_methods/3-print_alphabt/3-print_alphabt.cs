using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
             for (char alp='a'; alp <= 'z'; alp++)
                {
                    if(alp != 'q' && alp != 'e')
                    {
                        Console.Write(alp);
                    }
                }
        }
    }
}
