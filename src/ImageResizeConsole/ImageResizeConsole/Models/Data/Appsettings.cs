namespace ImageResizeConsole.Models.Data
{
    public class Appsettings
    {
        public bool IsGIFConvert { get; set; }

        public bool IsGIFExtract { get; set; }

        public Appsettings()
        {
            IsGIFConvert = false;
            IsGIFExtract = false;
        }
    }
}
