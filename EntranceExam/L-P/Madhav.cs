using System;

namespace EntranceExam
{
    public class Madhav
    {
        public static int isMadHav(int[] a)
        {
            int isMadhavArray = 0;
            int arrayLength = a.Length;
            int startIndex = 0; // start index of current array elements under consideration
            int endIndex = 0; // end index of current array elements under consideration
            int n = 1; // track current length of array elements between start and end index
            int currentSum = 0; // current sum of array elements
            int sum = 0; // sum of elements of array between startIndex and endIndex
            int currentLengthOfArray = 1; // length of array from index 0 to endIndex
            int calculatedLengthOfArray = 1; // length calculating n * (n+1)/2
            while (currentLengthOfArray <= arrayLength)
            {
                if (currentLengthOfArray == calculatedLengthOfArray)
                {
                    for (int index = startIndex; index <= endIndex; index++)
                    {
                        sum += a[index];
                    }
                }
                else
                {
                    // Fail ::: The length of a Madhav array must be n*(n+1)/2 for some n
                    isMadhavArray = 0;
                    break;
                }

                if ((currentSum == sum) || (startIndex == endIndex))
                { // startIndex == endIndex to satisfy initial condition
                    currentSum = sum;
                    sum = 0;
                    isMadhavArray = 1;
                }
                else
                {
                    // Fail ::: The sum is not equal
                    isMadhavArray = 0;
                    break;
                }
                if (currentLengthOfArray == arrayLength)
                {
                    // already at the end of the array
                    break;
                }
                else
                {
                    startIndex = endIndex + 1;
                    endIndex = startIndex + n;
                    if ((startIndex < arrayLength && endIndex < arrayLength))
                    {
                        // operating inside the array bounderies
                        n++;
                    }
                    else
                    {
                        // adjusting boundries; so that lastIndex points last element of array
                        endIndex = arrayLength - 1;
                        n = endIndex - startIndex;
                    }
                    calculatedLengthOfArray = n * (n + 1) / 2;
                    currentLengthOfArray = endIndex + 1;
                }
            }
            return isMadhavArray;
        }
    }
}

