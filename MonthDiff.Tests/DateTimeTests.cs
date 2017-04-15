using System;
using MonthDiff.Lib;
using NUnit.Framework;

namespace MonthDiff.Tests
{
    [TestFixture]
    public class DateTimeTests
    {
        [Test]
        public void TestOneMonthApart()
        {
            Assert.AreEqual(1, new DateTime(2014, 1, 1).GetTotalMonthsFrom(new DateTime(2014, 2, 1)));
        }

        [Test]
        public void TestJustUnderOneMonthApart()
        {
            Assert.AreEqual(0, new DateTime(2014, 1, 1).GetTotalMonthsFrom(new DateTime(2014, 1, 31)));
        }

        [Test]
        public void TestJustOverOneMonthApart()
        {
            Assert.AreEqual(1, new DateTime(2014, 1, 1).GetTotalMonthsFrom(new DateTime(2014, 2, 2)));
        }

        [Test]
        public void Test31JanuaryTo28February()
        {
            Assert.AreEqual(1, new DateTime(2014, 1, 31).GetTotalMonthsFrom(new DateTime(2014, 2, 28)));
        }

        [Test]
        public void TestLeapYear29FebruaryTo29March()
        {
            Assert.AreEqual(1, new DateTime(2012, 2, 29).GetTotalMonthsFrom(new DateTime(2012, 3, 29)));
        }

        [Test]
        public void TestWholeYearMinusOneDay()
        {
            Assert.AreEqual(11, new DateTime(2012, 1, 1).GetTotalMonthsFrom(new DateTime(2012, 12, 31)));
        }

        [Test]
        public void TestWholeYear()
        {
            Assert.AreEqual(12, new DateTime(2012, 1, 1).GetTotalMonthsFrom(new DateTime(2013, 1, 1)));
        }

        [Test]
        public void TestLeapYear28FebruaryToNonLeapYear28February()
        {
            Assert.AreEqual(12, new DateTime(2012, 2, 29).GetTotalMonthsFrom(new DateTime(2013, 2, 28)));
        }

        [Test]
        public void Test100Years()
        {
            Assert.AreEqual(1200, new DateTime(2000, 1, 1).GetTotalMonthsFrom(new DateTime(2100, 1, 1)));
        }

        [Test]
        public void TestSameDate()
        {
            Assert.AreEqual(0, new DateTime(2014, 8, 5).GetTotalMonthsFrom(new DateTime(2014, 8, 5)));
        }

        [Test]
        public void TestPastDate()
        {
            Assert.AreEqual(6, new DateTime(2012, 1, 1).GetTotalMonthsFrom(new DateTime(2011, 6, 10)));
        }
    }
}
