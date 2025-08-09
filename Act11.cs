using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<float> salaries = new List<float>();

            Console.Write("Enter number of employees: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter employee {i + 1} name: ");
                names.Add(Console.ReadLine());

                Console.Write($"Enter employee {i + 1} salary: ");
                salaries.Add(float.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < count; i++)
            {
                if (salaries[i] < 15000)
                {
                    salaries[i] += salaries[i] * 0.05f;
                }
                else if (salaries[i] >= 15000 && salaries[i] <= 30000)
                {
                    salaries[i] += salaries[i] * 0.03f;
                }
            }

          
            Console.WriteLine("\nEmployees earning above 25,000 after adjustment:");
            for (int i = 0; i < count; i++)
            {
                if (salaries[i] > 25000)
                {
                    Console.WriteLine(names[i] + " - " + salaries[i]);
                }
            }
            }
    }
}
