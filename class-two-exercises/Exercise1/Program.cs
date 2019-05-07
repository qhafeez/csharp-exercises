using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(7);
            numbers.Add(9);
            numbers.Add(8);
            numbers.Add(4);
            numbers.Add(3);
            numbers.Add(19);
            numbers.Add(18);

            int thesum =  Sum.SumOf(numbers);
            Console.WriteLine(thesum);
            Console.ReadLine();
        }
    }
}
