namespace ImageResizeApp.Views
{
    partial class LogDisplayView
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
            LogLevelCheckedListBox = new CheckedListBox ();
            LogTextBox = new RichTextBox ();
            groupBox1 = new GroupBox ();
            groupBox1.SuspendLayout ();
            SuspendLayout ();
            // 
            // LogLevelCheckedListBox
            // 
            LogLevelCheckedListBox.FormattingEnabled = true;
            LogLevelCheckedListBox.Items.AddRange ( new object[] { "Info" , "Debug" , "Trace" , "Wraning" , "Error" , "Fatal" } );
            LogLevelCheckedListBox.Location = new Point ( 12 , 12 );
            LogLevelCheckedListBox.Name = "LogLevelCheckedListBox";
            LogLevelCheckedListBox.Size = new Size ( 161 , 112 );
            LogLevelCheckedListBox.TabIndex = 2;
            LogLevelCheckedListBox.ItemCheck += LogLevelCheckedListBox_ItemCheck;
            // 
            // LogTextBox
            // 
            LogTextBox.Dock = DockStyle.Fill;
            LogTextBox.Location = new Point ( 3 , 19 );
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.Size = new Size ( 794 , 429 );
            LogTextBox.TabIndex = 3;
            LogTextBox.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add ( LogTextBox );
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point ( 0 , 133 );
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size ( 800 , 451 );
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "ログ";
            // 
            // LogDisplayView
            // 
            AutoScaleDimensions = new SizeF ( 7F , 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size ( 800 , 584 );
            Controls.Add ( groupBox1 );
            Controls.Add ( LogLevelCheckedListBox );
            Name = "LogDisplayView";
            Text = "LogView";
            groupBox1.ResumeLayout ( false );
            ResumeLayout ( false );
        }

        #endregion
        private CheckedListBox LogLevelCheckedListBox;
        private RichTextBox LogTextBox;
        private GroupBox groupBox1;
    }
}