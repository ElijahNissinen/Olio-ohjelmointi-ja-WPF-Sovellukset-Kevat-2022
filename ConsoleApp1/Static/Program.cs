using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            float km = 7125f; // 7125km
            float miles = Muuuntaja.KmToMiles(km);

            Console.WriteLine(km + " kilometriä on yhtä kuin " + miles + "mailia");
        }
    }
}
