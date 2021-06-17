using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class StackedNumber
    {
        int isStackedNumber(int n)
        {

            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    sum += j;
                    // Console.Write(sum+" "+j);

                    if (sum == n)
                    {
                        // Console.WriteLine("\nFound: " + n);
                        return 1;
                    }
                }
                //Console.WriteLine();
            }
            return 0;
        }
    }
}
