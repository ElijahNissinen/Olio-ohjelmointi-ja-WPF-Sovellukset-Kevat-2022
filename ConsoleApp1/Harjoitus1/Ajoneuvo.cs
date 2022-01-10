using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus1
{
    class Ajoneuvo
    {
        public string Nimi;
        public int Nopeus;
        public int Renkaat;

        public void TulostaData()
        {
            Console.WriteLine("Ajoneuvo: " + Nimi + ", Nopeus: " + Nopeus + ", Renkaat: " + Renkaat);
        }
    }
}
