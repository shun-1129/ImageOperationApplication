namespace BuildTool
{
    internal class Program
    {
        private const string RELEASE = "Release";
        private const string DEBUG = "Debug";
        private const string TARGET_FRAMEWORK = "net8.0-windows";

        private const string GUI_APP_PROJECT_NAME = "ImageResizeApp";
        private const string CLI_APP_PROJECT_NAME = "ImageResizeConsole";

        private static readonly string DestinationBasePath = @$"{AppContext.BaseDirectory}..\";
        private static readonly string BaskupBasePath = Path.Combine ( DestinationBasePath, "old" );

        static void Main ( string[] args )
        {
            if ( !RELEASE.Equals ( args[0] ) && !DEBUG.Equals ( args[0] ) )
            {
                Console.WriteLine ( "Invalid argument. Please specify 'Release' or 'Debug'." );
                return;
            }

            if ( DEBUG.Equals ( args[0] ) )
            {
                Console.WriteLine ( "Debug build deployment is not supported." );
                return;
            }

            string guiAppBasePath = @$"{AppContext.BaseDirectory}\..\..\ImageResizeApp\bin";
            string cliAppBasePath = @$"{AppContext.BaseDirectory}\..\..\ImageResizeConsole\ImageResizeConsole\bin";

            string guiAppPath = @$"{guiAppBasePath}\{args[0]}\{TARGET_FRAMEWORK}";
            string cliAppPath = @$"{cliAppBasePath}\{args[0]}\{TARGET_FRAMEWORK}";

            string destGuiAppPath = Path.Combine ( DestinationBasePath, GUI_APP_PROJECT_NAME );

            if ( args[1].Equals ( GUI_APP_PROJECT_NAME ) )
            {
                Console.WriteLine ( $"Deploying {GUI_APP_PROJECT_NAME}..." );

                string tempSrcCliAppPath = Path.Combine ( destGuiAppPath , CLI_APP_PROJECT_NAME );
                string tempDestCliAppPath = Path.Combine ( DestinationBasePath , CLI_APP_PROJECT_NAME );
                if ( !Directory.Exists ( Path.Combine ( guiAppPath , CLI_APP_PROJECT_NAME ) ) )
                {
                    Directory.Move ( tempSrcCliAppPath , tempDestCliAppPath );
                }

                if ( Directory.Exists ( destGuiAppPath ) )
                {
                    string backupGuiAppPath = Path.Combine ( BaskupBasePath, $"{GUI_APP_PROJECT_NAME}_{DateTime.Now.ToString ( "yyyyMMdd_HHmmss" )}" );
                    MoveDirectory ( destGuiAppPath , backupGuiAppPath );
                }

                CopyDirectory ( guiAppPath , destGuiAppPath );
                Directory.Move ( tempDestCliAppPath , Path.Combine ( destGuiAppPath , CLI_APP_PROJECT_NAME ) );

                Console.WriteLine ( $"{GUI_APP_PROJECT_NAME} deployed successfully." );
            }
            else
            {
                Console.WriteLine ( $"Deploying {CLI_APP_PROJECT_NAME}" );
                string destPath = Path.Combine ( BaskupBasePath, $"{GUI_APP_PROJECT_NAME}_{DateTime.Now.ToString ( "yyyyMMdd_HHmmss" )}" );
                CopyDirectory ( destGuiAppPath , destPath );
                string tempPath = Path.Combine ( destGuiAppPath , CLI_APP_PROJECT_NAME );
                if ( Directory.Exists ( tempPath ) )
                {
                    Directory.Delete ( tempPath , true );
                }

                CopyDirectory ( cliAppPath , tempPath );
                Console.WriteLine ( $"{CLI_APP_PROJECT_NAME} deployed successfully." );
            }
        }

        private static void MoveDirectory ( string sourceDir , string destDir )
        {
            Directory.Move ( sourceDir , destDir );
        }

        private static void CopyDirectory ( string sourceDir , string destDir )
        {
            Directory.CreateDirectory ( destDir );
            foreach ( string file in Directory.GetFiles ( sourceDir ) )
            {
                string destFile = Path.Combine ( destDir , Path.GetFileName ( file ) );
                File.Copy ( file , destFile , true );
            }

            foreach ( string directory in Directory.GetDirectories ( sourceDir ) )
            {
                string destSubDir = Path.Combine ( destDir , Path.GetFileName ( directory ) );
                CopyDirectory ( directory , destSubDir );
            }
        }
    }
}
