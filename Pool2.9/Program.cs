using System;

namespace Pool2._9
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Sa se determine daca o secventa de n numere este monotona. 
            //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
            int n, i, a = 0,b = 0;
            Console.WriteLine("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            int x = rnd.Next(50);

            Console.Write("Secventa de numere este: ");
            Console.Write($"{x} ");
            for (i = 0; i < n - 1; i++)
            {
                int y = rnd.Next(50);
                Console.Write($"{y} ");
                if (x < y)
                    a++;
                else
                    if (y < x)
                    b++;
                x = y;
            }
            Console.WriteLine();
            if (a > 0 && b == 0)
                Console.WriteLine("Secvena  este monoton crescatoare.");
            if (a == 0 && b > 0)
                Console.WriteLine("Secvena  este monoton descrescatoare.");
            if (a > 0 && b > 0)
                Console.WriteLine("Secvena nu este monotona");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
