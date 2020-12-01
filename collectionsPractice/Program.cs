using System;
using System.Collections.Generic;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] thisArray = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim","Martin","Nikki","Sara"};
            bool[] boolz = {true,false,true,false,true,false,true,false,true,false};
            List<string> flavors = new List<string>() {
                "vanila",
                "chocolate",
                "strawberry",
                "peach",
                "mango"
                };
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            foreach(string item in flavors)
            {
                Console.WriteLine("*****");
                Console.WriteLine(item);
                Console.WriteLine("*****");
            }
            Console.WriteLine(flavors.Count);
            Dictionary<string,string> names2 = new Dictionary<string, string>();
            Random rand = new Random();
            int i = 0;
            while(i < names.Length)
            {
                names2.Add(names[i],flavors[rand.Next(0,4)]);
                i++;
            }
            foreach(KeyValuePair<string,string> pair in names2)
            {
                Console.WriteLine(pair);
            }

            // Add key/value pairs to this dictionary where:
            // each key is a name from your names array
            // each value is a randomly select a flavor from your flavors list.
        }
    }
}
