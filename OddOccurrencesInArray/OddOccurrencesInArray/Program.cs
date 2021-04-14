using System;
using System.Linq;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 100, 003 };
            var arraFind = Occurrence(array);
            Console.WriteLine(arraFind);

        }
        static int Occurrence(int[] array)
        {
            var groupArray = array.GroupBy(x => x).Where(x => x.Count() == 1);

            return groupArray.FirstOrDefault().Key;
        }
    }
}
