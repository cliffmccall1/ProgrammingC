using System;
using aliasOne = myNamespace.AnotherProgram;
using aliasTwo = textNamespace.AnotherClass;

namespace lesson6HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            aliasOne.printText();
            aliasTwo.print();
        }
    }
}
