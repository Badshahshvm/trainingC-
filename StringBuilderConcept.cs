using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class StringBuilderConcept
    {

        public static void basicStringBuilderConcept()
        {

            // Create a StringBuilder instance
            StringBuilder sb = new StringBuilder("Hello");

            // Append text
            sb.Append(" World");
            Console.WriteLine("After Append: " + sb.ToString());

            // Insert text at a specific index
            sb.Insert(6, "Beautiful ");
            Console.WriteLine("After Insert: " + sb.ToString());

            // Replace part of the string
            sb.Replace("Beautiful", "Awesome");
            Console.WriteLine("After Replace: " + sb.ToString());

            // Remove a range of characters
            sb.Remove(6, 8); // Removes "Awesome "
            Console.WriteLine("After Remove: " + sb.ToString());

            // Access individual characters
            Console.WriteLine("First character: " + sb[0]);

            // Capacity and Length
            Console.WriteLine("Length: " + sb.Length);
            Console.WriteLine("Capacity: " + sb.Capacity);
        }
    }
}
