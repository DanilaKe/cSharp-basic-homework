using System;

namespace cSharp_basic_homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] ResultOfProblemOne = ProblemOne();
            Console.WriteLine("Problem One : ");
            for(int i = 0; i < 3; i++)
                Console.WriteLine(ResultOfProblemOne[i]);
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
    }
}
