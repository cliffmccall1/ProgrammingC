using System;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // else if Statements
            var a = 5;
            var b = 6;
            if (a == 6)
            {
                Console.WriteLine("A equals six!");
            }
            else if (b == 6)
            {
                Console.WriteLine("B equals six!");
            }
            else
            {
                Console.WriteLine("False");
            }


            // First the variable rating is declared and set to 7.
            var rating = 7;

            // if the user rated the restaurant 5-stars, print "This food is the best! I could eat this every day."
            if (rating == 5)
            {
                Console.WriteLine("This food is the best! I could eat this every day.");
            }
            // if the user rated the restaurant 4-stars, print "Good meal."
            else if (rating == 4)
            {
                Console.WriteLine("Good meal.");
            }
            // if the user rated the restaurant 3-stars, print "It was OK."
            else if (rating == 3)
            {
                Console.WriteLine("It was OK.");
            }
            // if the user rated the restaurant 2-stars, print "I did not like this, but it's cheap."
            else if (rating == 2)
            {
                Console.WriteLine("I did not like this, but it's cheap.");
            }
            // if the user rated the restaurant 1-star,  print "I will never eat here again."
            else if (rating == 1)
            {
                Console.WriteLine("I will never eat here again.");
            }
            // Validation for number entered outside of rating.
            else
            {
                Console.WriteLine("Please enter a valid rating of 1-5.");
            }

            // inequality
            var frankAge = 30;
            var kevinAge = 40;
            Console.WriteLine(frankAge != kevinAge);

            // Logical Operators
            var isHungry = true;
            var isRestaurantOpen = true;

            if (isHungry && isRestaurantOpen)
            {
                Console.WriteLine("Go to the restaurant!");
            }
            else
            {
                Console.WriteLine("Don't go to the restaurant.");
            }

            var isSleepy = false;
            var isLibraryClosed = true;

            if (isSleepy || isLibraryClosed)
            {
                Console.WriteLine("You should leave now.");
            }
            else
            {
                Console.WriteLine("Keep on studying!");
            }

            // Arithmetic Operations

            var sum = 131 - 2 - 3 + 4 + 5;
            Console.WriteLine(sum);

            // multiplication
            var product = 6 * 3;
            Console.WriteLine(product);

            // division
            var quotient = 6 / 3;
            Console.WriteLine(quotient);

            // Modulus
            var remainder = 5 % 2;
            Console.WriteLine(remainder);

            // Concatenation
            var morningGreeting = "Good Morning, ";
            var name = "Alex";
            Console.WriteLine(morningGreeting + name);

            bool isProgrammer = true;
            Console.WriteLine("Am I a programmer? " + isProgrammer);

            int age = 30;
            Console.WriteLine("My age: " + age);

            // Length

            Console.WriteLine(morningGreeting.Length);

            // Lowercase & Uppercase
            Console.WriteLine((morningGreeting + name).ToUpper());
            Console.WriteLine((morningGreeting + name).ToLower());
        }
    }
}
