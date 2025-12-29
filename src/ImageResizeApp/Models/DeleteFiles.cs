namespace ImageResizeApp.Models
{
    /// <summary>
    /// 削除対象ファイル
    /// </summary>
    public class DeleteFiles
    {
        /// <summary>
        /// ファイル名称
        /// </summary>
        public List<string> FileNames { get; set; } = new List<string>();

        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public DeleteFiles() { }
    }
}
