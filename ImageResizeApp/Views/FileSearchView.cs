using CommonLibrary.Utilities;
using ImageResizeApp.Models;
using System.ComponentModel;
using System.Security.Cryptography;

namespace ImageResizeApp.Views
{
    public partial class FileSearchView : Form
    {
        private const int PADDING = 5;

        private BindingList<FileSearch.DirectoryInfo> _directoryInfoList = new BindingList<FileSearch.DirectoryInfo> ();
        private BindingList<FileSearch.FileInfo> _fileInfoList = new BindingList<FileSearch.FileInfo> ();

        public class FileHashInfo
        {
            private string _filePath = string.Empty;
            private string _fileName = string.Empty;
            private string _fileHash = string.Empty;

            public string FilePath
            {
                get => _filePath;
                set
                {
                    _filePath = value;
                    _fileName = FileUtil.GetFileName ( _filePath , false );
                }
            }
            public string FileName { get => _fileName; }
            public string FileHash { get => _fileHash; set => _fileHash = value; }
        }

        public FileSearchView ()
        {
            InitializeComponent ();
            InitializeLayout ();
        }

        private void InitializeLayout ()
        {
            int baseBtnPanelWidth = BtnPanel.Width;
            int baseBtnPanelHeight = BtnPanel.Height;
            int halfBtnPanelHeight = baseBtnPanelHeight / 2;

            InitializeButton ( halfBtnPanelHeight );

            RootFolderPathTextBox.Width = baseBtnPanelWidth - ( PADDING * 2 );
            int rootFolderPathTextBoxHeight = RootFolderPathTextBox.Height;
            int posisionY = ( halfBtnPanelHeight - rootFolderPathTextBoxHeight ) / 2;
            RootFolderPathTextBox.Location = new Point ( PADDING , posisionY );
            
            int folderTabPageHeigth = FolderSearchTabPage.Height;
            int folderTabPageWidth = FolderSearchTabPage.Width;
            int folderDataGridViewPositionY = baseBtnPanelHeight + PADDING;
            FolderDataGridView.Location = new Point ( 0 , folderDataGridViewPositionY );
            FolderDataGridView.Size = new Size ( folderTabPageWidth , folderTabPageHeigth - folderDataGridViewPositionY - PADDING );
        }

        private void InitializeButton ( int halfBtnPanelHeight )
        {
            const int BTN_COUNT = 4;
            const int BTN_WIDTH = 100;
            const int BTN_HEIGHT = 24;

            int btnHeightPosition = halfBtnPanelHeight + ( ( halfBtnPanelHeight - BTN_HEIGHT ) / 2 );
            for ( int count = 0 ; count < BTN_COUNT ; count++ )
            {
                int btnWidthPositionBase = 5;
                int btnWidthPosition = btnWidthPositionBase + ( ( BTN_WIDTH + PADDING ) * count );

                switch ( count )
                {
                    case 0:
                        FolderSearchBtn.Location = new Point ( btnWidthPosition , btnHeightPosition );
                        FolderSearchBtn.Size = new Size ( BTN_WIDTH , BTN_HEIGHT );
                        break;
                    case 1:
                        AllSelectBtn.Location = new Point ( btnWidthPosition , btnHeightPosition );
                        AllSelectBtn.Size = new Size ( BTN_WIDTH , BTN_HEIGHT );
                        break;
                    case 2:
                        AllClearBtn.Location = new Point ( btnWidthPosition , btnHeightPosition );
                        AllClearBtn.Size = new Size ( BTN_WIDTH , BTN_HEIGHT );
                        break;
                    case 3:
                        FileSearchBtn.Location = new Point ( btnWidthPosition , btnHeightPosition );
                        FileSearchBtn.Size = new Size ( BTN_WIDTH , BTN_HEIGHT );
                        break;
                    default:
                        throw new ArgumentOutOfRangeException ();
                }
            }
        }

        private async void button1_Click ( object sender , EventArgs e )
        {
            List<string> files = FileUtil.GetAllFile ( SelectedFolderSetting.Instance.WorkFolderPath ).ToList ();
            List<FileHashInfo> hashes = new List<FileHashInfo> ();

            foreach ( string file in files )
            {
                await using ( FileStream stream = File.OpenRead ( file ) )
                {
                    using ( var sha256 = SHA256.Create () )
                    {
                        byte[] hash = await sha256.ComputeHashAsync ( stream );
                        hashes.Add ( new FileHashInfo ()
                        {
                            FilePath = file ,
                            FileHash = Convert.ToHexString ( hash )
                        } );
                    }
                }
            }

            Dictionary<string , List<FileHashInfo>> temp = hashes
                .GroupBy ( x => x.FileHash )
                .Where ( g => g.Count () > 1 )
                .ToDictionary (
                    g => g.Key ,
                    g => g.ToList ()
                );

            if ( temp.Count > 0 )
            {
                MessageBox.Show ( $"重複ファイルがあります。件数: {temp.Count} 件" );
            }

            MessageBox.Show ( "完了" );
        }

        private async void FolderSearchBtn_Click ( object sender , EventArgs e )
        {
            if ( string.IsNullOrEmpty ( RootFolderPathTextBox.Text ) || !Directory.Exists ( RootFolderPathTextBox.Text ) )
            {
                MessageBox.Show ( "ルートフォルダパスが不正です。" );
                return;
            }

            await Task.Run ( () =>
            {
                IEnumerable<string> folderPathList = DirectoryUtil.GetDirectories ( RootFolderPathTextBox.Text );
                foreach ( string folderPath in folderPathList )
                {
                    _directoryInfoList.Add ( new FileSearch.DirectoryInfo ()
                    {
                        DirectoryPath = folderPath
                    } );
                }

                this.Invoke ( () => FolderDataGridView.DataSource = _directoryInfoList );
            } )
            .ContinueWith ( x =>
            {
                MessageBox.Show ( "完了" );
            } ,
            TaskScheduler.FromCurrentSynchronizationContext () );
        }

        private void AllSelectBtn_Click ( object sender , EventArgs e )
        {
            foreach ( var directoryInfo in _directoryInfoList )
            {
                directoryInfo.isSelected = true;
            }

            FolderDataGridView.Refresh ();
        }

        private void AllClearBtn_Click ( object sender , EventArgs e )
        {
            foreach ( var directoryInfo in _directoryInfoList )
            {
                directoryInfo.isSelected = false;
            }
            FolderDataGridView.Refresh ();
        }

        private async void FileSearchBtn_Click ( object sender , EventArgs e )
        {
            List<string> selectedFolderPaths = _directoryInfoList
                    .Where ( x => x.isSelected )
                    .Select ( x => x.DirectoryPath )
                    .ToList ();

            await Task.Run ( () =>
            {
                try
                {
                    List<FileSearch.FileInfo> fileInfoList = new List<FileSearch.FileInfo> ();
                    foreach ( string folderPath in selectedFolderPaths )
                    {
                        List<string> filePathList = Directory.GetFiles ( folderPath , "*.zip" , SearchOption.AllDirectories ).ToList ();
                        foreach ( string filePath in filePathList )
                        {
                            string fileHash = GetFileHash ( filePath );

                            fileInfoList.Add ( new FileSearch.FileInfo ()
                            {
                                FilePath = filePath ,
                                FileHash = fileHash
                            } );
                        }
                    }

                    fileInfoList = fileInfoList.GroupBy ( x => x.FileHash )
                        .Where ( g => g.Count () > 1 )
                        .SelectMany ( g => g )
                        .ToList ();

                    foreach ( FileSearch.FileInfo fileInfo in fileInfoList )
                    {
                        _fileInfoList.Add ( fileInfo );
                    }

                    this.Invoke ( () => FiledataGridView.DataSource = _fileInfoList );
                }
                catch ( Exception ex )
                {
                    MessageBox.Show ( $"ファイル検索中にエラーが発生しました。\n{ex.Message}" );
                }
            } )
            .ContinueWith ( x =>
            {
                MessageBox.Show ( "完了" );
            } ,
            TaskScheduler.FromCurrentSynchronizationContext () );
        }

        private string GetFileHash ( string filePath )
        {
            try
            {

                using ( FileStream stream = File.OpenRead ( filePath ) )
                {
                    using ( var sha256 = SHA256.Create () )
                    {
                        byte[] hash = sha256.ComputeHash ( stream );
                        return Convert.ToHexString ( hash );
                    }
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show ( $"ファイルハッシュの取得に失敗しました。ファイルパス: {filePath}\n{ex.Message}" );
                return string.Empty;
            }
        }
    }
}
