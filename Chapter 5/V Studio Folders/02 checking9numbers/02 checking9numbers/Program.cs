using System;

namespace _02_checking9numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number ");
            int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1:a = 1; 
                    Console.WriteLine("ONE");
                    break;
                case 2:
                    a = 2;
                    Console.WriteLine("Two");
                    break;
                case 3:
                    a = 3;
                    Console.WriteLine("THREE");
                    break;
                case 4:
                    a = 4;
                    Console.WriteLine("FOUR");
                    break;
                case 5:
                    a = 5;
                    Console.WriteLine("FIVE");
                    break;
                case 6:
                    a = 6;
                    Console.WriteLine("SIX");
                    break;
                case 7:
                    a = 7;
                    Console.WriteLine("SEVEN");
                    break;
                case 8:
                    a = 8;
                    Console.WriteLine("EIGHT");
                    break;
                case 9:
                    a = 9;
                    Console.WriteLine("NINE");
                    break;

            }
                 
        }
    }
}
