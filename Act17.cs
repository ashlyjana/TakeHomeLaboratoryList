using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> uniqueWords = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter sentence {i + 1}: ");
                string sentence = Console.ReadLine();

                string[] words = sentence.Split(' ');

                for (int j = 0; j < words.Length; j++)
                {
                    string word = words[j].ToLower();

                    word = word.Trim(new char[] { '.', ',', '!', '?', ';', ':' });

                    if (!uniqueWords.Contains(word) && word != "")
                    {
                        uniqueWords.Add(word);
                    }
                }
            }

            uniqueWords.Sort();

            Console.WriteLine($"\nTotal unique words: {uniqueWords.Count}");
            Console.WriteLine("Unique words:");
            for (int i = 0; i < uniqueWords.Count; i++)
            {
                Console.WriteLine(uniqueWords[i]);
            }
        }
    }
}
