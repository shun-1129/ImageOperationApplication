using static ImageResizeApp.Constants.AppConstants;

namespace ImageResizeApp.Models
{
    public class ProcessLog
    {
        public ProcessLogType Type { get; private set; }

        public DateTime OccurrenceDateTime { get; private set; }

        public string ProcessName { get; private set; } = string.Empty;

        public string Message { get; private set; } = string.Empty;

        public ProcessLog ()
        {
            Type = ProcessLogType.Info;
            OccurrenceDateTime = DateTime.Now;
            ProcessName = string.Empty;
            Message = string.Empty;
        }

        public ProcessLog ( ProcessLogType type , DateTime occurrenceDateTime , string processName , string message ) : this ()
        {
            Type = type;
            OccurrenceDateTime = occurrenceDateTime;
            ProcessName = processName;
            Message = message;
        }
    }
}
