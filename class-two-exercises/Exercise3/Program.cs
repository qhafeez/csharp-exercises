using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibs = new int[] {1,1,2,3,5,8 };

            foreach (int fib in fibs) {
                Console.WriteLine(fib);
            }
            Console.ReadLine();
        }
    }
}
