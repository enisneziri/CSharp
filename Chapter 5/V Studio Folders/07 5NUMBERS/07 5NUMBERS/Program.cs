using System;

namespace _07_5NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shkruaj 5 numra");
            
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine());

            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;
            Console.WriteLine("{0} is the biggest number.", a);
        }

           
    }
}
