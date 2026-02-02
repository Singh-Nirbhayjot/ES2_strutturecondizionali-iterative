using System;

namespace Es2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il primo numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo numero: ");
            int b = int.Parse(Console.ReadLine());

            int somma1 = 0;
            int somma2 = 0;

            for (int i = 1; i <= a/2; i++)
            {
                if (a % i == 0)
                    somma1 += i;
            }

            for (int i = 1; i <= b/2; i++)
            {
                if (b % i == 0)
                    somma2 += i;
            }

            if (somma1 == b && somma2 == a)
                Console.WriteLine("I numeri sono amici.");
            else
                Console.WriteLine("I numeri non sono amici.");
        }
    }
}