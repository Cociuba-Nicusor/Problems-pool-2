using System;

namespace Pool2._12
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            // Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
            //Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
            //De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
            int n, nr = 1,i;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            double x;
            Console.WriteLine("Secventa este: ");
            for ( i = 0; i < n; i++)
            {
                x = rnd.Next(11);
                if (x != 0)
                  Console.Write($"{x} ");
                else
                {
                   Console.WriteLine();
                   nr++;
                }

            }
                Console.WriteLine();
                Console.WriteLine($"In secventa data sunt {nr} secvente cu elemente nenule.");
                Console.WriteLine();
                Console.ReadKey();
        }
    }
}
