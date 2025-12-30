using CommonLibrary.Models;
using CommonLibrary.Utilities;
using ImageResizeApp.Logics.Impl;
using ImageResizeApp.Logics.Interface;
using ImageResizeApp.Models;
using ImageResizeApp.Models.Logics;
using System.Diagnostics;
using static ImageResizeApp.Constants.AppConstants;

namespace ImageResizeApp.Views
{
    public partial class ImageResizeView : Form
    {
        #region メンバ変数
        private List<ComboboxItem> _qualityComboboxItemList = new List<ComboboxItem> ();
        private List<ComboboxItem> _pixelMinimumComboboxItemList = new List<ComboboxItem> ();
        #endregion

        #region プロパティ
        public ResizeSetting ResizeSetting { get; set; }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public ImageResizeView ()
        {
            InitializeComponent ();

            ResizeSetting = new ResizeSetting ();

            InitializeLayout ();
            InitializeFolderSettings ();
            InitializeProgressBar ();

            Commons.ReadJsonFiles ();
        }
        #endregion

        #region メソッド
        #region 初期化
        /// <summary>
        /// レイアウト初期化
        /// </summary>
        private void InitializeLayout ()
        {
            QualityComboBox.Items.Clear ();
            for ( int i = 50 ; i <= 100 ; i += 10 )
            {
                string quality = $"{i}%";
                _qualityComboboxItemList.Add ( new ComboboxItem ( quality , i ) );
                QualityComboBox.Items.Add ( quality );
            }

            QualityComboBox.SelectedIndex = 2;

            PixelMinimumComboBox.Items.Clear ();
            for ( int i = 100 ; i <= 1500 ; i += 100 )
            {
                string pixel = $"{i}px";
                _pixelMinimumComboboxItemList.Add ( new ComboboxItem ( pixel , i ) );
                PixelMinimumComboBox.Items.Add ( pixel );
            }

            PixelMinimumComboBox.SelectedIndex = 9;
        }

        /// <summary>
        /// フォルダ設定初期化
        /// </summary>
        private void InitializeFolderSettings ()
        {
            SelectedFolderSetting.Instance.WorkFolderPath = DEFALUT_WORK_FOLDER;
            SelectedFolderSetting.Instance.TempFolderPath = DEFALUT_TEMP_FOLDER;
            SelectedFolderSetting.Instance.BackupFolderPath = DEFALUT_BACKUP_FOLDER;
            SelectedFolderSetting.Instance.FailureFolderPath = DEFALUT_FAILURE_FOLDER;
            SelectedFolderSetting.Instance.DuplicatesFolderPath = DEFALUT_DUPLICATES_FOLDER;
        }

        private void InitializeProgressBar ()
        {
            MainProgressBar.Minimum = ProgressBarData.Instance.MainProgressBarData.Minimum;
            MainProgressBar.Maximum = ProgressBarData.Instance.MainProgressBarData.Maximum;
            MainProgressBar.Value = ProgressBarData.Instance.MainProgressBarData.Value;
        }
        #endregion

        #region メニュークリックイベント
        /// <summary>
        /// 作業フォルダ設定メニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
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
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
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
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        public void LogDisplay_ToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            using ( LogDisplayView logDisplayView = new LogDisplayView () )
            {
                logDisplayView.ShowDialog ();
            }
        }

        /// <summary>
        /// 設定全件読み込みメニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private void AllReload_ToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            Commons.ReadJsonFiles ();
            MessageBox.Show (
                this ,
                "アプリケーション設定を全件読み込みが完了しました。" ,
                "読み込み完了" ,
                MessageBoxButtons.OK ,
                MessageBoxIcon.Information );
        }

        /// <summary>
        /// 削除文字列設定読み込みメニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private void DeleteTargetName_ToolStripMenuItem_Click ( object sender , EventArgs e )
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

        /// <summary>
        /// 削除ファイル設定読み込みメニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
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

        /// <summary>
        /// 入れ替え設定読み込みメニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private void Swap_ToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            Commons.ReadFileNameChangeSettingsJsonFile ();
            MessageBox.Show (
                this ,
                $"入れ替え設定の読み込みが完了しました。" +
                $"\n読み込み件数: {Appsettings.Instance.FileNameChangeSettings.SwapTarget.Count} 件" ,
                "読み込み完了" ,
                MessageBoxButtons.OK ,
                MessageBoxIcon.Information );
        }

        /// <summary>
        /// タイムスタンプ変更メニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private void TimeStampChangeToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            using ( TimeStampChangeView timeStampChengeView = new TimeStampChangeView () )
            {
                timeStampChengeView.ShowDialog ();
            }
        }

        /// <summary>
        /// ファイル検索メニュークリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private void FileSearchToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            using ( FileSearchView fileSearchView = new FileSearchView () )
            {
                fileSearchView.ShowDialog ();
            }
        }

        /// <summary>
        /// 品質コンボボックス変更イベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private void QualityComboBox_SelectedIndexChanged ( object sender , EventArgs e )
        {
            if ( QualityComboBox.SelectedItem is string selectQuality )
            {
                ComboboxItem item = _qualityComboboxItemList.First ( x => x.Text == selectQuality );
                ResizeSetting.Quality = ( int ) item.GetValue ();
            }
        }

        /// <summary>
        /// ピクセル下限コンボボックス変更イベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private void PixelMinimumComboBox_SelectedIndexChanged ( object sender , EventArgs e )
        {
            if ( PixelMinimumComboBox.SelectedItem is string selectPixel )
            {
                ComboboxItem item = _pixelMinimumComboboxItemList.First ( x => x.Text == selectPixel );
                ResizeSetting.PixelSize = ( int ) item.GetValue ();
            }
        }

        /// <summary>
        /// リサイズ開始ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private async void ResizeStartBtn_Click ( object sender , EventArgs e )
        {
            IImageResize imageResize = new ImageResize ( ResizeSetting , MainProgressBar );

            int failedCount = await imageResize.ExecuteAsync ();

            if ( 0 < failedCount )
            {
                MessageBox.Show ( this , $"{failedCount} 件失敗しました。" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
            else
            {
                MessageBox.Show ( this , "全件正常に完了しました。" , "Info" , MessageBoxButtons.OK , MessageBoxIcon.Information );
            }

            MainProgressBar.Value = 0;
            MainProgressBar.Minimum = 0;
            MainProgressBar.Maximum = 100;
        }

        /// <summary>
        /// ZIP解凍ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private async void UnzipBtn_Click ( object sender , EventArgs e )
        {
            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog (
                ProcessLogType.Info ,
                DateTime.Now ,
                "ZIP解凍処理" ,
                "解凍処理を開始します。" ) );

            if ( !File.Exists ( SEVEN_ZIP_EXE_PATH ) )
            {
                LogData.Instance.ErrorProcessLogList.Add ( new ProcessLog (
                    ProcessLogType.Error ,
                    DateTime.Now ,
                    "ZIP解凍処理" ,
                    $"7-ZIPの実行ファイルが存在しません。{SEVEN_ZIP_EXE_PATH}" ) );
                MessageBox.Show ( this , $"7-ZIPの実行ファイルが存在しません。{SEVEN_ZIP_EXE_PATH}" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                return;
            }

            int failCount = 0;
            IEnumerable<string> filePathList = FileUtil.GetAllFile ( SelectedFolderSetting.Instance.WorkFolderPath );

            MainProgressBar.Value = 0;
            MainProgressBar.Maximum = filePathList.Count ();
            MainProgressBar.Minimum = 0;

            await Task.Run ( async () =>
            {
                foreach ( string filePath in filePathList )
                {
                    this.Invoke ( new Action ( () =>
                    {
                        MainProgressBar.Value++;
                    } ) );
                    string outputFolderPath = Path.Combine ( SelectedFolderSetting.Instance.WorkFolderPath , FileUtil.GetFileName ( filePath ) );

                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = SEVEN_ZIP_EXE_PATH,
                        Arguments = $"x \"{filePath}\" -o\"{outputFolderPath}\" -y",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using Process process = Process.Start ( psi )!;
                    string stdOutput = process.StandardOutput.ReadToEnd ();
                    string stdError = process.StandardError.ReadToEnd ();
                    await process.WaitForExitAsync ();

                    if ( 0 != process.ExitCode )
                    {
                        failCount++;

                        if ( Directory.Exists ( outputFolderPath ) )
                        {
                            Directory.Delete ( outputFolderPath , true );
                        }

                        FileUtil.MoveFile ( filePath , SelectedFolderSetting.Instance.FailureFolderPath );

                        LogData.Instance.ErrorProcessLogList.Add ( new ProcessLog (
                            ProcessLogType.Error ,
                            DateTime.Now ,
                            "ZIP解凍処理" ,
                            $"ZIP解凍に失敗しました。ファイルパス: {filePath} エラー内容: {stdError}" ) );
                    }
                    else
                    {
                        LogData.Instance.InfoProcessLogList.Add ( new ProcessLog (
                            ProcessLogType.Error ,
                            DateTime.Now ,
                            "ZIP解凍処理" ,
                            $"ZIP解凍に成功しました。ファイルパス: {filePath}" ) );
                    }
                }
            } );

            if ( 0 < failCount )
            {
                LogData.Instance.WarningProcessLogList.Add ( new ProcessLog
                (
                    ProcessLogType.Warn ,
                    DateTime.Now ,
                    "ZIP解凍処理" ,
                    $"解凍処理が完了しました。ただし、{failCount} 件失敗しました。"
                ) );
                MessageBox.Show ( this , $"解凍処理が完了しました。ただし、{failCount} 件失敗しました。" , "Warn" , MessageBoxButtons.OK , MessageBoxIcon.Warning );

                MainProgressBar.Value = 0;
                MainProgressBar.Maximum = 100;
                MainProgressBar.Minimum = 0;
                return;
            }

            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
            (
                ProcessLogType.Info ,
                DateTime.Now ,
                "ZIP解凍処理" ,
                "解凍処理が完了しました。"
            ) );
            MessageBox.Show ( this , "解凍完了" , "Info" , MessageBoxButtons.OK , MessageBoxIcon.Information );

            MainProgressBar.Value = 0;
            MainProgressBar.Maximum = 100;
            MainProgressBar.Minimum = 0;
        }

        /// <summary>
        /// ZIP圧縮ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private async void CompressionBtn_Click ( object sender , EventArgs e )
        {
            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
            (
                ProcessLogType.Info ,
                DateTime.Now ,
                "ZIP圧縮処理" ,
                "圧縮処理を開始します。"
            ) );

            if ( !File.Exists ( SEVEN_ZIP_EXE_PATH ) )
            {
                LogData.Instance.ErrorProcessLogList.Add ( new ProcessLog
                (
                    ProcessLogType.Error ,
                    DateTime.Now ,
                    "ZIP圧縮処理" ,
                    $"7-ZIPの実行ファイルが存在しません。{SEVEN_ZIP_EXE_PATH}"
                ) );
                MessageBox.Show ( this , $"7-ZIPの実行ファイルが存在しません。{SEVEN_ZIP_EXE_PATH}" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                return;
            }

            int failCount = 0;
            IEnumerable<string> folderPathList = DirectoryUtil.GetDirectories ( SelectedFolderSetting.Instance.TempFolderPath );

            MainProgressBar.Value = 0;
            MainProgressBar.Maximum = folderPathList.Count ();
            MainProgressBar.Minimum = 0;

            foreach ( string folderPath in folderPathList )
            {
                MainProgressBar.Value++;
                string outputFilePath = Path.Combine ( SelectedFolderSetting.Instance.TempFolderPath , $"{Path.GetFileName ( folderPath )}.zip" );
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = SEVEN_ZIP_EXE_PATH,
                    Arguments = $"a -tzip -mx=9 \"{outputFilePath}\" \"{folderPath}\\*\" -y",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using Process process = Process.Start ( psi )!;
                string stdOutput = process.StandardOutput.ReadToEnd ();
                string stdError = process.StandardError.ReadToEnd ();
                await process.WaitForExitAsync ();

                if ( 0 != process.ExitCode )
                {
                    failCount++;
                    if ( File.Exists ( outputFilePath ) )
                    {
                        File.Delete ( outputFilePath );
                    }

                    LogData.Instance.ErrorProcessLogList.Add ( new ProcessLog
                    (
                        ProcessLogType.Error ,
                        DateTime.Now ,
                        "ZIP圧縮処理" ,
                        $"ZIP圧縮に失敗しました。フォルダパス: {folderPath} エラー内容: {stdError}"
                    ) );

                    continue;
                }

                string zipFilePath = Path.Combine ( SelectedFolderSetting.Instance.TempFolderPath , $"{Path.GetFileName ( folderPath )}.zip" );
                FileUtil.MoveFile ( zipFilePath , SelectedFolderSetting.Instance.WorkFolderPath );
                Directory.Delete ( folderPath , true );

                LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
                (
                    ProcessLogType.Info ,
                    DateTime.Now ,
                    "ZIP圧縮処理" ,
                    $"ZIP圧縮に成功しました。フォルダパス: {folderPath}"
                ) );
            }

            if ( 0 < failCount )
            {
                LogData.Instance.WarningProcessLogList.Add ( new ProcessLog
                (
                    ProcessLogType.Warn ,
                    DateTime.Now ,
                    "ZIP圧縮処理" ,
                    $"圧縮処理が完了しました。ただし、{failCount} 件失敗しました。"
                ) );
                MessageBox.Show ( this , $"圧縮処理が完了しました。ただし、{failCount} 件失敗しました。" , "Warn" , MessageBoxButtons.OK , MessageBoxIcon.Warning );

                MainProgressBar.Value = 0;
                MainProgressBar.Maximum = 100;
                MainProgressBar.Minimum = 0;
                return;
            }

            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
            (
                ProcessLogType.Info ,
                DateTime.Now ,
                "ZIP圧縮処理" ,
                "圧縮処理が完了しました。"
            ) );
            MessageBox.Show ( this , "圧縮完了" , "Info" , MessageBoxButtons.OK , MessageBoxIcon.Information );

            MainProgressBar.Value = 0;
            MainProgressBar.Maximum = 100;
            MainProgressBar.Minimum = 0;
        }

        /// <summary>
        /// 名称変更ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private async void RenameBtn_Click ( object sender , EventArgs e )
        {
            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
            (
                ProcessLogType.Info ,
                DateTime.Now ,
                "名称変更処理" ,
                "名称変更処理を開始します。"
            ) );

            IEnumerable<string> filePathList = FileUtil.GetAllFile ( SelectedFolderSetting.Instance.WorkFolderPath );

            MainProgressBar.Value = 0;
            MainProgressBar.Maximum = filePathList.Count ();
            MainProgressBar.Minimum = 0;

            await Task.Run ( () =>
            {
                OperateFile operateFile = new OperateFile ();
                foreach ( string filePath in filePathList )
                {
                    MainProgressBar.Invoke ( () =>
                    {
                        MainProgressBar.Value++;
                    } );

                    Result result = operateFile.ExecuteZipFileRemane ( filePath );
                    if ( !result.IsSuccess )
                    {
                        LogData.Instance.ErrorProcessLogList.Add ( new ProcessLog
                        (
                            ProcessLogType.Error ,
                            DateTime.Now ,
                            "名称変更処理" ,
                            $"名称変更に失敗しました。ファイルパス: {filePath} エラー内容: {result.Message}"
                        ) );
                    }
                }
            } );

            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
            (
                ProcessLogType.Info ,
                DateTime.Now ,
                "名称変更処理" ,
                "名称変更処理が完了しました。"
            ) );

            MessageBox.Show ( this , "名称変更処理が完了しました。" , "Info" , MessageBoxButtons.OK , MessageBoxIcon.Information );
            MainProgressBar.Value = 0;
            MainProgressBar.Maximum = 100;
            MainProgressBar.Minimum = 0;
        }

        /// <summary>
        /// フォルダ振り分けボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private async void FolderAllocationBtn_Click ( object sender , EventArgs e )
        {
            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
            (
                ProcessLogType.Info ,
                DateTime.Now ,
                "フォルダ振り分け処理" ,
                "フォルダ振り分け処理を開始します。"
            ) );

            await Task.Run ( async () =>
            {
                IEnumerable<string> filePathList = FileUtil.GetAllFile ( SelectedFolderSetting.Instance.WorkFolderPath );
                IEnumerable<string> folderPathList = DirectoryUtil.GetDirectories ( SelectedFolderSetting.Instance.WorkFolderPath );
                Dictionary<string , string> folderCreatorDict = folderPathList
                    .ToDictionary (
                        key => DirectoryUtil.GetDirectoryName ( key ) ,
                        path => path );

                Invoke ( new Action ( () =>
                {
                    MainProgressBar.Value = 0;
                    MainProgressBar.Maximum = filePathList.Count ();
                    MainProgressBar.Minimum = 0;
                } ) );

                await Task.Delay ( 10 );

                Dictionary<string , List<string>> moveTargetDict = new Dictionary<string , List<string>> ();
                foreach ( string filePath in filePathList )
                {
                    string creatorName = CommonMethod.DeleteBrackets ( CommonMethod.GetCreator ( filePath ) );
                    if ( moveTargetDict.ContainsKey ( creatorName ) )
                    {
                        moveTargetDict[creatorName].Add ( filePath );
                    }
                    else
                    {
                        moveTargetDict.Add ( creatorName , new List<string> { filePath } );
                    }
                }

                foreach ( KeyValuePair<string , List<string>> moveTarget in moveTargetDict )
                {
                    Invoke ( new Action ( () =>
                    {
                        MainProgressBar.Value++;
                    } ) );

                    if ( folderCreatorDict.ContainsKey ( moveTarget.Key ) )
                    {
                        foreach ( string filePath in moveTarget.Value )
                        {
                            FileUtil.MoveFile ( filePath , folderCreatorDict[moveTarget.Key] );
                        }

                        continue;
                    }

                    if ( moveTarget.Value.Count == 1 )
                    {
                        continue;
                    }

                    string newFolderPath = CommonMethod.CreateDirectory ( SelectedFolderSetting.Instance.WorkFolderPath , moveTarget.Key );
                    Directory.CreateDirectory ( newFolderPath );
                    foreach ( string filePath in moveTarget.Value )
                    {
                        FileUtil.MoveFile ( filePath , newFolderPath );
                    }

                    await Task.Delay ( 10 );
                }
            } );

            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
            (
                ProcessLogType.Info ,
                DateTime.Now ,
                "フォルダ振り分け処理" ,
                "フォルダ振り分け処理が完了しました。"
            ) );

            MessageBox.Show ( this , "フォルダ振り分け処理が完了しました。" , "Info" , MessageBoxButtons.OK , MessageBoxIcon.Information );
            MainProgressBar.Value = 0;
            MainProgressBar.Maximum = 100;
            MainProgressBar.Minimum = 0;
        }

        /// <summary>
        /// フォルダ分解ボタンクリックイベント
        /// </summary>
        /// <param name="sender">イベント発生元のオブジェクト</param>
        /// <param name="e">イベント固有のデータ</param>
        private async void FolderDecompositionBtn_Click ( object sender , EventArgs e )
        {
            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
            (
                ProcessLogType.Info ,
                DateTime.Now ,
                "フォルダ分解処理" ,
                "フォルダ分解処理を開始します。"
            ) );

            IEnumerable<string> folderPathList = DirectoryUtil.GetDirectories ( SelectedFolderSetting.Instance.WorkFolderPath );
            MainProgressBar.Value = 0;
            MainProgressBar.Maximum = folderPathList.Count ();
            MainProgressBar.Minimum = 0;

            await Task.Run ( async () =>
            {
                foreach ( string folderPath in folderPathList )
                {
                    MainProgressBar.Invoke ( () =>
                    {
                        MainProgressBar.Value++;
                    } );

                    IEnumerable<string> filePathList = FileUtil.GetAllFile ( folderPath );
                    foreach ( string filePath in filePathList )
                    {
                        FileUtil.MoveFile ( filePath , SelectedFolderSetting.Instance.WorkFolderPath );
                    }

                    await Task.Delay ( 10 );

                    filePathList = FileUtil.GetAllFile ( folderPath );
                    if ( 0 == filePathList.Count () )
                    {
                        Directory.Delete ( folderPath , true );
                    }
                }
            } )
            .ContinueWith ( x =>
            {
                MainProgressBar.Invoke ( new Action ( () =>
                {
                    MessageBox.Show ( this , "フォルダ分解処理が完了しました。" , "完了" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                    MainProgressBar.Value = 0;
                    MainProgressBar.Maximum = 100;
                    MainProgressBar.Minimum = 0;
                } ) );
            } , TaskScheduler.FromCurrentSynchronizationContext () );

            LogData.Instance.InfoProcessLogList.Add ( new ProcessLog
            (
                ProcessLogType.Info ,
                DateTime.Now ,
                "フォルダ分解処理" ,
                "フォルダ分解処理が完了しました。"
            ) );
        }
        #endregion
        #endregion

    }
}
