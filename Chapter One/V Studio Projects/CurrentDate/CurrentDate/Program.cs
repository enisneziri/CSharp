using System;

namespace CurrentDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToString("D");
            Console.WriteLine("The current Date is {0}", time);
        }
    }
}
