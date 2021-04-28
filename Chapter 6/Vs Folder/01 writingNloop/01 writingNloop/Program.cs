using System;

namespace _01_writingNloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shkruaj Nje numer ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
