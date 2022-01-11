using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    class Henkilö
    {
        public string Nimi;
        public int Ikä;
        public int Henkilötunnus;

        private static int Instanssit = 0;

        public Henkilö(string nimi, int ikä, int henkilötunnus)
        {
            Nimi = nimi;
            Ikä = ikä;

            Instanssit++;
        }

        public static void KuinkaMontaHenkilöä()
        {
            Console.WriteLine("Henkilöitä olemassa: " + Instanssit);
        }

        public virtual void TulostaTiedot()
        {
            Console.WriteLine("Henkilö: " + Nimi + ". Ikä: " + Ikä + ". Henkilötunnus: " + Henkilötunnus);
        }

        public void Syö()
        {
            Console.WriteLine(Nimi + " syö...");
        }

        public void Juo()
        {
            Console.WriteLine(Nimi + " juo...");
        }
    }
}
