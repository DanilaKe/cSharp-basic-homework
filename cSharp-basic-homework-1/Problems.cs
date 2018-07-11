using System;
using System.Numerics; // using for BigInteger

namespace cSharp_basic_homework_1
{
    class Problems
    {
        // Problem 1.Some Primes
        // Find the 24th, 101st and 251st prime number.
        static internal String[] One()
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
        static internal String[] Two()
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
        static internal String[] Three()
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
        static internal String[] Four()
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
        static internal String[] Five()
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
        static internal String[] Six()
        {
            var CacheString = new String[1]; 
            CacheString[0] = $"LCM(1234, 3456) = {Number.LCM(1234, 3456)}";
            return CacheString;
        }
    }
}