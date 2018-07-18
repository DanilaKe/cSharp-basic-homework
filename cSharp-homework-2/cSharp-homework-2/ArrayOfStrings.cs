using System;
using System.Collections.Generic;
using System.Linq;
using GLib;

namespace cSharphomework2
{
    public class ArrayOfStrings
    {
        private List<string> memoryOfStrings;
        private List<int> memoryOfInteger;
        private string bufferString;
        public ArrayOfStrings(string inString)
        {
            bufferString = inString;
        }

        public string SequencesofEqualStrings()
        {
            var resultString = "";
            try
            {
                memoryOfStrings = bufferString.Split().ToList();
            }
            catch (Exception er)
            {
                Console.WriteLine($"Error : {er.Message}");
            }

            resultString = memoryOfStrings[0];
            for (var i = 1; i < memoryOfStrings.Count; i++)
            {
                if (memoryOfStrings[i] == memoryOfStrings[i - 1])
                    resultString = $"{resultString} {memoryOfStrings[i]}";
                else
                    resultString = $"{resultString} \n{memoryOfStrings[i]}";
            }
            return resultString;
        }

        public string LongestIncreasingSequence()
        {
            var resultString = "";
            try
            {
                memoryOfInteger = Array.ConvertAll(bufferString.Split(), int.Parse).ToList();
            }
            catch (Exception er)
            {
                Console.WriteLine($"Error : {er.Message}");
            }

            var longestString = "";
            resultString = memoryOfInteger[0].ToString();
            var bufferLongestString = memoryOfInteger[0].ToString();
            int n = 0;
            int lastn = 0;
            for (var i = 1; i < memoryOfInteger.Count; i++)
            {
                if (memoryOfInteger[i] > memoryOfInteger[i - 1])
                {
                    resultString = $"{resultString} {memoryOfInteger[i]}";
                    bufferLongestString = $"{bufferLongestString} {memoryOfInteger[i]}";
                    n++;
                    if((i+1 == memoryOfInteger.Count)  && (n > lastn))
                        longestString = bufferLongestString;
                }
                else
                {
                    resultString = $"{resultString} \n{memoryOfInteger[i]}";
                    if (n > lastn)
                    {
                        lastn = n;
                        n = 0;
                        longestString = bufferLongestString;
                    }

                    bufferLongestString = memoryOfInteger[i].ToString();
                }
            }
            resultString = $"{resultString} \nLongest: {longestString}";
            return resultString;
        }
    }
}