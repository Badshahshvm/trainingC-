using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class ArrayConcept
    {

        public static void arryConcept()
        {
            //Initializatio
            int[] a = new int[5];
            int[] b = new int[5] { 1, 2, 3, 4, 5 }
            int[] c = { 1, 2, 3, 45 };
            //insert a elemnt in an empty array usinh user input
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            //For Displaying a arrays elemnt
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + " ");
            }

        }

      

    }
}
