using System;

namespace AddinYears
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            DateTime ageNow = new DateTime(age, 03, 08); // 03 and 08 are your date of birth
            ageNow = ageNow.AddYears(10);
            Console.WriteLine(ageNow.Year);
        }
    }
}
