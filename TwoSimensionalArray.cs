using System;

namespace Day3
{
    internal class TwoDimensionalArray
    {
        public static void create2dArray()
        {
            int[,] a = new int[3, 4];

            Console.WriteLine("Enter elements for 3x4 matrix:");

            for (int i = 0; i < a.GetLength(0); i++)  
            {
                for (int j = 0; j < a.GetLength(1); j++) 
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            display2DArray(a);
        }

        public static void display2DArray(int[,] a)
        {
            Console.WriteLine("\nMatrix elements:");

            for (int i = 0; i < a.GetLength(0); i++)  // rows
            {
                for (int j = 0; j < a.GetLength(1); j++)  // columns
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
