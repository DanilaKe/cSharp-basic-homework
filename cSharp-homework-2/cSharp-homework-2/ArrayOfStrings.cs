using System;
using System.Collections.Generic;
using System.Linq;
using GLib;

namespace cSharphomework2
{
    public class ArrayOfStrings
    {
        private List<string> memoryOfStrings;
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
            var counter = 0;
            List<int> nums = Array.ConvertAll(bufferString.Split(), int.Parse).ToList();
            List<List<int>> result = new List<List<int>>();
            while (nums.Count > 0)
            {
                result.Add(new List<int>(nums.TakeWhile((x, i) => i == 0 || x > nums[i - 1]).ToList()));
                nums.RemoveRange(0, result[counter].Count);
                counter++;
            }
            result.ForEach(x => resultString = $"{resultString} \n{String.Join(" ", x)}");
            resultString = $"{resultString} \nLongest: {String.Join(" ", result.OrderByDescending(x => x.Count()).First())}";
            return resultString;
        }
    }
}