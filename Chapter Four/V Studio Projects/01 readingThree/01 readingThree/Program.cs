using System;

namespace _01_readingThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shkruaj numrat ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2 + num3;

            Console.WriteLine("Shuma e numrave tuaj eshte {0}", sum);


        }
    }
}
