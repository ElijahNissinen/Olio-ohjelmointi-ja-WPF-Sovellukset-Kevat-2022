using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktiivisuus
{
    abstract class Henkilö
    {
        public abstract string Nimi { get; set; }

        public abstract void Puhu(); //abstract suljetaan ; EI {}

        public static int Instanssit = 0;

        public Henkilö()
        {
            Instanssit++;
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Henkilöita elossa: " + Instanssit);
        }
    }
}
