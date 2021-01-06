using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntranceExam
{
    class Henry
    {
        public List<int> isDivisible(int n)
        {
            int mid = n/2;
            List<int> list = new List<int>();
            for (int i = 1; i <= mid; i++)
            {
                if (n % i == 0)
                {
                    list.Add(i);
                }

            }
            return list;
        }
        public int[] perfectNumber(int i, int j)
        {
            int[] theNumbers =  new int[2];
            int n = int.MaxValue;
            int the_main_number = 5;
            int count = 0;
            
            for (int L = the_main_number; L < n; L++)
            {
                int sum = isDivisible(L).Sum();
                if (L == sum)
                {
                    count++;
                    if(i == count)
                    {
                        theNumbers[0] = L;
                    }
                    if(j == count)
                    {
                        theNumbers[1] = L;
                        return theNumbers;
                    }
                }
            }
            return theNumbers;
        }
    }
}
