namespace SunamoTest._sunamo;

internal class LinearHelper
{
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
