using KlaviyoSharp.Models.Filters;
using Shouldly;

namespace KlaviyoSharp.Tests;

[Trait("Category", "Filter")]

public class Filter_Tests
{
    [Fact]
    public void Filters()
    {
        new Filter(FilterOperation.Equals, "last_name", "Smith").ToString().ShouldBe("equals(last_name,\"Smith\")");
        new Filter(FilterOperation.LessThan, "value", 25).ToString().ShouldBe("less-than(value,25)");
        new Filter(FilterOperation.LessOrEqual, "datetime", new DateTime(2001, 1, 1, 11, 0, 0, DateTimeKind.Utc)).ToString().ShouldBe("less-or-equal(datetime,2001-01-01T11:00:00Z)");
        new Filter(FilterOperation.GreaterThan, "datetime", new DateTime(2022, 4, 1, 11, 30, 0, DateTimeKind.Utc)).ToString().ShouldBe("greater-than(datetime,2022-04-01T11:30:00Z)");
        new Filter(FilterOperation.GreaterThan, "datetime", new DateOnly(2022, 4, 1)).ToString().ShouldBe("greater-than(datetime,2022-04-01)");
        new Filter(FilterOperation.GreaterOrEqual, "percentage", 33.33m).ToString().ShouldBe("greater-or-equal(percentage,33.33)");
        new Filter(FilterOperation.Contains, "description", "cooking").ToString().ShouldBe("contains(description,\"cooking\")");
        new Filter(FilterOperation.EndsWith, "description", "End").ToString().ShouldBe("ends-with(description,\"End\")");
        new Filter(FilterOperation.StartsWith, "description", "Start").ToString().ShouldBe("starts-with(description,\"Start\")");
        new Filter(FilterOperation.Any, "chapter", new List<string> { "Intro", "Summary", "Conclusion" }).ToString().ShouldBe("any(chapter,[\"Intro\",\"Summary\",\"Conclusion\"])");
        new Filter(FilterOperation.Any, "amount", new List<decimal> { 1, 2.5M, 3 }).ToString().ShouldBe("any(amount,[1,2.5,3])");
        new Filter(FilterOperation.Equals, "status", true).ToString().ShouldBe("equals(status,true)");
        new Filter(FilterOperation.Equals, "status", false).ToString().ShouldBe("equals(status,false)");
    }

    [Fact]
    public void FilterList()
    {
        new FilterList
        {
            new Filter(FilterOperation.Equals, "field1", "foo"),
            new Filter(FilterOperation.Equals, "field2", "bar")
        }.ToString().ShouldBe("equals(field1,\"foo\"),equals(field2,\"bar\")");

        new FilterList
        {
            new Filter(FilterOperation.Equals, "metric_id", "UxxK4u"),
            new Filter(FilterOperation.GreaterOrEqual, "datetime", new DateOnly(2023, 2, 7)),
            new Filter(FilterOperation.LessThan, "datetime", new DateOnly(2023, 2, 15))
        }.ToString().ShouldBe("equals(metric_id,\"UxxK4u\"),greater-or-equal(datetime,2023-02-07),less-than(datetime,2023-02-15)");
    }
}