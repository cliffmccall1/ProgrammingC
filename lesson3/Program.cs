using System;

namespace lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            string[] theBeatles = { "John", "George", "Paul", "Ringo" };
            Console.WriteLine(theBeatles[3]);
            Console.WriteLine(theBeatles.Length);
            string[] groceryList = new String[4];
            groceryList[0] = "bread";
            groceryList[1] = "eggs";
            groceryList[2] = "milk";
            groceryList[3] = "tea";

            Console.WriteLine(groceryList[1]);
            groceryList[1] = "beans";
            Console.WriteLine(groceryList[1]);

            int[] temperature = { 120, 122, 121, 118, 119 };
            Console.WriteLine(temperature[0]);
            Console.WriteLine(temperature[4]);

            // Loops
            // int myNumber = 1;
            // while loop
            // while (myNumber < 10)
            // {
            //     Console.WriteLine(myNumber);
            //     myNumber++;
            // }

            // do-while
            // do
            // {
            //     Console.WriteLine(myNumber);
            //     myNumber++;
            // } while (myNumber < 10);

            // for loop
            for (int count = 10; count > 0; count--)
            {
                Console.WriteLine(count);
            }
            Console.WriteLine("Lift off!");

            // Looping Through Arrays
            string[] myArray = { "Albert", "Kirsten", "Hester", "Henry" };
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i] + ", hello!");
            }

            // int[] results = new int[numbers.Length];
            // for(int idx = 0; idx < numbers.Length; idx++) {
            //     results[idx] = numbers[idx] * 2;
            // }
            // return results;

            // double results = 0.0;
            // if(numbers.Length > 0) {
            //     int idx = 0;
            //     do {
            //         results += numbers[idx];
            //         idx++;
            //     }
            //     while(idx < numbers.Length);
            //     results /= numbers.Length;
            // }
            // return results;
        }
    }
}
