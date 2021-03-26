using System;

namespace _05_checkingEvery5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Write("Write the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            for(int i = a; i <= b; i++)
            {
                if (i % 5 == 0) counter++;            
            }
            Console.WriteLine("{0} numbers found.", counter);
        }
    }
}
