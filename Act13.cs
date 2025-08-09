using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>();
            List<int> scores = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter student {i + 1} name: ");
                studentNames.Add(Console.ReadLine());

                Console.Write($"Enter score for {studentNames[i]}: ");
                scores.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < scores.Count - 1; i++)
            {
                for (int j = i + 1; j < scores.Count; j++)
                {
                    if (scores[j] > scores[i])
                    {

                        int tempScore = scores[i];
                        scores[i] = scores[j];
     
                        string tempName = studentNames[i];
                        studentNames[i] = studentNames[j];
                        studentNames[j] = tempName;
                    }
                }
            }

            Console.WriteLine("\nTop 3 Performers:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i + 1}. {studentNames[i]} - {scores[i]}");
            }
        }
    }
}
