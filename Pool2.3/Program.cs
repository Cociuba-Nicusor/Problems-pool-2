using System;

namespace Pool2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma si produsul numerelor de la 1 la n.
            int n, i, s = 0, p = 1;
            Console.WriteLine("Introducet numarul n:");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine($"Suma numerelor pana la n este {s}.");
            Console.WriteLine($"Produsul numerelor pana la n este {p}.");
            Console.ReadKey();
        }
    }
}
