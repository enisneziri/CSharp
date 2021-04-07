using System;

namespace _10_SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 12;
            switch (value)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Value is 2");
                    break;
                default:
                    Console.WriteLine("value is different");
                    break;
            }
        }
    }
}
