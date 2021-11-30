using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        int lastNumber = Math.Abs(number) % 10;
        if (lastNumber > 5)
        {
            Console.WriteLine($"The last digit of {number} is {lastNumber} and is greater than 5");
        }
        if (lastNumber == 0)
        {
            Console.WriteLine($"The last digit of {number} is {lastNumber} and is 0");
        }
        if (lastNumber > 0 && lastNumber < 6)
        {
            Console.WriteLine($"The last digit of {number} is {lastNumber} and is less than 6 and not 0");
        }
    }
}
