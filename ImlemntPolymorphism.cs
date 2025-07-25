using System;
using System.Collections.Generic;

namespace Day3
{
    internal class ImlemntPolymorphism
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public virtual void greet()
        {
            Console.WriteLine("hello world!!!!");
        }
    }

    class Child : ImlemntPolymorphism
    {
        public override void greet()
        {
            Console.WriteLine("Namastey");
        }
    }
}