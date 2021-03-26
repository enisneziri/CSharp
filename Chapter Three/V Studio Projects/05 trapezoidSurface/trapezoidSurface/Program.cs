using System;

namespace trapezoidSurface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shkruaj informatat e Trapezit tuaj:");
            Console.Write("Shkruaj Brinjen a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Shkruaj Brinjen b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Shkruaj Brinjen h: ");
            int h = Convert.ToInt32(Console.ReadLine());
            int formula = (a + b) * h / 2;
            Console.WriteLine("Syprina e Trapezit eshte {0}",formula);
        }
    }
}
