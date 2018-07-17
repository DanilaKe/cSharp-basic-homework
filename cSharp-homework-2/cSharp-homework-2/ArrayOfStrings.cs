using System;
using System.Collections.Generic;
using System.Linq;
using GLib;

namespace cSharphomework2
{
    public class ArrayOfStrings
    {
        private List<string> memory;
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
                memory = bufferString.Split().ToList();
            }
            catch (Exception er)
            {
                Console.WriteLine($"Error : {er.Message}");
            }

            resultString = memory[0];
            for (var i = 1; i < memory.Count; i++)
            {
                if (memory[i] == memory[i - 1])
                    resultString = $"{resultString} {memory[i]}";
                else
                    resultString = $"{resultString} \n{memory[i]}";
            }
            return resultString;
        }
        
    }
}