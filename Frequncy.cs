using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Frequncy
    {

        public static void countFfrquency(int[] a)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            for(int i =0;i<a.Length;i++)
            {
                if (d.ContainsKey(a[i]))
                  d[a[i]]++;
                else
                 d[a[i]] = 1;
            }

            Console.WriteLine("Element : Frequency");
            foreach (var kvp in d)
            {
                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
            }
        }
    }
}
