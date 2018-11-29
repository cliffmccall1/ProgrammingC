using System;

namespace myNamespaceTwo
{
    class ProgramTwo
    {
        static public int sequence(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static public void print()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(sequence(i));
            }
        }
    }
}