using System;
using System.Collections;
using System.Linq;

namespace FrogRiverOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 1, 4, 2, 3, 5, 4 };

            var returnTime = JumpFrog(5, array);

            Console.WriteLine(returnTime);
        }

        public static int JumpFrog(int X, int[] A)
        {
            int[] sequence = Enumerable.Range(1, X).ToArray();
            var timeToJump = -1;

            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[j] == sequence[i])
                    {
                        timeToJump = j;
                        continue;
                    }
                }
            }

            return timeToJump;
        }

    }
}
