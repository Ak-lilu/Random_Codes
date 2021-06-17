using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EntranceExam
{
   public class Square
    {
        int isSquare(int n)
        {
            int Square = 0;
            double root = Math.Sqrt(n);
            if ((int)root * (int)root == n)
            {
                Square = 1;
                return Square;
            }
            return Square;
        }
            public int isVanilla(int[] a)
            {
            int temp = 0;
            int firstdigit = a[0] % 10;
            int currentElement = 0;
            for (int i = 0; i < a.Length; i++)
            {
                currentElement = a[i];
                while(currentElement != 0)
                {
                    temp = currentElement % 10;
                    if(Math.Abs(firstdigit) != Math.Abs(temp))
                    {
                        return 0;
                    }
                    currentElement = currentElement / 10;
                }
            }
            return 1;
            }
        public int isTrivalent(int[] array)
        {
            List<int> unique = new List<int>();
            for (int d = 0; d < array.Length; d++)
            {
                if (!unique.Contains(array[d]))
                {
                    unique.Add(array[d]);
                }
            }
            if(unique.Count == 3)
            {
                return 1;
            }
            return 0;
        }
        int squarePair(int[] aaa)
        {
            int[] array = { 9, 0, 2, -5, 7 };
            int len = array.Length;
         
            var pairs =
                from i in Enumerable.Range(0, len - 1)
                where array[i] > 0
                from j in Enumerable.Range(i + 1, len - i - 1)
                where array[j] > 0
                let sqrt = (int)Math.Sqrt(array[i] + array[j])
                where array[i] + array[j] == sqrt * sqrt
                select new
                {
                    A = Math.Min(array[i], array[j]),
                    B = Math.Max(array[i], array[j])
                };
          
            return pairs.Count();
        }
         public  int countofSquarePair(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] <= 0 && arr[i]<=0) continue;
                    if (isPerfectSquare(arr[i]+arr[j]) == 1)
                    {
                        count++;
                    }
                }
                
            }
            return count;
        }
        public int isPerfectSquare(int n)
        {
            double root = Math.Sqrt(n);
            if(n == Math.Pow(root, 2))
            {
                return 1;
            }
            return 0;
        }
                public int isDivisible(int[] array, int divisor)
                {
                    int value = 1;
                        for (int i = 0; i < array.Length; i++)
                        {
                            if(array[i]%divisor != 0)
                            {
                                 return 0;
                            }

                        }
                    return value;
                }
        }
    }

