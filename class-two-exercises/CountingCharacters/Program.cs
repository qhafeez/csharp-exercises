using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string lorum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            Dictionary<string, int> characters = new Dictionary<string, int>();

            foreach (char letter in lorum) {
                string current = letter.ToString().ToLower();

                if (characters.ContainsKey(current))
                {
                    characters[current]++;
                }
                else
                {
                    characters.Add(current, 1);
                }
            }


            foreach (KeyValuePair<string, int> pair in characters) {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
            Console.ReadLine();
        }
    }
}
