using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            int countA = 0;
            int countB = 0;
            int countC = 0;
            int countD = 0;
            int countF = 0;

            Console.WriteLine("Students Grades:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter grade for student {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
                {
                    grades.Add(grade);
                    switch (grade / 10)
                    {
                        case 10: 
                        case 9:
                            countA++;
                            break;
                        case 8:
                            countB++;
                            break;
                        case 7:
                            countC++;
                            break;
                        case 6:
                            countD++;
                            break;
                        default:
                            countF++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input:");
                    i--;
                }
            }

            Console.WriteLine("Grade Summary:");
            Console.WriteLine($"A: {countA}");
            Console.WriteLine($"B: {countB}");
            Console.WriteLine($"C: {countC}");
            Console.WriteLine($"D: {countD}");
            Console.WriteLine($"F: {countF}");
        }
    }
}
