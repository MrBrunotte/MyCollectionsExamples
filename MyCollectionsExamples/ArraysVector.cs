using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollectionsExamples
{
    public class ArraysVector
    {
        public static void ArrayInt()
        {
            // Vector - arrays (single row)
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] values = new int[3];
            values[0] = 5;
            values[1] = 6;
            values[2] = 7;
            Console.WriteLine("\nPrints an array of numbers from 1 - 10:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("\n#################\n");
        }
        public static void ArrayString()
        {
            string[] names = new string[3];
            names[0] = "Stefan";
            names[1] = "Viggo";
            names[2] = "Rebecca";
            Console.WriteLine("Prints an array of three strings:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("\n#################\n");
        }
    }
}
