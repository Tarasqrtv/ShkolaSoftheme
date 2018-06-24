using System;

namespace HWTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Devided(8, 2));
        }

        private static double Devided(double x, double y)
        {
            var z = x / y;
            return z;
        }

        private static double GetE()
        {
            return Math.E;
        }
    }
}
