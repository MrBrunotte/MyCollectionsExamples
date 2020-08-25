using System;
using System.Collections.Generic;
using System.Windows.Markup;

namespace MyCollectionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the methods
            ArrayInt();
            ArrayString();
            GenericCollectionLists();


        }
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
       public static void GenericCollectionLists()
        {
            Console.WriteLine("A generic class is one that is not tied to a particular data type\n");
            Console.WriteLine("A list is a simple ordered list of items\n");

            //Declaration and initalization of a string list:
            List<string> names = new List<string>();

            names.Add("Peter");
            names.Add("Sven");
            names.Add("Calle");
            names.Add("Viggo");
            names.Add("Herman");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nAdding Dennis with the add() method");

            names.Add("Dennis");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nRemoving Sven with the remove() method");

            names.Remove("Sven");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nRemoving at index 3 (Herman) with the removeAt() method");

            names.RemoveAt(3);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }



                Console.WriteLine("\n#################\n");
        }
    }
}
