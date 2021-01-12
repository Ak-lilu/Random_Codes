
using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    public class SequenciallyBounded
    {
        public int isSequentiallyBounded(int[] a)
        {
            // check each element
            //{1,2,3,4,4}
            if (a.Length < 1) return 1;
            for (int i = 0; i < a.Length; i++)
            {
                // check how many times happened
                int count = 0;
                for (int e = i + 1; e < a.Length; e++)
                {
                   

                    if (a[i] >  a[e] || a[i] < 0)
                    {
                        return 0;
                    }
                    if(a[i] == a[e])
                    {
                        count++;
                        if (a[i] <= count)
                        {
                            return 0;
                        }
                    }
                }
            }
            return 1;
        }
    }
}
