using System;
using System.Numerics;
enum Problem
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six
}

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
            var ResultOfProblem = new String[6][];
            String[] ResultOfProblemOne = ProblemOne();
            String[] ResultOfProblemTwo = ProblemTwo();
            String[] ResultOfProblemThree = ProblemThree();
            String[] ResultOfProblemFour = ProblemFour();
            String[] ResultOfProblemFive = ProblemFive();
            String[] ResultOfProblemSix = ProblemSix();
            Console.WriteLine($"\nProblem {(Problem)0} : ");
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
                Console.WriteLine(ResultOfProblemFour[i]);
            Console.WriteLine("\nProblem  five :");
            for(int i = 0; i < 6; i++)
                Console.WriteLine(ResultOfProblemFive[i]);
            Console.WriteLine("\nProblem  six :");
            Console.WriteLine(ResultOfProblemSix[0]);
        }
        // Problem 1.Some Primes
        // Find the 24th, 101st and 251st prime number.
        static String[] ProblemOne()
        {
            var CacheArray = new int[]{24, 101, 251};
            var CacheString = new String[CacheArray.Length];
            for(var i = 0; i < CacheArray.Length; i++) 
                CacheString[i] = $"{CacheArray[i]} a prime number is {Number.PrimeNumber(CacheArray[i])}";
            return CacheString;
        }
        // Problem 2.Some Fibonacci Primes
        // Check if the 24th, 101st and 251st prime numbers are part
        // of the base Fibonacci number set. What is their position? 
        static String[] ProblemTwo()
        {
            var CacheArray = new int[]{24, 101, 251};
            var ArrayOfSomePrimeNumbers = new int[CacheArray.Length];
            for(var i = 0; i < CacheArray.Length; i++) 
                ArrayOfSomePrimeNumbers[i] = Number.PrimeNumber(CacheArray[i]);
            int [] ResultOfProblemTwo = Number.FibonacciPrimes(ArrayOfSomePrimeNumbers);
            var CacheString = new String[ArrayOfSomePrimeNumbers.Length];
            for(var i = 0; i < CacheString.Length; i++)
            {
                if(ResultOfProblemTwo[i] != 0)
                    CacheString[i] =  $"{ArrayOfSomePrimeNumbers[i]} prime number is {ResultOfProblemTwo[i]} Fibonacci";
                else
                    CacheString[i] =  $"{ArrayOfSomePrimeNumbers[i]} prime number is not Fibonacci number";
            }
            return CacheString;
        }
        // Problem 3.Some Factorials
        // Find 100!, 171! and 250! Give all digits.
        static String[] ProblemThree()
        {
            var CacheArray = new int[]{100, 171, 250};
            BigInteger[] ResultOfProblemThree = Number.Factarial((int[])CacheArray.Clone());
            var CacheString = new String[CacheArray.Length];
            for(var i = 0; i < CacheArray.Length; i++)
                CacheString[i] = ($"{CacheArray[i]}! = {ResultOfProblemThree[i]}");
            return CacheString;
        }
        // Problem 4.Calculate Hypotenuse
        // You are given three right angled triangles. Find the length of their hypotenuses.
        // 1.Catheti: 3 and 4
        // 2.Catheti:  10 and 12
        // 3.Catheti 100 and 250
        static String[] ProblemFour()
        {
            var CacheArray = new String[3];
            var InitArray = new int[,]{{3,4},{10,12},{100,250}};
            var RowsInitArray = InitArray.GetUpperBound(0) + 1;
            for (var i = 0; i < RowsInitArray; i++)
                CacheArray[i] = $"{i+1} . {Number.Hypotenuse(InitArray[i,0],InitArray[i,1])}";
            return CacheArray;
        }
        // Problem 5.Numeral System Conversions
        // Convert 1234 to binary and hexadecimal numeral systems.
        // Convert 0b1100101 to decimal and hexadecimal numeral systems.
        // Convert 0xABC to decimal and binary numeral systems.
        static String[] ProblemFive()
        {
            var CacheString = new String[6];
            CacheString[0] = $"1234 -> {Convert.ToString(1234, 2)} (10 -> 2)";
            CacheString[1] = $"1234 -> {Convert.ToString(1234, 16)} (10 -> 16)";
            CacheString[2] = $"0b1100101 -> {Convert.ToString(0b1100101, 10)} (2 -> 10)";
            CacheString[3] = $"0b1100101 -> {Convert.ToString(0b1100101, 16)} (2 -> 16)";
            CacheString[4] = $"0xABC -> {Convert.ToString(0xABC, 2)} (16 -> 2)";
            CacheString[5] = $"0xABC -> {Convert.ToString(0xABC, 10)} (16 -> 10)";
            return CacheString;
        }
        // Problem 6.Least Common Multiple
        // Find LCM(1234, 3456).
        static String[] ProblemSix()
        {
            var CacheString = new String[1]; 
            CacheString[0] = $"LCM(1234, 3456) = {Number.LCM(1234, 3456)}";
            return CacheString;
        }
    }   
}
