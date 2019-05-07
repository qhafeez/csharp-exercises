using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloMethods
{
    public class Program
    {

        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            {
                return "Hello World";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour le monde";
            }
            else
            {
                return "Hola Mundo";
            }
        }

        public static void Main(string[] args)
        {
            string message = GetMessage("fr");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
