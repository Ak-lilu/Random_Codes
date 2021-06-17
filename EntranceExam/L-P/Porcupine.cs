using System;
using System.Collections.Generic;
using System.Text;

namespace EntranceExam
{
    class Porcupine
    {
        int isDivisionCounter(int n)
        {
            int count = 0;
            int mid = n / 2;
            for (int i = 1; i < mid; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
        int findPorcupineNumber(int n)
        {
            int thenextPrime = 0;
            int thePorcupineNumber = 0;
            bool porcupine = false;
            int max = int.MaxValue;
            n++;
            while (n <= max)
            {
                if (porcupine)
                {
                    if (n % 10 == 9 && isDivisionCounter(n) == 1)
                    {
                        porcupine = true;
                        break;
                    }
                    else
                    {
                        porcupine = false;
                    }

                }
                else
                {
                    if ((isDivisionCounter(n) == 1) && (n % 10 == 9))
                    {
                        porcupine = true;
                        thePorcupineNumber = n;
                    }

                }
                n++;
            }


            return n;
        }


    }
}
