using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class StringAndStringBuilder
    {

        public static void stringConcept()
        {
            string fname = "Shivam";
            string lname = "Kumar";
            string fullname = fname + " " + lname;
            Console.WriteLine("Full Name: " + fullname);


            string name = "  Shivam Kumar  ";

            // Remove leading and trailing spaces
            string trimmed = name.Trim();
            Console.WriteLine("Trimmed: '" + trimmed + "'");

            // Convert to upper and lower case
            Console.WriteLine("Upper: " + trimmed.ToUpper());
            Console.WriteLine("Lower: " + trimmed.ToLower());

            // Check if it contains a word
            Console.WriteLine("Contains 'Kumar': " + trimmed.Contains("Kumar"));

            // Replace a word
            string replaced = trimmed.Replace("Kumar", "Raj");
            Console.WriteLine("After Replace: " + replaced);

            // Get substring
            string sub = trimmed.Substring(0, 6);
            Console.WriteLine("Substring (0,6): " + sub);

            // Split the string
            string[] parts = trimmed.Split(' ');
            Console.WriteLine("First Part: " + parts[0]);
            Console.WriteLine("Second Part: " + parts[1]);

            // String length
            Console.WriteLine("Length: " + trimmed.Length);
        }
    }
}
