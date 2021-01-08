using System;

namespace Pool2._7
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.
            int n, i;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            int min = rnd.Next(50);
            int max = rnd.Next(50);
            Console.WriteLine("Secventa de numere este:");
            for ( i = 0; i < n; i++)
            {
                int x = rnd.Next(50);
                Console.WriteLine($"{x} ");
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;

            }
            Console.WriteLine();
            Console.WriteLine($"Valoarea cea mai mica din secventa este: {min}.");
            Console.WriteLine($"Valoarea cea mai mare din secventa este: {max}");
            Console.ReadKey();
        }
    }
}
