using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> BirthYears = new List<string>();
            int CurrentYear = DateTime.Now.Year;

            Console.WriteLine("Birth Year to Age Converted:");

            for (int i = 0; i < 5; i++)
            {
                string input;
                int BirthYear;

                while (true)
                {
                    Console.Write("Enter Birth Year Num" + (i + 1) + ": ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out BirthYear)) 
                    {
                        if (BirthYear > 1900 && BirthYear <= CurrentYear)
                        {
                            BirthYears.Add(input); 
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a realistic year between 1900 and the current year.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric year.");
                    }
                }
            }

            Console.WriteLine("Results:");
            for (int i = 0; i < BirthYears.Count; i++) 
            {
                int year = Convert.ToInt32(BirthYears[i]);
                int age = CurrentYear - year;

                string classification;
                if (age <= 17)
                {
                    classification = "Minor";
                }
                else if (age >= 60)
                {
                    classification = "Senior";  
                }
                else
                {
                    classification = "Adult";
                }

                Console.WriteLine($"Person #{i + 1}: Birth Year = {year}, Age = {age}, Classification = {classification}");
            }
        }
    }
}
