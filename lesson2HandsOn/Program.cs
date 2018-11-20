using System;

namespace lesson2HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = 30;
            bool isStudent = true;

            // if age is a negative number
            if (age < 0)
            {
                Console.WriteLine("Invalid age, Try again.");
            }
            // if senior citizen, pay $7
            else if (age >= 65)
            {
                Console.WriteLine("$7");
            }
            // if child, pay $8
            else if (age <= 12 || isStudent)
            {
                Console.WriteLine("$8");
            }
            // everyone else, pay $10
            else
            {
                Console.WriteLine("$10");
            }
        }
    }
}
