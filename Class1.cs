using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
  public class Class1
    {
        public static bool binarySearch(int[] a, int target)
        {
            int i = 0;
            int j = a.Length - 1;
            Array.Sort(a);
            while (i <= j)
            {
                int mid = i + (j - i) / 2; ;

                if (a[mid] == target)
                {
                    return true;
                }
                else if (target > a[mid])
                {
                    i = mid + 1;
                }
                else
                {
                    {
                        j = mid - 1;
                    }
                }

            }
            return false;
        }
    }
}
