using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Cities = new List<string>();
            string input;

            Console.WriteLine("City List Application");
            Console.WriteLine("Enter city names (type 'exit' to finish):");

            while (true)
            {
                Console.Write("Enter city name: ");
                input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Cities.Add(input);
                    Console.WriteLine($"City '{input}' added");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            if (Cities.Count > 0)
            {
                Console.WriteLine("\nList of Cities:");
                foreach (var city in Cities)
                {
                    Console.WriteLine(city);
                }
            }
            else
            {
                Console.WriteLine("No cities were added");
            }
        }
    }
}
