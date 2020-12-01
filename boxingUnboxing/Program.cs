using System;
using System.Collections.Generic;

namespace boxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
{
            List<object> thisList = new List<object>();
            thisList.Add(7);
            thisList.Add(28);
            thisList.Add(-1);
            thisList.Add(true);
            thisList.Add("chair");
            int sum = 0;
            foreach(var them in thisList)
            {
                Console.WriteLine(them);
                if(them is int)
                {
                    sum += (int)them;
                }
            }
            Console.WriteLine($"Sum is : {sum}");
        }
    }
}
