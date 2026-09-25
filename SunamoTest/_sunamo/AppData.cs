namespace SunamoTest._sunamo;

/// <summary>
/// Provides application data management for folder creation and configuration.
/// </summary>
internal class AppData
{
    /// <summary>
    /// Singleton instance of the application data manager.
    /// </summary>
    internal static AppData Instance { get; set; } = new AppData();

    /// <summary>
    /// Creates application folders if they do not already exist.
    /// </summary>
    /// <param name="args">Arguments specifying which folders to create.</param>
    internal void CreateAppFoldersIfDontExists(CreateAppFoldersIfDontExistsArgs args)
    {
        throw new NotImplementedException();
    }
}
