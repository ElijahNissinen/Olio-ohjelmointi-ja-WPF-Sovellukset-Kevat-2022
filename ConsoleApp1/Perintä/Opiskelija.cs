﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Perintä
{
    class Opiskelija : Henkilö
    {
        public int opiskelijaID;
        public string koulu;

        private static int Instanssit = 0;

        public Opiskelija(string nimi, int ikä, int henkilötunnus, int _opiskelijaID, string _koulu) : base(nimi, ikä, henkilötunnus)
        {
            opiskelijaID = _opiskelijaID;
            koulu = _koulu;

            Instanssit++;
        }

        public static void KuinkaMontaOpiskelijaa()
        {
            Console.WriteLine("Opiskelijoita olemassa:" + Instanssit);
        }

        public override void TulostaTiedot()
        {
            Console.WriteLine("Opiskelija: " + Nimi + ". Ikä: " + Ikä + ". Koulu: " + koulu + ". OpiskelijaID: " + opiskelijaID);
        }

        public void Opiskele()
        {
            Console.WriteLine(Nimi + " opiskelee...");
        }
    }
}
