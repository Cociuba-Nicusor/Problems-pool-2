using System;

namespace Pool2._6
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
            int n, i;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            bool a = true;
            int x = rnd.Next(31);
            Console.WriteLine("Secventa data este: ");
            Console.Write($"{x} ");
            for (i = 0; i < n; i++)
            {
                int y = rnd.Next(31);
                Console.Write($"{y} ");

                if (!(x <= y))
                    a = false;
                    x = y;
            }
            Console.WriteLine();
            if (a==true)
                Console.WriteLine("Secventa data are numerele in oridne crescatoare.");
            else
                Console.WriteLine("Secventa data nu are numerele in oridne crescatoare.");
            Console.ReadKey();
        }
    }
}
