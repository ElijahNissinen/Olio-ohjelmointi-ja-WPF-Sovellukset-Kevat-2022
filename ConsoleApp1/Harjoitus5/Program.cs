using System;

namespace Harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 15;
            float b = 3;

            Console.WriteLine(StaattinenLaskin.Summa(a, b));
            Console.WriteLine();

            Console.WriteLine(StaattinenLaskin.Erotus(a, b));
            Console.WriteLine();

            Console.WriteLine(StaattinenLaskin.Kertolasku(a, b));
            Console.WriteLine();

            Console.WriteLine(StaattinenLaskin.Jako(a, b));
        }
    }
}
