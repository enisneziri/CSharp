using System;

namespace _01_greaterSwitchV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Write the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                num2 = num1;
                Console.WriteLine(num2);
            }
            else if(num2 > num1)
            {
                num1 = num2;
                Console.WriteLine(num1);
            }else if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal");
            }

        }
    }
}
