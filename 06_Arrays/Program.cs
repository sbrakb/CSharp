using System;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Array Samples
            /*
            string[] colors = new string[4];
            colors[0] = "Red";
            colors[1] = "Yellow";
            colors[2] = "White";
            colors[3] = "Blue";

            Console.WriteLine(colors[2]);

            string[] cities = new string[4];
            cities[0] = "Napoli";
            cities[1] = "Paris";
            cities[2] = "London";
            cities[3] = "Lyon";

            Console.WriteLine(cities[3]);

            int[] numbers = new int[10];
            numbers[0] = 3;
            numbers[1] = 4;
            numbers[2] = 5;

            Console.WriteLine(numbers[5]);

            string[] cities2 = { "London", "Paris", "Lyon" };
            Console.WriteLine(cities2[3]);
            */
            #endregion

            #region List Array Member's
            /*
            string[] colors = { "Yellow", "Red", "White", "Blue", "Green", "Orange", "Pink" };

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            int[] numbers = { 3, 4, 9, 12, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            char[] chars = { 'A', 'B', 'C', '*', '/', '-' };

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }

            // max number
            int[] numbers2 = { 3, 4, 12, 13, 23 };
            int max = numbers2[0];
            for (int i = 0; i < numbers2.Length; i++)
            {
                if (max < numbers2[i])
                    max = numbers2[i];
            }
            Console.WriteLine($"Max Number : {max}");
            */
            #endregion

            #region Array Methods
            /*
            string[] persons = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            Console.WriteLine(persons.Length);

            int[] numbers3 = { 3, 45, 52, 41, 86, 10, 22, 35 };
            Array.Sort(numbers3);
            for (int i = 0; i < numbers3.Length; i++)
                Console.WriteLine(numbers3[i]);

            Array.Reverse(numbers3);
            for (int i = 0; i < numbers3.Length; i++)
                Console.WriteLine(numbers3[i]);

            Console.WriteLine($"Max Number : {numbers3.Max()} Min Number : {numbers3.Min()}");

            string[] customers = { "ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            int index = Array.IndexOf(customers, "buse");
            Console.WriteLine($"IndexOf : {index}");
            */
            #endregion

            #region Get Value From User
            string[] cities = new string[5];

            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"Write {i + 1}. city : ");
                cities[i] = Console.ReadLine();
            }
            Console.WriteLine("*** Cities ***");
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }

            int[] numbers = { 15, 25, 35, 55, 15 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i];
            Console.WriteLine($"Sum : {sum}");

            int[] numbers2 = { 3, 12, 25, 18, 9, 36, 52, 35, 33 };
            Console.WriteLine("Even Numbers");
            for (int i = 0;i < numbers2.Length; i++)
            {
                if (numbers2[i]%2 == 0)
                    Console.WriteLine(numbers2[i]);
            }

            Console.WriteLine("Odd Numbers");
            for (int i = 0; i < numbers2.Length; i++)
            {
                if (numbers2[i] % 2 == 1)
                    Console.WriteLine(numbers2[i]);
            }
            #endregion

            Console.Read();
        }
    }
}
