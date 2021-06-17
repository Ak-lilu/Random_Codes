using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EntranceExam
{
    public class MinMax
    {
        public int isMinMaxDisjoint(int[] a)
        {
            //{18, -1, 3, 4, 0}
            if (a.Length <= 2) return 0;
            int min = 0, max = 0, mincounter= 0, maxcounter=0;
            List<int> list = new List<int>();
            foreach (var item in a)
            {
                list.Add(item);
            }
            min = list.Min();
            max = list.Max();
           // Console.WriteLine("Min : "+ min + " Max : "+ max);
            
           if(min == max)
            {
                return 0;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == min)
                {
                    mincounter++;
                }

                if(a[i] == max)
                {
                    maxcounter++;
                }
            }
            if(mincounter>1 || maxcounter > 1)
            {
                return 0;
            }
            if (Array.IndexOf(a, min) == Array.IndexOf(a, max) + 1 || Array.IndexOf(a, min) == Array.IndexOf(a, max) - 1)
            {
                return 0;
            }
            return 1;
        }
    }
}
