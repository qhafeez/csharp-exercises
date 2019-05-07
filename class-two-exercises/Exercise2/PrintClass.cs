using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class PrintClass
    {
        public static void print(List<string> words)
        {
            foreach (string word in words) {

                if (word.Length == 5) {

                    Console.WriteLine(word);
                }
            }
            Console.ReadLine();

        }

    }
}
