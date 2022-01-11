using System;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira.KuinkaMonta();
            Kissa.KuinkaMonta();
            Eläin.KuinkaMonta();

            Console.WriteLine();

            Koira koira1 = new Koira("Mopsi", 4);
            Koira koira2 = new Koira("Saksanpaimenkoira", 6);
            Kissa kissa1 = new Kissa("Ragdoll", 5);
            Kissa kissa2 = new Kissa("Maine Coon", 3);

            kissa1.Ääntele();
            koira1.Ääntele();

            Console.WriteLine();

            Koira.KuinkaMonta();
            Kissa.KuinkaMonta();
            Eläin.KuinkaMonta();

            Console.WriteLine();

            koira2.Ääntele();
            kissa2.Ääntele();
        }
    }
}
