using System;

namespace initizalizingHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberInDec = 256;
            int NumberInHex = 0x100;
            int sum = NumberInDec + NumberInHex;

            Console.WriteLine(sum);
        }
    }
}
