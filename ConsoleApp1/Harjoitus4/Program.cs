using System;

namespace Harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ()
            
            Albumi albumi = new Albumi();
            albumi.LisääKappale(new Kappale("Kappale1", "03:33"));
            albumi.LisääKappale(new Kappale("Kappale2", "04:04"));
            albumi.LisääKappale(new Kappale("Kappale3", "04:00"));
        }
    }
}
