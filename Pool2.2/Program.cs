using System;

namespace Pool2._2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
            int n, i, a = 0, b = 0, c = 0;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Secventa este:");
            for(i=0;i<n;i++)
            {
                int x = rnd.Next(-51,51);
                Console.WriteLine($"{x} ");
                if (x < 0)
                {
                    a++;
                }
                if(x==0)
                {
                    b++;
                }
                if (x > 0)
                    c++;
            }
            Console.WriteLine($"In secventa sunt {a} numere negative.");
            Console.WriteLine($"In secventa sunt {b} numere zero.");
            Console.WriteLine($"In secventa sunt {c} numere pozitive.");
            Console.ReadKey();
        }
    }
}
