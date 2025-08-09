using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> formattedNames = new List<string>();

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Enter full name:");
                string name = Console.ReadLine();
                names.Add(name);

                string[] parts = name.Split(' ');
                string formattedName = "";

                for (int j = 0; j < parts.Length; j++)
                {
                    if (parts[j].Length > 0)
                    {
                        formattedName += parts[j].Substring(0, 1).ToUpper() +
                                         parts[j].Substring(1).ToLower() + " ";
                    }
                }

                formattedNames.Add(formattedName.Trim());
            }
            Console.WriteLine("Formatted Names:");
            for (int i = 0; i < formattedNames.Count; i++)
            {
                Console.WriteLine(formattedNames[i]);
            }
        }
    }
}
