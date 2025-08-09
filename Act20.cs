using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>();
            int countA = 0, countB = 0, countC = 0, countD = 0, countF = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                int grade = int.Parse(Console.ReadLine());
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

            Console.WriteLine("\nNumerical Grades:");
            for (int i = 0; i < grades.Count; i++)
            {
                Console.Write(grades[i] + " ");
            }

            Console.WriteLine("\n\nGrade Summary:");
            Console.WriteLine("A: " + countA);
            Console.WriteLine("B: " + countB);
            Console.WriteLine("C: " + countC);
            Console.WriteLine("D: " + countD);
            Console.WriteLine("F: " + countF);
        }
    }
}

    
