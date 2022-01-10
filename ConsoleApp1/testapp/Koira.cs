using System;
using System.Collections.Generic;
using System.Text;

namespace testapp
{
    class Koira
    {
        public string Nimi;
        public string Rotu;
        public int Ikä;


        public Koira() { }

        public Koira(string _nimi, int _ikä, string _rotu)
        {
            Nimi = _nimi;
            Ikä = _ikä;
            Rotu = _rotu;

            Hauku();
        }

        public void TulostaData()
        {
            Console.WriteLine("Koiran nimi: " + Nimi + ", Ikä: " + Ikä + ", Rotu: " + Rotu);
        }

        public void Hauku()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
