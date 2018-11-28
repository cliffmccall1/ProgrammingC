using System;

namespace runTime
{
    class Run
    {
        public static void Divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("You can't divide by 0");
            }
            else
            {
                Console.WriteLine(a / b);

            }
        }
        public static void Runner()
        {
            Divide(5, 0);
        }
    }
}
