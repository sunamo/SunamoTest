namespace SunamoTest.Tests;

/// <summary>
/// Unit tests for SunamoTest library core functionality.
/// </summary>
public class UnitTest1
{
    /// <summary>
    /// Verifies that TestData static collections are initialized correctly.
    /// </summary>
    [Fact]
    public void TestDataCollectionsAreInitialized()
    {
        Assert.NotNull(TestData.ListAB1);
        Assert.Equal(2, TestData.ListAB1.Count);
        Assert.Equal(TestData.A, TestData.ListAB1[0]);
        Assert.Equal(TestData.B, TestData.ListAB1[1]);
    }

    /// <summary>
    /// Verifies that TestData integer ranges are generated correctly.
    /// </summary>
    [Fact]
    public void TestDataIntegerRangesAreCorrect()
    {
        Assert.Equal(101, TestData.Range0To100.Count);
        Assert.Equal(0, TestData.Range0To100[0]);
        Assert.Equal(100, TestData.Range0To100[100]);

        Assert.Equal(100, TestData.Range1To100.Count);
        Assert.Equal(1, TestData.Range1To100[0]);
    }

    /// <summary>
    /// Verifies that TestLogger instance throws on error-level log messages.
    /// </summary>
    [Fact]
    public void TestLoggerThrowsOnError()
    {
        var logger = TestLogger.Instance;
        Assert.True(logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel.Information));

        Assert.Throws<Exception>(() =>
            logger.Log(
                Microsoft.Extensions.Logging.LogLevel.Error,
                new Microsoft.Extensions.Logging.EventId(0),
                "Test error message",
                null,
                (state, exception) => state?.ToString() ?? string.Empty));
    }

    /// <summary>
    /// Verifies that TypeWithProperties can be instantiated and its properties set.
    /// </summary>
    [Fact]
    public void TypeWithPropertiesCanBeInstantiated()
    {
        var instance = new SunamoTest.Data.TypeWithProperties
        {
            IntegerValue = 42,
            BooleanValue = true,
            StringValue = "test",
            DateTimeValue = new DateTime(2024, 1, 1)
        };

        Assert.Equal(42, instance.IntegerValue);
        Assert.True(instance.BooleanValue);
        Assert.Equal("test", instance.StringValue);
        Assert.Equal(new DateTime(2024, 1, 1), instance.DateTimeValue);
    }

    /// <summary>
    /// Verifies that ExcTypes provides correct exception type references.
    /// </summary>
    [Fact]
    public void ExcTypesReferencesAreCorrect()
    {
        Assert.Equal(typeof(ArgumentOutOfRangeException), ExcTypes.ArgumentOutOfRangeExceptionType);
    }
}
