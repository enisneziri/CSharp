using System;

namespace _06_greaterThen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shkruaj Numrat: ");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} > {1}", Math.Max(a, b), Math.Min(a, b));
        }
    }
}
