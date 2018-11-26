using System;

namespace myNamespace
{
    class AnotherProgram
    {
        static public void printText()
        {
            Console.WriteLine("Hello Earth!");
        }
    }
}

namespace textNamespace
{
    class AnotherClass
    {
        static public void print()
        {
            Console.WriteLine("I am text from the textNamespace.");
        }
    }
}