using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus4
{
    class Albumi
    {
        private string Artisti;
        private string Genre;
        private string Hinta;

        private List<Kappale> kappaleet = new List<Kappale>();

        public Albumi(string artisti, string genre, string hinta, List<Kappale> kappaleet)
        {
            Artisti = artisti;
            Genre = genre;
            Hinta = hinta;
            this.kappaleet = kappaleet;
        }

        public void LisääKappale(Kappale uusiKappale)
        {
            kappaleet.Add(uusiKappale);
        }

        public void TulostaKappaleet()
        {
            foreach (Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + ", " + kappale.Pituus);
            }
        }
    }
}
