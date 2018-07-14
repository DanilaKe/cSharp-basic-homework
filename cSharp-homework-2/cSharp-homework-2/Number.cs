using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharphomework2
{
	public class Number
	{
		List<double> InNumbers;
		public Number(string instr)
		{
			try
			{
				InNumbers = Array.ConvertAll(instr.Split(), Double.Parse).ToList();
			}
			catch (Exception er)
			{
				Console.WriteLine("Error: " + er.Message);
			}
		}

		public string Categorize()
		{
			List<float> FloatResult = new List<float>();
			List<int> IntegerResult = new List<int>();
			float eps = 0.000001f;
			for (var i = 0; i < InNumbers.Count; i++)
			{
				if (InNumbers[i] - (Int32)InNumbers[i] > eps)
					FloatResult.Add((float)InNumbers[i]);
				else
					IntegerResult.Add((Int32)InNumbers[i]);
			}
			Console.WriteLine(String.Join(" ", FloatResult));
			Console.WriteLine(String.Join(" ", IntegerResult));
			string ResultString = "";
			if (FloatResult.Count != 0)
			{
				ResultString = $"[{String.Join(" ", FloatResult)} ]\n";
				ResultString += $"Min = {FloatResult.Min<float>()}\n";
				ResultString += $"Max = {FloatResult.Max()}\n";
				ResultString += $"Average = {FloatResult.Average()}\n";
			}
			if (IntegerResult.Count != 0)
			{
				ResultString += "------------------------------------------------\n";
				ResultString += $"[{String.Join(" ", IntegerResult)} ]\n";
				ResultString += $"Min = {IntegerResult.Min()}\n";
				ResultString += $"Max = {IntegerResult.Max()}\n";
				ResultString += $"Average = {IntegerResult.Average()}\n";
			}
			return ResultString;
		}
    }
}
