using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus7
{
    class Hissi
    {
        private int minKerros;
        private int maxKerros;

        private int nykyinenKerros;

        public Hissi(int minKerros, int maxKerros)
        {
            this.minKerros = minKerros;
            this.maxKerros = maxKerros;

            nykyinenKerros = minKerros;
        }

        public int NykyinenKerros
        {
            get => nykyinenKerros;
            set
            {
                if (value > maxKerros || value < minKerros)
                {
                    Console.WriteLine("Virheellinen kerros!");
                }
                else
                {
                    nykyinenKerros = value;
                }
            }
        }
    }
}
