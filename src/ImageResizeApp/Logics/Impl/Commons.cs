using CommonLibrary.Utilities.Json;
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

        public static void ReadDeleteFilesJsonFile ()
        {
            const string FILE_PATH = "DeleteFiles.json";
            string filePath = Path.Combine ( AppContext.BaseDirectory , "Json" , FILE_PATH );
            if ( !File.Exists ( filePath ) )
            {
                return;
            }

            DeleteFiles? deleteFiles = JsonReader.ReadJsonToModel<DeleteFiles> ( filePath , "DeleteFiles" );
            Appsettings.Instance.DeleteFiles = deleteFiles is null ? new DeleteFiles () : deleteFiles;
        }

        public static void ReadDeleteTargetJsonFile ()
        {
            const string FILE_PATH = "DeleteTarget.json";
            string filePath = Path.Combine ( AppContext.BaseDirectory , "Json" , FILE_PATH );
            if ( !File.Exists ( filePath ) )
            {
                return;
            }

            DeleteTarget? deleteTarget = JsonReader.ReadJsonToModel<DeleteTarget> ( filePath , "DeleteTarget" );
            Appsettings.Instance.DeleteTargets = deleteTarget is null ? new DeleteTarget () : deleteTarget;
        }

        public static void ReadFileNameChangeSettingsJsonFile ()
        {
            const string FILE_PATH = "FileNameChangeSettings.json";
            string filePath = Path.Combine ( AppContext.BaseDirectory , "Json" , FILE_PATH );
            if ( !File.Exists ( filePath ) )
            {
                return;
            }

            FileNameChangeSettings? fileNameChangeSettings = JsonReader.ReadJsonToModel<FileNameChangeSettings> ( filePath , "Settings" );
            Appsettings.Instance.FileNameChangeSettings = fileNameChangeSettings is null ? new FileNameChangeSettings () : fileNameChangeSettings;
        }
    }
}
