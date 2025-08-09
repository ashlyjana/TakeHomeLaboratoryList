using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string>();

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter course code {i + 1}: ");
                string code = Console.ReadLine();

                if (code.Length != 5)
                {
                    Console.WriteLine("Error: (Course code must be exactly 5 characters)");
                }
                else if (courses.Contains(code))
                {
                    Console.WriteLine("Error: (Duplicate course code)");
                }
                else
                {
                    courses.Add(code);
                    Console.WriteLine("Course registered successfully.");
                }
            }

            Console.WriteLine("\nRegistered Courses:");
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine(courses[i]);
            }
        }
    }
}
