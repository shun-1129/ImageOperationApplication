using ImageSplitApp.Constants;
using ImageSplitApp.Forms;
using System.Configuration;

namespace ImageSplitApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main ()
        {
            CheckApplicationConfigRootFolder ();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize ();
            Application.Run ( new ImageSplitForm () );
        }

        private static void CheckApplicationConfigRootFolder ()
        {
            string configPath = ConfigurationManager.OpenExeConfiguration ( ConfigurationUserLevel.PerUserRoamingAndLocal ).FilePath;
            string? directoryPath = Path.GetDirectoryName ( Path.GetDirectoryName ( configPath ) );
            string? rootDirectoryPath = Path.GetDirectoryName ( directoryPath );

            if ( !Directory.Exists ( directoryPath ) )
            {
                Directory.CreateDirectory ( AppConstants.DEFAULT_TEMP_DIRECTORY_PATH );

                Properties.Settings.Default.WorkFolderPath = AppConstants.DEFAULT_WORK_DIRECTORY_PATH;
                Properties.Settings.Default.TempFolderPath = AppConstants.DEFAULT_TEMP_DIRECTORY_PATH;
                Properties.Settings.Default.Save ();
            }
        }
    }
}