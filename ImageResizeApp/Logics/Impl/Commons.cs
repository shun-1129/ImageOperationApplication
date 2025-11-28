using ImageResizeApp.Models;
using System.Text.Json;

namespace ImageResizeApp.Logics.Impl
{
    public static class Commons
    {
        public static void ReadJsonFiles ()
        {
            ReadDeleteFilesJsonFile ();
            ReadDeleteTargetJsonFile ();
            ReadFileNameChangeSettingsJsonFile ();
        }

        public static void ReadDeleteFilesJsonFile()
        {
            const string FILE_PATH = "DeleteFiles.json";
            if ( !File.Exists ( FILE_PATH ) )
            {
                return;
            }

            string jsonContent = File.ReadAllText( FILE_PATH );
            JsonDocument jsonDocument = JsonDocument.Parse( jsonContent );
            JsonElement jsonElement = jsonDocument.RootElement.GetProperty( "DeleteFiles" );
            string jsonContentElement = jsonElement.GetRawText();

            DeleteFiles deleteFiles = JsonSerializer.Deserialize<DeleteFiles>( jsonContentElement ) ?? new DeleteFiles ();
            Appsettings.Instance.DeleteFiles = deleteFiles;
        }

        public static void ReadDeleteTargetJsonFile ()
        {
            const string FILE_PATH = "DeleteTarget.json";
            if ( !File.Exists ( FILE_PATH ) )
            {
                return;
            }

            string jsonContent = File.ReadAllText( FILE_PATH );
            JsonDocument jsonDocument = JsonDocument.Parse( jsonContent );
            JsonElement jsonElement = jsonDocument.RootElement.GetProperty( "DeleteTarget" );
            string jsonContentElement = jsonElement.GetRawText();

            DeleteTarget deleteTarget = JsonSerializer.Deserialize<DeleteTarget>( jsonContentElement ) ?? new DeleteTarget ();
            Appsettings.Instance.DeleteTargets = deleteTarget;
        }

        public static void ReadFileNameChangeSettingsJsonFile ()
        {
            const string FILE_PATH = "FileNameChangeSettings.json";
            if ( !File.Exists ( FILE_PATH ) )
            {
                return;
            }

            string jsonContent = File.ReadAllText( FILE_PATH );
            JsonDocument jsonDocument = JsonDocument.Parse( jsonContent );
            JsonElement jsonElement = jsonDocument.RootElement.GetProperty( "Settings" );
            string jsonContentElement = jsonElement.GetRawText();

            FileNameChangeSettings fileNameChangeSettings = JsonSerializer.Deserialize<FileNameChangeSettings>( jsonContentElement ) ?? new FileNameChangeSettings ();
            Appsettings.Instance.FileNameChangeSettings = fileNameChangeSettings;
        }
    }
}
