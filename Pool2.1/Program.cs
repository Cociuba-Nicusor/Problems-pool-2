using System;

namespace Pool2._1
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determine cate din ele sunt pare.
            int n, i, s = 0;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Secventa generata este:");
            for (i = 1; i <= n; i++)
            {
                int x = rnd.Next(51);
                
                Console.WriteLine($"{x}  ");
                if (x % 2 == 0)
                    s = s + 1;
            }
            Console.WriteLine($"In secvemta sunt {s} numere pare.");
            Console.ReadKey();

        }
    }
}
