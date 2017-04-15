using System;
using MonthDiff.Lib;
using NUnit.Framework;

namespace MonthDiff.Tests
{
    public class DateTimeOffsetTests
    {
        [Test]
        public void TestOneMonthApart()
        {
            Assert.AreEqual(1, new DateTimeOffset(2014, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 2, 1, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void TestJustUnderOneMonthApart()
        {
            Assert.AreEqual(0, new DateTimeOffset(2014, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 1, 31, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void TestJustOverOneMonthApart()
        {
            Assert.AreEqual(1, new DateTimeOffset(2014, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 2, 2, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void Test31JanuaryTo28February()
        {
            Assert.AreEqual(1, new DateTimeOffset(2014, 1, 31, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 2, 28, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void TestLeapYear29FebruaryTo29March()
        {
            Assert.AreEqual(1, new DateTimeOffset(2012, 2, 29, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2012, 3, 29, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void TestWholeYearMinusOneDay()
        {
            Assert.AreEqual(11, new DateTimeOffset(2012, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2012, 12, 31, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void TestWholeYear()
        {
            Assert.AreEqual(12, new DateTimeOffset(2012, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2013, 1, 1, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void TestLeapYear28FebruaryToNonLeapYear28February()
        {
            Assert.AreEqual(12, new DateTimeOffset(2012, 2, 29, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2013, 2, 28, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void Test100Years()
        {
            Assert.AreEqual(1200, new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2100, 1, 1, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void TestSameDate()
        {
            Assert.AreEqual(0, new DateTimeOffset(2014, 8, 5, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 8, 5, 0, 0, 0, TimeSpan.Zero)));
        }

        [Test]
        public void TestPastDate()
        {
            Assert.AreEqual(6, new DateTimeOffset(2012, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2011, 6, 10, 0, 0, 0, TimeSpan.Zero)));
        }

    }
}