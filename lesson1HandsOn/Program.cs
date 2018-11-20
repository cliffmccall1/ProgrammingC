using System;

namespace lesson1HandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = true;
            string wear = "Wear Sunglasses!";
            string dontWear = "You don't need to wear sunglasses";

            if (isSunny == true)
            {
                Console.WriteLine(wear);
            }
            else
            {
                Console.WriteLine(dontWear);
            }
            bool atBeach = true;
            string sunblock = "Sunblock is a good idea.";
            string noSunblock = "Sunblock isn't needed.";

            if (isSunny == true)
            {
                if (atBeach == true)
                {
                    Console.WriteLine(sunblock);
                }
                else
                {
                    Console.WriteLine(noSunblock);
                }
            }

            bool goTomorrow = true;
            string going = "Awesome! Glad you don't mind clouds!";
            string nextTime = "No worries! Hopefully next time we will have some sun!";

            if (isSunny == false)
            {
                if (goTomorrow == true)
                {
                    Console.WriteLine(going);
                }
                else
                {
                    Console.WriteLine(nextTime);
                }
            }
        }
    }
}
