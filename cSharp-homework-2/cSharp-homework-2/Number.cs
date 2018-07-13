using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharphomework2
{
	public class Number
	{
		List<float> InNumbers;
		public Number(string instr)
		{
			try
			{
				InNumbers = Array.ConvertAll(instr.Split(), float.Parse).ToList();
			}
			catch (Exception er)
			{
				Console.WriteLine("Error: " + er.Message);
			}
		}

		public (List<float>, List<int>) Categorize()
		{
			List<float> CacheNumbers = InNumbers;
			List<float> FloatResult = new List<float>();
			List<int> IntegerResult = new List<int>();
			float eps = 0.000001f;
			for (var i = 0; i < CacheNumbers.Count; i++)
			{
				if (CacheNumbers[i] - (Int32)CacheNumbers[i] > eps)
					FloatResult.Add(CacheNumbers[i]);
				else
					IntegerResult.Add((Int32)CacheNumbers[i]);
			}
			Console.WriteLine(String.Join(" ", FloatResult));
			Console.WriteLine(String.Join(" ", IntegerResult));
			return (FloatResult,IntegerResult);
		}
    }
}
