using System;

namespace Pool2._11
{
    
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Se cere sa se calculeze suma inverselor acestor numere.
            int n, i, s = 0,inv,aux;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Secventa generata este:");
            for (i = 0; i < n; i++)
            {
                int x = rnd.Next(100);
                Console.WriteLine($"{x}  ");
                aux = x;
                inv = 0;
                while (aux!=0)
                {
                    inv = inv * 10 + aux % 10;
                    aux = aux / 10;
                }
                s = s + inv;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma este {s}.");
            Console.ReadKey();

        }    
    }
}
