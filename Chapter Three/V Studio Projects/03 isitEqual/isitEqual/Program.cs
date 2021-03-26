using System;

namespace isitEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a 3 diget number to check if the 3rd digit is 7: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int devider = (number / 100);
            bool checking = devider == 7;
            Console.WriteLine("The third digit of the number {0} is {1} ", number, checking);
            
            
           
        }
    }
}
