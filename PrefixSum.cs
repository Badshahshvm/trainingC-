using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class PrefixSum
    {
        public static int[] prefixArray(int[]a)
        {
            int[] p = new int[a.Length];
            p[0] = a[0];
            for(int i=1;i<a.Length;i++)
            {
                p[i] = p[i - 1] + a[i];
            }
            return p;
        }

       
    }
}
