using System;

namespace basic13
{
    class Program
    {
// Print all of the integers from 1 to 255.
        public static void PrintNumbers()
        {
            int i = 1;
            while(i <= 255)
            {
                Console.WriteLine(i);
                i++;
            }
        }

// Print all of the odd integers from 1 to 255.
        public static void PrintOdds()
        {
            int i = 1;
            while(i <= 255)
            {
                Console.WriteLine(i);
                i+=2;
            }
        }

// Print all of the numbers from 0 to 255, 
// but this time, also print the sum as you go. 
// For example, your output should be something like this:
        public static void PrintSum()
        {
            int i = 0;
            int sum = 0;
            while(i <= 255)
            {
                sum += i;
                Console.WriteLine($"New number: { i } Sum: { sum }");
                i++;
            }
        }

// Write a function that would iterate through each item of the given integer array and print each value to the console. 
        public static void LoopArray(int[] numbers)
        {
            int i = 0;
            while(i < numbers.Length-1){
                i++;
                Console.WriteLine(numbers[i]);
            }
            
        }


// Write a function that takes an integer array and prints and returns the maximum value in the array. 
// Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), or even a mix of positive numbers, negative numbers and zero.
        public static int FindMax(int[] numbers)
        {
            int max = 0;
            int i = 0;
            while(i < numbers.Length)
            {
                if(numbers[i]>max)
                    max = numbers[i];
                i++;
            }
            Console.WriteLine(max);
            return max;
            
        }

// Write a function that takes an integer array and prints the AVERAGE of the values in the array. For example, with an array [2, 10, 3], your program should write 5 to the console.
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach(int item in numbers)
            {
                sum += item;
            }
            double avg = (double)sum / (double)numbers.Length;
            Console.WriteLine(avg);
        }
// Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        public static int[] OddArray()
        {
            int i = 0;
            int oddCount = 0;
            while(i <= 255)
            {
                if(i % 2 != 0)
                {
                    oddCount++;
                }
                i++;
            }
            int[] thisArray = new int[oddCount];
            i = 0;
            while(i < thisArray.Length)
            {
                if(i==0)
                    thisArray[i] = 1;
                else if(i!=0)
                    thisArray[i] = thisArray[i-1]+2;
                Console.WriteLine(thisArray[i]);
                i++;
            }
            return thisArray;
        }


// Write a function that takes an integer array, and a integer "y" and returns the number of array valuesThat are greater than the "y" value.For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 (since there are two values in the array that are greater than 3).
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            int i = 0;
            while(i < numbers.Length)
            {
                if(numbers[i]> y){
                    count++;
                }
                i++;
            }
            return count;
        }

// Write a function that takes an integer array "numbers", and then multiplies each value by itself.For example, [1,5,10,-10] should become [1,25,100,100]
        public static void SquareArrayValues(int[] numbers)
        {
            int index = 0;
            while(index < numbers.Length)
            {
                numbers[index] = numbers[index] * numbers[index];
                Console.WriteLine(numbers[index]);
                index++;
            }
            
        }

// Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        public static void EliminateNegatives(int[] numbers)
        {
            int index = 0;
            while(index < numbers.Length)
            {
                if(numbers[index]<0)
                    numbers[index] = 0;
                Console.WriteLine(numbers[index]);
                index++;
            }
        }

// Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, the minimum value in the array, and the average of the values in the array.
        public static void MinMaxAverage(int[] numbers)
        {
            int max = 0;
            int index = 0;
            int sum = 0;
            int min = numbers[index];
            while(index < numbers.Length)
            {
                sum += numbers[index];
                if(numbers[index] < min)
                    min = numbers[index];
                else if(numbers[index]>max)
                    max = numbers[index];
                index++;
            }
            Console.WriteLine($"Max: {max}, Min: {min}, Sum: {(double)sum / (double)numbers.Length}");
        }

// Given an integer array, say [1, 5, 10, 7, -2], Write a function that shifts each number by one to the front and adds '0' to the end. For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, it should become [5, 10, 7, -2, 0].

        public static void ShiftValues(int[] numbers)
        {
            int index = 0;
            while(index < numbers.Length-1)
            {
                numbers[index] = numbers[index+1];
                index++;
            }
            numbers[numbers.Length-1] = 0;
            foreach(int item in numbers)
                Console.WriteLine(item);
        }

// Write a function that takes an integer array and returns an object array that replaces any negative number with the string 'Dojo'. For example, if array "numbers" is initially [-1, -3, 2] your function should return an array with values ['Dojo', 'Dojo', 2].
        public static object[] NumToString(int[] numbers)
        {
            object[] newArray = new object[numbers.Length];
            int index = 0;
            while(index < numbers.Length)
            {
                if(numbers[index]<0)
                {
                    newArray[index] = "Dojo";
                }
                else if(numbers[index] >= 0 )
                    newArray[index] = numbers[index];
                Console.WriteLine(newArray[index]);
                index++;
            }
            return newArray;
        }

        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
            // FindMax(new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
            // GetAverage(new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
            // OddArray();
            // Console.WriteLine(GreaterThanY(new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9},5));
            // SquareArrayValues(new int[]{0, 1, 2, 3, -4, 5, 6, 7, -8, 9});
            // EliminateNegatives(new int[]{0, 1, 2, 3, -4, 5, 6, 7, -8, 9});
            // MinMaxAverage(new int[]{7,2,3,4,0,5});
            // ShiftValues(new int[]{5,4,3,2,1});
            // NumToString(new int[]{-5,4,-3,-2,1});
        }
    }
}
