using CommonLibrary.Utilities;
using System.Reflection;
using static CommonLibrary.Constants.Constants;
using static ImageSplitApp.Constants.AppConstants;

namespace ImageSplitApp.Forms
{
    public partial class ImageSplitForm : Form
    {
        #region メンバ変数
        private int _splitXInImage;
        private SaveMode _currentSaveMode = SaveMode.Both;
        private string _workFolderPath = string.Empty;
        private List<string> _imageList = new List<string> ();
        private Image? _image;
        private int _currentIndex = 0;
        private bool _isLeftPage = true;
        #endregion

        #region プロパティ
        public int SplitXInImage
        {
            get => _splitXInImage;
            set
            {
                _splitXInImage = value;
                PictureBox.Invalidate ();
            }
        }
        #endregion

        #region コンストラクタ
        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public ImageSplitForm ()
        {
            InitializeComponent ();
        }
        #endregion

        #region メソッド
        #region イベント
        private void ImageSplitForm_Load ( object sender , EventArgs e )
        {
            _workFolderPath = Properties.Settings.Default.WorkFolderPath;

            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            int pictureBoxHeigth = ClientSize.Height - SettingGroupBox.Height - ( 10 * 3 );
            PictureBox.Size = new Size ( ClientSize.Width , pictureBoxHeigth );
            PictureBox.Location = new Point ( 10 , SettingGroupBox.Bottom + 10 );

            // ToDo: 後で消す
            //string imagePath = Path.Combine ( AppContext.BaseDirectory , "TestImage" , "001.jpg" );
            //PictureBox.Image = Image.FromFile ( imagePath );
            PictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            LeftPositionTextBox.Text = ( 0 ).ToString ();

            LeftRadioButton.Location = new Point ( BothRadioBtn.Right + 10 , 22 );
            RightRadioButton.Location = new Point ( LeftRadioButton.Right + 10 , 22 );
            SaveRadioBtnGroupBox.Width = 10 * 4 + BothRadioBtn.Width + LeftRadioButton.Width + RightRadioButton.Width;
            SaveRadioBtnGroupBox.Location = new Point ( LeftPositionGroupBox.Right + 10 , 22 );
            BothRadioBtn.Checked = true;

            PageGroupBox.Location = new Point ( SaveRadioBtnGroupBox.Right + 10 , 22 );
            LeftPageRadioButton.Location = new Point ( 10 , 23 );
            RightPageRadioButton.Location = new Point ( LeftPageRadioButton.Right + 10 , 23 );
            PageGroupBox.Width = 10 * 3 + LeftPageRadioButton.Width + RightPageRadioButton.Width;
            LeftPageRadioButton.Checked = true;

            PreImageBtn.Location = new Point ( PageGroupBox.Right + 50 , 22 );
            NextImageBtn.Location = new Point ( PreImageBtn.Right + 10 , 22 );
            SampleBtn.Location = new Point ( PreImageBtn.Left , PreImageBtn.Bottom + 10 );
            ExecuteBtn.Location = new Point ( SampleBtn.Right + 10 , PreImageBtn.Bottom + 10 );
            ResetBtn.Location = new Point ( ExecuteBtn.Right + 10 , PreImageBtn.Bottom + 10 );
            ReloadBtn.Location = new Point ( ResetBtn.Right + 10 , PreImageBtn.Bottom + 10 );

            ImageWidthLabel.Location = new Point ( SettingGroupBox.Right - 100 , 23 );
            ImageHeightLabel.Location = new Point ( SettingGroupBox.Right - 100 , 60 );

            InitializeImage ();
        }

        private void ImageSplitForm_FormClosed ( object sender , FormClosedEventArgs e )
        {
            Properties.Settings.Default.WorkFolderPath = _workFolderPath;
            Properties.Settings.Default.Save ();
        }

        private void PictureBox_Paint ( object sender , PaintEventArgs e )
        {
            try
            {
                if ( PictureBox.Image == null ) return;

                // 1. 画像が実際に表示されているサイズと位置を計算
                // (Zoomモード時の余白を考慮)
                PropertyInfo? rectangleProperty = typeof ( PictureBox ).GetProperty ( "ImageRectangle" , BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance );

                if ( rectangleProperty is null )
                {
                    return;
                }

                Rectangle displayRect = ( Rectangle ) rectangleProperty.GetValue ( PictureBox )!;

                // 2. 元の画像座標(splitXInImage)を表示上の座標(lineX)に変換
                double ratio = (double)displayRect.Width / PictureBox.Image.Width;
                int lineX = displayRect.X + (int)(SplitXInImage * ratio);

                // 3. グレーアウト用のブラシ（半透明の黒）
                using ( SolidBrush grayBrush = new SolidBrush ( Color.FromArgb ( 150 , 0 , 0 , 0 ) ) )
                {
                    if ( _currentSaveMode == SaveMode.Right ) // 右を保存＝左をグレーアウト
                    {
                        Rectangle leftRect = new Rectangle(displayRect.X, displayRect.Y, lineX - displayRect.X, displayRect.Height);
                        e.Graphics.FillRectangle ( grayBrush , leftRect );
                    }
                    else if ( _currentSaveMode == SaveMode.Left ) // 左を保存＝右をグレーアウト
                    {
                        Rectangle rightRect = new Rectangle(lineX, displayRect.Y, displayRect.Right - lineX, displayRect.Height);
                        e.Graphics.FillRectangle ( grayBrush , rightRect );
                    }
                }

                // 4. 分割線（赤）を描画
                using ( Pen redPen = new Pen ( Color.Red , 2 ) )
                {
                    e.Graphics.DrawLine ( redPen , lineX , displayRect.Y , lineX , displayRect.Bottom );
                }
            }
            catch /* ( Exception ex ) */
            {
            }
        }

        private void LeftPositionTextBox_TextChanged ( object sender , EventArgs e )
        {
            if ( !int.TryParse ( LeftPositionTextBox.Text , out int tempSplitXInImage ) )
            {
                return;
            }

            LeftPositionTextBox.Text = tempSplitXInImage.ToString ();
            SplitXInImage = tempSplitXInImage;
        }

        private void BothRadioBtn_CheckedChanged ( object sender , EventArgs e )
        {
            if ( BothRadioBtn.Checked )
            {
                _currentSaveMode = SaveMode.Both;
            }
            PictureBox.Invalidate ();
        }

        private void LeftRadioButton_CheckedChanged ( object sender , EventArgs e )
        {
            if ( LeftRadioButton.Checked )
            {
                _currentSaveMode = SaveMode.Left;
            }
            PictureBox.Invalidate ();
        }

        private void RightRadioButton_CheckedChanged ( object sender , EventArgs e )
        {
            if ( RightRadioButton.Checked )
            {
                _currentSaveMode = SaveMode.Right;
            }
            PictureBox.Invalidate ();
        }

        private void LeftPageRadioButton_CheckedChanged ( object sender , EventArgs e )
        {
            if ( LeftPageRadioButton.Checked )
            {
                _isLeftPage = true;
            }
        }

        private void RightPageRadioButton_CheckedChanged ( object sender , EventArgs e )
        {
            if ( RightPageRadioButton.Checked )
            {
                _isLeftPage = false;
            }
        }

        private void WorkFolderSettingToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            SelectWorkFolder ();
        }

        private void WorkFolderSelectToolStripMenuItem_Click ( object sender , EventArgs e )
        {
            SelectWorkFolder ();
        }

        private void NextImageBtn_Click ( object sender , EventArgs e )
        {
            if ( _currentIndex > _imageList.Count )
            {
                return;
            }

            _currentIndex++;
            ChangePictureBox ( _currentIndex );
        }

        private void PreImageBtn_Click ( object sender , EventArgs e )
        {
            if ( 0 == _currentIndex )
            {
                return;
            }

            _currentIndex--;
            ChangePictureBox ( _currentIndex );
        }

        private void ExecuteBtn_Click ( object sender , EventArgs e )
        {
            if ( 0 == SplitXInImage )
            {
                // ToDo: 
                return;
            }

            string rootPath = DirectoryUtil.GetParentDirectory ( _workFolderPath );
            string directoryName = DirectoryUtil.GetDirectoryName ( _workFolderPath );
            string outputDirectoryPath = Path.Combine ( rootPath , $"{directoryName}_Split" );
            if ( Directory.Exists ( outputDirectoryPath ) )
            {
                DialogResult dialogResult = MessageBox.Show ( this , "既にフォルダが存在します。\n削除しますか？" , "Warn" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning );
                if ( DialogResult.Yes == dialogResult )
                {
                    Directory.Delete ( outputDirectoryPath , true );
                }
                else
                {
                    return;
                }
            }

            Directory.CreateDirectory ( outputDirectoryPath );
            Directory.CreateDirectory ( Path.Combine ( outputDirectoryPath , "L" ) );
            Directory.CreateDirectory ( Path.Combine ( outputDirectoryPath , "R" ) );
            int fileCount = 1;
            foreach ( string imagePath in _imageList )
            {
                string leftOutputPath = string.Empty;
                string rightOutputPath = string.Empty;

                // ToDo: ここでも保存するか見るべき
                if ( _isLeftPage )
                {
                    leftOutputPath = Path.Combine ( outputDirectoryPath , "L" , $"{fileCount.ToString ( "D4" )}{FileExtension.JPEG}" );
                    fileCount++;
                    rightOutputPath = Path.Combine ( outputDirectoryPath , "R" , $"{fileCount.ToString ( "D4" )}{FileExtension.JPEG}" );
                    fileCount++;
                }
                else
                {
                    rightOutputPath = Path.Combine ( outputDirectoryPath , "L" , $"{fileCount.ToString ( "D4" )}{FileExtension.JPEG}" );
                    fileCount++;
                    leftOutputPath = Path.Combine ( outputDirectoryPath , "R" , $"{fileCount.ToString ( "D4" )}{FileExtension.JPEG}" );
                    fileCount++;
                }

                SpritImage ( imagePath , leftOutputPath , rightOutputPath );
            }

            MessageBox.Show ( this , "分割が完了しました。" , "Info" , MessageBoxButtons.OK , MessageBoxIcon.Information );
        }

        private void ResetBtn_Click ( object sender , EventArgs e )
        {
            try
            {
                _imageList.Clear ();
                if ( _image is not null )
                {
                    _image.Dispose ();
                    _image = null;
                }
                PictureBox.Image = null;
                PictureBox.Invalidate ();
            }
            catch
            {

            }
        }

        private void ReloadBtn_Click ( object sender , EventArgs e )
        {
            InitializeImage ();
        }
        #endregion

        private void InitializeImage ()
        {
            if ( !Directory.Exists ( _workFolderPath ) )
            {
                return;
            }

            IEnumerable<string> filePathList = FileUtil.GetAllFile ( _workFolderPath , searchOption: SearchOption.AllDirectories )
                .Where ( x => FileUtil.CheckExtension ( x , FileExtension.JPG )
                           || FileUtil.CheckExtension ( x , FileExtension.JPEG )
                           || FileUtil.CheckExtension ( x , FileExtension.PNG ) );

            _imageList = filePathList.ToList ();
            if ( _imageList.Count == 0 )
            {
                return;
            }

            int count = 0;
            int preWidth = 0;
            int preHeight = 0;
            foreach ( string filePath in filePathList )
            {
                using ( Image image = Image.FromFile ( filePath ) )
                {
                    if ( 0 == count )
                    {
                        preWidth = image.Width;
                        preHeight = image.Height;
                        count++;
                        continue;
                    }

                    if ( preWidth != image.Width || preHeight != image.Height )
                    {
                        MessageBox.Show ( this , "イメージのサイズが違います。\nサイズを合わせてください。" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                        return;
                    }

                    preWidth = image.Width;
                    preHeight = image.Height;
                    count++;
                }
            }

            ChangePictureBox ( _currentIndex );
        }

        private void SelectWorkFolder ()
        {
            using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog ()
            {
                Description = "フォルダを選択してください",
                ShowNewFolderButton = false ,
                SelectedPath = @"C:\Resize\work\"
            };

            if ( !DialogResult.OK.Equals ( folderBrowserDialog.ShowDialog () ) )
            {
                return;
            }

            _workFolderPath = folderBrowserDialog.SelectedPath;
            MessageBox.Show ( this , $"{_workFolderPath} を選択しました" , "Info" , MessageBoxButtons.OK , MessageBoxIcon.Information );

            _currentIndex = 0;

            InitializeImage ();
        }

        private void ChangePictureBox ( int index )
        {
            _image = Image.FromFile ( _imageList[index] );

            int width = _image.Width;
            int height = _image.Height;

            ImageWidthLabel.Text = $"Width : {width}";
            ImageHeightLabel.Text = $"Heigth : {height}";

            PictureBox.Image = _image;
            PictureBox.Invalidate ();
        }

        private void SpritImage ( string imagePath , string leftPath , string rigthPath )
        {
            using Bitmap image = new Bitmap ( imagePath );

            if ( SaveMode.Both == _currentSaveMode || SaveMode.Left == _currentSaveMode )
            {
                Rectangle rect = new Rectangle ( 0 , 0 , SplitXInImage , image.Height );
                using Bitmap destImage = image.Clone ( rect , image.PixelFormat );
                destImage.Save ( leftPath );
                destImage.Dispose ();
            }


            if ( SaveMode.Both == _currentSaveMode || SaveMode.Right == _currentSaveMode )
            {
                Rectangle rect = new Rectangle ( SplitXInImage , 0 , image.Width - SplitXInImage , image.Height );
                using Bitmap destImage = image.Clone ( rect , image.PixelFormat );
                destImage.Save ( rigthPath );
                destImage.Dispose ();
            }
        }
        #endregion
    }
}
