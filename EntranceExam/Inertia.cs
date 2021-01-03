using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntranceExam
{
    class Inertia
    {
        int isInertial(int[] a)
        {
            int isInertial = 0;
            bool containsOddValue = false;
            int maxValue = int.MinValue;
            int[] oddValues = new int[a.Length];
            int[] evenValues = new int[a.Length];
            int oddValuesIndex = 0;
            int evenValuesIndex = 0;
            for (int index = 0; index < a.Length; index++)
            {
                if ((a[index] % 2) != 0)
                {
                    containsOddValue = true;
                    oddValues[oddValuesIndex] = a[index];
                    oddValuesIndex++;
                }
                else
                {
                    evenValues[evenValuesIndex] = a[index];
                    evenValuesIndex++;
                }
                if (a[index] > maxValue)
                {
                    maxValue = a[index];
                }
            }
            if (containsOddValue)
            {
                if (maxValue % 2 == 0)
                {
                    for (int oddIndex = 0; oddIndex < oddValuesIndex; oddIndex++)
                    {
                        for (int evenIndex = 0; evenIndex < evenValuesIndex; evenIndex++)
                        {
                            if (evenValues[evenIndex] != maxValue)
                            {
                                if (oddValues[oddIndex] > evenValues[evenIndex])
                                {
                                    isInertial = 1;
                                }
                                else
                                {
                                    isInertial = 0;
                                    break;
                                }
                            }
                            else
                            {
                                isInertial = 1;
                            }
                        }
                        if (isInertial == 0)
                        {
                            break;
                        }
                    }
                }
            }
            return isInertial;
        }

        int inertia(int[] inertiaArray)
        {
            int inertiaArr = 0;
            if (inertiaArray.Length < 3) return inertiaArr;
            bool odd = false, maxEvenTrue = false, biggerOdds = true;
            var even = inertiaArray.Where(x => x % 2 == 0).ToList();
            var odds = inertiaArray.Where(x => x % 2 != 0).ToList();
            // var secondMax = even.Where(x => x != even.Max()).FirstOrDefault();


            if (even.ToList().Count < 1 || odds.ToList().Count < 1) return inertiaArr;
            var oddmin = odds.Min();
            for (int l = 0; l < even.Count(); l++)
            {
                if (even[l] != even.Max() && oddmin < even[l])
                {
                    biggerOdds = false;
                }
            }
            if (inertiaArray.Max() % 2 == 0)
            {
                maxEvenTrue = true;
            }
            for (int i = 0; i < inertiaArray.Length; i++)
            {
                if (inertiaArray[i] % 2 != 0)
                {
                    odd = true;
                }
            }
            if (odd && maxEvenTrue && biggerOdds)
            {
                inertiaArr = 1;
            }
            return inertiaArr;
        }
    }
}
