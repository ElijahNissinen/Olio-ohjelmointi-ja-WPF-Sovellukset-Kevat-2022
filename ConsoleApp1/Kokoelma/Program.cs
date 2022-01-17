using System;
using System.Collections.Generic;

namespace Kokoelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------LISTA-------------------");
            List<string> lista = new List<string>();
            lista.Add("Pekka"); // indeksi 0
            lista.Add("Juha");  // indeksi 1
            lista.Add("Mika");  // indeksi 2

            lista.Remove("Juha");
            // lista.RemoveAt(1);

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------PINO-------------------");
            Stack<string> pino = new Stack<string>();

            pino.Push("Kortti 1");
            pino.Push("Kortti 2");
            pino.Push("Kortti 3");

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek()); //Peek:in avulla saadaan tietoon mikä objekti

            pino.Pop(); // Poistetaan päällimmäinen objekti pinosta

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek() + " on pinon päällä");

            Console.WriteLine("-------------------JONO-------------------");

            Queue<string> jono = new Queue<string>();

            jono.Enqueue("Matti"); // Jonoon lisätään Enqueue toiminnolla uusi objekti jonoon
            jono.Enqueue("Teppo");
            jono.Enqueue("Juuso");

            Console.WriteLine("Jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            jono.Dequeue(); //Dequeue poistaa jonon ensimmäisen objektin

            Console.WriteLine("Jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            Console.WriteLine("-------------------SANAKIRJA-------------------");

            Dictionary<string, string> sanakirja = new Dictionary<string, string>();
            sanakirja.Add("123654-4320", "Juulia"); // Juulialla on uniikki avain
            sanakirja.Add("098123-1267", "Joona");  // Joonalla on uniikki avain

            Console.WriteLine("Sanakirjassa on " + sanakirja.Count + " henkilöä");

            Console.WriteLine(sanakirja["123654-4320"]);

            Console.WriteLine("Etsitään sanakirjasta avaimella '123654-4320', haettu henkilö on: " + sanakirja["123654 - 4320"]);

            foreach (string avain in sanakirja.Keys)
            {
                Console.WriteLine("Sanakirjasta haettu avaimella: " + avain + ". Value:" + sanakirja[avain]);
            }

            foreach (string henkilö in sanakirja.Keys)
            {
                Console.WriteLine("Savankirjasta haettu valuella: " + henkilö);
            }

            // Alla olevista tulee virhe sovellukseen

            Console.WriteLine("Etsitään sanakirjasta avaimella '996214-9238', haettu henkilö on: " + sanakirja["996214 - 9238"]);

            sanakirja.Add("123654-4320", "Milla"); // Millalla on sama henkilötunnus kuin Juulialla
        }
    }
}
