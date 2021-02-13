using System;
using System.Collections.Generic;
using System.Linq;

namespace EntranceExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4,4,4,78,12,7,10,78,12 };
            countingOccurence(array);
        }
        private static void countingOccurence(int[] array)
        {
            int[] v = new int[array.Length] ;
            int[] c = new int[] { };
            int a = 0, b = 0;
            for (int i = 0 ; i < array.Length; i++)
            {
                Console.WriteLine(v[i]);
                //if(!v.Contains(array[i])){
                //    v[a] = array[i];
                //    a++;
                //}
                //else
                //{
                //    c[b]= array[i];
                //    b++;
                //}
            }
            Console.WriteLine("unique :"+string.Join(",", v));
            Console.WriteLine("count : "+string.Join(",", c));
        }
        static int[] reversingArray(int[] array)
        {
            Array.Sort(array);
            return array;
        }
        static int Fibonacci(int num)
        {
            if (num <= 2)
                return 1;
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
        static float Power(float num, int tothepower)
        {
            if (tothepower == 1)
                return num;
            return num * Power(num, tothepower - 1);
        }
        static int recur(int num)
        {
            if (num == 1)
                return num;
            return num + 3 * recur(num - 1);
        }
        static int Factorial(int number){
            if (number == 1)
                return 1;
           return number * Factorial(number - 1);
          }
        static int poww(int num, int exp)
        {
            int final = 1;
            for (int i = exp; i > 0; i--)
            { 
                final *= num;
            }
            return final;
        }
} 
}
            ////int rem ,initialNumber = 123;

            ////var reverse = 0;
            ////while(initialNumber!=0)
            ////{
            ////    rem = initialNumber % 10;
            ////    reverse = reverse*10+rem;
            ////    initialNumber = initialNumber / 10;
            ////}
            ////Console.WriteLine(reverse);
            //Program pr = new Program();
            ////var randomNumber = 3;
            ////int[] first = { 1,1,2};
            ////int[] second = null;

            ////Madhav md = new Madhav();

            ////Console.WriteLine(pr.f(first,second));
            //// Console.WriteLine(Math.Sqrt(randomNumber));
            //// Console.WriteLine(pr.isPerfectSquare(randomNumber));
            //// Console.WriteLine(pr.equilibrium(randomArray));
            ////int variab = 4;
            ////int[] randomArray = {1,0,4,0};
            ////int[] evenArray = {2 };
            //// Console.WriteLine(pr.inertia(randomArray));
            ////Console.WriteLine(pr.isHollow(randomArray));
            ////Console.WriteLine(pr.nUnique(randomArray, variab));
            ////Console.WriteLine(pr.isSquare(0));
            ////Console.WriteLine(pr.EvenMinusOdd(randomArray));
            //// Console.WriteLine(pr.Intersection(first,second));
            //// pr.isLegalNumbers(first, randomNumber);
            //// Console.WriteLine(pr.findPorcupineNumber(103));
            //Square s = new Square();
            //int[] arraya = { };
            //// Console.WriteLine(s.countofSquarePair(array));
            ////pr.countofSquarePair(array);
            ////Console.WriteLine(pr.guthrieIndex(42));
            ////Console.WriteLine(pr.SolveTen());
            //Henry HH = new Henry();
            //int divisor = 12;
            //// Console.WriteLine(s.isDivisible(array, divisor));
            //// Console.WriteLine(string.Join(",",HH.perfectNumber(1,3)));
            //// Console.WriteLine(pr.isStackedNumber(11));
            ////int st = 0;
            ////int len = 3;
            ////char[] chara = {'a', 'b', 'c'};
            ////Non_Zero nz = new Non_Zero();
            ////PatternMatch pm = new PatternMatch();
            ////Console.WriteLine(nz.hasZeroes(array));
            ////Console.WriteLine(pr.ComputeDepth(25));
            ////int[] A = { 1, 2, 3, -5, -5, 2, 3, 18};
            ////int[] P = { 3, -2, 3 };
            ////Console.WriteLine(pm.Pattern(A,P));

            //SumSafe ss = new SumSafe();
            //Square sm = new Square();
            //// Console.WriteLine(sm.isTrivalent(ranArr));
            ////Console.WriteLine(ss.issumSafe(ranArr));

            //// Console.WriteLine(pr.isolated(2097151));

            //int[] array = { 1 };
            //MinMax mm = new MinMax();
            //Multiple ml = new Multiple();
            ////Console.WriteLine(ml.smallest(7));
            //Cluster cl = new Cluster();
            ////Console.WriteLine(string.Join(",",cl.ClusterCompression(ranArr)));
            //Railroad rr = new Railroad();
            //FullnessQuotient full = new FullnessQuotient();
            ////Console.WriteLine(rr.isRailroadTie(ranArr));
            //// Console.WriteLine(full.isPacked(ranArr));
            //// Console.WriteLine(mm.isMinMaxDisjoint(array));
            //// Console.WriteLine(pr.countRepresentations(15));
            ////SequenciallyBounded bounded = new SequenciallyBounded();
            ////Console.WriteLine(bounded.isSequentiallyBounded(array));





            ////EntranceExam ee = new EntranceExam();
            ////int[] ranArr = {1,2,22,5,5,5,5,57,8,8,9,588  };
            ////PrimeNumbers pn = new PrimeNumbers();

            ////Console.WriteLine(string.Join(", ",candies.distribute(12, 30)));

            //////int[] akk = { 2, -5, 0, 3, -1 };
            ////for (int i = 0; i < 5; i++)
            ////{
            ////    if (akk[i] > 0)
            ////    {
            ////        akk[i] -= 1;
            ////    }
            ////    else
            ////    {
            ////        akk[i] = +2
            ////    }

            ////}
            ////Console.WriteLine(string.Join(",",akk));


        
        //public int isMercurial(int[] a)
        //{
        //    if (!a.Contains(3)) return 1;
        //    if (!a.Contains(1)) return 1;
        //    int indexofthree = -1;
        //    int indexofone = -1;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (a[i] == 1)
        //        {
                    
        //        }
        //    }
        //    return 0;
        //}
    
