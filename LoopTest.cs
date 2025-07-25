using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class LoopTest
    {

        public static void loopConcept(int n)
        {
            //For Loop
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(n * i + " ");
            }

            //while
            int t = 1;
            while (t <= 10)
            {
                Console.Write(n * t + " ");
                t++;
            }

            //do while loop
            int p = 1;
            do
            {
                Console.Write(n * p + " ");
                p++;


            }
            while (p <= 10);
        }
    }
}
