using System;

namespace game
{
    class GameProgram
    {
        static public void play()
        {
            for (int x = 1; x <= 100; x++)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine("Bling");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("Blong");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}