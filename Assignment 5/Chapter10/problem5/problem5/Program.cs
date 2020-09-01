using System;

namespace problem5
{
	class Program
	{
		public static void Main(String[] args)
		{
			string[] B = { "test", "rock", "fun" };
			Subsets(B, 0);
		}
		static void Subsets(string[] A, int x)
		{
			if (x == A.Length - 1)
			{
				A[x] = 0;
				printArray(A);
				A[x] = 1;
				printArray(A);
				return;
			}
			A[x] = 0;
			Subsets(A, x + 1);
			A[x] = 1;
			Subsets(A, x + 1);
		}
		static void printArray(string[] A)
		{
			bool isNULL = true;
			Console.Write("{");
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == 1)
				{
					Console.Write(A[i] + "");
					isNULL = false;
				}
			}
			if (isNULL == false)
			{
				Console.Write("}");
				Console.Write("  ");
			}

			if (isNULL)
			{
				Console.Write(" ");
				Console.Write("} ");
			}
		}
	}
}
