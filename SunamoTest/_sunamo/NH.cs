namespace SunamoTest._sunamo;

/// <summary>
/// Provides numeric helper methods for test data generation.
/// </summary>
internal class NH
{
    /// <summary>
    /// Generates a list of integers from <paramref name="start"/> to <paramref name="end"/> inclusive.
    /// </summary>
    /// <param name="start">The first integer in the range.</param>
    /// <param name="end">The last integer in the range (inclusive).</param>
    /// <returns>A list of integers in the specified range.</returns>
    internal static List<int> GenerateIntervalInt(int start, int end)
    {
        var result = new List<int>(end - start + 1);
        for (var i = start; i <= end; i++)
        {
            result.Add(i);
        }
        return result;
    }
}