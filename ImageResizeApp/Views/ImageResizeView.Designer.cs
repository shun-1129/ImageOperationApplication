namespace ImageResizeApp.Views
{
    partial class ImageResizeView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ();
            }
            base.Dispose ( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            QualityGroupBox = new GroupBox ();
            QualityComboBox = new ComboBox ();
            PixelMinimumGroupBox = new GroupBox ();
            PixelMinimumComboBox = new ComboBox ();
            ApplicationSettingReload_ToolStripMenuItem = new ToolStripMenuItem ();
            MenuStrip = new MenuStrip ();
            Setting_ToolStripMenuItem = new ToolStripMenuItem ();
            SettingReload_ToolStripMenuItem = new ToolStripMenuItem ();
            AllReload_ToolStripMenuItem = new ToolStripMenuItem ();
            DeleteTargetName_ToolStripMenuItem = new ToolStripMenuItem ();
            DeleteTargetFileCToolStripMenuItem = new ToolStripMenuItem ();
            Swap_ToolStripMenuItem = new ToolStripMenuItem ();
            WorkFolderSettinf_ToolStripMenuItem = new ToolStripMenuItem ();
            Option_ToolStripMenuItem = new ToolStripMenuItem ();
            Log_ToolStripMenuItem = new ToolStripMenuItem ();
            LogDisplay_ToolStripMenuItem = new ToolStripMenuItem ();
            SpecialToolStripMenuItem = new ToolStripMenuItem ();
            TimeStampChangeToolStripMenuItem = new ToolStripMenuItem ();
            FileSearchToolStripMenuItem = new ToolStripMenuItem ();
            UnzipBtn = new Button ();
            CompressionBtn = new Button ();
            ResizeStartBtn = new Button ();
            RenameBtn = new Button ();
            FolderDecompositionBtn = new Button ();
            FolderAllocationBtn = new Button ();
            MainProgressBar = new ProgressBar ();
            QualityGroupBox.SuspendLayout ();
            PixelMinimumGroupBox.SuspendLayout ();
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
            QualityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            QualityComboBox.FormattingEnabled = true;
            QualityComboBox.Location = new Point ( 12 , 22 );
            QualityComboBox.Name = "QualityComboBox";
            QualityComboBox.Size = new Size ( 121 , 23 );
            QualityComboBox.TabIndex = 0;
            QualityComboBox.SelectedIndexChanged +=  QualityComboBox_SelectedIndexChanged ;
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
            PixelMinimumComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PixelMinimumComboBox.FormattingEnabled = true;
            PixelMinimumComboBox.Location = new Point ( 12 , 22 );
            PixelMinimumComboBox.Name = "PixelMinimumComboBox";
            PixelMinimumComboBox.Size = new Size ( 121 , 23 );
            PixelMinimumComboBox.TabIndex = 0;
            PixelMinimumComboBox.SelectedIndexChanged +=  PixelMinimumComboBox_SelectedIndexChanged ;
            // 
            // ApplicationSettingReload_ToolStripMenuItem
            // 
            ApplicationSettingReload_ToolStripMenuItem.Name = "ApplicationSettingReload_ToolStripMenuItem";
            ApplicationSettingReload_ToolStripMenuItem.Size = new Size ( 213 , 22 );
            ApplicationSettingReload_ToolStripMenuItem.Text = "アプリケーション設定読み込み";
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange ( new ToolStripItem[] { Setting_ToolStripMenuItem , Log_ToolStripMenuItem , SpecialToolStripMenuItem } );
            MenuStrip.Location = new Point ( 0 , 0 );
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size ( 521 , 24 );
            MenuStrip.TabIndex = 2;
            MenuStrip.Text = "menuStrip1";
            // 
            // Setting_ToolStripMenuItem
            // 
            Setting_ToolStripMenuItem.DropDownItems.AddRange ( new ToolStripItem[] { SettingReload_ToolStripMenuItem , WorkFolderSettinf_ToolStripMenuItem , Option_ToolStripMenuItem } );
            Setting_ToolStripMenuItem.Name = "Setting_ToolStripMenuItem";
            Setting_ToolStripMenuItem.Size = new Size ( 57 , 20 );
            Setting_ToolStripMenuItem.Text = "設定(&S)";
            // 
            // SettingReload_ToolStripMenuItem
            // 
            SettingReload_ToolStripMenuItem.DropDownItems.AddRange ( new ToolStripItem[] { AllReload_ToolStripMenuItem , DeleteTargetName_ToolStripMenuItem , DeleteTargetFileCToolStripMenuItem , Swap_ToolStripMenuItem } );
            SettingReload_ToolStripMenuItem.Name = "SettingReload_ToolStripMenuItem";
            SettingReload_ToolStripMenuItem.Size = new Size ( 180 , 22 );
            SettingReload_ToolStripMenuItem.Text = "設定再読み込み(&R)";
            // 
            // AllReload_ToolStripMenuItem
            // 
            AllReload_ToolStripMenuItem.Name = "AllReload_ToolStripMenuItem";
            AllReload_ToolStripMenuItem.Size = new Size ( 173 , 22 );
            AllReload_ToolStripMenuItem.Text = "全て(&A)";
            AllReload_ToolStripMenuItem.Click +=  AllReload_ToolStripMenuItem_Click ;
            // 
            // DeleteTargetName_ToolStripMenuItem
            // 
            DeleteTargetName_ToolStripMenuItem.Name = "DeleteTargetName_ToolStripMenuItem";
            DeleteTargetName_ToolStripMenuItem.Size = new Size ( 173 , 22 );
            DeleteTargetName_ToolStripMenuItem.Text = "削除文字列対象(&B)";
            DeleteTargetName_ToolStripMenuItem.Click +=  DeleteTargetName_ToolStripMenuItem_Click ;
            // 
            // DeleteTargetFileCToolStripMenuItem
            // 
            DeleteTargetFileCToolStripMenuItem.Name = "DeleteTargetFileCToolStripMenuItem";
            DeleteTargetFileCToolStripMenuItem.Size = new Size ( 173 , 22 );
            DeleteTargetFileCToolStripMenuItem.Text = "削除ファイル対象(&C)";
            DeleteTargetFileCToolStripMenuItem.Click +=  DeleteTargetFileCToolStripMenuItem_Click ;
            // 
            // Swap_ToolStripMenuItem
            // 
            Swap_ToolStripMenuItem.Name = "Swap_ToolStripMenuItem";
            Swap_ToolStripMenuItem.Size = new Size ( 173 , 22 );
            Swap_ToolStripMenuItem.Text = "入替対象(&D)";
            Swap_ToolStripMenuItem.Click +=  Swap_ToolStripMenuItem_Click ;
            // 
            // WorkFolderSettinf_ToolStripMenuItem
            // 
            WorkFolderSettinf_ToolStripMenuItem.Name = "WorkFolderSettinf_ToolStripMenuItem";
            WorkFolderSettinf_ToolStripMenuItem.Size = new Size ( 180 , 22 );
            WorkFolderSettinf_ToolStripMenuItem.Text = "作業フォルダ設定(&S)...";
            WorkFolderSettinf_ToolStripMenuItem.Click +=  WorkFolderSettinf_ToolStripMenuItem_Click ;
            // 
            // Option_ToolStripMenuItem
            // 
            Option_ToolStripMenuItem.Name = "Option_ToolStripMenuItem";
            Option_ToolStripMenuItem.Size = new Size ( 180 , 22 );
            Option_ToolStripMenuItem.Text = "オプション(&O)...";
            Option_ToolStripMenuItem.Click +=  Option_ToolStripMenuItem_Click ;
            // 
            // Log_ToolStripMenuItem
            // 
            Log_ToolStripMenuItem.DropDownItems.AddRange ( new ToolStripItem[] { LogDisplay_ToolStripMenuItem } );
            Log_ToolStripMenuItem.Name = "Log_ToolStripMenuItem";
            Log_ToolStripMenuItem.Size = new Size ( 51 , 20 );
            Log_ToolStripMenuItem.Text = "ログ(&L)";
            // 
            // LogDisplay_ToolStripMenuItem
            // 
            LogDisplay_ToolStripMenuItem.Name = "LogDisplay_ToolStripMenuItem";
            LogDisplay_ToolStripMenuItem.Size = new Size ( 141 , 22 );
            LogDisplay_ToolStripMenuItem.Text = "ログ表示(&D)...";
            LogDisplay_ToolStripMenuItem.Click +=  LogDisplay_ToolStripMenuItem_Click ;
            // 
            // SpecialToolStripMenuItem
            // 
            SpecialToolStripMenuItem.DropDownItems.AddRange ( new ToolStripItem[] { TimeStampChangeToolStripMenuItem , FileSearchToolStripMenuItem } );
            SpecialToolStripMenuItem.Name = "SpecialToolStripMenuItem";
            SpecialToolStripMenuItem.Size = new Size ( 57 , 20 );
            SpecialToolStripMenuItem.Text = "特殊(&T)";
            // 
            // TimeStampChangeToolStripMenuItem
            // 
            TimeStampChangeToolStripMenuItem.Name = "TimeStampChangeToolStripMenuItem";
            TimeStampChangeToolStripMenuItem.Size = new Size ( 184 , 22 );
            TimeStampChangeToolStripMenuItem.Text = "タイムスタンプ変更(&T)...";
            TimeStampChangeToolStripMenuItem.Click +=  TimeStampChangeToolStripMenuItem_Click ;
            // 
            // FileSearchToolStripMenuItem
            // 
            FileSearchToolStripMenuItem.Name = "FileSearchToolStripMenuItem";
            FileSearchToolStripMenuItem.Size = new Size ( 184 , 22 );
            FileSearchToolStripMenuItem.Text = "同一ファイル検索(&S)...";
            FileSearchToolStripMenuItem.Click +=  FileSearchToolStripMenuItem_Click ;
            // 
            // UnzipBtn
            // 
            UnzipBtn.Location = new Point ( 182 , 44 );
            UnzipBtn.Name = "UnzipBtn";
            UnzipBtn.Size = new Size ( 100 , 30 );
            UnzipBtn.TabIndex = 3;
            UnzipBtn.Text = "ZIP解凍";
            UnzipBtn.UseVisualStyleBackColor = true;
            UnzipBtn.Click +=  UnzipBtn_Click ;
            // 
            // CompressionBtn
            // 
            CompressionBtn.Location = new Point ( 182 , 80 );
            CompressionBtn.Name = "CompressionBtn";
            CompressionBtn.Size = new Size ( 100 , 30 );
            CompressionBtn.TabIndex = 4;
            CompressionBtn.Text = "ZIP圧縮";
            CompressionBtn.UseVisualStyleBackColor = true;
            CompressionBtn.Click +=  CompressionBtn_Click ;
            // 
            // ResizeStartBtn
            // 
            ResizeStartBtn.Location = new Point ( 288 , 80 );
            ResizeStartBtn.Name = "ResizeStartBtn";
            ResizeStartBtn.Size = new Size ( 100 , 30 );
            ResizeStartBtn.TabIndex = 6;
            ResizeStartBtn.Text = "リサイズ開始";
            ResizeStartBtn.UseVisualStyleBackColor = true;
            ResizeStartBtn.Click +=  ResizeStartBtn_Click ;
            // 
            // RenameBtn
            // 
            RenameBtn.Location = new Point ( 288 , 44 );
            RenameBtn.Name = "RenameBtn";
            RenameBtn.Size = new Size ( 100 , 30 );
            RenameBtn.TabIndex = 5;
            RenameBtn.Text = "名称変更";
            RenameBtn.UseVisualStyleBackColor = true;
            RenameBtn.Click +=  RenameBtn_Click ;
            // 
            // FolderDecompositionBtn
            // 
            FolderDecompositionBtn.Location = new Point ( 394 , 80 );
            FolderDecompositionBtn.Name = "FolderDecompositionBtn";
            FolderDecompositionBtn.Size = new Size ( 100 , 30 );
            FolderDecompositionBtn.TabIndex = 8;
            FolderDecompositionBtn.Text = "フォルダ分解";
            FolderDecompositionBtn.UseVisualStyleBackColor = true;
            FolderDecompositionBtn.Click +=  FolderDecompositionBtn_Click ;
            // 
            // FolderAllocationBtn
            // 
            FolderAllocationBtn.Location = new Point ( 394 , 44 );
            FolderAllocationBtn.Name = "FolderAllocationBtn";
            FolderAllocationBtn.Size = new Size ( 100 , 30 );
            FolderAllocationBtn.TabIndex = 7;
            FolderAllocationBtn.Text = "フォルダ振り分け";
            FolderAllocationBtn.UseVisualStyleBackColor = true;
            FolderAllocationBtn.Click +=  FolderAllocationBtn_Click ;
            // 
            // MainProgressBar
            // 
            MainProgressBar.Location = new Point ( 12 , 169 );
            MainProgressBar.Name = "MainProgressBar";
            MainProgressBar.Size = new Size ( 497 , 23 );
            MainProgressBar.TabIndex = 10;
            // 
            // ImageResizeView
            // 
            AutoScaleDimensions = new SizeF ( 7F , 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size ( 521 , 205 );
            Controls.Add ( MainProgressBar );
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
            Name = "ImageResizeView";
            Text = "ImageResizeApp";
            QualityGroupBox.ResumeLayout ( false );
            PixelMinimumGroupBox.ResumeLayout ( false );
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
        private MenuStrip MenuStrip;
        private ToolStripMenuItem ApplicationSettingReload_ToolStripMenuItem;
        private ToolStripMenuItem Log_ToolStripMenuItem;
        private ToolStripMenuItem LogDisplay_ToolStripMenuItem;
        private ToolStripMenuItem Setting_ToolStripMenuItem;
        private ToolStripMenuItem SettingReload_ToolStripMenuItem;
        private ToolStripMenuItem AllReload_ToolStripMenuItem;
        private ToolStripMenuItem DeleteTargetName_ToolStripMenuItem;
        private ToolStripMenuItem Swap_ToolStripMenuItem;
        private ToolStripMenuItem WorkFolderSettinf_ToolStripMenuItem;
        private ToolStripMenuItem Option_ToolStripMenuItem;
        private Button UnzipBtn;
        private Button CompressionBtn;
        private Button ResizeStartBtn;
        private Button RenameBtn;
        private Button FolderDecompositionBtn;
        private Button FolderAllocationBtn;
        private ProgressBar MainProgressBar;
        private ToolStripMenuItem DeleteTargetFileCToolStripMenuItem;
        private ToolStripMenuItem SpecialToolStripMenuItem;
        private ToolStripMenuItem TimeStampChangeToolStripMenuItem;
        private ToolStripMenuItem FileSearchToolStripMenuItem;
    }
}
