namespace ImageResizeApp.Models
{
    public class LogData
    {
        public List<ProcessLog> InfoProcessLogList { get; set; } = new List<ProcessLog>();
        public List<ProcessLog> DebugProcessLogList { get; set; } = new List<ProcessLog>();
        public List<ProcessLog> WarningProcessLogList { get; set; } = new List<ProcessLog>();
        public List<ProcessLog> ErrorProcessLogList { get; set; } = new List<ProcessLog>();

        public static LogData Instance { get; } = new LogData();

        public LogData () { }
    }
}
