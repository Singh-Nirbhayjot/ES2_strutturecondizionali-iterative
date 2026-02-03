using System;
using static System.Console;

namespace Es4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Write("Inserisci numero:");
            int.TryParse(ReadLine(), out n);
            for (int i = 1; i <= n; i++)
            {
                for (int z = 1; z <= n - i; z++)
                {
                    Write(" ");
                }
                    for (int j = 1; j <= i; j++)
                    {
                        Write(j);
                    }
                    for (int j = i - 1; j >= 1; j--)
                    {
                        Write(j);
                    }
                    WriteLine();
            }

        }
    }
}