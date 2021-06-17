using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntranceExam
{
    class IsLayered
    {
        private static int isLayered(int[] array)
        {
            if (array.Length < 2) return 0;
            if (array.Length == 2 && array.Distinct().Count() != 1) return 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                Console.WriteLine(i);
                int back = i - 1;
                int front = i + 1;
                Console.WriteLine("before :" + array[back] + "current : " + array[i] + " next : " + array[front]);
                if (array[i] > array[i + 1])
                {
                    return 0;
                }
                if (array[i] != array[back])
                {
                    if (array[i] != array[front])
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }

        private static int isAllPossibilities(int[] array)
        {
            int count = 0;
            if (array.Length == 0) return 0;
            if (array.Distinct().Count() != array.Length) return 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!array.Contains(i))
                {
                    return 0;
                }
            }
            return 1;
        }

        static void min(int[] array)
        {
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }

    }
}
