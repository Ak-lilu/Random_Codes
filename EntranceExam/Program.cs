using System;
using System.Collections.Generic;
using System.Linq;

namespace EntranceExam
{
    partial class Program
    {
        static void Main(string[] args)
        {

            //int rem ,initialNumber = 123;

            //var reverse = 0;
            //while(initialNumber!=0)
            //{
            //    rem = initialNumber % 10;
            //    reverse = reverse*10+rem;
            //    initialNumber = initialNumber / 10;
            //}
            //Console.WriteLine(reverse);
            Program pr = new Program();
            var randomNumber = 3;
            int[] first = { 1,1,2};
            int[] second = null;

            Madhav md = new Madhav();




            //Console.WriteLine(pr.f(first,second));
            // Console.WriteLine(Math.Sqrt(randomNumber));
            // Console.WriteLine(pr.isPerfectSquare(randomNumber));
            // Console.WriteLine(pr.equilibrium(randomArray));
            int variab = 4;
            int[] randomArray = {1,0,4,0};
            int[] evenArray = {2 };
            // Console.WriteLine(pr.inertia(randomArray));
            //Console.WriteLine(pr.isHollow(randomArray));
            //Console.WriteLine(pr.nUnique(randomArray, variab));
            //Console.WriteLine(pr.isSquare(0));
            //Console.WriteLine(pr.EvenMinusOdd(randomArray));
           // Console.WriteLine(pr.Intersection(first,second));
           // pr.isLegalNumbers(first, randomNumber);
            Console.WriteLine(pr.ComputeDepth(42));
        }
        int ComputeDepth(int n)
        {
            int depth = 0, final=0;
            int multiplier = 1;
            List<char> finalArray = new List<char>();
            do
            {
                var a = n * multiplier;
                char[] arr = a.ToString().ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    if (!finalArray.Contains(arr[i]))
                    {
                        finalArray.Add(arr[i]);
                    }
                }
                depth++;
                multiplier++;
            }
            while (finalArray.Count != 10);
            return depth;
        }
         int nonzero(int[] rp)
        {
            if (rp.Contains(0))
            {
                return 0;
            }
            return 1;
        }
        static int isLegalNumber(int[] a, int based)
        {
            foreach (int anA in a)
            {
                if (anA < 0 || anA > based)
                    return 0;
            }
            return 1;
        }
        void isLegalNumbers(int[] array, int base_num)
        {
            // (2 * 30) +(1 * 31) + (1 * 32) = 2 + 3 + 9 = 1410
            int sum = 0;

            for (int i = array.Length-1,a=0; i >= 0; i--)
            {
                double curent = Math.Pow((double)base_num, (double)a);
                sum += array[i] * (int)curent;
                Console.WriteLine(sum);
                a++;
            }
         
        }
        int EvenMinusOdd(int[] arr)
        {
            int even =0, odd = 0, final=0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even+=arr[i];
                }
                else
                {
                    odd+=arr[i];
                }
                final = odd - even;
            }
            return final;
        }
        int isSquare(int n)
        {
            int Square = 0;
            double root = Math.Sqrt(n);
            if((int)root* (int)root == n)
            {
                Square = 1;
                return Square;
            }
            return Square;
        }
        int mad(int[] a)
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

        int isHollow(int[] HollowArray)
        {
            int Hollow = 0;
            int count = 0, numberofZeroes = 0, afterzeroes=0;
            for (int i = 0; i < HollowArray.Length; i++)
            {
                if(HollowArray[i] != 0)
                {
                    count++;
                   
                }
                else
                {
                    break;
                }
            }
            for (int i = count; i <HollowArray.Length; i++)
            {
                if(HollowArray[i] == 0)
                {
                    numberofZeroes++;
                }
                else
                {
                    break;
                }
            }
            var leftover = numberofZeroes + count;
           // Console.WriteLine(leftover);
            for (int i = numberofZeroes+count; i < HollowArray.Length; i++)
            {
                
                if (HollowArray[i] == 0)
                {
                    //break;
                    return Hollow;
                   
                }
                else
                {
                    afterzeroes++;
                }
            }
            if (numberofZeroes > 2 && count == afterzeroes)
            {
                Hollow = 1;
                return Hollow;
            }
            return Hollow;
        }
        int nUnique(int[] a, int n)
        {
            int count = 0;
            int unique = 0;
            if (a.Length < 2) return count;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == n)
                    {
                        count++;
                    }
                }
            }
            if (count == 1)
            {
                unique = 1;
            }
            return unique;
        }
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
            bool odd = false,  maxEvenTrue = false, biggerOdds=true;
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
                if(inertiaArray[i]%2 != 0)
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
        private static void UnfinishedMadhavArraySolution(int[] randomArray)
        {

            int nextStarter = 1, end = 0;
            Console.WriteLine("3, 2, 1, -6, 8, -3, -1, 2,9,7");
            for (int i = 1; i < randomArray.Length; i++)
            {
                int sum = 0;
                int currentEnd = end + nextStarter;

                for (int k = end; k < currentEnd; k++)
                {
                    Console.Write(randomArray[k]);
                    if (currentEnd == randomArray.Length)
                    {
                        break;
                    }
                }
                end += nextStarter;
                Console.WriteLine(end);
                nextStarter++;
                Console.WriteLine("--- " + nextStarter + "[ some variable ]" + end);
            }
        }

        static void  aa()
        {
            for (int i = 1; i < 7; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.WriteLine(k);
                }
            }
        }
        int[] Intersection(int[] first, int[] second)
        {

            if (first == null || second == null) return null;
                if (first.Length == 0 || second.Length == 0)
                {
                    return null;
                }
                else
                {
                    int total = first.Length + second.Length;
                    int[] a = new int[total];

                    for (int i = 0, count = 0; i < first.Length; count++, i++)
                    {
                        for (int j = 0; j < second.Length; j++)
                        {
                            if (first[i] == second[j])
                            {
                                a[i] = first[i];
                                Console.WriteLine(a[i]);
                            }
                        }
                    }
                    return a.ToArray();
                }
        }
    }
}
