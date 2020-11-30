using System;

namespace fundamentalsI
{
    class Program
    {
        public static void oneToTwoFiftyFive()
        {
            for(int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        public static void threeOrFive()
        {
            for(int i = 1;i <= 100;i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    if(i % 3 != 0 || i % 5 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        public static void fizzBuzz()
        {
            for(int i = 0; i <= 100; i++)
            {
                if( i % 3 == 0 || i % 5 == 0 )
                {
                    if(i % 3 == 0 && i % 5 != 0)
                    {
                        Console.WriteLine("Fizz " + i);
                    }
                    else if(i % 5 == 0 && i % 3 !=0)
                    {
                        Console.WriteLine("Buzz " + i);
                    }
                    else
                    {
                        Console.WriteLine("FizzBuzz " + i);
                    }
                }
            }
        }
        public static void whileOneToTwoFiftyFive()
        {
            int i = 1;
            while(i <= 255)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public static void whileThreeOrFive()
        {
            int i= 1;
            while(i <= 100)
            {
                if(i % 3 ==0 || i % 5 ==0 )
                {
                    if(i % 3 != 0 || i % 5 != 0){
                        Console.WriteLine(i);
                    }
                }
                i++;
            }
        }
        public static void whileFizzBuzz()
        {
            int i =1;
            while(i <= 100)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    if(i % 5 != 0)
                    {
                        Console.WriteLine("Fizz " + i);
                    }
                    else if(i % 3 != 0)
                    {
                        Console.WriteLine("Buzz " + i);
                    }
                    else
                    {
                        Console.WriteLine("FizzBuzz " + i);
                    }
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
            // oneToTwoFiftyFive();
            // threeOrFive();
            // fizzBuzz();
            // whileOneToTwoFiftyFive();
            // whileThreeOrFive();
            // whileFizzBuzz();
        }
    }
}
