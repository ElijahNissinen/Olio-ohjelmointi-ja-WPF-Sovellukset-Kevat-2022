using System;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira Koira1 = new Koira();
            Koira1.Nimi = "Rekku";
            Koira1.Ikä = 4;
            Koira1.Rotu = "Saksanpaimenkoira";

            Koira1.Hauku();
            Koira1.TulostaData();

            Console.WriteLine("----------------------------------------------------");

            Koira Koira2 = new Koira();
            Koira2.Nimi = "Luna";
            Koira2.Ikä = 2;
            Koira2.Rotu = "Mopsi";

            Koira2.Hauku();
            Koira2.TulostaData();

            Console.WriteLine("----------------------------------------------------");
        }
    }
}
