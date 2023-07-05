namespace DataStructure
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			int[] a = { 1, 2, 3 };
			int[,] b = new int[2,2];

			String[] s = { "ALI", "Hasan", "kazmi"};
			// 0 (1)
			log(a);
			// 0 (n)
			printArray(a);
			Console.WriteLine();
			// 0 (n + m => n)
			names(a, s);
			Console.WriteLine("Enter elements");
            for (int i = 0; i < 2; i++)
			{
				for(int j = 0; j < 2; j++)
				{
					b[i,j] = Int32.Parse(Console.ReadLine());
				}
			}

			Console.WriteLine("Elements: \n");
			Console.WriteLine(b.Length);
			// (n^2)
			twoDimension(b);*/

			SpaceComplexity sp = new SpaceComplexity();
			sp.greet();
		}
		static void log(int[] num)
		{
			Console.WriteLine(num[0]);
		}
		static void printArray (int[] a)
		{
			foreach (int i in a)
			{
				Console.Write(i + " ");
			}
		}
		static void names(int[] a, string[] names)
		{
			foreach (string name in names)
			{
				Console.Write(name + " ");
			}
			foreach (int i in a)
			{
				Console.WriteLine(i + " ");
			}
		}
		static void twoDimension(int[,] b)
		{
			int i, j;
			for(i=0; i < 2; i++)
			{
				for (j=0; j < 2; j++)
				{
					Console.Write(b[i, j] + " ");
                }
			}
		}
	}	
}