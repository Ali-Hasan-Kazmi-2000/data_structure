using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
	internal class SpaceComplexity
	{				
		// 0(x) --> O(n) Space Complexity.
		public void greet()
		{
			String[] names = new string[5];
			names[0] = "Ali";
			names[1] = "Bilal";
			names[2] = "Calthy";
			names[3] = "Dawood";
			names[4] = "Erum";
			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine("Hi, " + names[i]);
			}
		}
	}
}
