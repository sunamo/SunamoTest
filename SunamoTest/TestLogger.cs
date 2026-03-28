namespace SunamoTest;

using Microsoft.Extensions.Logging;

/// <summary>
/// A test implementation of <see cref="ILogger"/> that throws exceptions for error-level log messages.
/// </summary>
public class TestLogger : ILogger
{
    /// <summary>
    /// Singleton instance of the test logger.
    /// </summary>
    public static TestLogger Instance { get; set; } = new TestLogger();

    /// <summary>
    /// Initializes a new instance of the <see cref="TestLogger"/> class.
    /// </summary>
    public TestLogger()
    {
    }

    /// <summary>
    /// Begins a logical operation scope. Returns null as scoping is not supported.
    /// </summary>
    /// <typeparam name="TState">The type of the state object.</typeparam>
    /// <param name="state">The scope state.</param>
    /// <returns>Always returns null.</returns>
    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }

    /// <summary>
    /// Checks whether logging is enabled for the specified log level. Always returns true.
    /// </summary>
    /// <param name="logLevel">The log level to check.</param>
    /// <returns>Always returns true.</returns>
    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    /// <summary>
    /// Logs a message. Throws an exception if the log level is Error or Critical to surface test failures.
    /// </summary>
    /// <typeparam name="TState">The type of the state object.</typeparam>
    /// <param name="logLevel">The severity level of the log entry.</param>
    /// <param name="eventId">The event identifier.</param>
    /// <param name="state">The log state object.</param>
    /// <param name="exception">The exception associated with the log entry, if any.</param>
    /// <param name="formatter">The function to format the state and exception into a message string.</param>
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
