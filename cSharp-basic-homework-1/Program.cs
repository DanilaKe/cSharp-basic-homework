using System;

enum Problem
{
    One=1,
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
            Console.WriteLine("What problem to solve?");
            String[] ResultOfProblem;
            try
            {
                String selection = Console.ReadLine();
                switch (selection)
                {
                case "1":
                    ResultOfProblem = Problems.One();
                    break;
                case "2":
                    ResultOfProblem = Problems.Two();
                    break;
                case "3":
                    ResultOfProblem = Problems.Three();
                    break;
                case "4":
                    ResultOfProblem = Problems.Four();
                    break;
                case "5":
                    ResultOfProblem = Problems.Five();
                    break;
                case "6":
                    ResultOfProblem = Problems.Six();
                    break;
                default:
                    throw new Exception("Unknown problem");
                }
                Console.WriteLine($"\nProblem {(Problem)(Int32.Parse(selection))} : ");
                for(int i = 0; i < ResultOfProblem.Length; i++)
                    Console.WriteLine(ResultOfProblem[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }   
}
