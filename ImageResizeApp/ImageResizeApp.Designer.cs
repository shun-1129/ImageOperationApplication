namespace ImageResizeApp
{
    partial class ImageResizeApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            components = new System.ComponentModel.Container ();
            QualityGroupBox = new GroupBox ();
            QualityComboBox = new ComboBox ();
            PixelMinimumGroupBox = new GroupBox ();
            PixelMinimumComboBox = new ComboBox ();
            contextMenuStrip1 = new ContextMenuStrip ( components );
            アプリケーション設定読み込みToolStripMenuItem = new ToolStripMenuItem ();
            MenuStrip = new MenuStrip ();
            設定SToolStripMenuItem = new ToolStripMenuItem ();
            設定再読み込みToolStripMenuItem = new ToolStripMenuItem ();
            全てAToolStripMenuItem = new ToolStripMenuItem ();
            削除対象BToolStripMenuItem = new ToolStripMenuItem ();
            入れ替ToolStripMenuItem = new ToolStripMenuItem ();
            作業フォルダ設定SToolStripMenuItem = new ToolStripMenuItem ();
            オプションOToolStripMenuItem = new ToolStripMenuItem ();
            ログLToolStripMenuItem = new ToolStripMenuItem ();
            ログ表示DToolStripMenuItem = new ToolStripMenuItem ();
            UnzipBtn = new Button ();
            CompressionBtn = new Button ();
            ResizeStartBtn = new Button ();
            RenameBtn = new Button ();
            FolderDecompositionBtn = new Button ();
            FolderAllocationBtn = new Button ();
            SubProgressBar = new ProgressBar ();
            MainProgressBar = new ProgressBar ();
            削除ファイル対象CToolStripMenuItem = new ToolStripMenuItem ();
            QualityGroupBox.SuspendLayout ();
            PixelMinimumGroupBox.SuspendLayout ();
            contextMenuStrip1.SuspendLayout ();
            MenuStrip.SuspendLayout ();
            SuspendLayout ();
            // 
            // QualityGroupBox
            // 
            QualityGroupBox.Controls.Add ( QualityComboBox );
            QualityGroupBox.Location = new Point ( 12 , 27 );
            QualityGroupBox.Name = "QualityGroupBox";
            QualityGroupBox.Size = new Size ( 144 , 61 );
            QualityGroupBox.TabIndex = 0;
            QualityGroupBox.TabStop = false;
            QualityGroupBox.Text = "品質";
            // 
            // QualityComboBox
            // 
            QualityComboBox.FormattingEnabled = true;
            QualityComboBox.Location = new Point ( 12 , 22 );
            QualityComboBox.Name = "QualityComboBox";
            QualityComboBox.Size = new Size ( 121 , 23 );
            QualityComboBox.TabIndex = 0;
            // 
            // PixelMinimumGroupBox
            // 
            PixelMinimumGroupBox.Controls.Add ( PixelMinimumComboBox );
            PixelMinimumGroupBox.Location = new Point ( 12 , 94 );
            PixelMinimumGroupBox.Name = "PixelMinimumGroupBox";
            PixelMinimumGroupBox.Size = new Size ( 144 , 61 );
            PixelMinimumGroupBox.TabIndex = 1;
            PixelMinimumGroupBox.TabStop = false;
            PixelMinimumGroupBox.Text = "ピクセル下限値";
            // 
            // PixelMinimumComboBox
            // 
            PixelMinimumComboBox.FormattingEnabled = true;
            PixelMinimumComboBox.Location = new Point ( 12 , 22 );
            PixelMinimumComboBox.Name = "PixelMinimumComboBox";
            PixelMinimumComboBox.Size = new Size ( 121 , 23 );
            PixelMinimumComboBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange ( new ToolStripItem[] { アプリケーション設定読み込みToolStripMenuItem } );
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size ( 214 , 26 );
            // 
            // アプリケーション設定読み込みToolStripMenuItem
            // 
            アプリケーション設定読み込みToolStripMenuItem.Name = "アプリケーション設定読み込みToolStripMenuItem";
            アプリケーション設定読み込みToolStripMenuItem.Size = new Size ( 213 , 22 );
            アプリケーション設定読み込みToolStripMenuItem.Text = "アプリケーション設定読み込み";
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange ( new ToolStripItem[] { 設定SToolStripMenuItem , ログLToolStripMenuItem } );
            MenuStrip.Location = new Point ( 0 , 0 );
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size ( 521 , 24 );
            MenuStrip.TabIndex = 2;
            MenuStrip.Text = "menuStrip1";
            // 
            // 設定SToolStripMenuItem
            // 
            設定SToolStripMenuItem.DropDownItems.AddRange ( new ToolStripItem[] { 設定再読み込みToolStripMenuItem , 作業フォルダ設定SToolStripMenuItem , オプションOToolStripMenuItem } );
            設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
            設定SToolStripMenuItem.Size = new Size ( 57 , 20 );
            設定SToolStripMenuItem.Text = "設定(&S)";
            // 
            // 設定再読み込みToolStripMenuItem
            // 
            設定再読み込みToolStripMenuItem.DropDownItems.AddRange ( new ToolStripItem[] { 全てAToolStripMenuItem , 削除対象BToolStripMenuItem , 削除ファイル対象CToolStripMenuItem , 入れ替ToolStripMenuItem } );
            設定再読み込みToolStripMenuItem.Name = "設定再読み込みToolStripMenuItem";
            設定再読み込みToolStripMenuItem.Size = new Size ( 180 , 22 );
            設定再読み込みToolStripMenuItem.Text = "設定再読み込み(&R)";
            // 
            // 全てAToolStripMenuItem
            // 
            全てAToolStripMenuItem.Name = "全てAToolStripMenuItem";
            全てAToolStripMenuItem.Size = new Size ( 180 , 22 );
            全てAToolStripMenuItem.Text = "全て(&A)";
            全てAToolStripMenuItem.Click +=  AllAToolStripMenuItem_Click ;
            // 
            // 削除対象BToolStripMenuItem
            // 
            削除対象BToolStripMenuItem.Name = "削除対象BToolStripMenuItem";
            削除対象BToolStripMenuItem.Size = new Size ( 180 , 22 );
            削除対象BToolStripMenuItem.Text = "削除文字対象(&B)";
            削除対象BToolStripMenuItem.Click +=  DeleteTargetBToolStripMenuItem_Click ;
            // 
            // 入れ替ToolStripMenuItem
            // 
            入れ替ToolStripMenuItem.Name = "入れ替ToolStripMenuItem";
            入れ替ToolStripMenuItem.Size = new Size ( 180 , 22 );
            入れ替ToolStripMenuItem.Text = "入替対象(&D)";
            入れ替ToolStripMenuItem.Click +=  SwapTargetCToolStripMenuItem_Click ;
            // 
            // 作業フォルダ設定SToolStripMenuItem
            // 
            作業フォルダ設定SToolStripMenuItem.Name = "作業フォルダ設定SToolStripMenuItem";
            作業フォルダ設定SToolStripMenuItem.Size = new Size ( 180 , 22 );
            作業フォルダ設定SToolStripMenuItem.Text = "作業フォルダ設定(&S)...";
            // 
            // オプションOToolStripMenuItem
            // 
            オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem";
            オプションOToolStripMenuItem.Size = new Size ( 180 , 22 );
            オプションOToolStripMenuItem.Text = "オプション(&O)...";
            // 
            // ログLToolStripMenuItem
            // 
            ログLToolStripMenuItem.DropDownItems.AddRange ( new ToolStripItem[] { ログ表示DToolStripMenuItem } );
            ログLToolStripMenuItem.Name = "ログLToolStripMenuItem";
            ログLToolStripMenuItem.Size = new Size ( 51 , 20 );
            ログLToolStripMenuItem.Text = "ログ(&L)";
            // 
            // ログ表示DToolStripMenuItem
            // 
            ログ表示DToolStripMenuItem.Name = "ログ表示DToolStripMenuItem";
            ログ表示DToolStripMenuItem.Size = new Size ( 141 , 22 );
            ログ表示DToolStripMenuItem.Text = "ログ表示(&D)...";
            // 
            // UnzipBtn
            // 
            UnzipBtn.Location = new Point ( 182 , 44 );
            UnzipBtn.Name = "UnzipBtn";
            UnzipBtn.Size = new Size ( 100 , 30 );
            UnzipBtn.TabIndex = 3;
            UnzipBtn.Text = "ZIP解凍";
            UnzipBtn.UseVisualStyleBackColor = true;
            // 
            // CompressionBtn
            // 
            CompressionBtn.Location = new Point ( 182 , 80 );
            CompressionBtn.Name = "CompressionBtn";
            CompressionBtn.Size = new Size ( 100 , 30 );
            CompressionBtn.TabIndex = 4;
            CompressionBtn.Text = "ZIP圧縮";
            CompressionBtn.UseVisualStyleBackColor = true;
            // 
            // ResizeStartBtn
            // 
            ResizeStartBtn.Location = new Point ( 288 , 80 );
            ResizeStartBtn.Name = "ResizeStartBtn";
            ResizeStartBtn.Size = new Size ( 100 , 30 );
            ResizeStartBtn.TabIndex = 6;
            ResizeStartBtn.Text = "リサイズ開始";
            ResizeStartBtn.UseVisualStyleBackColor = true;
            // 
            // RenameBtn
            // 
            RenameBtn.Location = new Point ( 288 , 44 );
            RenameBtn.Name = "RenameBtn";
            RenameBtn.Size = new Size ( 100 , 30 );
            RenameBtn.TabIndex = 5;
            RenameBtn.Text = "名称変更";
            RenameBtn.UseVisualStyleBackColor = true;
            // 
            // FolderDecompositionBtn
            // 
            FolderDecompositionBtn.Location = new Point ( 394 , 80 );
            FolderDecompositionBtn.Name = "FolderDecompositionBtn";
            FolderDecompositionBtn.Size = new Size ( 100 , 30 );
            FolderDecompositionBtn.TabIndex = 8;
            FolderDecompositionBtn.Text = "フォルダ分解";
            FolderDecompositionBtn.UseVisualStyleBackColor = true;
            // 
            // FolderAllocationBtn
            // 
            FolderAllocationBtn.Location = new Point ( 394 , 44 );
            FolderAllocationBtn.Name = "FolderAllocationBtn";
            FolderAllocationBtn.Size = new Size ( 100 , 30 );
            FolderAllocationBtn.TabIndex = 7;
            FolderAllocationBtn.Text = "フォルダ振り分け";
            FolderAllocationBtn.UseVisualStyleBackColor = true;
            // 
            // SubProgressBar
            // 
            SubProgressBar.Location = new Point ( 12 , 207 );
            SubProgressBar.Name = "SubProgressBar";
            SubProgressBar.Size = new Size ( 497 , 23 );
            SubProgressBar.TabIndex = 9;
            // 
            // MainProgressBar
            // 
            MainProgressBar.Location = new Point ( 12 , 178 );
            MainProgressBar.Name = "MainProgressBar";
            MainProgressBar.Size = new Size ( 497 , 23 );
            MainProgressBar.TabIndex = 10;
            // 
            // 削除ファイル対象CToolStripMenuItem
            // 
            削除ファイル対象CToolStripMenuItem.Name = "削除ファイル対象CToolStripMenuItem";
            削除ファイル対象CToolStripMenuItem.Size = new Size ( 180 , 22 );
            削除ファイル対象CToolStripMenuItem.Text = "削除ファイル対象(&C)";
            削除ファイル対象CToolStripMenuItem.Click +=  DeleteTargetFileCToolStripMenuItem_Click ;
            // 
            // ImageResizeApp
            // 
            AutoScaleDimensions = new SizeF ( 7F , 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size ( 521 , 242 );
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add ( MainProgressBar );
            Controls.Add ( SubProgressBar );
            Controls.Add ( FolderDecompositionBtn );
            Controls.Add ( FolderAllocationBtn );
            Controls.Add ( ResizeStartBtn );
            Controls.Add ( RenameBtn );
            Controls.Add ( CompressionBtn );
            Controls.Add ( UnzipBtn );
            Controls.Add ( MenuStrip );
            Controls.Add ( PixelMinimumGroupBox );
            Controls.Add ( QualityGroupBox );
            MainMenuStrip = MenuStrip;
            Name = "ImageResizeApp";
            Text = "ImageResizeApp";
            QualityGroupBox.ResumeLayout ( false );
            PixelMinimumGroupBox.ResumeLayout ( false );
            contextMenuStrip1.ResumeLayout ( false );
            MenuStrip.ResumeLayout ( false );
            MenuStrip.PerformLayout ();
            ResumeLayout ( false );
            PerformLayout ();
        }

        #endregion

        private GroupBox QualityGroupBox;
        private ComboBox QualityComboBox;
        private GroupBox PixelMinimumGroupBox;
        private ComboBox PixelMinimumComboBox;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem アプリケーション設定読み込みToolStripMenuItem;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem ログLToolStripMenuItem;
        private ToolStripMenuItem ログ表示DToolStripMenuItem;
        private ToolStripMenuItem 設定SToolStripMenuItem;
        private ToolStripMenuItem 設定再読み込みToolStripMenuItem;
        private ToolStripMenuItem 全てAToolStripMenuItem;
        private ToolStripMenuItem 削除対象BToolStripMenuItem;
        private ToolStripMenuItem 入れ替ToolStripMenuItem;
        private ToolStripMenuItem 作業フォルダ設定SToolStripMenuItem;
        private ToolStripMenuItem オプションOToolStripMenuItem;
        private Button UnzipBtn;
        private Button CompressionBtn;
        private Button ResizeStartBtn;
        private Button RenameBtn;
        private Button FolderDecompositionBtn;
        private Button FolderAllocationBtn;
        private ProgressBar SubProgressBar;
        private ProgressBar MainProgressBar;
        private ToolStripMenuItem 削除ファイル対象CToolStripMenuItem;
    }
}
