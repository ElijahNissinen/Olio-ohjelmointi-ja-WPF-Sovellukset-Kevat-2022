using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8
{
    abstract class Henkilö
    {
        public abstract string Nimi { get; set; }
        public abstract string Työpaikka { get; set; }
        public abstract int Palkka { get; set; }

    }
}
