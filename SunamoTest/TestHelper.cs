namespace SunamoTest;

using System.IO;

public class TestHelper
{
    public static void Init()
    {
        Init("sunamo");
    }

    public static void Init(string appName)
    {
        ThisApp.Name = appName;
        ThisApp.Project = appName;

        XlfResourcesHSunamo.SaveResouresToRLSunamo(new LocalizationLanguages { });

        AppData.Instance.CreateAppFoldersIfDontExists(new CreateAppFoldersIfDontExistsArgs { });
    }

    public static string DefaultFolderPath()
    {
        string appName = ThisApp.Name;
        string project = ThisApp.Project;

        string folderPath = Path.Combine(Path.GetTempPath(), "SunamoTest", appName, project);
        return folderPath;
    }

    public static
    async Task<List<string>>
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
    await
 TF.ReadAllText(currentFile);
                content = SHReplace.Replace(content, originalSuffix, string.Empty);

                await
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

    public static string FolderForTestFiles(object featureOrType)
    {
        string feature = NameOfFeature(featureOrType);

        string appName = ThisApp.Name;
        string project = ThisApp.Project;

        var folderPath = Path.Combine(Path.GetTempPath(), "SunamoTest", appName, project, feature) + "\\";
        FS.CreateFoldersPsysicallyUnlessThere(folderPath);
        return folderPath;
    }

    public static string TestFile(object featureOrType, string fileName)
    {
        return FS.Combine(FolderForTestFiles(featureOrType), fileName);
    }

    public static string GetFileInProjectsFolder(string projectsBasePath, string fileRelativeToProjectPath)
    {
        return FS.Combine(projectsBasePath, ThisApp.Name, ThisApp.Project, fileRelativeToProjectPath);
    }
}
