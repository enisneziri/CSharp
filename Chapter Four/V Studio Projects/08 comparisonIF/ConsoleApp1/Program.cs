using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Shkruaj numrin e par: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Shkruaj numrin e dyt: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Shkruaj numrin e tret: ");
            int c = int.Parse(Console.ReadLine());

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
