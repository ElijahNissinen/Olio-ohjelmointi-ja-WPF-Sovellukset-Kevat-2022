using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas Sähkökiuas = new Kiuas("Sähkökiuas", 90, 50);

            Sähkökiuas.NäytäTiedot();
            Sähkökiuas.Tila = true;
            Sähkökiuas.NäytäTiedot();
            Sähkökiuas.SäädäLämpötila(100);
            Sähkökiuas.NäytäTiedot();
        }
    }
}
