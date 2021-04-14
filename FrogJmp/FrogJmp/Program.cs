using System;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalJump = JumpFrog(10, 90, 30);
            Console.WriteLine(totalJump);


        }


        static int JumpFrog(int x, int y, int d)
        {
            
            int numberOfJumps = 0;

            if ((y - x) < d)
            {
                numberOfJumps = 1;
            }

            if ((y - x) % d == 0)
            {
                numberOfJumps = (y - x) / d;
            }
            else
            {
                numberOfJumps = ((y - x) / d) + 1;
            }

            return numberOfJumps;
        }

  
    }
}
