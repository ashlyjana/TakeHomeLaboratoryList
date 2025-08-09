using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<decimal> prices = new List<decimal>();
            decimal input;

            Console.WriteLine("Enter item prices ( input -1 to stop):");

            while (true)
            {
                if (!decimal.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                if (input == -1)
                    break;

                if (input < 0)
                {
                    Console.WriteLine("Price cannot be negative");
                    continue;
                }

                prices.Add(input);
            }

            if (prices.Count > 0)
            {
                Console.WriteLine($"Total Items: {prices.Count}");
                Console.WriteLine($"Average Price: {prices.Average():F2}");
                Console.WriteLine($"Highest Price: {prices.Max():F2}");
                Console.WriteLine($"Lowest Price: {prices.Min():F2}");
            }
            else
            {
                Console.WriteLine("No valid prices entered");
            }
        }
    }
}
