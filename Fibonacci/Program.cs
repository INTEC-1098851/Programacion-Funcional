using System;

namespace Semana_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var fiboCounter = BuildFibonacciCounter();
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
            Console.WriteLine(fiboCounter());
        }
        static Func<int> BuildFibonacciCounter(){

            int n1 = 0;
            int n2 = n1++;
            return () =>
            {
                int n3 = n1 + n2;
                n1 = n2;
                n2 = n3;
                return n1;
            };
        }
    }
}
