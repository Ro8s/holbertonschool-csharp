using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int num = 0; num <= 98; num++)
            {
                Console.Write("{0} = {1}\n", num, String.Format("0x{0:x}", num));
            }
        }
    }
}
