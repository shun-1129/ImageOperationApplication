namespace ImageResizeApp.Views
{
    public partial class ImageResizeView : Form
    {
        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public ImageResizeView ()
        {
            InitializeComponent ();
        }

        /// <summary>
        /// 作業フォルダ設定メニュークリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WorkFolderSettinf_ToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            using ( WorkFolderView workFolderView = new WorkFolderView () )
            {
                workFolderView.ShowDialog ();
            }
        }

        /// <summary>
        /// オプションメニュークリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Option_ToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            using ( OptionView optionView = new OptionView () )
            {
                optionView.ShowDialog ();
            }
        }

        /// <summary>
        /// ログ表示メニュークリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LogDisplay_ToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            using ( LogDisplayView logDisplayView = new LogDisplayView () )
            {
                logDisplayView.ShowDialog ();
            }
        }
    }
}
