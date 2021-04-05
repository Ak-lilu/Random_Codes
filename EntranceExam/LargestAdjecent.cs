using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    public class LargestAdjacent
    {
        public int LargestAdjacentSum(int[] array)
        {
            if (array.Length < 2) return array[0];
            if (array == null || array.Length == 0) return 0;
                int max = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] + array[i + 1] > max)
                {
                    max = array[i] + array[i + 1];
                }
            }
            return max;
        }
    }
}
