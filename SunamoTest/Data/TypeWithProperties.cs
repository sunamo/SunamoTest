namespace SunamoTest.Data;

/// <summary>
/// A simple type with properties of various types, used for testing property reflection and serialization.
/// </summary>
public class TypeWithProperties
{
    /// <summary>
    /// An integer property for testing.
    /// </summary>
    public int IntegerValue { get; set; }

    /// <summary>
    /// A boolean property for testing.
    /// </summary>
    public bool BooleanValue { get; set; }

    /// <summary>
    /// A string property for testing.
    /// </summary>
    public string StringValue { get; set; } = string.Empty;

    /// <summary>
    /// A DateTime property for testing.
    /// </summary>
    public DateTime DateTimeValue { get; set; }
}