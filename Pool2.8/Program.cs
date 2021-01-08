using System;

namespace Pool2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determianti al n-lea numar din sirul lui Fibonacci. 
            //Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). 
            //Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
            int n;
            Console.Write("Introduceti numarul n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write($"f({n})  din sir  este: ");
            Console.Write(Fibonacci(n));
            Console.WriteLine();
            Console.ReadKey();

        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }   
}
