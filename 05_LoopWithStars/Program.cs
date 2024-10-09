using System;

namespace _05_LoopWithStars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Ten Star

			/*

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("*");
            }

            Console.WriteLine();

			for (int i = 0; i < 10; i++)
			{
				Console.Write("*");
			}

			*/

			#endregion

			#region 10 * 10 Star

			/*

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
					Console.Write("*");
				}
                Console.WriteLine();
            }

            */

			#endregion

			#region Right Triangle

			/*
			 
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			*/

			#endregion

			#region Reverse Right Triangle

			/*
			 
			for (int i = 5; i >= 0; i--)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			*/

			#endregion

			#region Symmetric Triangle

			/*

			for (int i = 0; i <= 5; i++)
			{
				for (int j = 0; j <i+1; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			for (int i = 4; i >= 1; i--)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			*/

			#endregion

			#region Baklava Slice

			/*

			int n = 5;

            for (int i = 1; i < n; i++)
            {
                for (int j = n-1; j >0; j--)
				{
                    Console.Write(" ");
				}

				for (int k = 1; k <= 2*i-1; k++)
				{
                    Console.Write("*");
				}
                Console.WriteLine();
            }

			for (int i = n-1; i >= 1; i--)
			{
				for (int j = n - 1; j > 0; j--)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= 2 * i - 1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			*/

			#endregion

			#region Pyramid

			/*

			int n = 5;

			for (int i = 1; i <= n; i++)
			{
				for (int j = n - i; j > 0; j--)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= 2 * i - 1; k++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			*/

			#endregion

			#region Reverse Pyramid

			int n = 5;

			for (int i = n; i >0 ; i--)
			{
				for (int j = n - i; j > 0; j--)
				{
					Console.Write(" ");
				}

				for (int k = 1; k <= 2 * i - 1; k++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			#endregion

			Console.Read();
		}
	}
}
