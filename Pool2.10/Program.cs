using System;

namespace Pool2._10
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            // Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.
            int n, i;
            Console.WriteLine("Introduceti numarul elementelor din secventa: ");
            n = int.Parse(Console.ReadLine());
            int nr_consecutive = 1;
            int Lungime_Max_secventa = 0;
            int x = rnd.Next(2);
            Console.WriteLine("Secventa de numere este: ");
            Console.Write($"{x} ");
            for ( i = 0; i < n - 1; i++)
            {
                int y = rnd.Next(2);
                Console.Write($"{y} ");
                if (x == y) //conditia pt ca numerele sa fie consecutive
                {
                    nr_consecutive++;
                    if (nr_consecutive > Lungime_Max_secventa)
                        Lungime_Max_secventa = nr_consecutive;
                }
                else
                    nr_consecutive = 1;
                x = y;
            }
            Console.WriteLine();
            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa data este: {Lungime_Max_secventa}");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
