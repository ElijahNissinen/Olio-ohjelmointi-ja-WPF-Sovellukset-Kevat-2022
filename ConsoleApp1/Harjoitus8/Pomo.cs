using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8
{
    class Pomo : Henkilö
    {
        private static int instanssit = 0;

        public Pomo()
        {
            instanssit++;
        }
    }
}
