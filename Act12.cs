using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> productNames = new List<string>();
            List<int> stockCounts = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter product {i + 1} name: ");
                productNames.Add(Console.ReadLine());

                Console.Write($"Enter stock count for {productNames[i]}: ");
                stockCounts.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("\nUpdated Inventory:");
            for (int i = 0; i < 10; i++)
            {
                string restockFlag = "";

                if (stockCounts[i] < 10)
                {
                    stockCounts[i] += 20;
                    restockFlag = " (Restocked)";
                }

                Console.WriteLine(productNames[i] + " - " + stockCounts[i] + restockFlag);
            }
        }
    }
}
