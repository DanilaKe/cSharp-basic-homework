using System;
using System.Numerics; // using for BigInteger

namespace cSharp_basic_homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] ResultOfProblemOne = ProblemOne();
            int [] ResultOfProblemTwo = ProblemTwo(ResultOfProblemOne);
            BigInteger [] ResultOfProblemThree = ProblemThree(100,171,250);
            double [] ResultOfProblemFour = ProblemFour();
            Console.WriteLine("Problem One : ");
            for(int i = 0; i < 3; i++)
                Console.WriteLine(ResultOfProblemOne[i]);
            Console.WriteLine("Problem Two : ");
            for(int i = 0; i < 3; i++)
            {
                string CacheString;
                if(ResultOfProblemTwo[i] != 0)
                    CacheString =  $"{ResultOfProblemOne[i]} prime number is {ResultOfProblemTwo[i]} Fibonacci";
                else
                    CacheString =  $"This prime number is not Fibonacci number";
                Console.WriteLine(CacheString);
            }
            Console.WriteLine("Problem  three :");
            Console.WriteLine("100! = "+ResultOfProblemThree[0]);
            Console.WriteLine("171! = "+ResultOfProblemThree[1]);
            Console.WriteLine("250! = "+ResultOfProblemThree[2]);
            Console.WriteLine("Problem  four :");
            for(int i = 0; i < 3; i++)
                Console.WriteLine(i+1+".  "+ResultOfProblemFour[i]);
        }
        /*
        Problem 1.Some Primes
        Find the 24th, 101st and 251st prime number.
         */
        static int[] ProblemOne()
        {
            int [] ArrayOfSomePrimeNumbers = new int[3];
            ArrayOfSomePrimeNumbers[0] = Number.PrimeNumber(24);
            ArrayOfSomePrimeNumbers[1] = Number.PrimeNumber(101);
            ArrayOfSomePrimeNumbers[2] = Number.PrimeNumber(251);
            return ArrayOfSomePrimeNumbers;
        }
        /*
        Problem 2.Some Fibonacci Primes
        Check if the 24th, 101st and 251st prime numbers are part
        of the base Fibonacci number set. What is their position? 
        */
        static int[] ProblemTwo(int[] InArray)
        {
            return Number.FibonacciPrimes(InArray);
        }
        /*
        Problem 3.Some Factorials
        Find 100!, 171! and 250! Give all digits.
        */
        static BigInteger[] ProblemThree(int n1, int n2, int n3)
        {
            int[] CacheArray = new int[3];
            CacheArray[0] = n1;
            CacheArray[1] = n2;
            CacheArray[2] = n3;
            return Number.Factarial(CacheArray);
        }
        /*
        Problem 4.Calculate Hypotenuse
        You are given three right angled triangles. Find the length of their hypotenuses.
        1.Catheti: 3 and 4
        2.Catheti:  10 and 12
        3.Catheti 100 and 250
         */
        static double[] ProblemFour()
        {
            double[] CacheArray = new double[3];
            CacheArray[0] = Number.Hypotenuse(3,4);
            CacheArray[1] = Number.Hypotenuse(10,12);
            CacheArray[2] = Number.Hypotenuse(100,250);
            return CacheArray;
        }
    }
    class Number 
    {
        static bool isPrime(int n)
        {
            if(n <= 1)
                return false;
            for(int i = 2; i*i <= n; i++)
            {
                if(n%i==0)
                    return false;
            }
            return true;
        } 
        public static int PrimeNumber(int Number)
        {
            int i = 0;
            int ResultNumber = 0;
            while(i < Number)
            {
                ResultNumber++;
                if(isPrime(ResultNumber) == true)
                    i++;
            }
            return ResultNumber;
        }
        public static int[] FibonacciPrimes(int[] ArrayOfPrimeNumber)
        {
            int[] Result = new int[3];
            for(int i = 0; i < 3; i++)
            {
                Result[i] = 0;
                int PreviousNumber = 1;
                int NextNumber = 1;
                int CacheNumber;
                int n=3;
                while(true)
                {
                    CacheNumber = PreviousNumber + NextNumber;
                    if(CacheNumber > ArrayOfPrimeNumber[i]) break;
                    if(CacheNumber == ArrayOfPrimeNumber[i])
                    {
                        Result[i] = n;
                        break;
                    }
                    n++;
                    PreviousNumber = NextNumber;
                    NextNumber = CacheNumber;
                }
            }
            return Result;
        }

        public static BigInteger[] Factarial (int[] CacheArray)
        {
            BigInteger[] Result = new BigInteger[3];
            for(int i = 0; i < 3; i++)
            {
                Result[i] = 1;
                while(CacheArray[i] >= 1)
                    Result[i]*=CacheArray[i]--;
            }
            return Result;
        }
        public static double Hypotenuse(double a, double b)
        {
            return Math.Sqrt(a*a+b*b);
        }
    }
}
