namespace SunamoTest._sunamo;

/// <summary>
/// Provides linear sequence generation helpers for test data.
/// </summary>
internal class LinearHelper
{
    /// <summary>
    /// Generates a list of string-converted integers from <paramref name="start"/> to <paramref name="end"/> inclusive.
    /// </summary>
    /// <param name="start">The first integer in the range.</param>
    /// <param name="end">The last integer in the range (inclusive).</param>
    /// <returns>A list of strings representing each integer in the range.</returns>
    internal static List<string> GetStringListFromTo(int start, int end)
    {
        var result = new List<string>(end - start + 1);
        for (var i = start; i <= end; i++)
        {
            result.Add(i.ToString());
        }
        return result;
    }
}