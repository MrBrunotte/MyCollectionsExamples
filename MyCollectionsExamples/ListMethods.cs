using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollectionsExamples
{
    class ListMethods
    {
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
