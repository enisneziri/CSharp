using System;

namespace intSwitching
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 10;

            int oldn1 = n1;
            n1 = n2;
            n2 = oldn1;
        }
    }
}
