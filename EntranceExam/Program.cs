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
            int[] arraya = {};
            // Console.WriteLine(s.countofSquarePair(array));
            //pr.countofSquarePair(array);
            //Console.WriteLine(pr.guthrieIndex(42));
            //Console.WriteLine(pr.SolveTen());
            Henry HH = new Henry();
            int divisor = 12;
            // Console.WriteLine(s.isDivisible(array, divisor));
            // Console.WriteLine(string.Join(",",HH.perfectNumber(1,3)));
            // Console.WriteLine(pr.isStackedNumber(11));
            //int st = 0;
            //int len = 3;
            //char[] chara = {'a', 'b', 'c'};
            //Non_Zero nz = new Non_Zero();
            //PatternMatch pm = new PatternMatch();
            //Console.WriteLine(nz.hasZeroes(array));
            //Console.WriteLine(pr.ComputeDepth(25));
            //int[] A = { 1, 2, 3, -5, -5, 2, 3, 18};
            //int[] P = { 3, -2, 3 };
            //Console.WriteLine(pm.Pattern(A,P));
           
            SumSafe ss = new SumSafe();
            Square sm = new Square();
            // Console.WriteLine(sm.isTrivalent(ranArr));
            //Console.WriteLine(ss.issumSafe(ranArr));

            // Console.WriteLine(pr.isolated(2097151));

            int[] array = { 1};
            MinMax mm = new MinMax();
            Multiple ml = new Multiple();
            //Console.WriteLine(ml.smallest(7));
            Cluster cl = new Cluster();
            //Console.WriteLine(string.Join(",",cl.ClusterCompression(ranArr)));
            Railroad rr = new Railroad();
            FullnessQuotient full = new FullnessQuotient();
            //Console.WriteLine(rr.isRailroadTie(ranArr));
            // Console.WriteLine(full.isPacked(ranArr));
            // Console.WriteLine(mm.isMinMaxDisjoint(array));
            // Console.WriteLine(pr.countRepresentations(15));
            //SequenciallyBounded bounded = new SequenciallyBounded();
            //Console.WriteLine(bounded.isSequentiallyBounded(array));
            int[] ranArr = { 0, 0, 0, 0, 0 };
            //Console.WriteLine(rr.railroadtie(ranArr));
            BEQ_number bn = new BEQ_number();
            Console.WriteLine(bn.zerLimited(ranArr));
        }
        static int distributeCandy(int[] score)
        {
            int m = score.Length;
            int[] left = new int[m];
            int[] right = new int[m];
            int candies = 0;
            left[0] = 1;
            for (int i = 1; i < m; i++)
                left[i] = score[i] > score[i - 1] ? left[i - 1] + 1 : 1;
            right[m - 1] = 1;
            for (int i = m - 2; i >= 0; i--)
                right[i] = score[i] > score[i + 1] ? right[i + 1] + 1 : 1;
            for (int i = 0; i < m; i++)
                candies += Math.Max(left[i], right[i]);
            return candies;
        }
        public int countRepresentations(int numRupees)
            {
                int count = 0;
                for (int rupee20 = 0; rupee20 <= (numRupees) / 20; rupee20++)
                {
                    for (int rupee10 = 0; rupee10 <= (numRupees - (rupee20 * 20)) / 10; rupee10++)
                {
                    Console.WriteLine("rupee 1 2 5 10 20 : "  + rupee10 + " | " + rupee20);
                    for (int rupee5 = 0; rupee5 <= (numRupees - (rupee10 * 10 + rupee20 * 20)) / 5; rupee5++)
                        {
                            for (int rupee2 = 0; rupee2 <= (numRupees - (rupee5 * 5 + rupee10 * 10 + rupee20 * 20)) / 2; rupee2++)
                            {
                                for (int rupee1 = 0; rupee1 <= numRupees - (rupee2 * 2 + rupee5 * 5 + rupee10 * 10 + rupee20 * 20); rupee1++)
                                {
                                    if ((rupee1 + rupee2 * 2 + rupee5 * 5 + rupee10 * 10 + rupee20 * 20) == numRupees)
                                    {
                                        count++;
                                  //  Console.WriteLine("rupee 1 2 5 10 20 : "+rupee1+" | "+rupee2+"  "+rupee5 + " | "+rupee10+" | "+rupee20);
                                    }
                              //  Console.WriteLine();
                                }
                            }
                        }
                    }
                }
                return count;
            }

        public int isolated(long n)
        {
            //int inter = 0;
            var square = n*n;
            var cube = n * n * n;
            var squar = square.ToString().ToCharArray();
            var cub = cube.ToString().ToCharArray();
            // if (n >= 2097151) return -1;
            Console.WriteLine(cub);
            if (squar.Where(x=> cub.Contains(x)).Count() == 0)
            {
                return 1;
            }
            return 0; 
        }
        static void WeirdTrees()
        {
            for (int a =7; a>0; a--)
            {
                for (int i = a; i < 7; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 7; i > a; i--)
                {
                    Console.Write("   ");
                    //for (int d = 0; d < a; d++)
                    //{
                    //    Console.Write("* ");
                    //}
                 //  Console.WriteLine("*");
                }
                for (int i = 7; i > a; i--)
                {
                    Console.Write("0");
                }
                Console.WriteLine(" ");
            }
        }
        int reverseAnIntArray(int num)
        {
            int reverse = 0;
            while(num != 0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            return reverse;
        }
        char[] PartOfanArray(char[] a, int start, int len)
        {
            List<char> part = new List<char>();
            if (start < 0 || len > a.Length) return null;
            for (int i = start; i < len; i++)
            {
                part.Add(a[i]);
            }
            return part.ToArray();
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
        
        int ComputeDepth(int n)
        {
            List<char> arr = new List<char>();
            int depth = 0;
            int multiplier = 1;
            while (arr.Count < 10)
            {
                int result = n * multiplier;
                var tocharacters = result.ToString().ToCharArray();
                foreach (var item in tocharacters)
                {
                    if (!arr.Contains(item))
                    {
                        arr.Add(item);
                        
                    }
                }
                depth++;
                multiplier++;
            }
            return depth;
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
