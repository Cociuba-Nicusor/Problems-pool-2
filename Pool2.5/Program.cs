using System;

namespace Pool2._5
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Cate elemente dintr - o secventa de n numere sunt egale cu pozitia pe care apar in secventa.Se considera ca primul element din secventa este pe pozitia 0.
            int n, i, m = 0;
            Console.WriteLine("Introduceti numarul elementelor din secventa: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Secventa este: ");
            for ( i = 0; i < n; i++)
            {
                int x = rnd.Next(10);
                Console.WriteLine($"{x} ");
                if (i == x) 
                    m++;
            }
            Console.WriteLine($"In secventa sunt {m} numere egale cu pozitia lor. ");
            Console.ReadKey();

        }
    }
}
