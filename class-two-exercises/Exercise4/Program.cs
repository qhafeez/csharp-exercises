using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> idsNames = new Dictionary<int, string>();
            string newStudentName="";

            
            do
            {
                Console.WriteLine("Enter Name");
                newStudentName = Console.ReadLine();
                if (newStudentName != "")
                {

                    Console.WriteLine("Enter ID Number");
                    int newStudentID = int.Parse(Console.ReadLine());
                    idsNames.Add(newStudentID, newStudentName);

                }

            } while (newStudentName != "");

            Console.WriteLine("\nClass Roster:");
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, string> student in idsNames) {
                
                sb.Append("\nID: ");
                sb.Append(student.Key);
                sb.Append(" Name: ");
                sb.Append(student.Value);
               

            }
            Console.WriteLine(sb);
            Console.ReadLine();
            


            
        }
    }
}
