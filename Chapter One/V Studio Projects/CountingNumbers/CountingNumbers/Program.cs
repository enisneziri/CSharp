using System;

namespace CountingNumbers
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{-i}, ");
                }
                else
                {
                    Console.WriteLine($"{i}, ");
                }
            }
        }
    }
}
