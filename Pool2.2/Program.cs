using System;

namespace Pool2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
            int n, i, a = 0, b = 0, c = 0;
            Console.WriteLine("Introduceti lungimea secventei:");
            n = int.Parse(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                if (i < 0)
                {
                    a++;
                }
                if(i==0)
                {
                    b++;
                }
                if (i > 0)
                    c++;
            }
            Console.WriteLine($"In secventa sunt {a} numere negative.");
            Console.WriteLine($"In secventa sunt {b} numere zero.");
            Console.WriteLine($"In secventa sunt {c} numere pozitive.");
            Console.ReadKey();
        }
    }
}
