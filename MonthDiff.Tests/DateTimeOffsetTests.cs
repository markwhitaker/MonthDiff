namespace MonthDiff.Tests;

public class DateTimeOffsetTests
{
    [Test]
    public void TestOneMonthApart()
    {
        Assert.That(new DateTimeOffset(2014, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 2, 1, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(1));
    }

    [Test]
    public void TestJustUnderOneMonthApart()
    {
        Assert.That(new DateTimeOffset(2014, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 1, 31, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(0));
    }

    [Test]
    public void TestJustOverOneMonthApart()
    {
        Assert.That(new DateTimeOffset(2014, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 2, 2, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(1));
    }

    [Test]
    public void Test31JanuaryTo28February()
    {
        Assert.That(new DateTimeOffset(2014, 1, 31, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 2, 28, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(1));
    }

    [Test]
    public void TestLeapYear29FebruaryTo29March()
    {
        Assert.That(new DateTimeOffset(2012, 2, 29, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2012, 3, 29, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(1));
    }

    [Test]
    public void TestWholeYearMinusOneDay()
    {
        Assert.That(new DateTimeOffset(2012, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2012, 12, 31, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(11));
    }

    [Test]
    public void TestWholeYear()
    {
        Assert.That(new DateTimeOffset(2012, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2013, 1, 1, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(12));
    }

    [Test]
    public void TestLeapYear28FebruaryToNonLeapYear28February()
    {
        Assert.That(new DateTimeOffset(2012, 2, 29, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2013, 2, 28, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(12));
    }

    [Test]
    public void Test100Years()
    {
        Assert.That(new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2100, 1, 1, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(1200));
    }

    [Test]
    public void TestSameDate()
    {
        Assert.That(new DateTimeOffset(2014, 8, 5, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2014, 8, 5, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(0));
    }

    [Test]
    public void TestPastDate()
    {
        Assert.That(new DateTimeOffset(2012, 1, 1, 0, 0, 0, TimeSpan.Zero).GetTotalMonthsFrom(new DateTimeOffset(2011, 6, 10, 0, 0, 0, TimeSpan.Zero)), Is.EqualTo(6));
    }
}
