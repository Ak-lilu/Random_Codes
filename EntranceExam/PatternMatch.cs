using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
   public class PatternMatch
    {
        public int Pattern(int[] array, int[] pattern)
        {
            int sum = 0;
            for (int i = 0; i < pattern.Length; i++)
            {
                sum += Math.Abs(pattern[i]);
            }
            if (sum != array.Length) return 0;
            int val = 1;
            int skipValue = 0;
            for (int p = 0; p < pattern.Length; p++)
            {
                int len = Math.Abs(pattern[p]);
                int currentend = len + skipValue;
                for (int i = skipValue; i < currentend; i++)
                {
                    // Console.WriteLine("Raw : "+array[i]);
                    if (pattern[p] > 0)
                    {
                        if (array[i] < 0)
                        {
                            val = 0;

                            return val;
                        }

                        // Console.WriteLine("cooked : "+array[i]);
                    }
                    else if (pattern[p] < 0)
                    {
                        if (array[i] > 0)
                        {
                            val = 0;
                            return val;
                        }

                    }
                }
                //Console.WriteLine("Skip value" + skipValue);
                skipValue = skipValue + len;
            }
            return val;
        }
    }
}
