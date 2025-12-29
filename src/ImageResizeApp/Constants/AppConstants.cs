namespace ImageResizeApp.Constants
{
    public class AppConstants
    {
        public readonly static string ResizeAppPath = Path.Combine ( Application.StartupPath , @"ImageResizeConsole\ImageResizeConsole.exe" );

        /// <summary>
        /// 作業フォルダのデフォルトパス
        /// </summary>
        public const string DEFALUT_WORK_FOLDER = @"C:\Resize\work\";
        /// <summary>
        /// 一時フォルダのデフォルトパス
        /// </summary>
        public const string DEFALUT_TEMP_FOLDER = @"C:\Resize\temp\";
        /// <summary>
        /// バックアップフォルダのデフォルトパス
        /// </summary>
        public const string DEFALUT_BACKUP_FOLDER = @"C:\Resize\backup\";
        /// <summary>
        /// 失敗フォルダのデフォルトパス
        /// </summary>
        public const string DEFALUT_FAILURE_FOLDER = @"C:\Resize\failure\";
        /// <summary>
        /// 重複フォルダのデフォルトパス
        /// </summary>
        public const string DEFALUT_DUPLICATES_FOLDER = @"C:\Resize\duplicates\";

        /// <summary>
        /// 7-ZIPの実行ファイルパス
        /// </summary>
        public const string SEVEN_ZIP_EXE_PATH = @"C:\Program Files\7-Zip\7z.exe";

        public enum ProcessLogType : Int16
        {
            Info = 0,
            Debug = 1,
            Track = 2,
            Warn = 3,
            Error = 4
        }
    }
}
