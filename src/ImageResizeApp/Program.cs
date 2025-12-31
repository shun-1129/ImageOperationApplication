using ImageResizeApp.Logics.Impl;
using ImageResizeApp.Views;
using NLog;

namespace ImageResizeApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main ()
        {
            Logger logger = LogManager.GetCurrentClassLogger ();
            logger.Info ( "アプリケーション起動処理開始" );

            Commons.ReadJsonFiles ();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            logger.Debug ( "アプリケーション初期化開始" );
            ApplicationConfiguration.Initialize ();
            logger.Debug ( "アプリケーション初期化終了" );

            logger.Info ( "アプリケーション起動" );
            Application.Run ( new ImageResizeView () );
        }
    }
}