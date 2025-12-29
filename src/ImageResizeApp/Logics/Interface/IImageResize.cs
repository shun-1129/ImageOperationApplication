namespace ImageResizeApp.Logics.Interface
{
    public interface IImageResize
    {
        /// <summary>
        /// ロジック実行（非同期）
        /// </summary>
        public Task<int> ExecuteAsync ();
    }
}
