namespace ImageSplitApp.Forms
{
    partial class ImageSplitForm
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
            SettingGroupBox = new GroupBox ();
            ReloadBtn = new Button ();
            ResetBtn = new Button ();
            ImageHeightLabel = new Label ();
            ImageWidthLabel = new Label ();
            NextImageBtn = new Button ();
            PreImageBtn = new Button ();
            SampleBtn = new Button ();
            ExecuteBtn = new Button ();
            PageGroupBox = new GroupBox ();
            RightPageRadioButton = new RadioButton ();
            LeftPageRadioButton = new RadioButton ();
            SaveRadioBtnGroupBox = new GroupBox ();
            RightRadioButton = new RadioButton ();
            LeftRadioButton = new RadioButton ();
            BothRadioBtn = new RadioButton ();
            LeftPositionGroupBox = new GroupBox ();
            LeftPositionTextBox = new TextBox ();
            PictureBox = new PictureBox ();
            menuStrip1 = new MenuStrip ();
            SettingToolStripMenuItem = new ToolStripMenuItem ();
            WorkFolderSettingToolStripMenuItem = new ToolStripMenuItem ();
            SettingGroupBox.SuspendLayout ();
            PageGroupBox.SuspendLayout ();
            SaveRadioBtnGroupBox.SuspendLayout ();
            LeftPositionGroupBox.SuspendLayout ();
            ( ( System.ComponentModel.ISupportInitialize ) PictureBox ).BeginInit ();
            menuStrip1.SuspendLayout ();
            SuspendLayout ();
            // 
            // SettingGroupBox
            // 
            SettingGroupBox.Anchor =      AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            SettingGroupBox.Controls.Add ( ReloadBtn );
            SettingGroupBox.Controls.Add ( ResetBtn );
            SettingGroupBox.Controls.Add ( ImageHeightLabel );
            SettingGroupBox.Controls.Add ( ImageWidthLabel );
            SettingGroupBox.Controls.Add ( NextImageBtn );
            SettingGroupBox.Controls.Add ( PreImageBtn );
            SettingGroupBox.Controls.Add ( SampleBtn );
            SettingGroupBox.Controls.Add ( ExecuteBtn );
            SettingGroupBox.Controls.Add ( PageGroupBox );
            SettingGroupBox.Controls.Add ( SaveRadioBtnGroupBox );
            SettingGroupBox.Controls.Add ( LeftPositionGroupBox );
            SettingGroupBox.Location = new Point ( 8 , 27 );
            SettingGroupBox.Name = "SettingGroupBox";
            SettingGroupBox.Size = new Size ( 1065 , 100 );
            SettingGroupBox.TabIndex = 0;
            SettingGroupBox.TabStop = false;
            SettingGroupBox.Text = "設定";
            // 
            // ReloadBtn
            // 
            ReloadBtn.Location = new Point ( 812 , 57 );
            ReloadBtn.Name = "ReloadBtn";
            ReloadBtn.Size = new Size ( 60 , 25 );
            ReloadBtn.TabIndex = 10;
            ReloadBtn.Text = "再読込";
            ReloadBtn.UseVisualStyleBackColor = true;
            ReloadBtn.Click +=  ReloadBtn_Click ;
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point ( 746 , 57 );
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size ( 60 , 25 );
            ResetBtn.TabIndex = 9;
            ResetBtn.Text = "リセット";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click +=  ResetBtn_Click ;
            // 
            // ImageHeightLabel
            // 
            ImageHeightLabel.AutoSize = true;
            ImageHeightLabel.Location = new Point ( 1007 , 45 );
            ImageHeightLabel.Name = "ImageHeightLabel";
            ImageHeightLabel.Size = new Size ( 52 , 15 );
            ImageHeightLabel.TabIndex = 8;
            ImageHeightLabel.Text = "Height : ";
            // 
            // ImageWidthLabel
            // 
            ImageWidthLabel.AutoSize = true;
            ImageWidthLabel.Location = new Point ( 1011 , 19 );
            ImageWidthLabel.Name = "ImageWidthLabel";
            ImageWidthLabel.Size = new Size ( 48 , 15 );
            ImageWidthLabel.TabIndex = 7;
            ImageWidthLabel.Text = "Width : ";
            // 
            // NextImageBtn
            // 
            NextImageBtn.Location = new Point ( 660 , 22 );
            NextImageBtn.Name = "NextImageBtn";
            NextImageBtn.Size = new Size ( 40 , 25 );
            NextImageBtn.TabIndex = 6;
            NextImageBtn.Text = "次";
            NextImageBtn.UseVisualStyleBackColor = true;
            NextImageBtn.Click +=  NextImageBtn_Click ;
            // 
            // PreImageBtn
            // 
            PreImageBtn.Location = new Point ( 614 , 22 );
            PreImageBtn.Name = "PreImageBtn";
            PreImageBtn.Size = new Size ( 40 , 25 );
            PreImageBtn.TabIndex = 5;
            PreImageBtn.Text = "前";
            PreImageBtn.UseVisualStyleBackColor = true;
            PreImageBtn.Click +=  PreImageBtn_Click ;
            // 
            // SampleBtn
            // 
            SampleBtn.Location = new Point ( 680 , 57 );
            SampleBtn.Name = "SampleBtn";
            SampleBtn.Size = new Size ( 60 , 25 );
            SampleBtn.TabIndex = 4;
            SampleBtn.Text = "サンプル";
            SampleBtn.UseVisualStyleBackColor = true;
            // 
            // ExecuteBtn
            // 
            ExecuteBtn.Location = new Point ( 614 , 57 );
            ExecuteBtn.Name = "ExecuteBtn";
            ExecuteBtn.Size = new Size ( 60 , 25 );
            ExecuteBtn.TabIndex = 3;
            ExecuteBtn.Text = "実行";
            ExecuteBtn.UseVisualStyleBackColor = true;
            ExecuteBtn.Click +=  ExecuteBtn_Click ;
            // 
            // PageGroupBox
            // 
            PageGroupBox.Controls.Add ( RightPageRadioButton );
            PageGroupBox.Controls.Add ( LeftPageRadioButton );
            PageGroupBox.Location = new Point ( 408 , 22 );
            PageGroupBox.Name = "PageGroupBox";
            PageGroupBox.Size = new Size ( 200 , 60 );
            PageGroupBox.TabIndex = 2;
            PageGroupBox.TabStop = false;
            PageGroupBox.Text = "1ページ";
            // 
            // RightPageRadioButton
            // 
            RightPageRadioButton.AutoSize = true;
            RightPageRadioButton.Location = new Point ( 83 , 23 );
            RightPageRadioButton.Name = "RightPageRadioButton";
            RightPageRadioButton.Size = new Size ( 71 , 19 );
            RightPageRadioButton.TabIndex = 1;
            RightPageRadioButton.TabStop = true;
            RightPageRadioButton.Text = "右1ページ";
            RightPageRadioButton.UseVisualStyleBackColor = true;
            RightPageRadioButton.CheckedChanged +=  RightPageRadioButton_CheckedChanged ;
            // 
            // LeftPageRadioButton
            // 
            LeftPageRadioButton.AutoSize = true;
            LeftPageRadioButton.Location = new Point ( 6 , 23 );
            LeftPageRadioButton.Name = "LeftPageRadioButton";
            LeftPageRadioButton.Size = new Size ( 71 , 19 );
            LeftPageRadioButton.TabIndex = 0;
            LeftPageRadioButton.TabStop = true;
            LeftPageRadioButton.Text = "左1ページ";
            LeftPageRadioButton.UseVisualStyleBackColor = true;
            LeftPageRadioButton.CheckedChanged +=  LeftPageRadioButton_CheckedChanged ;
            // 
            // SaveRadioBtnGroupBox
            // 
            SaveRadioBtnGroupBox.Controls.Add ( RightRadioButton );
            SaveRadioBtnGroupBox.Controls.Add ( LeftRadioButton );
            SaveRadioBtnGroupBox.Controls.Add ( BothRadioBtn );
            SaveRadioBtnGroupBox.Location = new Point ( 96 , 22 );
            SaveRadioBtnGroupBox.Name = "SaveRadioBtnGroupBox";
            SaveRadioBtnGroupBox.Size = new Size ( 306 , 60 );
            SaveRadioBtnGroupBox.TabIndex = 1;
            SaveRadioBtnGroupBox.TabStop = false;
            SaveRadioBtnGroupBox.Text = "保存個所";
            // 
            // RightRadioButton
            // 
            RightRadioButton.AutoSize = true;
            RightRadioButton.Location = new Point ( 206 , 22 );
            RightRadioButton.Name = "RightRadioButton";
            RightRadioButton.Size = new Size ( 58 , 19 );
            RightRadioButton.TabIndex = 4;
            RightRadioButton.TabStop = true;
            RightRadioButton.Text = "右のみ";
            RightRadioButton.UseVisualStyleBackColor = true;
            RightRadioButton.CheckedChanged +=  RightRadioButton_CheckedChanged ;
            // 
            // LeftRadioButton
            // 
            LeftRadioButton.AutoSize = true;
            LeftRadioButton.Location = new Point ( 106 , 22 );
            LeftRadioButton.Name = "LeftRadioButton";
            LeftRadioButton.Size = new Size ( 58 , 19 );
            LeftRadioButton.TabIndex = 3;
            LeftRadioButton.TabStop = true;
            LeftRadioButton.Text = "左のみ";
            LeftRadioButton.UseVisualStyleBackColor = true;
            LeftRadioButton.CheckedChanged +=  LeftRadioButton_CheckedChanged ;
            // 
            // BothRadioBtn
            // 
            BothRadioBtn.AutoSize = true;
            BothRadioBtn.Location = new Point ( 6 , 22 );
            BothRadioBtn.Name = "BothRadioBtn";
            BothRadioBtn.Size = new Size ( 49 , 19 );
            BothRadioBtn.TabIndex = 2;
            BothRadioBtn.TabStop = true;
            BothRadioBtn.Text = "両方";
            BothRadioBtn.UseVisualStyleBackColor = true;
            BothRadioBtn.CheckedChanged +=  BothRadioBtn_CheckedChanged ;
            // 
            // LeftPositionGroupBox
            // 
            LeftPositionGroupBox.Controls.Add ( LeftPositionTextBox );
            LeftPositionGroupBox.Location = new Point ( 10 , 22 );
            LeftPositionGroupBox.Name = "LeftPositionGroupBox";
            LeftPositionGroupBox.Size = new Size ( 80 , 60 );
            LeftPositionGroupBox.TabIndex = 0;
            LeftPositionGroupBox.TabStop = false;
            LeftPositionGroupBox.Text = "左から";
            // 
            // LeftPositionTextBox
            // 
            LeftPositionTextBox.Location = new Point ( 10 , 22 );
            LeftPositionTextBox.Name = "LeftPositionTextBox";
            LeftPositionTextBox.Size = new Size ( 60 , 23 );
            LeftPositionTextBox.TabIndex = 1;
            LeftPositionTextBox.TextChanged +=  LeftPositionTextBox_TextChanged ;
            // 
            // PictureBox
            // 
            PictureBox.Anchor =      AnchorStyles.Bottom  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            PictureBox.Location = new Point ( 8 , 133 );
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size ( 1065 , 305 );
            PictureBox.TabIndex = 1;
            PictureBox.TabStop = false;
            PictureBox.Paint +=  PictureBox_Paint ;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange ( new ToolStripItem[] { SettingToolStripMenuItem } );
            menuStrip1.Location = new Point ( 0 , 0 );
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size ( 1085 , 24 );
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // SettingToolStripMenuItem
            // 
            SettingToolStripMenuItem.DropDownItems.AddRange ( new ToolStripItem[] { WorkFolderSettingToolStripMenuItem } );
            SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            SettingToolStripMenuItem.Size = new Size ( 56 , 20 );
            SettingToolStripMenuItem.Text = "設定(&s)";
            // 
            // WorkFolderSettingToolStripMenuItem
            // 
            WorkFolderSettingToolStripMenuItem.Name = "WorkFolderSettingToolStripMenuItem";
            WorkFolderSettingToolStripMenuItem.Size = new Size ( 174 , 22 );
            WorkFolderSettingToolStripMenuItem.Text = "作業フォルダ設定(&w)";
            WorkFolderSettingToolStripMenuItem.Click +=  WorkFolderSettingToolStripMenuItem_Click ;
            // 
            // ImageSplitForm
            // 
            AutoScaleDimensions = new SizeF ( 7F , 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size ( 1085 , 450 );
            Controls.Add ( PictureBox );
            Controls.Add ( SettingGroupBox );
            Controls.Add ( menuStrip1 );
            MainMenuStrip = menuStrip1;
            Name = "ImageSplitForm";
            Text = "ImageSplitApp";
            FormClosed +=  ImageSplitForm_FormClosed ;
            Load +=  ImageSplitForm_Load ;
            SettingGroupBox.ResumeLayout ( false );
            SettingGroupBox.PerformLayout ();
            PageGroupBox.ResumeLayout ( false );
            PageGroupBox.PerformLayout ();
            SaveRadioBtnGroupBox.ResumeLayout ( false );
            SaveRadioBtnGroupBox.PerformLayout ();
            LeftPositionGroupBox.ResumeLayout ( false );
            LeftPositionGroupBox.PerformLayout ();
            ( ( System.ComponentModel.ISupportInitialize ) PictureBox ).EndInit ();
            menuStrip1.ResumeLayout ( false );
            menuStrip1.PerformLayout ();
            ResumeLayout ( false );
            PerformLayout ();
        }

        #endregion

        private GroupBox SettingGroupBox;
        private PictureBox PictureBox;
        private GroupBox LeftPositionGroupBox;
        private TextBox LeftPositionTextBox;
        private GroupBox SaveRadioBtnGroupBox;
        private RadioButton RightRadioButton;
        private RadioButton LeftRadioButton;
        private RadioButton BothRadioBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem SettingToolStripMenuItem;
        private ToolStripMenuItem WorkFolderSettingToolStripMenuItem;
        private GroupBox PageGroupBox;
        private RadioButton RightPageRadioButton;
        private RadioButton LeftPageRadioButton;
        private Button ExecuteBtn;
        private Button SampleBtn;
        private Button PreImageBtn;
        private Button NextImageBtn;
        private Label ImageWidthLabel;
        private Label ImageHeightLabel;
        private Button ResetBtn;
        private Button ReloadBtn;
    }
}
