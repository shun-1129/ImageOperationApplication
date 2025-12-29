using CommonLibrary.Helpers.Impl;
using CommonLibrary.Utilities.Impl;
using ImageResizeApp.Constants;
using ImageResizeApp.Logics.Interface;
using ImageResizeApp.Models;
using System.Diagnostics;
using System.Text.Json;
using static ImageResizeApp.Constants.AppConstants;

namespace ImageResizeApp.Logics.Impl
{
    public class ImageResize : IImageResize
    {
        #region メンバ変数
        /// <summary>
        /// ログ
        /// </summary>
        private readonly Logger _logger;
        /// <summary>
        /// リサイズ設定
        /// </summary>
        private ResizeSetting _resizeSetting;

        private ProgressBar _mainProgressBar;
        #endregion

        #region プロパティ
        #endregion

        #region コンストラクタ
        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        /// <param name="resizeSetting"></param>
        public ImageResize ( ResizeSetting resizeSetting , ProgressBar mainProgresBar )
        {
            _logger = new Logger ( typeof ( ImageResize ) );
            _resizeSetting = resizeSetting;
            _mainProgressBar = mainProgresBar;
        }
        #endregion

        /// <summary>
        /// ロジック実行（非同期）
        /// </summary>
        public async Task<int> ExecuteAsync ()
        {
            if ( !File.Exists ( AppConstants.ResizeAppPath ) )
            {
                LogData.Instance.ErrorProcessLogList.Add (
                    new ProcessLog (
                        ProcessLogType.Error,
                        DateTime.Now ,
                        "イメージリサイズ" ,
                        $"リサイズアプリケーションが存在しません。Path: {AppConstants.ResizeAppPath}" ) );
                return 0;
            }

            List<string> tempList = Appsettings.Instance.DeleteFiles.FileNames;
            string str = JsonSerializer.Serialize ( tempList );

            IEnumerable<string> folderPathList = DirectoryOperation.GetDirectories ( SelectedFolderSetting.Instance.WorkFolderPath );

            InitializeMainProgressBar ( folderPathList.Count () );

            int failedCount = 0;
            foreach ( string folderPath in folderPathList )
            {
                _mainProgressBar.Value++;

                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = AppConstants.ResizeAppPath,
                    ArgumentList =
                    {
                        folderPath,
                        _resizeSetting.PixelSize.ToString (),
                        _resizeSetting.Quality.ToString (),
                        str
                    },
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using Process process = Process.Start ( psi )!;
                await process.WaitForExitAsync ();

                if ( 0 != process.ExitCode )
                {
                    LogData.Instance.ErrorProcessLogList.Add (
                        new ProcessLog (
                            ProcessLogType.Error,
                            DateTime.Now ,
                            "イメージリサイズ" ,
                            $"イメージリサイズ処理に失敗しました。folderPath: {folderPath}" ) );
                    _logger.Error ( $"イメージリサイズ処理に失敗しました。folderPath: {folderPath}" );

                    FileOperation.MoveFile ( $"{folderPath}.zip" , SelectedFolderSetting.Instance.FailureFolderPath );
                    failedCount++;
                    continue;
                }

                FileOperation.MoveFile ( $"{folderPath}.zip" , SelectedFolderSetting.Instance.BackupFolderPath );

                string folderName = Path.GetFileName ( folderPath );
                DirectoryOperation.MoveDirectory ( folderPath , Path.Combine ( SelectedFolderSetting.Instance.TempFolderPath , folderName ) );
            }

            return failedCount;
        }

        private void InitializeMainProgressBar ( int maximum )
        {
            _mainProgressBar.Minimum = 0;
            _mainProgressBar.Maximum = maximum;
            _mainProgressBar.Value = 0;
        }
    }
}
