using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class Opiskelija
    {
        private string nimi;
        private string opiskelijaID;
        private int opintopisteet;

        public Opiskelija(string _nimi, string _opiskelijaID, int _opintopisteet)
        {
            nimi = _nimi;
            opiskelijaID = _opiskelijaID;
            opintopisteet = _opintopisteet;
        }

        public void TulostaData()
        {
            Console.WriteLine(nimi + ". ID: " + opiskelijaID + ". Opintopisteet: " + opintopisteet);
        }

        public void MuokkaaOpintopisteitä(int määrä)
        {
            opintopisteet += määrä;
        }
    }
}
