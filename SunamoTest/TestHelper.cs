namespace SunamoTest;

using System.IO;

/// <summary>
/// Provides helper methods for initializing and managing test environments.
/// </summary>
public class TestHelper
{
    /// <summary>
    /// Initializes the test environment with default application name "sunamo".
    /// </summary>
    public static void Init()
    {
        Init("sunamo");
    }

    /// <summary>
    /// Initializes the test environment with the specified application name.
    /// </summary>
    /// <param name="appName">The name of the application to initialize for testing.</param>
    public static void Init(string appName)
    {
        ThisApp.Name = appName;
        ThisApp.Project = appName;

        XlfResourcesHSunamo.SaveResouresToRLSunamo(new LocalizationLanguages { });

        AppData.Instance.CreateAppFoldersIfDontExists(new CreateAppFoldersIfDontExistsArgs { });
    }

    /// <summary>
    /// Returns the default folder path for test files based on the current application name and project.
    /// </summary>
    /// <returns>The default folder path.</returns>
    public static string DefaultFolderPath()
    {
        string appName = ThisApp.Name;
        string project = ThisApp.Project;

        string folderPath = Path.Combine(Path.GetTempPath(), "SunamoTest", appName, project);
        return folderPath;
    }

    /// <summary>
    /// Refreshes the original test files by copying them from the original folder to the working folder.
    /// Optionally replaces occurrences of "_Original" in file names and content.
    /// </summary>
    /// <param name="baseFolder">The base folder path. If null, uses the default folder path.</param>
    /// <param name="featureOrType">A Type, string, or object whose class name identifies the feature.</param>
    /// <param name="modeOfFeature">An optional subfolder mode within the feature folder. Can be null or empty.</param>
    /// <param name="isCopyingFilesRecursively">Whether to copy files from subfolders recursively.</param>
    /// <param name="isReplacingOriginal">Whether to replace "_Original" in file names and content.</param>
    /// <returns>A list of file paths in the working folder after refresh.</returns>
    public static
#if ASYNC
    async Task<List<string>>
#else
    List<string>
#endif
 RefreshOriginalFiles(string baseFolder, object featureOrType, string modeOfFeature, bool isCopyingFilesRecursively, bool isReplacingOriginal)
    {
        if (baseFolder == null)
        {
            baseFolder = DefaultFolderPath();
        }

        string feature = NameOfFeature(featureOrType);

        FS.WithoutEndSlash(ref baseFolder);
        baseFolder = baseFolder + "\\" + feature;
        var originalFolder = baseFolder + "_Original\\";
        string workingFolder = baseFolder + "\\";

        if (!string.IsNullOrEmpty(modeOfFeature))
        {
            modeOfFeature = modeOfFeature.TrimEnd('\\') + "\\";
            originalFolder += modeOfFeature;
            workingFolder += modeOfFeature;
        }

        Directory.GetFiles(workingFolder, "*", isCopyingFilesRecursively ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).ToList().ForEach(filePath => FS.TryDeleteFile(filePath));
        if (isCopyingFilesRecursively)
        {
            FS.CopyAllFilesRecursively(originalFolder, workingFolder, FileMoveCollisionOption.Overwrite);
        }
        else
        {
            FS.CopyAllFiles(originalFolder, workingFolder, FileMoveCollisionOption.Overwrite);
        }

        var files = Directory.GetFiles(workingFolder).ToList();

        if (isReplacingOriginal)
        {
            const string originalSuffix = "_Original";

            for (int i = 0; i < files.Count; i++)
            {
                var currentFile = files[i];
                var content =
#if ASYNC
    await
#endif
 TF.ReadAllText(currentFile);
                content = SHReplace.Replace(content, originalSuffix, string.Empty);

#if ASYNC
                await
#endif
                TF.WriteAllText(currentFile, content);

                if (currentFile.Contains(originalSuffix))
                {
                    string renamedFile = currentFile.Replace(originalSuffix, string.Empty);
                    FS.MoveFile(currentFile, renamedFile, FileMoveCollisionOption.Overwrite);
                    files[i] = renamedFile;
                }
            }
        }
        return files;
    }

    /// <summary>
    /// Extracts the feature name from the given object, which can be a Type, string, or any object.
    /// </summary>
    /// <param name="featureOrType">A Type, string, or object whose class name identifies the feature.</param>
    /// <returns>The feature name as a string.</returns>
    private static string NameOfFeature(object featureOrType)
    {
        if (featureOrType is Type featureType)
        {
            return featureType.Name;
        }
        else if (featureOrType is string featureString)
        {
            return featureString;
        }
        else
        {
            return featureOrType.GetType().Name;
        }
    }

    /// <summary>
    /// Returns the backslash-terminated folder path for test files of the specified feature.
    /// </summary>
    /// <param name="featureOrType">A Type, string, or object whose class name identifies the feature.</param>
    /// <returns>The folder path for test files.</returns>
    public static string FolderForTestFiles(object featureOrType)
    {
        string feature = NameOfFeature(featureOrType);

        string appName = ThisApp.Name;
        string project = ThisApp.Project;

        var folderPath = Path.Combine(Path.GetTempPath(), "SunamoTest", appName, project, feature) + "\\";
        FS.CreateFoldersPsysicallyUnlessThere(folderPath);
        return folderPath;
    }

    /// <summary>
    /// Returns the full path to a test file within the feature's test folder.
    /// </summary>
    /// <param name="featureOrType">A Type, string, or object whose class name identifies the feature.</param>
    /// <param name="fileName">The name of the test file.</param>
    /// <returns>The full path to the test file.</returns>
    public static string TestFile(object featureOrType, string fileName)
    {
        return FS.Combine(FolderForTestFiles(featureOrType), fileName);
    }

    /// <summary>
    /// Returns the full path to a file relative to the project folder within the specified base directory.
    /// The path is combined with ThisApp.Name and ThisApp.Project.
    /// </summary>
    /// <param name="projectsBasePath">The base directory containing the projects.</param>
    /// <param name="fileRelativeToProjectPath">The file path relative to the project folder.</param>
    /// <returns>The full path to the file.</returns>
    public static string GetFileInProjectsFolder(string projectsBasePath, string fileRelativeToProjectPath)
    {
        return FS.Combine(projectsBasePath, ThisApp.Name, ThisApp.Project, fileRelativeToProjectPath);
    }
}
