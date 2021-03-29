using System;

namespace _11_lengthIneger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int count = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= count; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
