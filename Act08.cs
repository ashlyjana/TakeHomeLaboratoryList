using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> filtered = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter a number {i + 1} :");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            foreach (int num in numbers)
            {
                if (num > 50)
                {
                    filtered.Add(num);
                }

            }
            Console.WriteLine("Original Count: " + numbers.Count);
            Console.WriteLine("Filtered Count: " + filtered.Count);
            Console.WriteLine("Filtered Numbers: ");
            foreach (int num in filtered)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

           