namespace ImageResizeApp.Models
{
    public class ResizeSetting
    {
        #region メンバ変数
        private int _quality;
        private int _pixelSize;
        #endregion

        #region プロパティ
        public int Quality { get => _quality; set => _quality = value; }
        public int PixelSize { get => _pixelSize; set => _pixelSize = value; }
        #endregion
    }
}
