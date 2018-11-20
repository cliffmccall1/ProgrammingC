using System;

namespace lesson4HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            Console.WriteLine("Doubled Number: " + DoubleMe(4));
            // Part 2
            Console.WriteLine("Quadrupled Number: " + QuadrupleMe(5));
            // Part 3
            Console.WriteLine("Number Doubled Many Times: " + DoubleNumberMultipleTimes(2, 4));

        }

        // Part 1
        public static int DoubleMe(int value)
        {
            return value * 2;
        }

        // Part 2
        public static int QuadrupleMe(int value)
        {
            return (DoubleMe(DoubleMe(value)));
        }

        // Part 3
        public static int DoubleNumberMultipleTimes(int doubled, int times)
        {
            for (int i = 0; i < times; i++)
            {
                doubled = DoubleMe(doubled);
            }
            return doubled;
        }
    }
}
