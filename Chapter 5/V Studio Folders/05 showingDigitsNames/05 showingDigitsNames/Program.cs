using System;

namespace _05_showingDigitsNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Shkruaj nje numer: ");
            int number = Int32.Parse(Console.ReadLine());

            switch (number)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("nje"); break;
                case 2: Console.WriteLine("dy"); break;
                case 3: Console.WriteLine("tre"); break;
                case 4: Console.WriteLine("kater"); break;
                case 5: Console.WriteLine("Pes"); break;
                case 6: Console.WriteLine("gjashte"); break;
                case 7: Console.WriteLine("shtate"); break;
                case 8: Console.WriteLine("tet"); break;
                case 9: Console.WriteLine("nente"); break;
                default: Console.WriteLine("gabim ne input"); break;
            }
        }
    }
}
