using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class DateAndTimeCocept
    {
        public static void basicCoceptDateandTime()
        {
            //Default Date and Time:-

            DateTime dt = new DateTime();
            Console.WriteLine(dt.ToString());

            //Date and timw with specific motnth, day and year :-

            DateTime dt2 = new DateTime(2003, 02, 23);

            Console.WriteLine(dt2.ToString());

            //Date and Time with sepcific month, year, day alog with time

            DateTime dt3 = new DateTime(2003, 02, 23, 12, 34,30);
            Console.WriteLine(dt3.ToString());

            //Anonymous Type :-

   
          var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
            Console.WriteLine(student.Id);
            Console.WriteLine(student.FirstName);


        }
    }
}
