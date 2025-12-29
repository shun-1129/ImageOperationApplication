using CommonLibrary.Utilities;

namespace ImageResizeApp.Models
{
    public class FileSearch
    {
        public class DirectoryInfo
        {
            private string _directoryPath = string.Empty;
            private string _directoryName = string.Empty;

            public bool isSelected { get; set; } = false;
            public string DirectoryPath
            {
                get => _directoryPath;
                set
                {
                    _directoryPath = value;
                    _directoryName = DirectoryUtil.GetDirectoryName ( _directoryPath );
                }
            }

            public string DirectoryName { get => _directoryName; }
        }

        public class FileInfo
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

            public string FileHash { get => _fileHash; set => _fileHash =  value ; }
        }
    }
}
