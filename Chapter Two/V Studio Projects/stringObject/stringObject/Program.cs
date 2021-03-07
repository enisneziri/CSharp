using System;

namespace stringObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello";
            string word2 = "World";
            object both = word1+ " " + word2;
            string Hello = both.ToString();
            Console.WriteLine(Hello);
        }
    }
}
