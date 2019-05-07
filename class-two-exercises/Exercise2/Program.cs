using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> theWords = new List<string>();
            theWords.Add("hello");
            theWords.Add("poll");
            theWords.Add("quarter");
            theWords.Add("phone");


            PrintClass.print(theWords);
        }
    }
}
