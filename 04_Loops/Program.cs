using System;

namespace _04_Loops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region For

			/*

			int i;

			for (i = 1; i <= 5; i++)
			{
				Console.WriteLine(i);
			}

            for (int j = 0; j < 20; j++)
            {
                Console.WriteLine(j);
            }

            for (int j = 0; j < 50; j+=3)
            {
                Console.WriteLine(j);
            }

			Console.Write("Count : ");
			int count = int.Parse(Console.ReadLine());

            for (int j = 0; j < count; j++)
            {
                Console.WriteLine(j);
            }

			*/

			#endregion

			#region  For Loop With Decision Making

			/*
            
            for (int i = 0; i <= 100; i++)
            {
                if(i%5 == 0)
                    Console.WriteLine(i);
            }

            int total = 0;

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                    total += i;
            }
            Console.WriteLine(total);

            int count = 0;
            for (int i = 1; i < 50; i++)
            {
                if (i % 7 == 0)
                    count++;
            }
            Console.WriteLine(count);

            int bacteria = 1;

            for (int i = 1;i <= 24; i++)
            {
                bacteria *= 2;
                Console.WriteLine($"{i}. Saat Sonunda : {bacteria}");
            }

            */

			#endregion

			#region  While

			/*
             
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine(i);
                i++;
            }
            
            i = 1;
            while (i <= 10)
            {
                if(i%3 == 0)
                    Console.WriteLine(i);
                i++;
            }

            */

			#endregion

			#region Sample App

			// Calculate the sum of the digits of the 3 digit number entered from the keyboard

			Console.Write("3 Digits Number : ");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine();

			int digitCount = 0;
			int digitTotal = 0;
			int digitValue = 0;

			while (number > 1)
			{
				digitValue = number % 10;
				digitTotal += digitValue;
				digitCount++;
				number /= 10;
			}

			if (digitCount != 3)
			{
				Console.WriteLine("Please Enter 3 Digit Number\n");
				Console.WriteLine($"Count Of The Digits = {digitCount}\n");
			}
			else if (number == 0)
			{
				Console.WriteLine("Please Enter 3 Digit Number\n");
				Console.WriteLine($"Count Of The Digits = {digitCount + 1}\n");
			}
			else
			{
				Console.WriteLine($"Count Of The Digits = {digitCount}\n");
				Console.WriteLine($"Sum Of The Digits = {digitTotal}");
			}



			#endregion

			Console.Read();
		}
	}
}
