namespace MonthDiff.Tests;

[TestFixture]
public class DateTimeTests
{
    [Test]
    public void TestOneMonthApart()
    {
        Assert.That(new DateTime(2014, 1, 1).GetTotalMonthsFrom(new DateTime(2014, 2, 1)), Is.EqualTo(1));
    }

    [Test]
    public void TestJustUnderOneMonthApart()
    {
        Assert.That(new DateTime(2014, 1, 1).GetTotalMonthsFrom(new DateTime(2014, 1, 31)), Is.EqualTo(0));
    }

    [Test]
    public void TestJustOverOneMonthApart()
    {
        Assert.That(new DateTime(2014, 1, 1).GetTotalMonthsFrom(new DateTime(2014, 2, 2)), Is.EqualTo(1));
    }

    [Test]
    public void Test31JanuaryTo28February()
    {
        Assert.That(new DateTime(2014, 1, 31).GetTotalMonthsFrom(new DateTime(2014, 2, 28)), Is.EqualTo(1));
    }

    [Test]
    public void TestLeapYear29FebruaryTo29March()
    {
        Assert.That(new DateTime(2012, 2, 29).GetTotalMonthsFrom(new DateTime(2012, 3, 29)), Is.EqualTo(1));
    }

    [Test]
    public void TestWholeYearMinusOneDay()
    {
        Assert.That(new DateTime(2012, 1, 1).GetTotalMonthsFrom(new DateTime(2012, 12, 31)), Is.EqualTo(11));
    }

    [Test]
    public void TestWholeYear()
    {
        Assert.That(new DateTime(2012, 1, 1).GetTotalMonthsFrom(new DateTime(2013, 1, 1)), Is.EqualTo(12));
    }

    [Test]
    public void TestLeapYear28FebruaryToNonLeapYear28February()
    {
        Assert.That(new DateTime(2012, 2, 29).GetTotalMonthsFrom(new DateTime(2013, 2, 28)), Is.EqualTo(12));
    }

    [Test]
    public void Test100Years()
    {
        Assert.That(new DateTime(2000, 1, 1).GetTotalMonthsFrom(new DateTime(2100, 1, 1)), Is.EqualTo(1200));
    }

    [Test]
    public void TestSameDate()
    {
        Assert.That(new DateTime(2014, 8, 5).GetTotalMonthsFrom(new DateTime(2014, 8, 5)), Is.EqualTo(0));
    }

    [Test]
    public void TestPastDate()
    {
        Assert.That(new DateTime(2012, 1, 1).GetTotalMonthsFrom(new DateTime(2011, 6, 10)), Is.EqualTo(6));
    }
}
