namespace ImageResizeApp.Views
{
    partial class WorkFolderView
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
            WrokFolderGroupBox = new GroupBox ();
            WorkFolderSelectBtn = new Button ();
            WorkFolderTextBox = new TextBox ();
            TempFolderGroupBox = new GroupBox ();
            TempFolderSelectBtn = new Button ();
            TempFolderTextBox = new TextBox ();
            BackupFolderGroupBox = new GroupBox ();
            BackupFolderSelectBtn = new Button ();
            BackupFolderTextBox = new TextBox ();
            FailureFolderGroupBox = new GroupBox ();
            FailureFolderSelectBtn = new Button ();
            FailureFolderTextBox = new TextBox ();
            DuplicatesFolderGroupBox = new GroupBox ();
            DuplicatesFolderSelectBtn = new Button ();
            DuplicatesFolderTextBox = new TextBox ();
            WrokFolderGroupBox.SuspendLayout ();
            TempFolderGroupBox.SuspendLayout ();
            BackupFolderGroupBox.SuspendLayout ();
            FailureFolderGroupBox.SuspendLayout ();
            DuplicatesFolderGroupBox.SuspendLayout ();
            SuspendLayout ();
            // 
            // WrokFolderGroupBox
            // 
            WrokFolderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WrokFolderGroupBox.Controls.Add ( WorkFolderSelectBtn );
            WrokFolderGroupBox.Controls.Add ( WorkFolderTextBox );
            WrokFolderGroupBox.Location = new Point ( 8 , 12 );
            WrokFolderGroupBox.Name = "WrokFolderGroupBox";
            WrokFolderGroupBox.Size = new Size ( 764 , 69 );
            WrokFolderGroupBox.TabIndex = 0;
            WrokFolderGroupBox.TabStop = false;
            WrokFolderGroupBox.Text = "作業フォルダ";
            // 
            // WorkFolderSelectBtn
            // 
            WorkFolderSelectBtn.Location = new Point ( 658 , 22 );
            WorkFolderSelectBtn.Name = "WorkFolderSelectBtn";
            WorkFolderSelectBtn.Size = new Size ( 100 , 30 );
            WorkFolderSelectBtn.TabIndex = 1;
            WorkFolderSelectBtn.Tag = "work";
            WorkFolderSelectBtn.Text = "フォルダ選択";
            WorkFolderSelectBtn.UseVisualStyleBackColor = true;
            WorkFolderSelectBtn.Click += FolderSelectBtn_Click;
            // 
            // WorkFolderTextBox
            // 
            WorkFolderTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            WorkFolderTextBox.Location = new Point ( 6 , 27 );
            WorkFolderTextBox.Name = "WorkFolderTextBox";
            WorkFolderTextBox.Size = new Size ( 646 , 23 );
            WorkFolderTextBox.TabIndex = 0;
            // 
            // TempFolderGroupBox
            // 
            TempFolderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TempFolderGroupBox.Controls.Add ( TempFolderSelectBtn );
            TempFolderGroupBox.Controls.Add ( TempFolderTextBox );
            TempFolderGroupBox.Location = new Point ( 8 , 87 );
            TempFolderGroupBox.Name = "TempFolderGroupBox";
            TempFolderGroupBox.Size = new Size ( 764 , 69 );
            TempFolderGroupBox.TabIndex = 2;
            TempFolderGroupBox.TabStop = false;
            TempFolderGroupBox.Text = "一時フォルダ";
            // 
            // TempFolderSelectBtn
            // 
            TempFolderSelectBtn.Location = new Point ( 658 , 22 );
            TempFolderSelectBtn.Name = "TempFolderSelectBtn";
            TempFolderSelectBtn.Size = new Size ( 100 , 30 );
            TempFolderSelectBtn.TabIndex = 1;
            TempFolderSelectBtn.Tag = "temp";
            TempFolderSelectBtn.Text = "フォルダ選択";
            TempFolderSelectBtn.UseVisualStyleBackColor = true;
            TempFolderSelectBtn.Click += FolderSelectBtn_Click;
            // 
            // TempFolderTextBox
            // 
            TempFolderTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TempFolderTextBox.Location = new Point ( 6 , 27 );
            TempFolderTextBox.Name = "TempFolderTextBox";
            TempFolderTextBox.Size = new Size ( 646 , 23 );
            TempFolderTextBox.TabIndex = 0;
            // 
            // BackupFolderGroupBox
            // 
            BackupFolderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BackupFolderGroupBox.Controls.Add ( BackupFolderSelectBtn );
            BackupFolderGroupBox.Controls.Add ( BackupFolderTextBox );
            BackupFolderGroupBox.Location = new Point ( 8 , 162 );
            BackupFolderGroupBox.Name = "BackupFolderGroupBox";
            BackupFolderGroupBox.Size = new Size ( 764 , 69 );
            BackupFolderGroupBox.TabIndex = 3;
            BackupFolderGroupBox.TabStop = false;
            BackupFolderGroupBox.Text = "バックアップフォルダ";
            // 
            // BackupFolderSelectBtn
            // 
            BackupFolderSelectBtn.Location = new Point ( 658 , 22 );
            BackupFolderSelectBtn.Name = "BackupFolderSelectBtn";
            BackupFolderSelectBtn.Size = new Size ( 100 , 30 );
            BackupFolderSelectBtn.TabIndex = 1;
            BackupFolderSelectBtn.Tag = "backup";
            BackupFolderSelectBtn.Text = "フォルダ選択";
            BackupFolderSelectBtn.UseVisualStyleBackColor = true;
            BackupFolderSelectBtn.Click += FolderSelectBtn_Click;
            // 
            // BackupFolderTextBox
            // 
            BackupFolderTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            BackupFolderTextBox.Location = new Point ( 6 , 27 );
            BackupFolderTextBox.Name = "BackupFolderTextBox";
            BackupFolderTextBox.Size = new Size ( 646 , 23 );
            BackupFolderTextBox.TabIndex = 0;
            // 
            // FailureFolderGroupBox
            // 
            FailureFolderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FailureFolderGroupBox.Controls.Add ( FailureFolderSelectBtn );
            FailureFolderGroupBox.Controls.Add ( FailureFolderTextBox );
            FailureFolderGroupBox.Location = new Point ( 8 , 237 );
            FailureFolderGroupBox.Name = "FailureFolderGroupBox";
            FailureFolderGroupBox.Size = new Size ( 764 , 69 );
            FailureFolderGroupBox.TabIndex = 4;
            FailureFolderGroupBox.TabStop = false;
            FailureFolderGroupBox.Text = "失敗フォルダ";
            // 
            // FailureFolderSelectBtn
            // 
            FailureFolderSelectBtn.Location = new Point ( 658 , 22 );
            FailureFolderSelectBtn.Name = "FailureFolderSelectBtn";
            FailureFolderSelectBtn.Size = new Size ( 100 , 30 );
            FailureFolderSelectBtn.TabIndex = 1;
            FailureFolderSelectBtn.Tag = "failure";
            FailureFolderSelectBtn.Text = "フォルダ選択";
            FailureFolderSelectBtn.UseVisualStyleBackColor = true;
            FailureFolderSelectBtn.Click += FolderSelectBtn_Click;
            // 
            // FailureFolderTextBox
            // 
            FailureFolderTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FailureFolderTextBox.Location = new Point ( 6 , 27 );
            FailureFolderTextBox.Name = "FailureFolderTextBox";
            FailureFolderTextBox.Size = new Size ( 646 , 23 );
            FailureFolderTextBox.TabIndex = 0;
            // 
            // DuplicatesFolderGroupBox
            // 
            DuplicatesFolderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DuplicatesFolderGroupBox.Controls.Add ( DuplicatesFolderSelectBtn );
            DuplicatesFolderGroupBox.Controls.Add ( DuplicatesFolderTextBox );
            DuplicatesFolderGroupBox.Location = new Point ( 8 , 312 );
            DuplicatesFolderGroupBox.Name = "DuplicatesFolderGroupBox";
            DuplicatesFolderGroupBox.Size = new Size ( 764 , 69 );
            DuplicatesFolderGroupBox.TabIndex = 5;
            DuplicatesFolderGroupBox.TabStop = false;
            DuplicatesFolderGroupBox.Text = "重複フォルダ";
            // 
            // DuplicatesFolderSelectBtn
            // 
            DuplicatesFolderSelectBtn.Location = new Point ( 658 , 22 );
            DuplicatesFolderSelectBtn.Name = "DuplicatesFolderSelectBtn";
            DuplicatesFolderSelectBtn.Size = new Size ( 100 , 30 );
            DuplicatesFolderSelectBtn.TabIndex = 1;
            DuplicatesFolderSelectBtn.Tag = "duplicates";
            DuplicatesFolderSelectBtn.Text = "フォルダ選択";
            DuplicatesFolderSelectBtn.UseVisualStyleBackColor = true;
            DuplicatesFolderSelectBtn.Click += FolderSelectBtn_Click;
            // 
            // DuplicatesFolderTextBox
            // 
            DuplicatesFolderTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            DuplicatesFolderTextBox.Location = new Point ( 6 , 27 );
            DuplicatesFolderTextBox.Name = "DuplicatesFolderTextBox";
            DuplicatesFolderTextBox.Size = new Size ( 646 , 23 );
            DuplicatesFolderTextBox.TabIndex = 0;
            // 
            // WorkFolderView
            // 
            AutoScaleDimensions = new SizeF ( 7F , 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size ( 784 , 393 );
            Controls.Add ( DuplicatesFolderGroupBox );
            Controls.Add ( FailureFolderGroupBox );
            Controls.Add ( BackupFolderGroupBox );
            Controls.Add ( TempFolderGroupBox );
            Controls.Add ( WrokFolderGroupBox );
            Name = "WorkFolderView";
            Text = "WorkFolderView";
            WrokFolderGroupBox.ResumeLayout ( false );
            WrokFolderGroupBox.PerformLayout ();
            TempFolderGroupBox.ResumeLayout ( false );
            TempFolderGroupBox.PerformLayout ();
            BackupFolderGroupBox.ResumeLayout ( false );
            BackupFolderGroupBox.PerformLayout ();
            FailureFolderGroupBox.ResumeLayout ( false );
            FailureFolderGroupBox.PerformLayout ();
            DuplicatesFolderGroupBox.ResumeLayout ( false );
            DuplicatesFolderGroupBox.PerformLayout ();
            ResumeLayout ( false );
        }

        #endregion

        private GroupBox WrokFolderGroupBox;
        private TextBox WorkFolderTextBox;
        private Button WorkFolderSelectBtn;
        private GroupBox TempFolderGroupBox;
        private Button TempFolderSelectBtn;
        private TextBox TempFolderTextBox;
        private GroupBox BackupFolderGroupBox;
        private Button BackupFolderSelectBtn;
        private TextBox BackupFolderTextBox;
        private GroupBox FailureFolderGroupBox;
        private Button FailureFolderSelectBtn;
        private TextBox FailureFolderTextBox;
        private GroupBox DuplicatesFolderGroupBox;
        private Button DuplicatesFolderSelectBtn;
        private TextBox DuplicatesFolderTextBox;
    }
}