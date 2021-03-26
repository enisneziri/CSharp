using System;

namespace racktangelPandS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            Console.Write("Shkruaj Brinjen b; ");
            int b = Convert.ToInt32(Console.ReadLine());
            int perimetri = (2 * a) + (2 * b);
            int syprina = a * b;
            Console.WriteLine("Perimetri i drejtkendeshit eshte {0}, kurse syprina eshte {1}", perimetri,syprina);
        }
    }
}
