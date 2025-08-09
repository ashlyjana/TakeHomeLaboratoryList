using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> attendees = new List<string>();

            Console.Write("Enter number of logins: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                if (!attendees.Contains(name, StringComparer.OrdinalIgnoreCase))
                {
                    attendees.Add(name);
                }
            }

            attendees.Sort(StringComparer.OrdinalIgnoreCase);

            Console.WriteLine($"\nTotal unique attendees: {attendees.Count}");
            Console.WriteLine("Attendee List:");
            for (int i = 0; i < attendees.Count; i++)
            {
                Console.WriteLine(attendees[i]);
            }
        }
    }
}
