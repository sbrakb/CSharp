using System;

namespace _01_MainSubjects
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Console.Write

			Console.WriteLine("Hello World\n");

			Console.WriteLine("***** Categories *****\n");

			Console.WriteLine("1. Clothing, Shoes & Accessories");
			Console.WriteLine("2. Home & Patio");
			Console.WriteLine("3. Electronics");
			Console.WriteLine("4. School & Office");
			Console.WriteLine("5. Toys");
			Console.WriteLine("6. Sports, Fitness & Outdoors\n");

			Console.WriteLine("***** Categories *****\n");

			#endregion

			#region String

			// string
			// variable_type variable_name;

			//string name;
			//name = "John";
			//Console.WriteLine(name);


			// customer 1
			string customerFirstName = "John";
			int customerFirstNameWidth = customerFirstName.Length + 1;

			string customerLastName = "Doe";
			int customerLastNameWidth = customerLastName.Length + 1;

			string customerPhone = "+44 500 400 30 20";
			int customerPhoneWidth = customerPhone.Length + 1;

			string customerEmail = "johndoe@gmail.com";
			int customerEmailWidth = customerEmail.Length + 1;

			string customerCity = "London";
			int customerCityWidth = customerCity.Length + 1;

			Console.WriteLine("***** Reservation Cards *****\n");
			Console.WriteLine("Customer 1");
			Console.WriteLine("-------------------------------------");
			Console.WriteLine($"Firstname :{customerFirstName.PadLeft(customerFirstNameWidth)}");
			Console.WriteLine($"Lastname  :{customerLastName.PadLeft(customerLastNameWidth)}");
			Console.WriteLine($"Phone     :{customerPhone.PadLeft(customerPhoneWidth)}");
			Console.WriteLine($"Email     :{customerEmail.PadLeft(customerEmailWidth)}");
			Console.WriteLine($"City      :{customerCity.PadLeft(customerCityWidth)}");
			Console.WriteLine("-------------------------------------\n");

			// customer 2
			customerFirstName = "Alice";
			customerFirstNameWidth = customerFirstName.Length + 1;

			customerLastName = "Doe";
			customerLastNameWidth = customerLastName.Length + 1;

			customerPhone = "+44 400 300 80 70";
			customerPhoneWidth = customerPhone.Length + 1;

			customerEmail = "alicedoe@gmail.com";
			customerEmailWidth = customerEmail.Length + 1;

			customerCity = "Manchester";
			customerCityWidth = customerCity.Length + 1;

			Console.WriteLine("Customer 2");
			Console.WriteLine("-------------------------------------");
			Console.WriteLine($"Firstname :{customerFirstName.PadLeft(customerFirstNameWidth)}");
			Console.WriteLine($"Lastname  :{customerLastName.PadLeft(customerLastNameWidth)}");
			Console.WriteLine($"Phone     :{customerPhone.PadLeft(customerPhoneWidth)}");
			Console.WriteLine($"Email     :{customerEmail.PadLeft(customerEmailWidth)}");
			Console.WriteLine($"City      :{customerCity.PadLeft(customerCityWidth)}");
			Console.WriteLine("-------------------------------------\n");

			#endregion

			#region Int


			// int
			// int number = 90;
			// Console.WriteLine(number);

			int hamburgerPrice = 300;
			int cokePrice = 35;
			int waterPrice = 10;
			int friesPrice = 50;
			int pizzaPrice = 200;
			int lemonadePrice = 25;

			Console.WriteLine("***** Menu *****\n");

			Console.WriteLine($"-----  Hamburger : {hamburgerPrice, 5} TL");
			Console.WriteLine($"-----  Pizza     : {pizzaPrice, 5} TL");
			Console.WriteLine($"-----  Kola      : {cokePrice, 5} TL");
			Console.WriteLine($"-----  Limonata  : {lemonadePrice, 5} TL");
			Console.WriteLine($"-----  Kızartma  : {friesPrice, 5} TL");
			Console.WriteLine($"-----  Su        : {waterPrice, 5} TL\n");

			Console.WriteLine("***** Menu *****\n");

			int totalHamburgerPrice, totalCokePrice, totalWaterPrice, totalFricePrice, totalPizzaPrice, totalLemonadePrice;

			int hamburgerCount = 3;
			int cokeCount = 3;
			int waterCount = 3;
			int friesCount = 1;
			int pizzaCount = 0;
			int lemonadeCount = 0;

			totalHamburgerPrice = hamburgerPrice *hamburgerCount;
			totalCokePrice = cokePrice * cokeCount;
			totalWaterPrice = waterPrice * waterCount;
			totalFricePrice = friesPrice * friesCount;
			totalPizzaPrice = pizzaPrice * pizzaCount;
			totalLemonadePrice = lemonadePrice * lemonadeCount;

			int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFricePrice + totalPizzaPrice + totalLemonadePrice;
			Console.WriteLine("***** Your Order *****\n");
			Console.WriteLine($"Hamburger (x{hamburgerCount})   : {totalHamburgerPrice,5} TL");
			Console.WriteLine($"Pizza     (x{pizzaCount})   : {totalPizzaPrice,5} TL");
			Console.WriteLine($"Kola      (x{cokeCount})   : {totalCokePrice,5} TL");
			Console.WriteLine($"Limonata  (x{lemonadeCount})   : {totalLemonadePrice,5} TL");
			Console.WriteLine($"Kızartma  (x{friesCount})   : {totalFricePrice,5} TL");
			Console.WriteLine($"Su        (x{waterCount})   : {totalWaterPrice,5} TL\n");

			Console.WriteLine($"Total Food Price : {totalPrice,5} TL");


			#endregion


			Console.Read();
		}
	}
}
