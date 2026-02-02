using System;

namespace Es3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write(n);

            while (n != 1)
            {
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = n * 3 + 1;

                Console.Write($"->{n}");
            }
        }
    }
}