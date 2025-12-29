namespace ImageResizeApp.Models
{
    public class ProgressBarData
    {
        public class ProgressBarBase
        {
            private int _maximum;
            private int _minimum;
            private int _value;

            public int Maximum { get => _maximum; set => _maximum = value; }
            public int Minimum { get => _minimum; set => _minimum = value; }
            public int Value { get => _value; set => _value =  value ; }
        }

        private ProgressBarBase _mainProgressBarData;
        private ProgressBarBase _subProgressBarData;

        public static ProgressBarData Instance { get; } = new ProgressBarData ();
        public ProgressBarBase MainProgressBarData { get => _mainProgressBarData; set => _mainProgressBarData = value; }
        public ProgressBarBase SubProgressBarData { get => _subProgressBarData; set => _subProgressBarData =  value ; }

        public ProgressBarData ()
        {
            _mainProgressBarData = new ProgressBarBase ();
            _subProgressBarData = new ProgressBarBase ();
        }
    }
}
