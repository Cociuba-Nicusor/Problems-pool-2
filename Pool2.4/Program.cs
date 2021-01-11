using System;

namespace Pool2._4
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
            //Se considera ca primul element din secventa este pe pozitia zero.
            //Daca numarul nu se afla in secventa raspunsul va fi -1. 
            int n, i, a,m=0,y=0;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul cautat:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Secventa este:");
            for(i=0;i<n;i++)
            {
                int x = rnd.Next(5);
                Console.WriteLine($"{x}  ");
                if (x == a)
                    Console.WriteLine($"Numarul {a} se afla pe pozitia {i}.");
                }

            




        }
    }
}
