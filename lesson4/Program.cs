using System;

namespace lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetPerson("Cliff");
            GreetPerson("Emilia");
            GreetPerson("Thomas");
            GreetPerson("Gail");
            GreetPerson("Abraham");

            Console.WriteLine(IsEven(3));

            int num1 = 1;
            int num2 = 2;

            int add = Sum(num1, num2);
            Console.WriteLine(add);
        }

        public static void GreetPerson(string personName)
        {
            Console.WriteLine("Hello " + personName);
        }
        public static bool IsEven(int number)
        {
            bool result;

            if (number % 2 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public static int Sum(int num1, int num2)
        {
            return (num1 + num2);
        }
    }
}
