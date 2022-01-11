using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Kissa : Eläin
    {
        public string Rotu;
        public int Ikä;

        public static int instanssit = 0;

        public Kissa(string rotu, int ikä)
        {
            Rotu = rotu;
            Ikä = ikä;

            instanssit++;
        }

        public static new void KuinkaMonta() // new -avain sanalla korvataan Eläin luokan "KuinkaMonta"
        {
            Console.WriteLine("Kissoja on elossa: " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
