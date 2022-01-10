using System;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija1 = new Opiskelija("Maija", "123", 0);
            opiskelija1.TulostaData();
            opiskelija1.MuokkaaOpintopisteitä(10);
            opiskelija1.MuokkaaOpintopisteitä(15);
            opiskelija1.TulostaData();
        }
    }
}
