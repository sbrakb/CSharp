using System;

namespace _03_DecisionMaking
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region If-Else Structure

			/*

			Console.Write("Password : ");

			string password = Console.ReadLine();

			if (password == "abcd")
				Console.WriteLine("Correct");
			else
				Console.WriteLine("Wrong");


			string capital, country;
			Console.Write("Capital : ");
			capital = Console.ReadLine();

			Console.Write("Country : ");
			country = Console.ReadLine();

			if (capital == "ankara" && country == "türkiye")
				Console.WriteLine("true");
			else
				Console.WriteLine("false");


			int number;
			Console.Write("Number : ");
			number = int.Parse(Console.ReadLine());

			if (number == 5)
				Console.WriteLine("true");
			else
				Console.WriteLine("false");


			int exam1, exam2, exam3, average;
			string result = "";

			Console.Write("Exam 1: ");
			exam1 = int.Parse(Console.ReadLine());

			Console.Write("Exam 2: ");
			exam2 = int.Parse(Console.ReadLine());

			Console.Write("Exam 3: ");
			exam3 = int.Parse(Console.ReadLine());

			average = (exam1 + exam2 + exam3) / 3;
			Console.Write("Average : " + average);

			if (average > 0 && average < 50)
				result = "Failed";
			if (average >= 50 && average < 70)
				result = "Not Bad";
			if (average >= 70 && average < 85)
				result = "Good";
			if (average >= 85 && average <= 100)
				result = "Better";

			Console.WriteLine($"Result : {result}");


			string city;
			Console.Write("City: ");
			city = Console.ReadLine();

			if (city == "adana" || city == "ankara" || city == "bursa")
				Console.WriteLine("City Exist");
			else 
				Console.WriteLine("City Not Exist");

			Console.Write("Username : ");
			string username = Console.ReadLine();

			if (username != "admin")
				Console.WriteLine("False");
			else
				Console.WriteLine("True");

			*/

			#endregion

			#region Mod

			/*
			 
			int number = 26;
			int result = number % 5;
            Console.WriteLine(result);

			Console.Write("Number1 : ");
			int number1 = int.Parse(Console.ReadLine());

			Console.Write("Number2 : ");
			int number2 = int.Parse(Console.ReadLine());

			int result2 = number1 % number2;
			Console.WriteLine(result2);

			Console.Write("Number3 : ");
			int number3 = int.Parse(Console.ReadLine());

			if (number3 % 2 == 0)
				Console.WriteLine("Number is even");
			else
				Console.WriteLine("Number is odd");

			char team;

            Console.Write("Team Symbol : ");
			team = char.Parse(Console.ReadLine());

			if(team == 'g' | team == 'G')
                Console.Write("Galatasaray");
			if (team == 'f' | team == 'F')
				Console.Write("Fenerbahçe");
			if (team == 'b' | team == 'B')
				Console.Write("Beşiktaş");

			*/

			#endregion

			#region Sample App

			/*
			 
			Console.WriteLine("***** Restaurant *****\n");
			Console.WriteLine("-----------------------------------------");

			Console.WriteLine("1. Main Dishes");
			Console.WriteLine("2. Soups");
			Console.WriteLine("3. Pizzas");
			Console.WriteLine("4. Drinks");
			Console.WriteLine("5. Desserts");
			Console.WriteLine("-----------------------------------------\n");

			string menuItem;
			Console.Write("Select : ");
			menuItem = Console.ReadLine();

			if (menuItem == "1")
			{
				Console.WriteLine("---------Main Dishes---------\n");
				Console.WriteLine("1. Chicken with Curry Sauce");
				Console.WriteLine("2. Fried Platter");
				Console.WriteLine("3. Beans with Rice");
				Console.WriteLine("4. Baked Salmon");
				Console.WriteLine("5. Eggplant Moussaka\n");
				Console.WriteLine("---------Main Dishes---------\n");
			}
			if (menuItem == "2")
			{
				Console.WriteLine("---------Soups---------\n");
				Console.WriteLine("1. Lentil Soup");
				Console.WriteLine("2. Ezogelin Soup\n");
				Console.WriteLine("---------Soups---------\n");
			}
			if (menuItem == "3")
			{
				Console.WriteLine("---------Pizzas---------\n");
				Console.WriteLine("1. Mediterranean Pizza");
				Console.WriteLine("2. Margherita");
				Console.WriteLine("3. Chicken Pizza\n");
				Console.WriteLine("---------Pizzas---------\n");
			}
			if (menuItem == "4")
			{
				Console.WriteLine("---------Drinks---------\n");
				Console.WriteLine("1. Cola");
				Console.WriteLine("2. Ayran");
				Console.WriteLine("3. Water\n");
				Console.WriteLine("---------Drinks---------\n");
			}
			if (menuItem == "5")
			{
				Console.WriteLine("---------Desserts---------\n");
				Console.WriteLine("1. Trilece");
				Console.WriteLine("2. Kazandibi");
				Console.WriteLine("3. Rice Pudding\n");
				Console.WriteLine("---------Desserts---------\n");
			}

			*/

			#endregion

			#region Switch Case

			/*
			 
			Console.Write("Month Number: ");
			int monthNumber = int.Parse(Console.ReadLine());

			switch (monthNumber)
			{
				case 1: Console.Write("January"); break;
				case 2: Console.Write("February"); break;
				case 3: Console.Write("March"); break;
				case 4: Console.Write("April"); break;
				case 5: Console.Write("May"); break;
				case 6: Console.Write("June"); break;
				case 7: Console.Write("July"); break;
				case 8: Console.Write("August"); break;
				case 9: Console.Write("September"); break;
				case 10: Console.Write("October"); break;
				case 11: Console.Write("November"); break;
				case 12: Console.Write("December"); break;
				default: Console.Write("Unknown Month"); break;
			}

			*/

			#endregion

			#region Switch Case Calculator App

			int number1, number2, result;
			char symbol;

			Console.Write("Number1 : ");
			number1 = int.Parse(Console.ReadLine());

			Console.Write("Number2 : ");
			number2 = int.Parse(Console.ReadLine());

			Console.Write("Symbol : ( +, -, *, / ) = ");
			symbol = char.Parse(Console.ReadLine());


			switch (symbol)
			{
				case '+':
					result = number1 + number2;
					Console.WriteLine($"Result: {result}");
					break;

				case '-':
					result = number1 - number2;
					Console.WriteLine($"Result: {result}");
					break;

				case '*':
					result = number1 * number2;
					Console.WriteLine($"Result: {result}");
					break;

				case '/':
					result = number1 / number2;
					Console.WriteLine($"Result: {result}");
					break;
			}


			#endregion

			Console.Read();
		}
	}
}
