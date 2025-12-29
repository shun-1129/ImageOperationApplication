namespace ImageResizeConsole.Constants
{
    public class AppConstants
    {
        public enum ErrorCode : Int16
        {
            Success = 0x00,
            ArgsReceiveFailed = 0x01,
            FolderNotFound = 0x02,
            MinimumPixelSizeInvalid = 0x03,
            QualityInvalid = 0x04,
            ImageResizeFailed = 0x05,
        }
    }
}
