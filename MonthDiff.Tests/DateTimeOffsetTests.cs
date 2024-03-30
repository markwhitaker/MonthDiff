namespace MonthDiff.Tests;

public class DateTimeOffsetTests
{
    [Test]
    public void TestOneMonthApart()
    {
        var from = new DateTimeOffset(2014, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2014, 2, 1, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 1;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestJustUnderOneMonthApart()
    {
        var from = new DateTimeOffset(2014, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2014, 1, 31, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 0;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestJustOverOneMonthApart()
    {
        var from = new DateTimeOffset(2014, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2014, 2, 2, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 1;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void Test31JanuaryTo28February()
    {
        var from = new DateTimeOffset(2014, 1, 31, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2014, 2, 28, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 1;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestLeapYear29FebruaryTo29March()
    {
        var from = new DateTimeOffset(2012, 2, 29, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2012, 3, 29, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 1;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestWholeYearMinusOneDay()
    {
        var from = new DateTimeOffset(2012, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2012, 12, 31, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 11;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestWholeYear()
    {
        var from = new DateTimeOffset(2012, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2013, 1, 1, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 12;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestLeapYear28FebruaryToNonLeapYear28February()
    {
        var from = new DateTimeOffset(2012, 2, 29, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2013, 2, 28, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 12;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void Test100Years()
    {
        var from = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2100, 1, 1, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 1200;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestSameDate()
    {
        var from = new DateTimeOffset(2014, 8, 5, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2014, 8, 5, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 0;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestPastDate()
    {
        var from = new DateTimeOffset(2012, 1, 1, 0, 0, 0, TimeSpan.Zero);
        var to = new DateTimeOffset(2011, 6, 10, 0, 0, 0, TimeSpan.Zero);
        const int expectedDiffInMonths = 6;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }
}
