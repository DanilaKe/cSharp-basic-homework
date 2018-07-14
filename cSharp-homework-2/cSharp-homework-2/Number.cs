using System;
using System.Collections.Generic;
using System.Linq;

namespace cSharphomework2
{
	public class Number
	{
		List<double> _inNumbers;
		public Number(string instr)
		{
			try
			{
				_inNumbers = Array.ConvertAll(instr.Split(), double.Parse).ToList();
			}
			catch (Exception er)
			{
				Console.WriteLine("Error: " + er.Message);
			}
		}

		public string Categorize()
		{
			var floatResult = new List<float>();
			var integerResult = new List<int>();
			const float eps = 0.000001f;
			foreach (var i in _inNumbers)
			{
				if (i - (int)i > eps)
					floatResult.Add((float)i);
				else
					integerResult.Add((int)i);
			}
			Console.WriteLine(string.Join(" ", floatResult));
			Console.WriteLine(string.Join(" ", integerResult));
			var ResultString = "";
			if (floatResult.Count != 0)
			{
				ResultString = $"[{string.Join(" ", floatResult)} ]\n";
				ResultString += $"Min = {floatResult.Min<float>()}\n";
				ResultString += $"Max = {floatResult.Max()}\n";
				ResultString += $"Average = {floatResult.Average()}\n";
			}
			if (integerResult.Count != 0)
			{
				ResultString += "------------------------------------------------\n";
				ResultString += $"[{string.Join(" ", integerResult)} ]\n";
				ResultString += $"Min = {integerResult.Min()}\n";
				ResultString += $"Max = {integerResult.Max()}\n";
				ResultString += $"Average = {integerResult.Average()}\n";
			}
			return ResultString;
		}
    }
}
