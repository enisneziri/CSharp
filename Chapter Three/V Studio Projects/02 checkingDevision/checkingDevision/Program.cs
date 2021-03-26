using System;

namespace checkingDevision
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 37;
            bool check = num1 % 7 == 0;
            bool check2 = num1 % 5 == 0;

            Console.WriteLine(check);
            Console.WriteLine(check2);
        }
    }
}
