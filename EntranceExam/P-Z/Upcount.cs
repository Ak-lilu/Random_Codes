using System;

namespace EntranceExam
{
        class Upcount
        {


            int nUpcount(int[] a, int n)
            {
                //LOGIC
                // PARTIAL SUM
                int sum = 0, count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    var previousSum = sum;

                    sum += a[i];
                    Console.WriteLine($"Sum {sum}");
                    if (previousSum <= n && sum > n)
                    {

                        count++;
                        Console.WriteLine("Count : " + count);
                    }

                }
                //UPCOUNT
                return count;
            }
        }
    }

