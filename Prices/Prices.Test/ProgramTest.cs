using NUnit.Framework;
using System;
using System.Collections.Generic;
using Xunit;

namespace Prices.Test
{
    public class ProgramTest
    {
        [Test]
        public void Four_Possibilities()
        {
            Program.priceOfJeans = new List<int>();
            Program.priceOfJeans.Add(2);
            Program.priceOfJeans.Add(3);

            Program.priceOfShoes = new List<int>();
            Program.priceOfShoes.Add(4);

            Program.priceOfSkirts = new List<int>();
            Program.priceOfSkirts.Add(2);
            Program.priceOfSkirts.Add(3);

            Program.priceOfTops = new List<int>();
            Program.priceOfTops.Add(1);
            Program.priceOfTops.Add(2);

            Program.dollars = 10;
            var totalPossibilities = Program.getNumberOfOptions();

            Assert.AreEqual(4, totalPossibilities);
        }

        [Test]
        public void Six_Possibilities()
        {
            Program.priceOfJeans = new List<int>();
            Program.priceOfJeans.Add(3);

            Program.priceOfShoes = new List<int>();
            Program.priceOfShoes.Add(4);

            Program.priceOfSkirts = new List<int>();
            Program.priceOfSkirts.Add(2);
            Program.priceOfSkirts.Add(3);
            Program.priceOfSkirts.Add(1);

            Program.priceOfTops = new List<int>();
            Program.priceOfTops.Add(1);
            Program.priceOfTops.Add(2);
            Program.priceOfTops.Add(1);

            Program.dollars = 10;
            var totalPossibilities = Program.getNumberOfOptions();

            Assert.AreEqual(6, totalPossibilities);
        }

        [Test]
        public void Data_Load_Random()
        {
            Random rnd = new Random();
            int totalLoop = 9000;
            int minPrice = 1;
            int maxPrice = 100;

            Program.priceOfJeans = new List<int>();
            for (int i = 0; i < totalLoop; i++)
            {
                Program.priceOfJeans.Add(rnd.Next(minPrice, maxPrice));
            }

            Program.priceOfShoes = new List<int>();
            for (int i = 0; i < totalLoop; i++)
            {
                Program.priceOfShoes.Add(rnd.Next(minPrice, maxPrice));
            }

            Program.priceOfSkirts = new List<int>();
            for (int i = 0; i < totalLoop; i++)
            {
                Program.priceOfSkirts.Add(rnd.Next(minPrice, maxPrice));
            }

            Program.priceOfTops = new List<int>();
            for (int i = 0; i < totalLoop; i++)
            {
                Program.priceOfTops.Add(rnd.Next(minPrice, maxPrice));
            }

            Program.dollars = rnd.Next(100, 1000);

            var watch = System.Diagnostics.Stopwatch.StartNew();

            Program.getNumberOfOptions();

            watch.Stop();

            var elapsedMs = watch.ElapsedMilliseconds / 1000;

            Assert.LessOrEqual(elapsedMs, 3);
        }




    }
}