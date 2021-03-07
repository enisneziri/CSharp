using System;

namespace floatAndDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            float Num1 = 5f;
            float Num2 = -5.01f;
            double Num3 = 34.567839023;
            float Num4 = 12.345f;
            double Num5 = 8923.1234857;
            decimal Num6 = 3456.091124875956542151256683467M;

            Console.WriteLine("float: {0}, float:{1}, double:{2}, float:{3}, double:{4}, decimal:{5}", Num1, Num2, Num3, Num4, Num5, Num6);
        }
    }
}
