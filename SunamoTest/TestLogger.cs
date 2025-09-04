// Instance variables refactored according to C# conventions
namespace SunamoTest;

using Microsoft.Extensions.Logging;

public class TestLogger : ILogger
{
    public static TestLogger Instance = new TestLogger();

    public TestLogger()
    {

    }

    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
    {
        if (logLevel == LogLevel.Error || logLevel == LogLevel.Critical)
        {
            if (state != null)
            {
                throw new Exception(state.ToString());
            }
            else
            {
                throw new Exception("State is null!");
            }
        }
    }
}