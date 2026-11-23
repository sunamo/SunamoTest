namespace SunamoTest.Data;

/// <summary>
/// Represents the type with properties type.
/// </summary>
public class TypeWithProperties
{
    /// <summary>
    /// Gets or sets the integer value.
    /// </summary>
    public int IntegerValue { get; set; }
    /// <summary>
    /// Gets or sets the boolean value.
    /// </summary>
    public bool BooleanValue { get; set; }
    /// <summary>
    /// Gets or sets the string value.
    /// </summary>
    public string StringValue { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the date time value.
    /// </summary>
    public DateTime DateTimeValue { get; set; }
}
