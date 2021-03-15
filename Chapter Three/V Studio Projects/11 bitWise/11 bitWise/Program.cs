using System;

namespace _11_bitWise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 25; 

            int p = 3;

            int i = 1; 

            int mask = i << p; 

            Console.WriteLine((n & mask) != 0 ? 1 : 0);
        }
    }
}
