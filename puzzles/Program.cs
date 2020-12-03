using System;
using System.Collections.Generic;

namespace puzzles
{
    class Program
    {
        public static List<string> Names()
        {
            List<string> names = new List<string>()
            {
                "Todd",
                "Syd",
                "Tiffany",
                "Charlie",
                "Geneva"
            };
            int i = 0;
            Random rand = new Random();
            while(i < names.Count)
            {
                rand.Next(6);
                
                Console.WriteLine(names[i]);
                // if(names[i].Length < 5)
                // {
                //     names.RemoveAt(i);
                // }
                i++;
            }
            return (List<string>) names;
            // Names
            // Build a function Names that returns a list of strings.  In this function:

            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            // Shuffle the list and print the values in the new order
            // Return a list that only includes names longer than 5 characters
            // var list = new List<string>{"CT", "MA", "VA", "NY"};
            // var order = new List<int>{2, 0, 1, 3};
            // var result = order.Select(i => list[i]).ToList();
        }
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int[] randArrayOfInts = new int[10];
            int sum = 0;
            int i = 0;
            int max = 0;
            int min = 25;
            while(i < randArrayOfInts.Length){
                randArrayOfInts[i] = rand.Next(4,26);
                Console.WriteLine(randArrayOfInts[i]);
                if(randArrayOfInts[i] > max)
                    max = randArrayOfInts[i];
                else if(randArrayOfInts[i] < min)
                    min = randArrayOfInts[i];
                sum += randArrayOfInts[i];
                i++;
            }
            Console.WriteLine($"Sum: {sum}, Max: {max}, Min: {min}");
            return randArrayOfInts;
        }
        static string TossCoin()
        {
            Console.WriteLine("Tossing a Coin!");
            List<string> CoinSide = new List<string>()
            {
                "Heads",
                "Tails"
            };
            Random rand = new Random();
            string resultzz = CoinSide[rand.Next(2)];
            Console.WriteLine(resultzz);
            return resultzz;
        }
        static double TossMultiCoin(int num)
        {
            int headCount = 0;
            int iteration = 0;
            while(iteration < num)
            {
                if(TossCoin()=="Heads")
                    headCount++;
                iteration++;
            }
            double tossRatio = (double)headCount/(double)num;
            return tossRatio;
        }
        static void Main(string[] args)
        {
            // TossCoin();
            TossMultiCoin(5);
            // RandomArray();
            // Names();
        }
    }
}
