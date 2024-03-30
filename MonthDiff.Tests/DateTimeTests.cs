namespace MonthDiff.Tests;

[TestFixture]
public class DateTimeTests
{
    [Test]
    public void TestOneMonthApart()
    {
        var from = new DateTime(2014, 1, 1);
        var to = new DateTime(2014, 2, 1);
        const int expectedDiffInMonths = 1;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestJustUnderOneMonthApart()
    {
        var from = new DateTime(2014, 1, 1);
        var to = new DateTime(2014, 1, 31);
        const int expectedDiffInMonths = 0;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestJustOverOneMonthApart()
    {
        var from = new DateTime(2014, 1, 1);
        var to = new DateTime(2014, 2, 2);
        const int expectedDiffInMonths = 1;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void Test31JanuaryTo28February()
    {
        var from = new DateTime(2014, 1, 31);
        var to = new DateTime(2014, 2, 28);
        const int expectedDiffInMonths = 1;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestLeapYear29FebruaryTo29March()
    {
        var from = new DateTime(2012, 2, 29);
        var to = new DateTime(2012, 3, 29);
        const int expectedDiffInMonths = 1;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestWholeYearMinusOneDay()
    {
        var from = new DateTime(2012, 1, 1);
        var to = new DateTime(2012, 12, 31);
        const int expectedDiffInMonths = 11;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestWholeYear()
    {
        var from = new DateTime(2012, 1, 1);
        var to = new DateTime(2013, 1, 1);
        const int expectedDiffInMonths = 12;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestLeapYear28FebruaryToNonLeapYear28February()
    {
        var from = new DateTime(2012, 2, 29);
        var to = new DateTime(2013, 2, 28);
        const int expectedDiffInMonths = 12;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void Test100Years()
    {
        var from = new DateTime(2000, 1, 1);
        var to = new DateTime(2100, 1, 1);
        const int expectedDiffInMonths = 1200;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestSameDate()
    {
        var from = new DateTime(2014, 8, 5);
        var to = new DateTime(2014, 8, 5);
        const int expectedDiffInMonths = 0;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }

    [Test]
    public void TestPastDate()
    {
        var from = new DateTime(2012, 1, 1);
        var to = new DateTime(2011, 6, 10);
        const int expectedDiffInMonths = 6;

        var actualDiffInMonths = from.GetTotalMonthsFrom(to);

        Assert.That(actualDiffInMonths, Is.EqualTo(expectedDiffInMonths));
    }
}
