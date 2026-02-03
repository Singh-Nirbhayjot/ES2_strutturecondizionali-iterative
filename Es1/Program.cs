using System;

namespace Es1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il codice di transazione: ");
            int codice = int.Parse(Console.ReadLine());

            int c = codice;
            int cifre = 0;

            while (c > 0)
            {
                cifre++;
                c /= 10;
            }

            c = codice;
            int somma = 0;

            while (c > 0)
            {
                int cifra = c % 10;
                somma += (int)Math.Pow(cifra, cifre);
                c /= 10;
            }

            if (somma == codice)
                Console.WriteLine("Codice valido");
            else
                Console.WriteLine("Codice non valido");
        }
    }
}