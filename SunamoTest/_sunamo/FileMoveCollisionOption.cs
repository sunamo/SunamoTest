namespace SunamoTest._sunamo;

/// <summary>
/// Specifies the behavior when a file collision occurs during move or copy operations.
/// </summary>
internal enum FileMoveCollisionOption
{
    /// <summary>
    /// Appends a sequential number to the file name.
    /// </summary>
    AddSerie,

    /// <summary>
    /// Appends the file size to the file name.
    /// </summary>
    AddFileSize,

    /// <summary>
    /// Overwrites the existing file at the destination.
    /// </summary>
    Overwrite,

    /// <summary>
    /// Discards the source file and keeps the existing one.
    /// </summary>
    DiscardFrom,

    /// <summary>
    /// Keeps the larger file, discarding the smaller one.
    /// </summary>
    LeaveLarger,

    /// <summary>
    /// Does not perform any file manipulation.
    /// </summary>
    DontManipulate
}