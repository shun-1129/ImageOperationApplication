using CommonLibrary.Models;
using CommonLibrary.Utilities.Json;
using ImageResizeConsole.Logics;
using ImageResizeConsole.Models.Data;
using NLog;
using System.Diagnostics;
using System.Text.Json;
using static ImageResizeConsole.Constants.AppConstants;

namespace ImageResizeConsole
{
    public class Program
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger ();
        private static Appsettings _appsettings = new Appsettings ();

        public static async Task<int> Main ( string[] args )
        {
            string path = Path.Combine ( AppContext.BaseDirectory , "appsettings.json" );
            Result<Appsettings> result = await JsonReader.TryReadJsonToModelAsync<Appsettings> ( path , "Appsettings" );
            if ( result.IsSuccess )
            {
                _appsettings = result.Data!;
            }

            using CancellationTokenSource cts = new CancellationTokenSource ();

            Task<int> workerTask = Task.Run ( () =>
            {
                return DoWork ( args , cts.Token );
            } );

            Task monitorTask = MonitorMemory ( cts.Token );

            int errorCode = await workerTask;
            cts.Cancel ();

            await monitorTask;

            return errorCode;
        }

        private static int DoWork ( string[] args , CancellationToken cancellationToken )
        {
            while ( true )
            {
                cancellationToken.ThrowIfCancellationRequested ();

                _logger.Info ( "ImageResizeConsole Start" );

                // 受け取った引数が正しいか確認する
                // 引数: フォルダパス、最小ピクセルサイズ、画質
                // 戻り値: エラーコード

                // 引数の数が正しいか確認する
                if ( 4 != args.Length )
                {
                    return ( int ) ErrorCode.ArgsReceiveFailed;
                }

                // フォルダパスが存在するか確認する
                if ( !Directory.Exists ( args[0] ) )
                {
                    return ( int ) ErrorCode.FolderNotFound;
                }
                Console.WriteLine ( $"Folder Path: {args[0]}" );

                // 最小ピクセルサイズが整数に変換できるか確認する
                if ( !int.TryParse ( args[1] , out int minimumPixelSize ) )
                {
                    return ( int ) ErrorCode.ImageResizeFailed;
                }

                // 画質が整数に変換できるか確認する
                if ( !int.TryParse ( args[2] , out int quality ) )
                {
                    return ( int ) ErrorCode.QualityInvalid;
                }

                List<string> deleteTargetNameList;
                try
                {
                    string deleteTargetNames = args[3];
                    deleteTargetNameList = JsonSerializer.Deserialize<List<string>> ( deleteTargetNames ) ?? new List<string> ();
                }
                catch
                {
                    deleteTargetNameList = new List<string> ();
                }

                // 画像リサイズを実行する
                ImageResize imageResize = new ImageResize ( args[0] , minimumPixelSize , quality , deleteTargetNameList , _appsettings );
                if ( !imageResize.Execute () )
                {
                    return ( int ) ErrorCode.ImageResizeFailed;
                }

                _logger.Info ( "ImageResizeConsole End" );
                return ( int ) ErrorCode.Success;
            }
        }

        private static async Task MonitorMemory ( CancellationToken cancellationToken )
        {
            using Process process = Process.GetCurrentProcess ();
            long ws = 0;
            long pm = 0;
            long vm = 0;
            long managed = 0;

            while ( !cancellationToken.IsCancellationRequested )
            {
                long tempWs = process.WorkingSet64;
                long tempPm = process.PagedMemorySize64;
                long tempVm = process.VirtualMemorySize64;
                long tempManaged = GC.GetTotalMemory ( false );

                bool isChanged = false;
                if ( ws != tempWs )
                {
                    ws = tempWs;
                    isChanged = true;
                }
                if ( pm != tempPm )
                {
                    pm = tempPm;
                    isChanged = true;
                }
                if ( vm != tempVm )
                {
                    vm = tempVm;
                    isChanged = true;
                }
                if ( managed != tempManaged )
                {
                    managed = tempManaged;
                    isChanged = true;
                }

                if ( isChanged )
                {
                    _logger.Debug ( "----- Memory Usage -----" );
                    _logger.Debug ( $"WS : {ws / 1024 / 1024} MB" );
                    _logger.Debug ( $"PM : {pm / 1024 / 1024} MB" );
                    _logger.Debug ( $"VM : {vm / 1024 / 1024} MB" );
                    _logger.Debug ( $"Managed : {managed / 1024 / 1024} MB" );
                }

                try
                {
                    await Task.Delay ( 1000 , cancellationToken );
                }
                catch ( TaskCanceledException )
                {
                    // タスクがキャンセルされた場合はループを抜ける
                    break;
                }
            }
        }
    }
}
