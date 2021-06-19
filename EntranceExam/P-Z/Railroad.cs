using System;
using System.Collections.Generic;
using System.Linq;

namespace EntranceExam
{
    public class Railroad
    {
        public int isRailroadTie(int[] a)
        {
            if (a.Length < 2)
            {
                return 0;
            }
            if (a.Length == 2 && a[0] != 0 && a[1] != 0)
            {
                return 1;
            }
            if (a[0] == 0 || a[a.Length - 1] == 0)
            {
                return 0;
            }
            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i] != 0)
                {
                    if (!((a[i - 1] == 0 && a[i + 1] != 0) || (a[i - 1] != 0 && a[i + 1] == 0)))
                    {
                        return 0;
                    }
                }
                else
                {
                    if (!(a[i - 1] != 0 && a[i + 1] != 0))
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
        public int zeroPlentiful(int[] array)
        {
            //{1, 2, 0, 0, 0, 0, 2, -18, 0, 0, 0, 0, 0, 12}1
            int count = 0;
            int sequence = 0;
            if (!array.Contains(0)) return 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == 0)
                {
                    sequence++;
                }
                else
                {
                    sequence = 0;
                }
                if (sequence >= 4)
                {
                    if (array.Length != i + 1)
                    {
                        if (array[i] != array[i + 1])
                        {
                            count++;
                        }
                    }
                    else
                    {
                        count++;
                    }
                }

            }

            return count;
        }
        public int Stanton(int[] a)
        {
            int measure = 0;
            var ones = a.Where(x => x == 1).Count();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ones)
                {
                    measure++;
                }
            }
            return measure;
        }
        public int decodeArray(int[] array)
        {
            int final = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int difference = array[i] - array[i + 1];
                final = final * 10 + Math.Abs(difference);
            }
            if (array[0] < 0)
            {
                final = final * -1;
            }
            return final;
        }
        public int is121Array(int[] array)
        {
            int start = array[0];
            int starter = 0;
            if (array[0] != array[array.Length - 1])
            {
                return 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 2 || array[i] < 1)
                {
                    return 0;
                }
                if (array[i] == start)
                {
                    starter++;
                }
                else
                {
                    break;
                }
            }
            if (array.Length == starter)
            {
                return 0;
            }
            for (int i = starter; i < array.Length - starter; i++)
            {
                if (array[i] == start)
                {
                    return 0;
                }
            }

            return 1;
        }

        public int railroadtie(int[] array)
        {
            if (array.Length < 2)
            {
                return 0;
            }
            if (array.Length == 2 && (array[0] == 0 || array[array.Length - 1] == 0))
            {
                return 0;
            }
            if (array[0] == 0 || array[array.Length - 1] == 0)
            {
                return 0;
            }
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] != 0)
                {
                    if ((array[i - 1] == 0 && array[i + 1] == 0) || (array[i - 1] != 0 && array[i + 1] != 0))
                    {
                        return 0;
                    }
                }
                else
                {
                    if (!(array[i - 1] != 0 && array[i + 1] != 0))
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
    }
}
