using System;
using System.Linq;

namespace EntranceExam
{
    internal class IntersectionBase
    {
        int[] Intersection(int[] first, int[] second)
        {

            if (first == null || second == null) return null;
            if (first.Length == 0 || second.Length == 0)
            {
                return null;
            }
            else
            {
                int total = first.Length + second.Length;
                int[] a = new int[total];

                for (int i = 0, count = 0; i < first.Length; count++, i++)
                {
                    for (int j = 0; j < second.Length; j++)
                    {
                        if (first[i] == second[j])
                        {
                            a[i] = first[i];
                            Console.WriteLine(a[i]);
                        }
                    }
                }
                return a.ToArray();
            }
        }
    }
}