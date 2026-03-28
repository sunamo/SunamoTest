namespace SunamoTest._sunamo;

/// <summary>
/// Provides collection conversion utility methods for test data.
/// </summary>
internal class CA
{
    /// <summary>
    /// Returns the given list of integers as-is.
    /// </summary>
    /// <param name="list">The list of integers.</param>
    /// <returns>The same list.</returns>
    internal static List<int> ToInt(List<int> list)
    {
        return list;
    }

    /// <summary>
    /// Converts a params string array to a list of strings.
    /// </summary>
    /// <param name="array">The array of strings.</param>
    /// <returns>A new list containing all strings.</returns>
    internal static List<string> ToListString2(params string[] array)
    {
        return new List<string>(array);
    }
}