namespace ImageResizeApp.Models
{
    public class FileNameChangeSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public List<List<string>> SwapTarget { get; set; } = new List<List<string>>();

        /// <summary>
        /// 
        /// </summary>
        public List<List<string>> SwapTargetMonth { get; set; } = new List<List<string>>();

        /// <summary>
        /// 
        /// </summary>
        public int VolPaddingZero { get; set; }
    }
}
