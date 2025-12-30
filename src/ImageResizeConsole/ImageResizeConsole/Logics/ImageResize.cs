using CommonLibrary.Utilities;
using ImageResizeConsole.Models.Data;
using NLog;
using static CommonLibrary.Constants.Constants.FileExtension;

namespace ImageResizeConsole.Logics
{
    public class ImageResize
    {
        #region メンバ変数
        private readonly Logger _logger;
        private readonly Appsettings _appsettings;
        private int _minimumPixelSize;
        private int _quality;
        private string _folderPath;
        private List<string> _deleteTargetNameList;
        #endregion

        #region プロパティ
        #endregion

        #region コンストラクタ
        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        /// <param name="folderPath">フォルダパス</param>
        /// <param name="minimumPixelSize">最小ピクセルサイズ</param>
        /// <param name="quality">品質</param>
        public ImageResize ( string folderPath , int minimumPixelSize , int quality , List<string> deleteTargetNameList , Appsettings appsettings )
        {
            _logger = LogManager.GetCurrentClassLogger ();
            _folderPath = folderPath;
            _minimumPixelSize = minimumPixelSize;
            _quality = quality;
            _deleteTargetNameList = deleteTargetNameList;
            _appsettings = appsettings;
        }
        #endregion

        #region メソッド
        #region publicメソッド
        public bool Execute ()
        {
            Console.WriteLine ( "画像の変換を開始します。" );

            bool isSuccess = ExecuteFileDelete ();
            if ( !isSuccess )
            {
                _logger.Error ( "不要ファイルの削除に失敗しました。" );
                return false;
            }
            _logger.Info ( "不要ファイルの削除が完了しました。" );

            isSuccess = ExecuteExtractGifFrames ();
            if ( !isSuccess )
            {
                _logger.Error ( "GIFの分解に失敗しました。" );
                return false;
            }

            isSuccess = ExecuteConvert ();
            if ( !isSuccess )
            {
                _logger.Error ( "画像の変換に失敗しました。" );
                return false;
            }
            _logger.Info ( "画像の変換が完了しました。" );

            isSuccess = ExecuteResize ();
            if ( !isSuccess )
            {
                _logger.Error ( "画像のリサイズに失敗しました。" );
                return false;
            }
            _logger.Info ( "画像のリサイズが完了しました。" );

            return true;
        }
        #endregion

        #region protectedメソッド
        #endregion

        #region internalメソッド
        #endregion

        #region privateメソッド
        private bool ExecuteConvert ()
        {
            try
            {
                // スレッド数の制限
                int maxDegreeOfParallelism = 4;
                SemaphoreSlim semaphore = new SemaphoreSlim(maxDegreeOfParallelism);
                List<Task> tasks = new List<Task>();
                object lockObject = new object();
                bool overallSuccess = true;
                List<string> failedFiles = new List<string>();

                IEnumerable<string> filePathList = FileUtil.GetAllFile ( _folderPath , searchOption: SearchOption.AllDirectories );

                if ( !_appsettings.IsGIFConvert )
                {
                    filePathList = filePathList.Where ( x => !FileUtil.CheckExtension ( x , GIF ) );
                }

                foreach ( string filePath in filePathList )
                {
                    tasks.Add ( Task.Run ( async () =>
                    {
                        await semaphore.WaitAsync ();

                        try
                        {
                            await ImageUtil.ConvertToJpegAsync ( filePath );
                        }
                        catch ( Exception ex )
                        {
                            lock ( lockObject )
                            {
                                overallSuccess = false;
                                failedFiles.Add ( filePath );
                                Console.WriteLine ( $"Error processing file {filePath}: {ex.Message}" );
                            }
                        }
                        finally
                        {
                            semaphore.Release ();
                        }
                    } ) );
                }

                Task.WhenAll ( tasks ).Wait ();

                if ( !overallSuccess )
                {
                    return false;
                }

                if ( 0 < failedFiles.Count )
                {
                    return false;
                }

                return true;
            }
            catch ( Exception ex )
            {
                Console.WriteLine ( ex.Message );
                return false;
            }
        }

        private bool ExecuteExtractGifFrames ()
        {
            if ( !_appsettings.IsGIFExtract )
            {
                return true;
            }

            try
            {
                // スレッド数の制限
                int maxDegreeOfParallelism = 4;
                SemaphoreSlim semaphore = new SemaphoreSlim(maxDegreeOfParallelism);
                List<Task> tasks = new List<Task>();
                object lockObject = new object();
                bool overallSuccess = true;
                List<string> failedFiles = new List<string>();

                IEnumerable<string> filePathList = FileUtil.GetAllFile ( _folderPath , searchOption: SearchOption.AllDirectories )
                    .Where ( x => FileUtil.CheckExtension ( x , GIF ) );

                _logger.Info ( $"Gifファイル数: {filePathList.Count ()} 件" );

                foreach ( string filePath in filePathList )
                {
                    tasks.Add ( Task.Run ( async () =>
                    {
                        await semaphore.WaitAsync ();

                        try
                        {
                            await ImageUtil.ExtractGifFrames ( filePath );
                        }
                        catch ( Exception ex )
                        {
                            lock ( lockObject )
                            {
                                overallSuccess = false;
                                failedFiles.Add ( filePath );
                                Console.WriteLine ( $"Error processing file {filePath}: {ex.Message}" );
                            }
                        }
                        finally
                        {
                            semaphore.Release ();
                        }
                    } ) );
                }

                Task.WhenAll ( tasks ).Wait ();

                if ( !overallSuccess )
                {
                    return false;
                }

                if ( 0 < failedFiles.Count )
                {
                    return false;
                }

                return true;
            }
            catch ( Exception ex )
            {
                Console.WriteLine ( ex.Message );
                return false;
            }
        }

        private bool ExecuteResize ()
        {
            try
            {
                // スレッド数の制限
                int maxDegreeOfParallelism = 4;
                SemaphoreSlim semaphore = new SemaphoreSlim(maxDegreeOfParallelism);
                List<Task> tasks = new List<Task>();
                object lockObject = new object();
                bool overallSuccess = true;
                List<string> failedFiles = new List<string>();

                IEnumerable<string> filePathList = FileUtil.GetAllFile ( _folderPath , searchOption: SearchOption.AllDirectories );

                if ( !_appsettings.IsGIFConvert )
                {
                    filePathList = filePathList.Where ( x => !FileUtil.CheckExtension ( x , GIF ) );
                }

                foreach ( string filePath in filePathList )
                {
                    tasks.Add ( Task.Run ( async () =>
                    {
                        await semaphore.WaitAsync ();
                        try
                        {
                            await ImageUtil.ResizeImageFile ( filePath , _minimumPixelSize , _quality );
                        }
                        catch ( Exception ex )
                        {
                            lock ( lockObject )
                            {
                                overallSuccess = false;
                                failedFiles.Add ( filePath );
                                Console.WriteLine ( $"Error processing file {filePath}: {ex.Message}" );
                            }
                        }
                        finally
                        {
                            semaphore.Release ();
                        }
                    } ) );
                }

                Task.WhenAll ( tasks ).Wait ();

                if ( !overallSuccess )
                {
                    return false;
                }

                if ( 0 < failedFiles.Count )
                {
                    return false;
                }

                return true;
            }
            catch ( Exception ex )
            {
                Console.WriteLine ( ex.Message );
                return false;
            }
        }

        private bool ExecuteFileDelete ()
        {
            try
            {
                IEnumerable<string> filePathList = FileUtil.GetAllFile ( _folderPath , searchOption: SearchOption.AllDirectories );
                foreach ( string filePath in filePathList )
                {
                    string fileName = FileUtil.GetFileName ( filePath , false );
                    bool isDeleteTarget = _deleteTargetNameList.Any ( x => x.Equals ( fileName ) );
                    if ( isDeleteTarget )
                    {
                        File.Delete ( filePath );
                    }
                }

                return true;
            }
            catch ( Exception ex )
            {
                Console.WriteLine ( ex.Message );
                return false;
            }
        }
        #endregion
        #endregion
    }
}
