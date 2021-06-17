using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class Unique
    {
        int nUnique(int[] a, int n)
        {
            int count = 0;
            int unique = 0;
            if (a.Length < 2) return count;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == n)
                    {
                        count++;
                    }
                }
            }
            if (count == 1)
            {
                unique = 1;
            }
            return unique;
        }
    }
}
