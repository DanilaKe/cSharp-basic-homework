using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharphomework2
{
	public class SortArray
	{
		public List<int> InNumbers;
		List<int> result = new List<int>();
		public SortArray(string instr)
		{
			InNumbers = Array.ConvertAll(instr.Split(), int.Parse).ToList();
		}
		public SortArray()
		{
		}
		public String SortArray1()
		{

			while (InNumbers.Count > 0)
			{
				int min = InNumbers[0];
				for (int i = 0; i < InNumbers.Count; i++)
				{
					if (InNumbers[i] < min)
					{
						min = InNumbers[i];
					}
				}
				result.Add(min);
				InNumbers.Remove(min);
			}
			Console.WriteLine(String.Join(" ", result));
			return String.Join(" ", result);
		}
        
		public String SortArray2()
		{
			for (var i = 0; i < InNumbers.Count; i++)
			{
				int min = InNumbers[i];
				for (var j = InNumbers.Count-1; j > i; j--)
				{
					if (min > InNumbers[j])
					{
						min = InNumbers[j];
						(InNumbers[i],InNumbers[j]) = (InNumbers[j], InNumbers[i]);
					}
				}
			}
			Console.WriteLine(String.Join(" ", InNumbers));
			return String.Join(" ", InNumbers);
        }
	}
}
