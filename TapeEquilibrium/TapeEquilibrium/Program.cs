using System;
using System.Collections.Generic;
using System.Linq;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 1, 2, 4, 3 };
            var returnTape = ReturnNumberTape(A);
            Console.WriteLine(returnTape);
        }

        static int ReturnNumberTape(int[] A)
        {
            int leftTotal = 0;
            int rightTotal = 0;
            int[] difference = new int[A.Length - 1];

            for (int P = 0; P < A.Length; P++)
            {
                rightTotal += A[P];
            }

            for (int i = 0; i < A.Length -1; i++)
            {
                leftTotal += A[i];
                var rightTotalLocal = rightTotal - leftTotal;
                var leftHigherRight = leftTotal > rightTotalLocal;

                difference[i] = leftHigherRight ? leftTotal - rightTotalLocal : rightTotalLocal - leftTotal;
            }


            return difference.Min();
        }
    }
}
