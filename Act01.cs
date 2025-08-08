using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string input;
            int countA = 0;

            Console.WriteLine("Enter student names (type 'done' to finish):");

            while (true)
            {
                input = Console.ReadLine();

                if (input.Equals("done", StringComparison.OrdinalIgnoreCase))
                    break;

                names.Add(input);
            }

            Console.WriteLine("Attendance List in UPPERCASE:");
            foreach (string name in names)
            {
                string upperName = name.ToUpper();
                Console.WriteLine(upperName);

                if (upperName.StartsWith("A"))
                    countA++;
            }

            Console.WriteLine($"\nNumber of names starting with 'A': {countA}");
        }
    
    }
}

