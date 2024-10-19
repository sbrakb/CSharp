using System;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods
            /*
            void CustomerList()
            {
                Console.WriteLine("Customer 1");
                Console.WriteLine("Customer 2");
                Console.WriteLine("Customer 3");
                Console.WriteLine("Customer 4");
                Console.WriteLine("Customer 5");
            }

            CustomerList();

            void Sum()
            {
                int x = 1, y = 2;
                int z = x + y;
                Console.WriteLine(z);
            }

            Sum();
            */
            #endregion

            #region Void Methods With Parameter
            /*
            void WriteCustomerName(string customerName)
            {
                Console.WriteLine(customerName);
            }

            WriteCustomerName("Customer 1");

            void CustomerCard(string firstName, string lastName)
            {
                Console.WriteLine($"Customer : {firstName} {lastName}");
            }

            CustomerCard("Firstname", "Lastname");

            void Sum(int x, int y)
            {
                Console.WriteLine(x + y);
            }

            Sum(3, 4);
            */
            #endregion

            #region Methods With Returning Value

            string CustomerName()
            {
                return "Customer";
            }

            CustomerName();

            string StudentCard()
            {
                return "firstname" + " lastname";
            }

            Console.WriteLine(StudentCard());

            string CountryCard(string countryName, string capital, string flagColor)
            {
                string cardInfo = "Country : " + countryName + "\nCapital : " + capital + "\nColor : " + flagColor;
                return cardInfo;
            }

            Console.WriteLine(CountryCard("Türkiye", "Ankara", "Red-White"));

            int Sum(int x, int y)
            { return x + y; }

            Console.WriteLine(Sum(4, 5));

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) /3;
                if (result > 50)
                    return $"{student} is success.\nResult : {result}";
                else
                    return $"{student} is failed.\nResult : {result}";
            }
            Console.WriteLine(ExamResult("Student", 50, 50, 50));
            #endregion

            Console.Read();
        }
    }
}
