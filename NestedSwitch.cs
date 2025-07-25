using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class NestedSwitch
    {

        public static void nestedSwitch()
        {
            Console.Write("Enter category (A/B): ");
            char category = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter option (1/2): ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (category)
            {
                case 'A':
                    Console.WriteLine("Category A selected.");
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("You chose Option 1 under Category A.");
                            break;
                        case 2:
                            Console.WriteLine("You chose Option 2 under Category A.");
                            break;
                        default:
                            Console.WriteLine("Invalid option in Category A.");
                            break;
                    }
                    break;

                case 'B':
                    Console.WriteLine("Category B selected.");
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("You chose Option 1 under Category B.");
                            break;
                        case 2:
                            Console.WriteLine("You chose Option 2 under Category B.");
                            break;
                        default:
                            Console.WriteLine("Invalid option in Category B.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid category.");
                    break;
            }

        }
    }
}
