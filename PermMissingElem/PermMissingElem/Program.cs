using System;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 2, 3, 1, 5 };
            //int[] A = new int[] { 2, };
            var missingNumber = MissingNumber(A);
            Console.WriteLine(missingNumber);
        }

        static int MissingNumber(int[] A)
        {
            Array.Sort(A);

            if (A.Length == 0 || A[0] != 1)
            {
                return 1;
            }

            for (int i = 0; i < A.Length; i++)
            {
                if (i + 1 >= A.Length)
                {
                    return A[i] + 1;
                }
                else if (A[i] + 1 != A[i + 1])
                {
                    return  A[i] + 1;
                }
            }

            return 0;
        }
    }
}
