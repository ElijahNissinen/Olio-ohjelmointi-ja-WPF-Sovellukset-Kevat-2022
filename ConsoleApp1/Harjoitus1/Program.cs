using System;

namespace Harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo Ajoneuvo1 = new Ajoneuvo();
            Ajoneuvo1.Nimi = "Auto";
            Ajoneuvo1.Nopeus = 100;
            Ajoneuvo1.Renkaat = 4;

            Ajoneuvo1.TulostaData();
        }
    }
}
