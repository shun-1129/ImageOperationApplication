using ImageResizeApp.Logics.Impl;
using ImageResizeApp.Models;

namespace ImageResizeApp
{
    public partial class ImageResizeApp : Form
    {
        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public ImageResizeApp ()
        {
            InitializeComponent ();
            InitializeLayout ();
        }

        /// <summary>
        /// レイアウト初期化
        /// </summary>
        private void InitializeLayout ()
        {
            QualityComboBox.Items.Clear ();
            for ( int i = 50 ; i <= 100 ; i += 10 )
            {
                QualityComboBox.Items.Add ( i.ToString () );
            }

            QualityComboBox.SelectedIndex = 2;

            PixelMinimumComboBox.Items.Clear ();
            for ( int i = 100 ; i <= 1500 ; i += 100 )
            {
                PixelMinimumComboBox.Items.Add ( i.ToString () );
            }

            PixelMinimumComboBox.SelectedIndex = 9;
        }

        private void AllAToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            Commons.ReadJsonFiles ();
            MessageBox.Show (
                this ,
                "アプリケーション設定を全件読み込みが完了しました。" ,
                "読み込み完了" ,
                MessageBoxButtons.OK ,
                MessageBoxIcon.Information );
        }

        private void DeleteTargetBToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            Commons.ReadDeleteTargetJsonFile ();
            MessageBox.Show ( 
                this ,
                $"削除対象文字列設定の読み込みが完了しました。" +
                $"\n読み込み件数: {Appsettings.Instance.DeleteTargets.DeleteTargetName.Count} 件" ,
                "読み込み完了" ,
                MessageBoxButtons.OK ,
                MessageBoxIcon.Information );
        }

        private void DeleteTargetFileCToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            Commons.ReadDeleteFilesJsonFile ();
            MessageBox.Show (
                this ,
                $"削除対象ファイル設定の読み込みが完了しました。" +
                $"\n読み込み件数: {Appsettings.Instance.DeleteFiles.FileNames.Count} 件" ,
                "読み込み完了" ,
                MessageBoxButtons.OK ,
                MessageBoxIcon.Information );
        }

        private void SwapTargetCToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            Commons.ReadFileNameChangeSettingsJsonFile ();
            MessageBox.Show (
                this ,
                $"入れ替え設定の読み込みが完了しました。" +
                $"\n読み込み件数: {Appsettings.Instance.FileNameChangeSettings.SwapTarget.Count} 件" ,
                "読み込み完了",
                MessageBoxButtons.OK ,
                MessageBoxIcon.Information );
        }

    }
}
