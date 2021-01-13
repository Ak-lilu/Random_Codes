using System;
using System.Collections.Generic;
using System.Linq;

namespace EntranceExam
{
    public class BEQ_number
    {
        public int findSmallestBEQ()
        {
            int value = 0;
            int number = 19;
            while (value != 4)
            {
                int result = number * number * number;
                value = containsFoursixes(result);
                if (value == 4)
                {
                    break;
                }
                number++;
                value = 0;
            }
            return number;
        }
        int containsFoursixes(int n)
        {
            int count = 0;

            while (n != 0)
            {
                int remainder = n % 10;
                if (remainder == 6)
                {
                    count++;
                }
                n /= 10;
            }
            return count;
        }
        int cube(int n)
        {
            double result = Math.Cbrt(n);
            return (int)result;
        }
        public int isPerfectCube(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int cubeRoot = cube(a[i]);
                if ((cubeRoot* cubeRoot * cubeRoot) != a[i])
                {
                    return 0;
                }
            }
            return 1;   
        }
        public int isDaphne(int[] a)
        {
            var even = a[0] % 2 == 0;
            var odd = a[0] % 2 != 0;
            if (even)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if(a[i]%2 != 0)
                    {
                        return 0;
                    }
                }
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] % 2 == 0)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
        public int countOnes(int n)
        {
            //var count = n.Where(x => x == 1).Count();
            int co = 0;
            string binary = Convert.ToString(n, 2);
            var count = binary.ToCharArray();
            foreach (var item in count)
            {
                if(item == '1')
                {
                    co++;
                }
            }
            return co;
        }
        public int OddValent(int[] a)
        {
            var compressed = a.Distinct().Count();
            if (a.Length == compressed) return 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]%2 != 0)
                {
                    return 1;
                }
            }
            return 0;
        }
        public List<int> isDivisible(int n)
        {
            int mid = n / 2;
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
        public int isNormal(int n)
        {
            List<int> ll = isDivisible(n);
            for (int i = 0; i < ll.Count; i++)
            {
                if(ll[i] != 1)
                {
                    if(ll[i]%2 != 0)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }
        public int zerLimited(int[] a)
        {
            if (a.Length < 2) return 0;

            for (int i = 1; i < a.Length; i += 3)
            {
                for (int n = 0; n < a.Length; n++)
                {
                    if (i == n)
                    {
                        if (a[n] != 0)
                        {
                            return 0;
                        }
                    }
                    else
                    {
                        if (a[n] == 0)
                        {
                            return 0;
                        }
                    }
                }
            }
                return 1;
            }
        }
    }

