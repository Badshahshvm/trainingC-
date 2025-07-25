using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class MaxiAndMinElemnt
    {

        //Find Maximum element in array
        public static int findMax(int[]a)
        {
            int max = int.MinValue;
            //int min = int.MaxValue;

            for(int i=0;i<a.Length;i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }

            }
            return max;

        }
        //Find Minimum element in an array

        public static int findMin(int[]a)
        {
            int min = int.MaxValue;
            for(int i=0;i<a.Length;i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
    }
}
