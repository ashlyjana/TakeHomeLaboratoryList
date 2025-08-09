using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Countries = new List<string>
            {
                "Maldives",
                "China",
                "Switzerland",
                "Italy",
                "Kuwait"
            };
            List<string> Capitals = new List<string>
            {
                "Male",
                "Beijing",
                "Bern",
                "Rome",
                "Kuwait City"
                };
            Console.WriteLine("Enter a country name:");
            string inputCountry = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < Countries.Count; i++)
            {
                if (Countries[i].Equals(inputCountry, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"The capital of {inputCountry} is {Capitals[i]}.");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Country not found.");
            }

        }
    }
}
