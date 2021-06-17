using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class FindDepth
    {
        int ComputeDepth(int n)
        {
            int depth = 0;
            int multiplier = 1;
            List<char> finalArray = new List<char>();
            do
            {
                var a = n * multiplier;
                char[] arr = a.ToString().ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!finalArray.Contains(arr[i]))
                    {
                        finalArray.Add(arr[i]);
                    }
                }
                depth++;
                multiplier++;
            }
            while (finalArray.Count != 10);
            return depth;
        }
    }
}
