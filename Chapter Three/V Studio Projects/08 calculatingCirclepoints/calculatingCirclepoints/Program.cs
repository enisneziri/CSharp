using System;

namespace calculatingCirclepoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shkruaj x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Shkruaj y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool formula;
            if (formula = (x * x) + (y * y) <= 5)
            {
                Console.WriteLine("For an expression that checks for given point {x, y} it is with" +
                    "in the circle");
            }
            else
            {
                Console.WriteLine("For an expression that checks for given point {x, y} it is not with" +
                    "in the circle");
            }

        }
    }
}
