namespace SunamoTest;

/// <summary>
/// Provides commonly used test data constants and collections for unit testing.
/// </summary>
public class TestData
{
    /// <summary>
    /// A list containing integers 1, 2, 3.
    /// </summary>
    public static readonly List<int> Integers123 = new List<int>(new int[] { 1, 2, 3 });

    /// <summary>
    /// A list containing integers 3, 2, 1.
    /// </summary>
    public static readonly List<int> Integers321 = new List<int>(new int[] { 3, 2, 1 });

    /// <summary>
    /// Test string constant "a".
    /// </summary>
    public const string A = "a";

    /// <summary>
    /// Test string constant "ab".
    /// </summary>
    public const string Ab = "ab";

    /// <summary>
    /// Test string constant "abc".
    /// </summary>
    public const string Abc = "abc";

    /// <summary>
    /// Test string constant "b".
    /// </summary>
    public const string B = "b";

    /// <summary>
    /// Test string constant "c".
    /// </summary>
    public const string C = "c";

    /// <summary>
    /// Test string constant "d".
    /// </summary>
    public const string D = "d";

    /// <summary>
    /// Test string constant "a2".
    /// </summary>
    public const string A2 = "a2";

    /// <summary>
    /// Wildcard pattern for C# files.
    /// </summary>
    public const string Wildcard = "*.cs";

    /// <summary>
    /// A list of strings not sorted by size: "ab", "abc", "a".
    /// </summary>
    public static readonly List<string> NotSortedBySize = [Ab, Abc, A];

    /// <summary>
    /// A list containing strings "a", "b".
    /// </summary>
    public static readonly List<string> ListAB1;

    /// <summary>
    /// A second list containing strings "a", "b".
    /// </summary>
    public static readonly List<string> ListAB2;

    /// <summary>
    /// A list containing strings "a", "b", "c".
    /// </summary>
    public static readonly List<string> ListABC;

    /// <summary>
    /// A list containing strings "a", "b", "c", "d".
    /// </summary>
    public static readonly List<string> ListABCD;

    /// <summary>
    /// A list containing strings "a", "b", "c", "c", "c".
    /// </summary>
    public static readonly List<string> ListABCCC;

    /// <summary>
    /// A list containing strings "a", "c".
    /// </summary>
    public static readonly List<string> ListAC;

    /// <summary>
    /// A list containing string "a".
    /// </summary>
    public static readonly List<string> ListA;

    /// <summary>
    /// A list containing string "b".
    /// </summary>
    public static readonly List<string> ListB;

    /// <summary>
    /// A list containing string "c".
    /// </summary>
    public static readonly List<string> ListC;

    /// <summary>
    /// A list containing integers 0 through 4.
    /// </summary>
    public static readonly List<int> List04;

    /// <summary>
    /// A list containing integers 5 through 9.
    /// </summary>
    public static readonly List<int> List59;

    /// <summary>
    /// A flat JSON string for testing JSON operations.
    /// </summary>
    public static readonly string FlatJson = "{\"IdUser\":1,\"Sc\":\"au1skm2qhjbwhmu4z0qwcpiv\"}";

    /// <summary>
    /// The "Sc" value extracted from the flat JSON test data.
    /// </summary>
    public static readonly string FlatJsonSc = "au1skm2qhjbwhmu4z0qwcpiv";

    /// <summary>
    /// Placeholder initialization method for test data setup.
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
    /// Integer constant 1.
    /// </summary>
    public const int One = 1;

    /// <summary>
    /// Integer constant 2.
    /// </summary>
    public const int Two = 2;

    /// <summary>
    /// Integer constant 3.
    /// </summary>
    public const int Three = 3;

    /// <summary>
    /// A list containing integers 1, 2.
    /// </summary>
    public static readonly List<int> List12 = CA.ToInt([1, 2]);

    /// <summary>
    /// A list containing integers 3, 4.
    /// </summary>
    public static readonly List<int> List34 = CA.ToInt([3, 4]);

    /// <summary>
    /// A list containing integer 1.
    /// </summary>
    public static readonly List<int> List1 = CA.ToInt([1]);

    /// <summary>
    /// A list containing integer 2.
    /// </summary>
    public static readonly List<int> List2 = CA.ToInt([2]);

    /// <summary>
    /// A list of 100 string items from "0" to "99".
    /// </summary>
    public static readonly List<string> List100Items = LinearHelper.GetStringListFromTo(0, 99);

    /// <summary>
    /// A list of 10 string items from "0" to "9".
    /// </summary>
    public static readonly List<string> List10Items = LinearHelper.GetStringListFromTo(0, 9);

    /// <summary>
    /// A list of integers from 0 to 100.
    /// </summary>
    public static readonly List<int> Range0To100 = NH.GenerateIntervalInt(0, 100);

    /// <summary>
    /// A list of integer lists, each containing a range of 10, from 0 to 95.
    /// </summary>
    public static readonly List<List<int>> RangeBy10From0To95 = null!;

    /// <summary>
    /// A list of integers from 1 to 100.
    /// </summary>
    public static readonly List<int> Range1To100 = NH.GenerateIntervalInt(1, 100);

    /// <summary>
    /// A list of integers from 0 to 95.
    /// </summary>
    public static readonly List<int> Range0To95 = NH.GenerateIntervalInt(0, 95);
}
