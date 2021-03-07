using System;

namespace objectString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "Hello ";
            string word2 = "World";
            object both = word1 + word2;
            Console.WriteLine(both);
        }
    }
}
