using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> originalWords = new List<string>();
            List<string> modifiedWords = new List<string>();

            Console.Write("Enter number of words: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter word {i + 1}: ");
                string word = Console.ReadLine();
                originalWords.Add(word);

                string modified = "";
                for (int j = 0; j < word.Length; j++)
                {
                    char ch = word[j];
                    if ("aeiouAEIOU".Contains(ch))
                    {
                        modified += "*";
                    }
                    else
                    {
                        modified += ch;
                    }
                }

                modifiedWords.Add(modified);
            }

            Console.WriteLine("\nOriginal  - Modified");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{originalWords[i]}  - {modifiedWords[i]}");
            }
        }
    }
}
