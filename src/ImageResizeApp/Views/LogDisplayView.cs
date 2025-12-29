using ImageResizeApp.Models;
using Microsoft.VisualBasic.Logging;
using static ImageResizeApp.Constants.AppConstants;

namespace ImageResizeApp.Views
{
    public partial class LogDisplayView : Form
    {
        private Dictionary<string , CheckState> _logLevelStateDict;
        private List<ProcessLog> _processLogs = new List<ProcessLog> ();

        public LogDisplayView ()
        {
            _logLevelStateDict = new Dictionary<string , CheckState> ();

            InitializeComponent ();
            InitializeCheckedListBox ();

            ReportLog ();
        }

        private void InitializeCheckedListBox ()
        {
            _logLevelStateDict.Clear ();
            _logLevelStateDict = new Dictionary<string , CheckState> ()
            {
                { "Info" , CheckState.Checked } ,
                { "Debug" , CheckState.Unchecked } ,
                { "Trace" , CheckState.Unchecked } ,
                { "Wraning" , CheckState.Checked } ,
                { "Error" , CheckState.Checked } ,
                { "Fatal" , CheckState.Unchecked }
            };

            LogLevelCheckedListBox.Items.Clear ();
            foreach ( KeyValuePair<string , CheckState> pair in _logLevelStateDict )
            {
                LogLevelCheckedListBox.Items.Add ( pair.Key , pair.Value );
            }
        }

        private void LogLevelCheckedListBox_ItemCheck ( object sender , ItemCheckEventArgs e )
        {
            if ( LogLevelCheckedListBox.SelectedItem is null )
            {
                return;
            }

            string selectedLogLevel = LogLevelCheckedListBox.SelectedItem.ToString () ?? string.Empty;
            if ( !_logLevelStateDict.ContainsKey ( selectedLogLevel ) )
            {
                return;
            }

            if ( _logLevelStateDict[selectedLogLevel] != e.NewValue )
            {
                _logLevelStateDict[selectedLogLevel] = e.NewValue;
            }

            ReportLog ();
        }

        private void ReportLog ()
        {
            _processLogs.Clear ();

            foreach ( KeyValuePair<string , CheckState> pair in _logLevelStateDict )
            {
                if ( pair.Value != CheckState.Checked )
                {
                    continue;
                }

                switch ( pair.Key )
                {
                    case "Info":
                        _processLogs.AddRange ( LogData.Instance.InfoProcessLogList );
                        break;
                    case "Debug":
                        _processLogs.AddRange ( LogData.Instance.DebugProcessLogList );
                        break;
                    case "Trace":
                        //_processLogs.AddRange ( LogData.Instance.TraceProcessLogList );
                        break;
                    case "Wraning":
                        _processLogs.AddRange ( LogData.Instance.WarningProcessLogList );
                        break;
                    case "Error":
                        _processLogs.AddRange ( LogData.Instance.ErrorProcessLogList );
                        break;
                    case "Fatal":
                        //_processLogs.AddRange ( LogData.Instance.FatalProcessLogList );
                        break;
                }
            }

            LogTextBox.Clear ();
            foreach ( ProcessLog log in _processLogs )
            {
                AppendColorerLine ( LogTextBox , log );
            }
        }

        private void AppendColorerLine ( RichTextBox textBox , ProcessLog processLog )
        {
            textBox.SelectionStart = textBox.SelectionLength;
            textBox.SelectionLength = 0;

            switch ( processLog.Type )
            {
                case ProcessLogType.Error:
                    textBox.SelectionColor = Color.Red;
                    break;
                case ProcessLogType.Warn:
                    textBox.SelectionColor = Color.Orange;
                    break;
                case ProcessLogType.Debug:
                    textBox.SelectionColor = Color.Green;
                    break;
                default:
                    textBox.SelectionColor = Color.Black;
                    break;
            }


            textBox.AppendText ( $"{processLog.OccurrenceDateTime} | {processLog.ProcessName} | {processLog.Message}" + Environment.NewLine );
            textBox.SelectionColor = textBox.ForeColor;
        }
    }
}
