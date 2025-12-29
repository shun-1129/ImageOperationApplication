namespace ImageResizeApp.Models
{
    public class SelectedFolderSetting
    {
        #region プロパティ
        /// <summary>
        /// インスタンス
        /// </summary>
        public static SelectedFolderSetting Instance { get; } = new SelectedFolderSetting ();
        /// <summary>
        /// 作業フォルダパス
        /// </summary>
        public string WorkFolderPath { get; set; } = string.Empty;
        /// <summary>
        /// 一時フォルダパス
        /// </summary>
        public string TempFolderPath { get; set; } = string.Empty;
        /// <summary>
        /// バックアップフォルダパス
        /// </summary>
        public string BackupFolderPath { get; set; } = string.Empty;
        /// <summary>
        /// 失敗フォルダパス
        /// </summary>
        public string FailureFolderPath { get; set; } = string.Empty;
        /// <summary>
        /// 重複フォルダパス
        /// </summary>
        public string DuplicatesFolderPath { get; set; } = string.Empty;
        #endregion

        #region コンストラクタ
        public SelectedFolderSetting ()
        {
            WorkFolderPath = string.Empty;
            TempFolderPath = string.Empty;
            BackupFolderPath = string.Empty;
            FailureFolderPath = string.Empty;
            DuplicatesFolderPath = string.Empty;
        }
        #endregion
    }
}
