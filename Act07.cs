using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Product = new List<string>();
            string keyword;

            Console.WriteLine("Product Search");

            for (int i = 0; i < 8; i++)
            {
                Console.Write("Enter product name: " + (i + 1) );
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                Product.Add(input);
            }
            Console.Write("Enter keyword to search: ");
            keyword = Console.ReadLine().ToLower();

            bool found = false;
            foreach (string item in Product)
            {
                if (item.ToLower().Contains(keyword))
                {
                    Console.WriteLine("Product found: " + item);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No products found with the keyword: " + keyword);
            }

        }
    }
}
