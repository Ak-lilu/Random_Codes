using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    public class FullnessQuotient
    {
        public int isPacked(int[] array)
        {
            
            int currentStart = 0;
            var start = array[0];
            List<int> list = new List<int>();
            for (int i = currentStart; i < array.Length; i++)
            {
                start = array[i];
                if (!list.Contains(array[i]))
                {
                    for (int p = 0; p < array[p]; p++)
                    {
                      if(start==array[p])
                            //Console.WriteLine(array[p]);
                        list.Add(array[i]);
                        currentStart++;
                    }
                }
            }
            if(array.Length == list.Count)
            {
                return 1;
            }
            return 0;
        }
    }
}
