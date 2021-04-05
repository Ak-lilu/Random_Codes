using System;
using System.Collections.Generic;
using System.Linq;

namespace EntranceExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {  };
            LargestAdjacent largestAdjacent = new LargestAdjacent();
            Console.WriteLine(largestAdjacent.LargestAdjacentSum(array));
        }

        private static int isLayered(int[] array)
        {
            if (array.Length < 2) return 0;
            if (array.Length == 2 && array.Distinct().Count() != 1) return 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                Console.WriteLine(i);
                int back = i - 1;
                int front = i + 1;
               Console.WriteLine("before :"+ array[back] + "current : " + array[i] + " next : "+ array[front]);
                if(array[i] > array[i + 1])
                {
                    return 0;
                }
                if (array[i] != array[back]) 
                {
                     if(array[i] != array[front])
                    {
                        return 1;
                    }   
                     else
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }

        private static int isAllPossibilities(int[] array)
        {
            int count = 0;
            if (array.Length == 0) return 0;
            if (array.Distinct().Count() != array.Length) return 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!array.Contains(i))
                {
                    return 0; 
                }
            }
            return 1;
        }

        static void min(int[] array)
        {
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
        private static void compareNumbers(int v1, int v2)
        {
            var result1 = 3 * (v1 * v1 * v1) / (3 * v1 - 2) - (2 * v1 + 4);
            var result2 = 3 * (v2 * v2 * v2) / (3 * v2 - 2) - (2 * v2 + 4);
            Console.WriteLine(Math.Max(result1,result2));
        }

        private static void countingOccurence(int[] array)
        {
            int[] v = new int[array.Length] ;
            int[] c = new int[] { };
            int a = 0, b = 0;
            for (int i = 0 ; i < array.Length; i++)
            {
                Console.WriteLine(v[i]);
               
            }
            Console.WriteLine("unique :"+string.Join(",", v));
            Console.WriteLine("count : "+string.Join(",", c));
        }
        static int[] reversingArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }
        static int Fibonacci(int num)
        {
            if (num <= 2)
                return 1;
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
        static float Power(float num, int tothepower)
        {
            if (tothepower == 1)
                return num;
            return num * Power(num, tothepower - 1);
        }
        static int recur(int num)
        {
            if (num == 1)
                return num;
            return num + 3 * recur(num - 1);
        }
        static int Factorial(int number){
            if (number == 1)
                return 1;
           return number * Factorial(number - 1);
          }
        static int poww(int num, int exp)
        {
            int final = 1;
            for (int i = exp; i > 0; i--)
            { 
                final *= num;
            }
            return final;
        }
} 
}

    
