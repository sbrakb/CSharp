using System;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loop
            /*
            string[] cities = { "London", "Paris", "Lyon" };
            foreach (string city in cities)
                Console.WriteLine(city);

            int[] numbers = { 3, 45, 52, 41, 86, 10, 22, 35 };
            foreach (int number in numbers)
                Console.WriteLine(number);

            Console.WriteLine("Even Numbers");
            foreach (int number in numbers)
            {
                if (number % 2 == 0) Console.WriteLine(number);
            }

            Console.WriteLine("Sum");
            int sum = 0;
            foreach (int number in numbers)
                sum += number;
            Console.WriteLine(sum);

            List<int> numbers2 = new List<int>()
            {
                1,2, 3, 4, 5, 6, 7
            };
            foreach (int number in numbers2)
                Console.WriteLine(number);

            string word = "Hello";
            foreach(char ch in word) Console.WriteLine(ch);
            */
            #endregion

            #region Sample Exam System App
            Console.Write("*** Exam App ***\n\n\n");
            Console.WriteLine("------------------------------");
            Console.Write("Count Of Students : ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Student's Name : ");
                studentNames[i] = Console.ReadLine();

                double totalExamsResult = 0;

                // 3 exam result for each student
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{j + 1}. Exam : ");
                    totalExamsResult += double.Parse(Console.ReadLine());
                }

                studentExamAvg[i] = totalExamsResult / 3;
            }
            Console.WriteLine("Averages");
            for (int i = 0; i < studentNames.Length; i++)
            {
                string isSuccess = studentExamAvg[i] > 50 ? "success" : "failed";
                Console.WriteLine(studentNames[i] + " : " + studentExamAvg[i] + " => " + isSuccess);
            }
            #endregion

            Console.Read();
        }
    }
}
