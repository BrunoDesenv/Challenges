using System;
using System.Collections.Generic;

namespace Prices
{
    public class Program
    {
        static int priceOfJeansCount = 0;
        static int priceOfShoesCount = 0;
        static int priceOfSkirtsCount = 0;
        static int priceOfTopsCount = 0;

        public static List<int> priceOfJeans { get; set; }
        public static List<int> priceOfShoes { get; set; }
        public static List<int> priceOfSkirts { get; set; }
        public static List<int> priceOfTops { get; set; }
        public static int dollars { get; set; }

        public static void Main(string[] args)
        {
            priceOfJeans = new List<int>();
            priceOfShoes = new List<int>();
            priceOfSkirts = new List<int>();
            priceOfTops = new List<int>();

            Console.WriteLine("Enter with the amount of jeans.");
            int priceOfJeansCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Enter with the values.");
            for (int i = 0; i < priceOfJeansCount; i++)
            {
                int priceOfJeansItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfJeans.Add(priceOfJeansItem);
            }

            Console.WriteLine();
            Console.WriteLine("Enter with the amount of shoes.");
            int priceOfShoesCount = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Enter with the values.");
            for (int i = 0; i < priceOfShoesCount; i++)
            {
                int priceOfShoesItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfShoes.Add(priceOfShoesItem);
            }

            Console.WriteLine();
            Console.WriteLine("Enter with the amount of skirts.");
            int priceOfSkirtsCount = Convert.ToInt32(Console.ReadLine().Trim());


            Console.WriteLine("Enter with the values.");
            for (int i = 0; i < priceOfSkirtsCount; i++)
            {
                int priceOfSkirtsItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfSkirts.Add(priceOfSkirtsItem);
            }

            Console.WriteLine();
            Console.WriteLine("Enter with the amount of tops.");
            int priceOfTopsCount = Convert.ToInt32(Console.ReadLine().Trim());


            Console.WriteLine("Enter with the values.");
            for (int i = 0; i < priceOfTopsCount; i++)
            {
                int priceOfTopsItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfTops.Add(priceOfTopsItem);
            }

            Console.WriteLine();
            Console.WriteLine("Enter with the budgeted");
            dollars = Convert.ToInt32(Console.ReadLine().Trim());

            int possibilities = getNumberOfOptions();

            Console.WriteLine();
            Console.WriteLine($"There are a total of {possibilities} possibilities to buy the items.");
        }

        public static void OrderArrays()
        {
            priceOfJeans.Sort();
            priceOfShoes.Sort();
            priceOfSkirts.Sort();
            priceOfTops.Sort();
        }

        public static int getNumberOfOptions()
        {
            OrderArrays();

            int possibilities = 0;

            int contador = (priceOfJeans.Count * priceOfShoes.Count * priceOfSkirts.Count * priceOfTops.Count) / 2;
             
            for (int i = 0; i < contador; i++)
            {
                if (priceOfTopsCount == 0 && priceOfSkirtsCount == 0 && priceOfShoesCount == 0 && priceOfJeansCount == 0)
                {
                    possibilities += ValidadeIfCanAdd();
                }

                //Logic for the tops
                if (ValidateTops())
                {
                    priceOfTopsCount++;
                    possibilities += ValidadeIfCanAdd();
                }

                //Logic for the skirts
                if (ValidateSkirts())
                {
                    priceOfSkirtsCount++;
                    ResetPriceOfTopsCount();
                    possibilities += ValidadeIfCanAdd();
                }

                //Logic for priceOfShoes
                if (ValidateShoes())
                {
                    priceOfShoesCount++;
                    ResetPriceOfTopsCount();
                    ResetPriceOfSkirtsCount();
                    possibilities += ValidadeIfCanAdd();
                }

                //Logic for jeans
                if (ValidateJeans())
                {
                    priceOfJeansCount++;
                    ResetPriceOfTopsCount();
                    ResetPriceOfSkirtsCount();
                    ResetPriceOfShoesCount();
                    possibilities += ValidadeIfCanAdd();
                }
            }
            return possibilities;
        }

        #region ValidatorsIfNext
        public static bool ValidateTops()
        {
            return priceOfTopsCount < priceOfTops.Count - 1;
        }

        public static bool ValidateSkirts()
        {
            return priceOfTopsCount == priceOfTops.Count - 1 &&

                   priceOfSkirtsCount < priceOfSkirts.Count - 1;
        }

        public static bool ValidateShoes()
        {
            return
                priceOfTopsCount == priceOfTops.Count - 1 &&
                priceOfSkirtsCount == priceOfSkirts.Count - 1 &&

                priceOfShoesCount < priceOfShoes.Count - 1;
        }

        public static bool ValidateJeans()
        {
            return
                priceOfTopsCount == priceOfTops.Count - 1 &&
                priceOfSkirtsCount == priceOfSkirts.Count - 1 &&
                priceOfShoesCount == priceOfShoes.Count - 1 &&

                priceOfJeansCount < priceOfJeans.Count - 1;
        }
        #endregion

        #region ResetCounters
        public static void ResetPriceOfTopsCount()
        {
            priceOfTopsCount = 0;
        }

        public static void ResetPriceOfSkirtsCount()
        {
            priceOfSkirtsCount = 0;
        }

        public static void ResetPriceOfShoesCount()
        {
            priceOfShoesCount = 0;
        }
        #endregion

        public static int ValidadeIfCanAdd()
        {
            int soma = priceOfJeans[priceOfJeansCount] + priceOfShoes[priceOfShoesCount] + priceOfSkirts[priceOfSkirtsCount] + priceOfTops[priceOfTopsCount];
            if (soma <= dollars)
            {
                return 1;
            }
            return 0;
        }
    }
}