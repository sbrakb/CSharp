using System;

namespace _02_Variables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Double

			/*

			double number;
			number = 4.85;
			Console.WriteLine(number);

			Console.WriteLine("***** Price List *****");
			Console.WriteLine();

			double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

			applePrice = 14.85;
			orangePrice = 20.95;
			strawberryPrice = 45;
			potatoPrice = 9.74;
			tomatoPrice = 6.88;

			Console.OutputEncoding = Encoding.Unicode;  // ₺ sembolü için

			Console.WriteLine($"----- Apple Unit Price       : {applePrice,5} ₺");
			Console.WriteLine($"----- Orange Unit Price      : {orangePrice,5} ₺");
			Console.WriteLine($"----- Strawberry Unit Price  : {strawberryPrice,5} ₺");
			Console.WriteLine($"----- Potato Unit Price      : {potatoPrice,5} ₺");
			Console.WriteLine($"----- Tomato Unit Price      : {tomatoPrice,5} ₺\n");

			double appleGr = 1.245;
			double orangeGr = 2.650;
			double strawberryGr = 0.750;
			double potatoGr = 4.859;
			double tomatoGr = 3.745;


			double totalApplePrice = applePrice * appleGr;
			double totalOrangePrice = orangePrice * orangeGr;
			double totalStrawberryPrice = strawberryPrice * strawberryGr;
			double totalPotatoPrice = potatoPrice * potatoGr;
			double totalTomatoPrice = tomatoPrice * tomatoGr;


			double totalPrice = totalApplePrice + totalOrangePrice + totalStrawberryPrice + totalPotatoPrice + totalTomatoPrice;

			Console.WriteLine(" ***** Your Order *****\n");
			Console.WriteLine($"Apple       | {totalApplePrice,10} ₺  |  {appleGr * 1000, 5} gr");
			Console.WriteLine($"Orange      | {totalOrangePrice,10} ₺  |  {orangeGr * 1000, 5} gr");
			Console.WriteLine($"Strawberry  | {totalStrawberryPrice,10} ₺  |  { strawberryGr * 1000,5} gr");
			Console.WriteLine($"Potato      | {totalPotatoPrice,10} ₺  |  {potatoGr * 1000,5} gr");
			Console.WriteLine($"Tomato      | {totalTomatoPrice,10} ₺  |  {tomatoGr * 1000,5} gr\n");

			Console.WriteLine($"Total Price : {totalPrice,10} ₺\n");

			*/

			#endregion

			#region Char

			/*

			char symbol;
			symbol = 'a';
			Console.WriteLine(symbol);
			Console.WriteLine();

			#endregion

			#region Console.ReadLine

			Console.WriteLine("**** Passenger Informations *****\n");
			string firstName, lastName, district, city, age, identityNumber;

			Console.Write("Firstname : ");
			firstName = Console.ReadLine();

			Console.Write("Lastname  : ");
			lastName = Console.ReadLine();

			Console.WriteLine($"Name      : {firstName} {lastName}");

			Console.Write("District  : ");
			district = Console.ReadLine();

			Console.Write("City      : ");
			city = Console.ReadLine();

			Console.Write("Age       : ");
			age = Console.ReadLine();

			Console.Write("Identity Number : ");
			identityNumber = Console.ReadLine();

			Console.WriteLine();
            Console.WriteLine($"Name                 | District   | City       | Age   | Identity Number");
            Console.WriteLine("-------------------------------------------------------------------------");

			Console.WriteLine($"{firstName + " " + lastName,-20} | {district,-10} | {city,-10} | {age,-5} | {identityNumber}");

			*/

			#endregion

			#region Convert To Int

			/*

			int shoePrice, computerPrice, chairPrice, tvPrice;
			shoePrice = 1000;
			computerPrice = 20000;
			chairPrice = 5000;
			tvPrice = 12000;

			int shoesCount, computerCount, chairCount, tvCount;

			Console.Write("Shoes Count     : ");
			shoesCount = Convert.ToInt32(Console.ReadLine());


			Console.Write("Computers Count : ");
			computerCount = Convert.ToInt32(Console.ReadLine());

			Console.Write("Chairs Count    : ");
			chairCount = Convert.ToInt32(Console.ReadLine());

			Console.Write("TVs Count       : ");
			tvCount = Convert.ToInt32(Console.ReadLine());

			int totalPrice = shoePrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

			Console.WriteLine($"Total Price     : {totalPrice} ₺");

			*/

			#endregion

			#region Convert To Double

			/*

			double exam1, exam2, exam3, result;
			Console.Write("Exam 1 : ");
			exam1 = double.Parse(Console.ReadLine());

			Console.Write("Exam 2 : ");
			exam2 = double.Parse(Console.ReadLine());

			Console.Write("Exam 3 : ");
			exam3 = double.Parse(Console.ReadLine());

			result = (exam1 + exam2 + exam3) / 3;
			Console.WriteLine("Your Exam Average : " + result);

			*/

			#endregion

			#region Console.Char

			/*
			 * 
			char gender;
			Console.Write("Gender (M/F) : ");
			gender = char.Parse(Console.ReadLine());

			Console.WriteLine("Gender : " + gender);

			*/

			#endregion

			Console.Read();
		}
	}
}
