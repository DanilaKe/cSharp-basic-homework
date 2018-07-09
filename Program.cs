using System;
using System.Numerics; // using for BigInteger

namespace cSharp_basic_homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("This program is a homework solution from");
            Console.WriteLine("https://github.com/Innos/Soft-Uni-Homework.git");
            Console.WriteLine("------------------------------------------------");
            int [] ResultOfProblemOne = ProblemOne();
            String [] ResultOfProblemTwo = ProblemTwo(ResultOfProblemOne);
            String [] ResultOfProblemThree = ProblemThree();
            double [] ResultOfProblemFour = ProblemFour();
            String [] ResultOfProblemFive = ProblemFive();
            String ResultOfProblemSix = ProblemSix();
            Console.WriteLine("\nProblem one : ");
            for(int i = 0; i < 3; i++)
                Console.WriteLine(ResultOfProblemOne[i]);
            Console.WriteLine("\nProblem two : ");
            for(int i = 0; i < 3; i++)
                Console.WriteLine(ResultOfProblemTwo[i]);
            Console.WriteLine("\nProblem  three :");
            for(int i = 0; i < 3; i++)
                Console.WriteLine(ResultOfProblemThree[i]);
            Console.WriteLine("\nProblem  four :");
            for(int i = 0; i < 3; i++)
                Console.WriteLine(i+1+".  "+ResultOfProblemFour[i]);
            Console.WriteLine("\nProblem  five :");
            for(int i = 0; i < 6; i++)
                Console.WriteLine(ResultOfProblemFive[i]);
            Console.WriteLine("\nProblem  six :");
            Console.WriteLine(ResultOfProblemSix);
        }
        /*
        Problem 1.Some Primes
        Find the 24th, 101st and 251st prime number.
         */
        static int[] ProblemOne()
        {
            int[] CacheArray = {24, 101, 251};
            int [] ArrayOfSomePrimeNumbers = new int[3];
            for(int i = 0; i < 3; i++) 
                ArrayOfSomePrimeNumbers[i] = Number.PrimeNumber(CacheArray[i]);
            return ArrayOfSomePrimeNumbers;
        }
        /*
        Problem 2.Some Fibonacci Primes
        Check if the 24th, 101st and 251st prime numbers are part
        of the base Fibonacci number set. What is their position? 
        */
        static String[] ProblemTwo(int[] InArray)
        {
            int [] ResultOfProblemTwo = Number.FibonacciPrimes(InArray);
            String[] CacheString = new String[3];
            for(int i = 0; i < 3; i++)
            {
                if(ResultOfProblemTwo[i] != 0)
                    CacheString[i] =  $"{InArray[i]} prime number is {ResultOfProblemTwo[i]} Fibonacci";
                else
                    CacheString[i] =  $"{InArray[i]} prime number is not Fibonacci number";
            }
            return CacheString;
        }
        /*
        Problem 3.Some Factorials
        Find 100!, 171! and 250! Give all digits.
        */
        static String[] ProblemThree()
        {
            int[] CacheArray = {100, 171, 250};
            BigInteger[] ResultOfProblemThree = Number.Factarial((int[])CacheArray.Clone());
            String[] CacheString = new String[3];
            for(int i = 0; i < 3; i++)
                CacheString[i] = ($"{CacheArray[i]}! = {ResultOfProblemThree[i]}");
            return CacheString;
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
        /*
        Problem 5.Numeral System Conversions
        Convert 1234 to binary and hexadecimal numeral systems.
        Convert 0b1100101 to decimal and hexadecimal numeral systems.
        Convert 0xABC to decimal and binary numeral systems.
         */
        static String[] ProblemFive()
        {
            String[] CacheString = new String[6];
            CacheString[0] = "1234 -> " + Convert.ToString(1234, 2) + " (10 -> 2)";
            CacheString[1] = "1234 -> " + Convert.ToString(1234, 16) + " (10 -> 16)";
            CacheString[2] = "0b1100101 -> " + Convert.ToString(0b1100101, 10) + " (2 -> 10)";
            CacheString[3] = "0b1100101 -> " + Convert.ToString(0b1100101, 16) + " (2 -> 16)";
            CacheString[4] = "0xABC -> " + Convert.ToString(0xABC, 2) + " (16 -> 2)";
            CacheString[5] = "0xABC -> " + Convert.ToString(0xABC, 10) + " (16 -> 10)";
            return CacheString;
        }
        /*
        Problem 6.Least Common Multiple
        Find LCM(1234, 3456).
         */
        static String ProblemSix()
        {
            String CacheString = "LCM(1234, 3456) = "+Number.LCM(1234, 3456);
            return CacheString;
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
        public static int LCM(int a, int b)
        {
            int GCD=Math.Min(a,b);
            while(GCD>1)
            {
                if (a%GCD==0 && b%GCD==0)
                    break;
                GCD--;
            }
            return a*b/GCD;
        }
    }
}
