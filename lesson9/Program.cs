/**************** Measuring Algorithm Performance ****************/
/*
using System;
using System.Diagnostics; //Measuring Algorithm Performance
using System.Collections.Generic; // Sieve of Eratosthenes

namespace lesson9
{
    class Program
    {
        // "simple" algorithm (iterative approach using a for loop) 
        static int SimpleSumIntegerUpToLimit(int limit)
        {
            int sum = 0;
            for (int count = 1; count <= limit; count++)
            {
                sum += count;
            }
            return sum;
        }
        */
// "clever' algorithm using Gauss' formula
/* 
static int CleverSumIntegerUpToLimit(int limit)
{
    return (limit * (limit + 1)) >> 1;
}

static void Main(string[] args)
{
    /* 
    int limit;
    int result;
    Stopwatch stopWatch = new Stopwatch();

    // test speed of the "simple algorithm to 10
    limit = 10;
    stopWatch.Start();
    result = SimpleSumIntegerUpToLimit(limit);
    stopWatch.Stop();
    Console.WriteLine("\nSimple algorithm to " + limit + " is: " + result);
    Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
    stopWatch.Reset();

    // test speed of the "clever" algorithm to 10
    stopWatch.Start();
    result = CleverSumIntegerUpToLimit(limit);
    stopWatch.Stop();
    Console.WriteLine("\nClever algorithm to " + limit + " is: " + result);
    Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
    stopWatch.Reset();

    // repeat "simple" algorithm test
    limit = 10;
    stopWatch.Start();
    result = SimpleSumIntegerUpToLimit(limit);
    stopWatch.Stop();
    Console.WriteLine("\nSimple algorithm to " + limit + " is: " + result);
    Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
    stopWatch.Reset();

    // repeat "clever" algorithm test
    stopWatch.Start();
    result = CleverSumIntegerUpToLimit(limit);
    stopWatch.Stop();
    Console.WriteLine("\nClever algorithm to " + limit + " is: " + result);
    Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
    stopWatch.Reset();

    // test speed of the "simple" algorithm to 1000
    limit = 1000;
    stopWatch.Start();
    result = SimpleSumIntegerUpToLimit(limit);
    stopWatch.Stop();
    Console.WriteLine("\nSimple algorithm to " + limit + " is: " + result);
    Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
    stopWatch.Reset();

    // test speed of the "clever" algorithm to 1000
    stopWatch.Start();
    result = CleverSumIntegerUpToLimit(limit);
    stopWatch.Stop();
    Console.WriteLine("\nClever algorithm to " + limit + " is: " + result);
    Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
    stopWatch.Reset();

}
}
}
*/
/**************** END ****************/


/**************** Sieve of Eratosthenes Algorithm ****************/
/*
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // O(n log log n)
        // create empty list
        List<int> nonPrimes = new List<int>();
        //define upper limit for testing 
        int max = 100;
        //iterate over numbers x from 2 to square root of max
        for (int x = 2; x * x <= max; x++)
        {
            // mark off all multiples of current number x as non-prime
            for (int y = x * 2; y < max; y += x)
            {
                if (!nonPrimes.Contains(y)) //avoid duplicates
                {
                    nonPrimes.Add(y);
                }
            }
        }
        // display the primes less than max
        for (int x = 2; x < max; x++) // 2 is smallest prime
        {
            if (!nonPrimes.Contains(x)) // only display if prime
            {
                Console.WriteLine(x);
            }
        }
    }
}
*/

/**************** END ****************/


/**************** Euclidean Algorithm ****************/
/*
using System;

class Program
{
    static int EuclideanAlgorithm(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }
        if (a == 0)
            return b;
        else
            return a;
    }
    static void Main()
    {
        int val1 = 252;
        int val2 = 105;
        int gcd = EuclideanAlgorithm(val1, val2);
        Console.WriteLine("The GCD of {0} and {1} is {2}", val1, val2, gcd);
    }
}
 */

/**************** END ****************/


/**************** Bubble Sort Algorithm ****************/
using System;

class Program
{
    static void Main()
    {
        // Array to be sorted
        int[] numbers = { 45, 72, 38, 62, 33, 87, 99, 11, 31, 15 };
        bool flag = true;
        int temp;
        // Sort the array 
        for (int i = 1; (i <= (numbers.Length - 1)) && flag; i++)
        {
            flag = false;
            for (int j = 0; j < (numbers.Length - 1); j++)
            {
                if (numbers[j + 1] > numbers[j])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                    flag = true;
                }
            }
        }
        // Display the sorted array
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}