using System;
using System.Collections.Generic;
using System.Linq;

namespace EntranceExam
{
    partial class Program : Intersections
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
            //var randomNumber = 3;
            //int[] first = { 1,1,2};
            //int[] second = null;

            //Madhav md = new Madhav();

            //Console.WriteLine(pr.f(first,second));
            // Console.WriteLine(Math.Sqrt(randomNumber));
            // Console.WriteLine(pr.isPerfectSquare(randomNumber));
            // Console.WriteLine(pr.equilibrium(randomArray));
            //int variab = 4;
            //int[] randomArray = {1,0,4,0};
            //int[] evenArray = {2 };
            // Console.WriteLine(pr.inertia(randomArray));
            //Console.WriteLine(pr.isHollow(randomArray));
            //Console.WriteLine(pr.nUnique(randomArray, variab));
            //Console.WriteLine(pr.isSquare(0));
            //Console.WriteLine(pr.EvenMinusOdd(randomArray));
            // Console.WriteLine(pr.Intersection(first,second));
            // pr.isLegalNumbers(first, randomNumber);
            // Console.WriteLine(pr.findPorcupineNumber(103));
            Square s = new Square();
            int[] array = { };
            // Console.WriteLine(s.countofSquarePair(array));
            //pr.countofSquarePair(array);
            //Console.WriteLine(pr.guthrieIndex(42));
            //Console.WriteLine(pr.SolveTen());
            Henry HH = new Henry();
            int divisor = 12;
            // Console.WriteLine(s.isDivisible(array, divisor));
            // Console.WriteLine(string.Join(",",HH.perfectNumber(1,3)));
           // Console.WriteLine(pr.isStackedNumber(11));
        }
       
        int isCenteredFifteen(int[] array)
        {
            int n = 0, sum = 0;
            for (int i = 0; i < array.Length ; i++)
            {
                for (int k = 0; k < array.Length; k++)
                {
                    sum += array[k];
                    if(sum == 15)
                    {
                        int before = i;
                        int after = array.Length - k-1;
                        if(before == after)
                        {
                            Console.WriteLine("After : " + after + " Elements before center fifteen :" + before);
                            Console.WriteLine("Sum : " + sum);
                            n = 1;
                        }
                       
                    }
                }
                sum = 0;
            }
            return n;
        }


  
        int sumFactor(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            var value = array.Where(x => x == sum).ToList().Count;
            return value;
        }
         void countofSquarePair(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) continue;
                for (int j = i + 1; j < arr.Length; j++)
                {
                   
                    if (isPerfectSquare((arr[i] + arr[j])) == 1 && arr[i]>0 && arr[j]>0)
                    {
                        count++;
                        Console.WriteLine(arr[i]+","+ arr[j]);
                    }
                }

            }
            Console.WriteLine(count);
        }
        int isPerfectSquare(int n)
        {
            double root = Math.Sqrt(n);
            if (n ==(int)root*(int)root)
            {
                return 1;
            }
            return 0;
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


    }
}
