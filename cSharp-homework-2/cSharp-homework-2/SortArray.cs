using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharphomework2
{
	public class SortArray
	{
		private List<int> InNumbers;
		public SortArray(string instr)
		{
			try
			{
				InNumbers = Array.ConvertAll(instr.Split(), int.Parse).ToList();
			}
			catch (Exception er)
			{
                Console.WriteLine($"Error : {er.Message}");
            }
		}
		public SortArray()
		{
		}
		public string SortArray1()
		{
			var result = new List<int>();
			while (InNumbers.Count > 0)
			{
				var min = InNumbers[0];
				foreach (var i in InNumbers)
				{	
					if (InNumbers[i] < min)
					{
						min = InNumbers[i];
					}
				}
				result.Add(min);
				InNumbers.Remove(min);
			}
			Console.WriteLine(string.Join(" ", result));
			return string.Join(" ", result);
		}
        
		public string SortArray2()
		{
			var result = new List<int>();
			for (var i = 0; i < InNumbers.Count; i++)
			{
				var min = InNumbers[i];
				for (var j = InNumbers.Count-1; j > i; j--)
				{
					if(min > InNumbers[j])
					{
						min = InNumbers[j];
						(InNumbers[i],InNumbers[j]) = (InNumbers[j], InNumbers[i]);
					}
				}
			}
			Console.WriteLine(string.Join(" ", InNumbers));
			return string.Join(" ", InNumbers);
        }
	}
}
