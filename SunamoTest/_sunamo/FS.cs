namespace SunamoTest._sunamo;

/// <summary>
/// Provides file system helper methods for path manipulation and file operations.
/// </summary>
internal class FS
{
    /// <summary>
    /// Combines multiple path parts into a single path.
    /// </summary>
    /// <param name="parts">The path parts to combine.</param>
    /// <returns>The combined path string.</returns>
    internal static string Combine(params object[] parts)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Copies all files from source folder to destination folder.
    /// </summary>
    /// <param name="sourceFolder">The source folder to copy from.</param>
    /// <param name="destinationFolder">The destination folder to copy to.</param>
    /// <param name="fileMoveCollisionOption">The behavior when a file already exists at destination.</param>
    internal static void CopyAllFiles(string sourceFolder, string destinationFolder, FileMoveCollisionOption fileMoveCollisionOption)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Copies all files recursively from source folder to destination folder.
    /// </summary>
    /// <param name="sourceFolder">The source folder to copy from.</param>
    /// <param name="destinationFolder">The destination folder to copy to.</param>
    /// <param name="fileMoveCollisionOption">The behavior when a file already exists at destination.</param>
    internal static void CopyAllFilesRecursively(string sourceFolder, string destinationFolder, FileMoveCollisionOption fileMoveCollisionOption)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Creates the specified folder physically if it does not already exist.
    /// </summary>
    /// <param name="path">The folder path to create.</param>
    internal static void CreateFoldersPsysicallyUnlessThere(string path)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets all files from the specified folder with optional recursive search.
    /// </summary>
    /// <param name="folder">The folder to search in.</param>
    /// <param name="isSearchingRecursively">Whether to search subfolders recursively.</param>
    /// <returns>A list of file paths found.</returns>
    internal static List<string> GetFiles(string folder, bool isSearchingRecursively)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets all files from the specified folder (non-recursive).
    /// </summary>
    /// <param name="folder">The folder to search in.</param>
    /// <returns>A list of file paths found.</returns>
    internal static List<string> GetFiles(string folder)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Moves a file from source path to destination path.
    /// </summary>
    /// <param name="sourcePath">The current file path.</param>
    /// <param name="destinationPath">The target file path.</param>
    /// <param name="fileMoveCollisionOption">The behavior when a file already exists at destination.</param>
    internal static void MoveFile(string sourcePath, string destinationPath, FileMoveCollisionOption fileMoveCollisionOption)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Attempts to delete the specified file, ignoring errors if it does not exist.
    /// </summary>
    /// <param name="path">The file path to delete.</param>
    internal static void TryDeleteFile(string path)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Removes the trailing slash from the specified path.
    /// </summary>
    /// <param name="path">The path to trim.</param>
    internal static void WithoutEndSlash(ref string path)
    {
        throw new NotImplementedException();
    }
}
