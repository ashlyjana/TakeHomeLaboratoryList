using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"Enter numbers {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);

                if (num % 2 == 0)
                {
                    evenList.Add(num);
                }
                else
                {
                    oddList.Add(num);
                }
            }

            Console.WriteLine("Even Numbers:");
            for (int i = 0; i < evenList.Count; i++)
            {
                Console.Write(evenList[i] + " ");
            }

            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddList.Count; i++)
            {
                Console.Write(oddList[i] + " ");
            }
        }
    }
}
