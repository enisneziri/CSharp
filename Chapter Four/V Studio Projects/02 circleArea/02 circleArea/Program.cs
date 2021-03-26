using System;

namespace _02_circleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("Shkruaj rrezen e rrethit: ");
            int r = Convert.ToInt32(Console.Read());

            double S = pi * (r ^ 2 );
            double P = 2 * pi * r;

            Console.WriteLine("Syprina e rrethit eshte {0}, kurse perimetri {1}", S,P);
        }
    }
}
