using ImageResizeApp.Models;

namespace ImageResizeApp.Views
{
    public partial class WorkFolderView : Form
    {
        public WorkFolderView ()
        {
            InitializeComponent ();
        }

        private void WorkFolderView_Load ( object sender , EventArgs e )
        {
            WorkFolderTextBox.Text = SelectedFolderSetting.Instance.WorkFolderPath;
            TempFolderTextBox.Text = SelectedFolderSetting.Instance.TempFolderPath;
            BackupFolderTextBox.Text = SelectedFolderSetting.Instance.BackupFolderPath;
            FailureFolderTextBox.Text = SelectedFolderSetting.Instance.FailureFolderPath;
            DuplicatesFolderTextBox.Text = SelectedFolderSetting.Instance.DuplicatesFolderPath;
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
                    SelectedFolderSetting.Instance.WorkFolderPath = selectedPath;
                    break;
                case "temp":
                    TempFolderTextBox.Text = selectedPath;
                    SelectedFolderSetting.Instance.TempFolderPath = selectedPath;
                    break;
                case "backup":
                    BackupFolderTextBox.Text = selectedPath;
                    SelectedFolderSetting.Instance.BackupFolderPath = selectedPath;
                    break;
                case "failure":
                    FailureFolderTextBox.Text = selectedPath;
                    SelectedFolderSetting.Instance.FailureFolderPath = selectedPath;
                    break;
                case "duplicates":
                    DuplicatesFolderTextBox.Text = selectedPath;
                    SelectedFolderSetting.Instance.DuplicatesFolderPath = selectedPath;
                    break;
                default:
                    break;
            }
        }
    }
}
