﻿using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace cSharphomework2
{
    public class TextProblems
    {
        private string text;
        private int _numberProblem;
        public TextProblems()
        {
            text = "";
            _numberProblem = -1;
        }
        public TextProblems(int n)
        {
            _numberProblem = n;
            text = $"Problem №{_numberProblem} \n";
        }

        public void EditNumberProblem(int n)
        {
            _numberProblem = n;
        }
        public string makeProblemText()
        {
            try
            {
                switch (_numberProblem)
                {
                    case 1 :
                        text = $"Write a program to sort an array of numbers and then print them back on the console. \n";
                        text = $"{text} The numbers should be entered from the console on a single line, separated by a space. \n";
                        break;
                    case 2 :
                        text = $"Write a program to sort an array of numbers and then print them back on the console. \n";
                        text = $"{text} The numbers should be entered from the console on a single line, separated by a space. \n";
                        break;
                    case 3 :
                        text = $"Write a program that reads N floating-point numbers from the console. \n";
                        text = $"{text} Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) \n";
                        text = $"{text} and the other containing the floating-point numbers with non-zero fraction. \n";
                        text = $"{text} Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). \n";
                        break;
                    case 4 :
                        text = $"Write a program that reads an array of strings and finds in it all sequences of equal elements \n";
                        text = $"{text} (comparison should be case-insensitive). \n";
                        text = $"{text} The input strings are given as a single line, separated by a space. \n";
                        break;
                    case 5 :
                        text = $"Write a program to find all increasing sequences inside an array of integers. The integers are \n";
                        text = $"{text} given on a single line, separated by a space. Print the sequences in the order of their appearance in \n";
                        text = $"{text} the input array, each at a single line. Separate the sequence elements by a space. Find also the longest \n";
                        text = $"{text} increasing sequence and print it at the last line. If several sequences have the same longest length, \n";
                        text = $"{text} print the left-most of them. \n";
                        break;
                    case 6 :
                        text = $"Write a program that reads from the console a number N and an array of integers given on a single line. \n";
                        text = $"{text} Your task is to find all subsets within the array which have a sum equal to N and print them on \n";
                        text = $"{text} the console (the order of printing is not important). Find only the unique subsets by filtering out \n";
                        text = $"{text} repeating numbers first. In case there aren't any subsets with the desired sum, print \"No matching subsets.\"";
                        break;
                    case 7 :
                        break;
                    case 8 :
                        break;
                    case 9 :
                        break;
                    default:
                        throw new Exception("Unknown problem");
                }
                return text;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}