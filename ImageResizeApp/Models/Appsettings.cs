using CommonLibrary.Models;

namespace ImageResizeApp.Models
{
    public class Appsettings : AppsettingsBase
    {
        public static Appsettings Instance { get; } = new Appsettings ();

        public DeleteFiles DeleteFiles { get; set; }

        public DeleteTarget DeleteTargets { get; set; }

        public FileNameChangeSettings FileNameChangeSettings { get; set; }

        public Appsettings ()
        {
            DeleteFiles = new DeleteFiles ();
            DeleteTargets = new DeleteTarget ();
            FileNameChangeSettings = new FileNameChangeSettings ();
        }
    }
}
