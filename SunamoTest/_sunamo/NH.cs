namespace SunamoTest._sunamo;

internal class NH
{
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
