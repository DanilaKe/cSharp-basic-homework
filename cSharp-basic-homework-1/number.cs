using System;
using System.Numerics; // using for BigInteger

namespace cSharp_basic_homework_1
{
class Number 
    {
        static bool isPrime(int n)
        {
            if(n <= 1)
                return false;
            for(int i = 2; i*i <= n; i++)
            {
                if(n%i == 0)
                    return false;
            }
            return true;
        } 
        internal static int PrimeNumber(int Number)
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
        internal static int[] FibonacciPrimes(int[] ArrayOfPrimeNumber)
        {
            var Result = new int[3];
            for(var i = 0; i < Result.Length; i++)
            {
                Result[i] = 0;
                var PreviousNumber = 1;
                var NextNumber = 1;
                var CacheNumber = 0;
                var n=3;
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

        internal static BigInteger[] Factarial (int[] CacheArray)
        {
            var Result = new BigInteger[3];
            for(var i = 0; i < Result.Length; i++)
            {
                Result[i] = 1;
                while(CacheArray[i] >= 1)
                    Result[i]*=CacheArray[i]--;
            }
            return Result;
        }
        internal static double Hypotenuse(double a, double b)
        {
            return Math.Sqrt(a*a+b*b);
        }
        internal static int LCM(int a, int b)
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