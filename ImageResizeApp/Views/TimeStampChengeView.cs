using CommonLibrary.Utilities;
using ImageResizeApp.Models;

namespace ImageResizeApp.Views
{
    public partial class TimeStampChangeView : Form
    {
        #region メンバ変数
        private int _year;
        private int _month;
        private int _day;
        private int _hour;
        private int _minutes;
        private int _second;
        private DateTime _timeStamp;
        #endregion

        #region プロパティ
        public int Year
        {
            get => _year;
            set
            {
                _year = value;
                ChangeTextBoxText ();
            }
        }
        public int Month
        {
            get => _month;
            set
            {
                _month = value;
                ChangeTextBoxText ();
            }
        }
        public int Day
        {
            get => _day;
            set
            {
                _day = value;
                ChangeTextBoxText ();
            }
        }
        public int Hour
        {
            get => _hour;
            set
            {
                _hour = value;
                ChangeTextBoxText ();
            }
        }
        public int Minutes
        {
            get => _minutes;
            set
            {
                _minutes = value;
                ChangeTextBoxText ();
            }
        }
        public int Second
        {
            get => _second;
            set
            {
                _second = value;
                ChangeTextBoxText ();
            }
        }
        public DateTime TimeStamp { get => _timeStamp; set => _timeStamp = value; }
        #endregion

        #region コンストラクタ
        public TimeStampChangeView ()
        {
            InitializeComponent ();

            DateTime nowDateTime = DateTime.Now;
            Second = nowDateTime.Second;
            YearTextBox.Text = nowDateTime.Year.ToString ( "D4" );
            MonthTextBox.Text = nowDateTime.Month.ToString ( "D2" );
            DayTextBox.Text = nowDateTime.Day.ToString ( "D2" );
            HourTextBox.Text = nowDateTime.Hour.ToString ( "D2" );
            MinutesTextBox.Text = nowDateTime.Minute.ToString ( "D2" );
            SecondTextBox.Text = nowDateTime.Second.ToString ( "D2" );

            Year = int.Parse ( YearTextBox.Text );
            Month = int.Parse ( MonthTextBox.Text );
            Day = int.Parse ( DayTextBox.Text );
            Hour = int.Parse ( HourTextBox.Text );
            Minutes = int.Parse ( MinutesTextBox.Text );
            Second = int.Parse ( SecondTextBox.Text );

            ChangeTextBoxText ();
            TimeStamp = new DateTime ( Year , Month , Day , Hour , Minutes , Second );
        }
        #endregion

        #region イベントハンドラ
        private void YearTextBox_TextChanged ( object sender , EventArgs e )
        {
            if ( !int.TryParse ( YearTextBox.Text , out int year ) )
            {
                YearTextBox.Text = Year.ToString ( "D4" );
            }

            Year = year;
        }

        private void MonthTextBox_TextChanged ( object sender , EventArgs e )
        {
            if ( !int.TryParse ( MonthTextBox.Text , out int month ) )
            {
                MonthTextBox.Text = Month.ToString ( "D2" );
            }

            Month = month;
        }

        private void DayTextBox_TextChanged ( object sender , EventArgs e )
        {
            if ( !int.TryParse ( DayTextBox.Text , out int day ) )
            {
                DayTextBox.Text = Day.ToString ( "D2" );
            }

            Day = day;
        }

        private void HourTextBox_TextChanged ( object sender , EventArgs e )
        {
            if ( !int.TryParse ( HourTextBox.Text , out int hour ) )
            {
                HourTextBox.Text = Hour.ToString ( "D2" );
            }

            Hour = hour;
        }

        private void MinutesTextBox_TextChanged ( object sender , EventArgs e )
        {
            if ( !int.TryParse ( MinutesTextBox.Text , out int minutes ) )
            {
                MinutesTextBox.Text = Minutes.ToString ( "D2" );
            }

            Minutes = minutes;
        }

        private void SecondTextBox_TextChanged ( object sender , EventArgs e )
        {
            if ( !int.TryParse ( SecondTextBox.Text , out int second ) )
            {
                SecondTextBox.Text = Second.ToString ( "D2" );
            }

            Second = second;
        }

        private async void ChangeBtn_Click ( object sender , EventArgs e )
        {
            await ChangeTimeStamp ();

            MessageBox.Show (
                this ,
                $"タイムスタンプの変更が完了しました。" ,
                "変更完了" ,
                MessageBoxButtons.OK ,
                MessageBoxIcon.Information );
        }

        private void ResetBtn_Click ( object sender , EventArgs e )
        {
            DateTime nowDateTime = DateTime.Now;
            Second = nowDateTime.Second;
            YearTextBox.Text = nowDateTime.Year.ToString ( "D4" );
            MonthTextBox.Text = nowDateTime.Month.ToString ( "D2" );
            DayTextBox.Text = nowDateTime.Day.ToString ( "D2" );
            HourTextBox.Text = nowDateTime.Hour.ToString ( "D2" );
            MinutesTextBox.Text = nowDateTime.Minute.ToString ( "D2" );
            SecondTextBox.Text = nowDateTime.Second.ToString ( "D2" );

            Year = int.Parse ( YearTextBox.Text );
            Month = int.Parse ( MonthTextBox.Text );
            Day = int.Parse ( DayTextBox.Text );
            Hour = int.Parse ( HourTextBox.Text );
            Minutes = int.Parse ( MinutesTextBox.Text );
            Second = int.Parse ( SecondTextBox.Text );

            ChangeTextBoxText ();
            TimeStamp = new DateTime ( Year , Month , Day , Hour , Minutes , Second );
        }
        #endregion

        #region メソッド
        private void ChangeTextBoxText ()
        {
            ChangeTextBox.Text = $"{Year.ToString ( "D4" )}/{Month.ToString ( "D2" )}/{Day.ToString ( "D2" )} {Hour.ToString ( "D2" )}:{Minutes.ToString ( "D2" )}:{Second.ToString ( "D2" )}";
        }

        private async Task ChangeTimeStamp ()
        {
            TimeStamp = new DateTime ( Year , Month , Day , Hour , Minutes , Second );

            await Task.Run ( () =>
            {
                List<string> filePathList = FileUtil.GetAllFile ( SelectedFolderSetting.Instance.WorkFolderPath ).ToList ();
                foreach ( string filePath in filePathList )
                {
                    File.SetCreationTime ( filePath , TimeStamp );
                    File.SetLastWriteTime ( filePath , TimeStamp );
                    File.SetLastAccessTime ( filePath , TimeStamp );
                }
            } );
        }
        #endregion
    }
}
