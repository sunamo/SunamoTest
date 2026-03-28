namespace SunamoTest._sunamo;

/// <summary>
/// Provides application identity properties for the current test context.
/// </summary>
internal class ThisApp
{
    /// <summary>
    /// The name of the current application.
    /// </summary>
    internal static string Name { get; set; } = string.Empty;

    /// <summary>
    /// The project name of the current application.
    /// </summary>
    internal static string Project { get; set; } = string.Empty;
}