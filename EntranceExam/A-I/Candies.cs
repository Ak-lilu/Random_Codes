using System;
using System.Collections.Generic;

namespace EntranceExam
{
    class Candies
    {
        public void CandyProblem()
        {
            Console.WriteLine("Enter the number of children ...");
            int n = int.Parse(Console.ReadLine());
            List<int> distributedCandy = new List<int>();
            int[] arr = new int[n];
            Console.WriteLine("Enter their scores ...");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] left = new int[n];
            int[] right = new int[n];
            left[0] = 1;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] <= arr[i - 1])
                {
                    left[i] = 1;
                }
                else
                {
                    left[i] = left[i - 1] + 1;
                }
                
            }
            right[n - 1] = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] <= arr[i + 1])
                {
                    right[i] = 1;
                }
                else
                {
                    right[i] = right[i + 1] + 1;
                }
                
            }

            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                int max = Math.Max(right[i], left[i]);
                answer += max;
                distributedCandy.Add(max);
            }


            Console.WriteLine("Total: " + answer);
            
            Console.WriteLine("Left  : "+string.Join(",", left));
           Console.WriteLine("Right : "+string.Join(",", right));
            Console.WriteLine("Final : "+string.Join(",", distributedCandy));
        }
    }
}
