namespace SunamoTest;

/// <summary>
/// Represents the test data type.
/// </summary>
public class TestData
{
    /// <summary>
    /// The integers 123.
    /// </summary>
    public static readonly List<int> Integers123 = new List<int>(new int[] { 1, 2, 3 });

    /// <summary>
    /// The integers 321.
    /// </summary>
    public static readonly List<int> Integers321 = new List<int>(new int[] { 3, 2, 1 });

    /// <summary>
    /// The a constant.
    /// </summary>
    public const string A = "a";

    /// <summary>
    /// The ab constant.
    /// </summary>
    public const string Ab = "ab";

    /// <summary>
    /// The abc constant.
    /// </summary>
    public const string Abc = "abc";

    /// <summary>
    /// The b constant.
    /// </summary>
    public const string B = "b";

    /// <summary>
    /// The c constant.
    /// </summary>
    public const string C = "c";

    /// <summary>
    /// The d constant.
    /// </summary>
    public const string D = "d";

    /// <summary>
    /// The a 2 constant.
    /// </summary>
    public const string A2 = "a2";

    /// <summary>
    /// The wildcard constant.
    /// </summary>
    public const string Wildcard = "*.cs";

    /// <summary>
    /// The not sorted by size.
    /// </summary>
    public static readonly List<string> NotSortedBySize = [Ab, Abc, A];

    /// <summary>
    /// The list AB 1.
    /// </summary>
    public static readonly List<string> ListAB1;

    /// <summary>
    /// The list AB 2.
    /// </summary>
    public static readonly List<string> ListAB2;

    /// <summary>
    /// The list ABC.
    /// </summary>
    public static readonly List<string> ListABC;

    /// <summary>
    /// The list ABCD.
    /// </summary>
    public static readonly List<string> ListABCD;

    /// <summary>
    /// The list ABCCC.
    /// </summary>
    public static readonly List<string> ListABCCC;

    /// <summary>
    /// The list AC.
    /// </summary>
    public static readonly List<string> ListAC;

    /// <summary>
    /// The list a.
    /// </summary>
    public static readonly List<string> ListA;

    /// <summary>
    /// The list b.
    /// </summary>
    public static readonly List<string> ListB;

    /// <summary>
    /// The list c.
    /// </summary>
    public static readonly List<string> ListC;

    /// <summary>
    /// The list 04.
    /// </summary>
    public static readonly List<int> List04;

    /// <summary>
    /// The list 59.
    /// </summary>
    public static readonly List<int> List59;

    /// <summary>
    /// The flat json.
    /// </summary>
    public static readonly string FlatJson = "{\"IdUser\":1,\"Sc\":\"au1skm2qhjbwhmu4z0qwcpiv\"}";

    /// <summary>
    /// The flat json sc.
    /// </summary>
    public static readonly string FlatJsonSc = "au1skm2qhjbwhmu4z0qwcpiv";

    /// <summary>
    /// Init.
    /// </summary>
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

    /// <summary>
    /// The one constant.
    /// </summary>
    public const int One = 1;

    /// <summary>
    /// The two constant.
    /// </summary>
    public const int Two = 2;

    /// <summary>
    /// The three constant.
    /// </summary>
    public const int Three = 3;

    /// <summary>
    /// The list 12.
    /// </summary>
    public static readonly List<int> List12 = CA.ToInt([1, 2]);

    /// <summary>
    /// The list 34.
    /// </summary>
    public static readonly List<int> List34 = CA.ToInt([3, 4]);

    /// <summary>
    /// The list 1.
    /// </summary>
    public static readonly List<int> List1 = CA.ToInt([1]);

    /// <summary>
    /// The list 2.
    /// </summary>
    public static readonly List<int> List2 = CA.ToInt([2]);

    /// <summary>
    /// The list 100 items.
    /// </summary>
    public static readonly List<string> List100Items = LinearHelper.GetStringListFromTo(0, 99);

    /// <summary>
    /// The list 10 items.
    /// </summary>
    public static readonly List<string> List10Items = LinearHelper.GetStringListFromTo(0, 9);

    /// <summary>
    /// The range 0 to 100.
    /// </summary>
    public static readonly List<int> Range0To100 = NH.GenerateIntervalInt(0, 100);

    /// <summary>
    /// The range by 10 from 0 to 95.
    /// </summary>
    public static readonly List<List<int>> RangeBy10From0To95 = null!;

    /// <summary>
    /// The range 1 to 100.
    /// </summary>
    public static readonly List<int> Range1To100 = NH.GenerateIntervalInt(1, 100);

    /// <summary>
    /// The range 0 to 95.
    /// </summary>
    public static readonly List<int> Range0To95 = NH.GenerateIntervalInt(0, 95);
}
