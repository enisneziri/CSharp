using System;

namespace _03_findingGreater3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 3 numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                if (a > c) Console.WriteLine("A is the biggest");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A and C are the biggest");
            else if (a < b)
                if (b > c) Console.WriteLine("B is the biggest");
                else if (b < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("B and C are the biggest");
            else if (a == b)
                if (a == c) Console.WriteLine("All are equal");
                else if (a < c) Console.WriteLine("C is the biggest");
                else Console.WriteLine("A and B are the biggest");
            

        }
    }
}
