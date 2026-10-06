namespace SunamoTest;

public class TestData
{
    public static readonly List<int> Integers123 = new List<int>(new int[] { 1, 2, 3 });

    public static readonly List<int> Integers321 = new List<int>(new int[] { 3, 2, 1 });

    public const string A = "a";

    public const string Ab = "ab";

    public const string Abc = "abc";

    public const string B = "b";

    public const string C = "c";

    public const string D = "d";

    public const string A2 = "a2";

    public const string Wildcard = "*.cs";

    public static readonly List<string> NotSortedBySize = [Ab, Abc, A];

    public static readonly List<string> ListAB1;

    public static readonly List<string> ListAB2;

    public static readonly List<string> ListABC;

    public static readonly List<string> ListABCD;

    public static readonly List<string> ListABCCC;

    public static readonly List<string> ListAC;

    public static readonly List<string> ListA;

    public static readonly List<string> ListB;

    public static readonly List<string> ListC;

    public static readonly List<int> List04;

    public static readonly List<int> List59;

    public static readonly string FlatJson = "{\"IdUser\":1,\"Sc\":\"au1skm2qhjbwhmu4z0qwcpiv\"}";

    public static readonly string FlatJsonSc = "au1skm2qhjbwhmu4z0qwcpiv";

    public static void Init()
    {
    }

    static TestData()
    {
        ListAB1 = new List<string>(CA.ToListString2(A, B));
        ListAB2 = new List<string>(CA.ToListString2(A, B));
        ListABC = new List<string>(CA.ToListString2(A, B, C));
        ListABCD = new List<string>(CA.ToListString2(A, B, C, D));
        ListABCCC = new List<string>(CA.ToListString2(A, B, C, C, C));
        ListAC = new List<string>(CA.ToListString2(A, C));
        ListA = new List<string>(CA.ToListString2(A));
        ListB = new List<string>(CA.ToListString2(B));
        ListC = new List<string>(CA.ToListString2(C));

        List04 = [0, 1, 2, 3, 4];
        List59 = [5, 6, 7, 8, 9];

        RangeBy10From0To95 = new List<List<int>>(new List<int>[] { NH.GenerateIntervalInt(0, 9), NH.GenerateIntervalInt(10, 19), NH.GenerateIntervalInt(20, 29), NH.GenerateIntervalInt(30, 39), NH.GenerateIntervalInt(40, 49), NH.GenerateIntervalInt(50, 59), NH.GenerateIntervalInt(60, 69), NH.GenerateIntervalInt(70, 79), NH.GenerateIntervalInt(80, 89), NH.GenerateIntervalInt(90, 95) });
    }

    public const int One = 1;

    public const int Two = 2;

    public const int Three = 3;

    public static readonly List<int> List12 = CA.ToInt([1, 2]);

    public static readonly List<int> List34 = CA.ToInt([3, 4]);

    public static readonly List<int> List1 = CA.ToInt([1]);

    public static readonly List<int> List2 = CA.ToInt([2]);

    public static readonly List<string> List100Items = LinearHelper.GetStringListFromTo(0, 99);

    public static readonly List<string> List10Items = LinearHelper.GetStringListFromTo(0, 9);

    public static readonly List<int> Range0To100 = NH.GenerateIntervalInt(0, 100);

    public static readonly List<List<int>> RangeBy10From0To95 = null!;

    public static readonly List<int> Range1To100 = NH.GenerateIntervalInt(1, 100);

    public static readonly List<int> Range0To95 = NH.GenerateIntervalInt(0, 95);
}
