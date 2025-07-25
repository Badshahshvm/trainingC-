using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class DuplicateElemnt
    {
        public static void findDuplicateElement(int[] a)
        {
            HashSet<int> h = new HashSet<int>();
            foreach (int i in a)
            {
                if(h.Contains(i))
                {
                    Console.WriteLine(i + " ");
                }
                h.Add(i);
            }
            
        }
    }
}
