using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class SolveTenFactorial
    {
        int Factorial(int n)
        {
            int fact = 1;
            while (n > 1)
            {
                fact *= n;
                n--;
            }
            return fact;
        }
        string SolveTen
        {
            get
            {
                int[] values = { };
                int tenFactorial = Factorial(10);
                for (int i = 1; i < 10; i++)
                {
                    for (int j = i + 1; j < 10; j++)
                    {
                        if (Factorial(i) + Factorial(j) == tenFactorial)
                        {
                            values[0] = i;
                            values[1] = j;
                            break;
                        }
                    }
                }

                return string.Join(",", values);
            }
        }
    }
}
