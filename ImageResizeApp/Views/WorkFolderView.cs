namespace ImageResizeApp.Views
{
    public partial class WorkFolderView : Form
    {
        public WorkFolderView ()
        {
            InitializeComponent ();
        }

        private void FolderSelectBtn_Click ( object sender , EventArgs e )
        {
            if ( sender is not Button btn )
            {
                return;
            }

            string tagValue = btn.Tag?.ToString () ?? string.Empty;

            if ( string.IsNullOrEmpty ( tagValue ) )
            {
                return;
            }

            string selectedPath = string.Empty;
            using ( FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog () )
            {
                folderBrowserDialog.Description = "Select Folder";
                folderBrowserDialog.ShowNewFolderButton = true;
                if ( folderBrowserDialog.ShowDialog () == DialogResult.OK )
                {
                    selectedPath = folderBrowserDialog.SelectedPath;
                }
            }

            switch ( tagValue )
            {
                case "work":
                    WorkFolderTextBox.Text = selectedPath;
                    break;
                case "temp":
                    TempFolderTextBox.Text = selectedPath;
                    break;
                case "backup":
                    BackupFolderTextBox.Text = selectedPath;
                    break;
                case "failure":
                    FailureFolderTextBox.Text = selectedPath;
                    break;
                case "duplicates":
                    DuplicatesFolderTextBox.Text = selectedPath;
                    break;
                default:
                    break;
            }
        }
    }
}
