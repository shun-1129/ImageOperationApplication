namespace ImageResizeApp.Views
{
    partial class FileSearchView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            TabControl = new TabControl ();
            FolderSearchTabPage = new TabPage ();
            BtnPanel = new Panel ();
            RootFolderPathTextBox = new TextBox ();
            FolderSearchBtn = new Button ();
            AllSelectBtn = new Button ();
            AllClearBtn = new Button ();
            FileSearchBtn = new Button ();
            FolderDataGridView = new DataGridView ();
            FileSearchTabPage = new TabPage ();
            FiledataGridView = new DataGridView ();
            TabControl.SuspendLayout ();
            FolderSearchTabPage.SuspendLayout ();
            BtnPanel.SuspendLayout ();
            ( ( System.ComponentModel.ISupportInitialize ) FolderDataGridView ).BeginInit ();
            FileSearchTabPage.SuspendLayout ();
            ( ( System.ComponentModel.ISupportInitialize ) FiledataGridView ).BeginInit ();
            SuspendLayout ();
            // 
            // TabControl
            // 
            TabControl.Controls.Add ( FolderSearchTabPage );
            TabControl.Controls.Add ( FileSearchTabPage );
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point ( 0 , 0 );
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size ( 1800 , 900 );
            TabControl.TabIndex = 0;
            // 
            // FolderSearchTabPage
            // 
            FolderSearchTabPage.Controls.Add ( BtnPanel );
            FolderSearchTabPage.Controls.Add ( FolderDataGridView );
            FolderSearchTabPage.Location = new Point ( 4 , 24 );
            FolderSearchTabPage.Name = "FolderSearchTabPage";
            FolderSearchTabPage.Padding = new Padding ( 3 );
            FolderSearchTabPage.Size = new Size ( 1792 , 872 );
            FolderSearchTabPage.TabIndex = 0;
            FolderSearchTabPage.Text = "フォルダ検索";
            FolderSearchTabPage.UseVisualStyleBackColor = true;
            // 
            // BtnPanel
            // 
            BtnPanel.Controls.Add ( RootFolderPathTextBox );
            BtnPanel.Controls.Add ( FolderSearchBtn );
            BtnPanel.Controls.Add ( AllSelectBtn );
            BtnPanel.Controls.Add ( AllClearBtn );
            BtnPanel.Controls.Add ( FileSearchBtn );
            BtnPanel.Dock = DockStyle.Top;
            BtnPanel.Location = new Point ( 3 , 3 );
            BtnPanel.Name = "BtnPanel";
            BtnPanel.Size = new Size ( 1786 , 60 );
            BtnPanel.TabIndex = 5;
            // 
            // RootFolderPathTextBox
            // 
            RootFolderPathTextBox.Location = new Point ( 5 , 3 );
            RootFolderPathTextBox.Name = "RootFolderPathTextBox";
            RootFolderPathTextBox.Size = new Size ( 100 , 23 );
            RootFolderPathTextBox.TabIndex = 5;
            // 
            // FolderSearchBtn
            // 
            FolderSearchBtn.Location = new Point ( 5 , 30 );
            FolderSearchBtn.Name = "FolderSearchBtn";
            FolderSearchBtn.Size = new Size ( 76 , 23 );
            FolderSearchBtn.TabIndex = 1;
            FolderSearchBtn.Text = "フォルダ検索";
            FolderSearchBtn.UseVisualStyleBackColor = true;
            FolderSearchBtn.Click +=  FolderSearchBtn_Click ;
            // 
            // AllSelectBtn
            // 
            AllSelectBtn.Location = new Point ( 5 , 30 );
            AllSelectBtn.Name = "AllSelectBtn";
            AllSelectBtn.Size = new Size ( 76 , 23 );
            AllSelectBtn.TabIndex = 2;
            AllSelectBtn.Text = "全選択";
            AllSelectBtn.UseVisualStyleBackColor = true;
            AllSelectBtn.Click +=  AllSelectBtn_Click ;
            // 
            // AllClearBtn
            // 
            AllClearBtn.Location = new Point ( 5 , 30 );
            AllClearBtn.Name = "AllClearBtn";
            AllClearBtn.Size = new Size ( 76 , 23 );
            AllClearBtn.TabIndex = 3;
            AllClearBtn.Text = "全解除";
            AllClearBtn.UseVisualStyleBackColor = true;
            AllClearBtn.Click +=  AllClearBtn_Click ;
            // 
            // FileSearchBtn
            // 
            FileSearchBtn.Location = new Point ( 5 , 30 );
            FileSearchBtn.Name = "FileSearchBtn";
            FileSearchBtn.Size = new Size ( 76 , 23 );
            FileSearchBtn.TabIndex = 4;
            FileSearchBtn.Text = "ファイル検索";
            FileSearchBtn.UseVisualStyleBackColor = true;
            FileSearchBtn.Click +=  FileSearchBtn_Click ;
            // 
            // FolderDataGridView
            // 
            FolderDataGridView.AllowUserToAddRows = false;
            FolderDataGridView.AllowUserToDeleteRows = false;
            FolderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FolderDataGridView.Location = new Point ( 3 , 3 );
            FolderDataGridView.Name = "FolderDataGridView";
            FolderDataGridView.Size = new Size ( 800 , 700 );
            FolderDataGridView.TabIndex = 0;
            // 
            // FileSearchTabPage
            // 
            FileSearchTabPage.Controls.Add ( FiledataGridView );
            FileSearchTabPage.Location = new Point ( 4 , 24 );
            FileSearchTabPage.Name = "FileSearchTabPage";
            FileSearchTabPage.Padding = new Padding ( 3 );
            FileSearchTabPage.Size = new Size ( 1792 , 872 );
            FileSearchTabPage.TabIndex = 1;
            FileSearchTabPage.Text = "ファイル検索";
            FileSearchTabPage.UseVisualStyleBackColor = true;
            // 
            // FiledataGridView
            // 
            FiledataGridView.AllowUserToAddRows = false;
            FiledataGridView.AllowUserToDeleteRows = false;
            FiledataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FiledataGridView.Location = new Point ( 8 , 6 );
            FiledataGridView.Name = "FiledataGridView";
            FiledataGridView.Size = new Size ( 240 , 150 );
            FiledataGridView.TabIndex = 0;
            FiledataGridView.Dock = DockStyle.Fill;
            // 
            // FileSearchView
            // 
            AutoScaleDimensions = new SizeF ( 7F , 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size ( 1800 , 900 );
            Controls.Add ( TabControl );
            Name = "FileSearchView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FileSearch";
            TabControl.ResumeLayout ( false );
            FolderSearchTabPage.ResumeLayout ( false );
            BtnPanel.ResumeLayout ( false );
            BtnPanel.PerformLayout ();
            ( ( System.ComponentModel.ISupportInitialize ) FolderDataGridView ).EndInit ();
            FileSearchTabPage.ResumeLayout ( false );
            ( ( System.ComponentModel.ISupportInitialize ) FiledataGridView ).EndInit ();
            ResumeLayout ( false );
        }

        #endregion

        private TabControl TabControl;
        private TabPage FolderSearchTabPage;
        private TabPage FileSearchTabPage;
        private DataGridView FolderDataGridView;
        private Button FolderSearchBtn;
        private Button AllClearBtn;
        private Button AllSelectBtn;
        private Button FileSearchBtn;
        private Panel BtnPanel;
        private TextBox RootFolderPathTextBox;
        private DataGridView FiledataGridView;
    }
}