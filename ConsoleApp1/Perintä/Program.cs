using System;

namespace Perintä
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö henkilö = new Henkilö("Matti", 20, 876543);
            Opiskelija opiskelija = new Opiskelija("Pekka", 18, 234567, 1234, "Careeria");

            henkilö.TulostaTiedot();

            Console.WriteLine();

            opiskelija.TulostaTiedot();

            Console.WriteLine("---------------------------------------------------------------");

            henkilö.Syö();
            henkilö.Juo();

            Console.WriteLine();

            opiskelija.Opiskele();
            opiskelija.Syö();
            opiskelija.Juo();
            opiskelija.Opiskele();

        }
    }
}
