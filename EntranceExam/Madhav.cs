using System;

namespace EntranceExam
{
       public class Madhav
        {

             int isMadhavArray(int[] a)
            {
                //get length
                int num = a.Length, counter = 0, sum = 0, previousSum = 0;
                for (int i = 1; i < a.Length - 1; i++)
                {
                    previousSum = sum;
                    while (counter < i)
                    {
                        sum += a[i];
                        counter--;
                        Console.WriteLine("Sum " + sum);
                        counter++;
                    }
                    Console.WriteLine(previousSum);
                    //  counter--;

                }
                return 0;
            }
        }
    }

