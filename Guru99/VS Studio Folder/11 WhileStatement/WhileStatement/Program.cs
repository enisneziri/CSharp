using System;

namespace WhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 value = 9, i = 0;

            while (i < value)
            {
                Console.WriteLine(i);
                i += 1;
            }
        }
    }
}
