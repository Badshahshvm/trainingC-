using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class BitwiseDemo
    {

        public static void demoOfBiwtwiseOperators(int a,int b)
        {
            Console.WriteLine("a = {0}, b = {1}", a, b);

            Console.WriteLine("a & b = " + (a & b));  // 0101 & 0011 = 0001 => 1
            Console.WriteLine("a | b = " + (a | b));  // 0101 | 0011 = 0111 => 7
            Console.WriteLine("a ^ b = " + (a ^ b));  // 0101 ^ 0011 = 0110 => 6
            Console.WriteLine("~a = " + (~a));        // ~0101 = 1010 (in 32-bit: -6)
            Console.WriteLine("a << 1 = " + (a << 1)); // 0101 << 1 = 1010 => 10
            Console.WriteLine("a >> 1 = " + (a >> 1)); // 0101 >> 1 = 0010 => 2
        }
    }
}
