using System;

namespace calculatingWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            float formula = weight * 0.17f;
            Console.WriteLine("Your weight on moon would be; {0}kg", formula);
        }
    }
}
