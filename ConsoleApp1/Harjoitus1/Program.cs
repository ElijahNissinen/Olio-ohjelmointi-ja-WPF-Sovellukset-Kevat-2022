using System;

namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo Auto = new Ajoneuvo();
            Auto.Nimi = "Toyota Corolla";
            Auto.Nopeus = 420;
            Auto.Renkaat = 4;

            Auto.TulostaData();

            Console.WriteLine();

            Ajoneuvo vene = new Ajoneuvo();
            vene.Nimi = "Buster";
            vene.Nopeus = 100;
            vene.Renkaat = 0;

            vene.TulostaData();
        }
    }
}
