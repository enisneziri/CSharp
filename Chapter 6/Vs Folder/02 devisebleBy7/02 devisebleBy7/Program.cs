using System;

namespace _02_devisebleBy7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shkruaj numrin ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                
                if (i % (3 * 7) != 0) Console.WriteLine(i);
            }
        }
    }
}
