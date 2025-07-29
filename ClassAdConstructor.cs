using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class ClassAdConstructor
    {
        // Static Members
        public static string CollegeName;
        public static string City;

        // Static Constructor
        static ClassAdConstructor()
        {
            CollegeName = "MIT Muzaffarpur";
            City = "Muzaffarpur";
            Console.WriteLine("Static Constructor Called: College Info Initialized");
        }

        // Static Method
        public static void DisplayCollegeDetails()
        {
            Console.WriteLine("College Name: " + CollegeName);
            Console.WriteLine("City: " + City);
        }
    }


}
