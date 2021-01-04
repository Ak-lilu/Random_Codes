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
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] <= 0) continue;
                    if (isPerfectSquare(arr[i]+arr[j]) == 1)
                    {
                        count++;
                    }
                }
                
            }
            return count;
        }
        int isPerfectSquare(int n)
        {
            double root = Math.Sqrt(n);
            if(n == Math.Pow(root, 2))
            {
                return 1;
            }
            return 0;
        }
            //;
            //
            //var newDictionary = new Dictionary<int, int>();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        newDictionary.Add( arr[i], arr[i + 1] );
            //    }
            //}
            //var lists = newDictionary.Select(p => new Dictionary<int, int>() { { p.Key, p.Value } });

            //return lists.ToList();
        }
    }

