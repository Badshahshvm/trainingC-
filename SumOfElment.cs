using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class SumOfElment
    {
        public static int sumOfElemnt(int[] a)
        {
            int sum = 0;
            for(int i=0;i<a.Length;i++)
            {
                sum += a[i];
            }

            return sum;

        }
    }
}
