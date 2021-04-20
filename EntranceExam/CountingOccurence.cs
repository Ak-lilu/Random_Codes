using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class CountingOccurence
    {
        private static void countingOccurence(int[] array)
        {
            int[] v = new int[array.Length];
            int[] c = new int[] { };
            int a = 0, b = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(v[i]);

            }
            Console.WriteLine("unique :" + string.Join(",", v));
            Console.WriteLine("count : " + string.Join(",", c));
        }
    }
}
