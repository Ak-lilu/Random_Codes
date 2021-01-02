using System;
using System.Collections.Generic;

namespace EntranceExam
{
    partial class Program
    {
        class PrimeNumbers
        {
            private List<int> FindFactors(int thevalue)
            {
                int mid = thevalue / 2;
                List<int> list = new List<int>();
                for (int i = 1; i <= mid; i++)
                {
                    if (thevalue % i == 0)
                    {
                        list.Add(i);
                    }
                }
                return list;
            }
            int primeCount(int start, int end)
            {
                int counter = 0;


                for (int i = start; i <= end; i++)
                {
                    List<int> nums = FindFactors(i);
                    if (nums.Count == 1)
                    {
                        Console.WriteLine(i);
                        counter++;
                    }
                }
                return counter;
            }
        }
    }
}
