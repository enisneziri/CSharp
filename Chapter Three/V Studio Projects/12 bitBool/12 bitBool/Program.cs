using System;

namespace _12_bitBool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 170;
            int p = 70;
            int mask = 1 << p;
            bool isOne = (v & mask) != 0;
            Console.WriteLine("The bit at position {0} of number {1} is 1 {2}", p, v, isOne);
        }
    }
}
