namespace SunamoTest;

using Microsoft.Extensions.Logging;

/// <summary>
/// Represents the test logger type.
/// </summary>
public class TestLogger : ILogger
{
    /// <summary>
    /// Gets or sets the instance.
    /// </summary>
    public static TestLogger Instance { get; set; } = new TestLogger();

    /// <summary>
    /// Test logger.
    /// </summary>
    /// <returns>The test logger result.</returns>
    public TestLogger()
    {
    }

    /// <summary>
    /// Begin scope t state.
    /// </summary>
    /// <typeparam name="TState">The type TState.</typeparam>
    /// <param name="state">The state.</param>
    /// <returns>The begin scope t state result.</returns>
    public IDisposable? BeginScope<TState>(TState state) where TState : notnull
    {
        return null;
    }

    /// <summary>
    /// Is enabled.
    /// </summary>
    /// <param name="logLevel">The log level.</param>
    /// <returns>The is enabled result.</returns>
    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    /// <summary>
    /// Log t state.
    /// </summary>
    /// <typeparam name="TState">The type TState.</typeparam>
    /// <param name="logLevel">The log level.</param>
    /// <param name="eventId">The event id.</param>
    /// <param name="state">The state.</param>
    /// <param name="exception">The exception.</param>
    /// <param name="formatter">The formatter.</param>
    /// <returns>The log t state result.</returns>
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
