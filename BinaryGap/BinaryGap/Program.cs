using System;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Solution(1041);
            Console.WriteLine(t);
        }

        static int Solution(int N)
        {
            var maxGap = 0;
            var maxInterator = 0;
            var binaries = Convert.ToString(N, 2);

            for (int i = 0; i < binaries.Length; i++)
            {
                if (binaries[i] == '0')
                    maxInterator += 1;
                else
                {
                    if (maxInterator > maxGap)
                    {
                        maxGap = maxInterator;
                    }
                    maxInterator = 0;
                }

            }

            return maxGap;
        }
    }
}
