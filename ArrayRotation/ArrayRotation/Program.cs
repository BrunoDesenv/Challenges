using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 8, 9, 7, 6 };
            var arrayRotate = ArrayRotation(array, 3);

            foreach (var item in arrayRotate)
            {
                Console.WriteLine(item);
            }
        }

        static int[] ArrayRotation(int[] array, int k)
        {
            for (int j = 0; j < k; j++)
            {
                int[] copyArray = (int[])array.Clone();
                for (int i = 0; i < array.Length; i++)
                {
                    if (i + 1 == array.Length)
                    {
                        array[0] = copyArray[array.Length - 1];
                    }
                    else
                    {
                        array[i + 1] = copyArray[i];
                    }
                
                }
            }

            return array;
        }
    }
}
