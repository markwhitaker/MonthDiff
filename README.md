# MonthDiff

A very simple pair of extension method on `DateTime` and `DateTimeOffset` to calculate the difference between two dates in months.

I wanted it to work exactly like a `TotalMonths` property on `TimeSpan` would work, i.e. return the count of complete months between two dates, ignoring any partial months. Because it's based on `DateTime.AddMonths()` it respects different month lengths and returns what a human would understand as a period of months. Unfortunately it can't be implemented as an extension method on `TimeSpan` because that doesn't retain knowledge of the actual dates used, and for months they're important.

Originally posted at [StackOverflow](http://stackoverflow.com/questions/1525990/calculating-the-difference-in-months-between-two-dates/25136172#25136172).