namespace ImageResizeApp.Views
{
    partial class TimeStampChangeView
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
            YearGroupBox = new GroupBox ();
            YearTextBox = new TextBox ();
            MonthGroupBox = new GroupBox ();
            MonthTextBox = new TextBox ();
            DayGroupBox = new GroupBox ();
            DayTextBox = new TextBox ();
            HourGroupBox = new GroupBox ();
            HourTextBox = new TextBox ();
            MinutesGroupBox = new GroupBox ();
            MinutesTextBox = new TextBox ();
            SecondGroupBox = new GroupBox ();
            SecondTextBox = new TextBox ();
            ChangeGroupBox = new GroupBox ();
            ResetBtn = new Button ();
            ChangeBtn = new Button ();
            ChangeTextBox = new TextBox ();
            YearGroupBox.SuspendLayout ();
            MonthGroupBox.SuspendLayout ();
            DayGroupBox.SuspendLayout ();
            HourGroupBox.SuspendLayout ();
            MinutesGroupBox.SuspendLayout ();
            SecondGroupBox.SuspendLayout ();
            ChangeGroupBox.SuspendLayout ();
            SuspendLayout ();
            // 
            // YearGroupBox
            // 
            YearGroupBox.Controls.Add ( YearTextBox );
            YearGroupBox.Location = new Point ( 12 , 12 );
            YearGroupBox.Name = "YearGroupBox";
            YearGroupBox.Size = new Size ( 113 , 61 );
            YearGroupBox.TabIndex = 0;
            YearGroupBox.TabStop = false;
            YearGroupBox.Text = "年";
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point ( 6 , 22 );
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size ( 100 , 23 );
            YearTextBox.TabIndex = 0;
            YearTextBox.TextChanged +=  YearTextBox_TextChanged ;
            // 
            // MonthGroupBox
            // 
            MonthGroupBox.Controls.Add ( MonthTextBox );
            MonthGroupBox.Location = new Point ( 131 , 12 );
            MonthGroupBox.Name = "MonthGroupBox";
            MonthGroupBox.Size = new Size ( 113 , 61 );
            MonthGroupBox.TabIndex = 1;
            MonthGroupBox.TabStop = false;
            MonthGroupBox.Text = "月";
            // 
            // MonthTextBox
            // 
            MonthTextBox.Location = new Point ( 6 , 22 );
            MonthTextBox.Name = "MonthTextBox";
            MonthTextBox.Size = new Size ( 100 , 23 );
            MonthTextBox.TabIndex = 0;
            MonthTextBox.TextChanged +=  MonthTextBox_TextChanged ;
            // 
            // DayGroupBox
            // 
            DayGroupBox.Controls.Add ( DayTextBox );
            DayGroupBox.Location = new Point ( 250 , 12 );
            DayGroupBox.Name = "DayGroupBox";
            DayGroupBox.Size = new Size ( 113 , 61 );
            DayGroupBox.TabIndex = 2;
            DayGroupBox.TabStop = false;
            DayGroupBox.Text = "日";
            // 
            // DayTextBox
            // 
            DayTextBox.Location = new Point ( 6 , 22 );
            DayTextBox.Name = "DayTextBox";
            DayTextBox.Size = new Size ( 100 , 23 );
            DayTextBox.TabIndex = 0;
            DayTextBox.TextChanged +=  DayTextBox_TextChanged ;
            // 
            // HourGroupBox
            // 
            HourGroupBox.Controls.Add ( HourTextBox );
            HourGroupBox.Location = new Point ( 369 , 12 );
            HourGroupBox.Name = "HourGroupBox";
            HourGroupBox.Size = new Size ( 113 , 61 );
            HourGroupBox.TabIndex = 3;
            HourGroupBox.TabStop = false;
            HourGroupBox.Text = "時";
            // 
            // HourTextBox
            // 
            HourTextBox.Location = new Point ( 6 , 22 );
            HourTextBox.Name = "HourTextBox";
            HourTextBox.Size = new Size ( 100 , 23 );
            HourTextBox.TabIndex = 0;
            HourTextBox.TextChanged +=  HourTextBox_TextChanged ;
            // 
            // MinutesGroupBox
            // 
            MinutesGroupBox.Controls.Add ( MinutesTextBox );
            MinutesGroupBox.Location = new Point ( 488 , 12 );
            MinutesGroupBox.Name = "MinutesGroupBox";
            MinutesGroupBox.Size = new Size ( 113 , 61 );
            MinutesGroupBox.TabIndex = 4;
            MinutesGroupBox.TabStop = false;
            MinutesGroupBox.Text = "分";
            // 
            // MinutesTextBox
            // 
            MinutesTextBox.Location = new Point ( 6 , 22 );
            MinutesTextBox.Name = "MinutesTextBox";
            MinutesTextBox.Size = new Size ( 100 , 23 );
            MinutesTextBox.TabIndex = 0;
            MinutesTextBox.TextChanged +=  MinutesTextBox_TextChanged ;
            // 
            // SecondGroupBox
            // 
            SecondGroupBox.Controls.Add ( SecondTextBox );
            SecondGroupBox.Location = new Point ( 607 , 12 );
            SecondGroupBox.Name = "SecondGroupBox";
            SecondGroupBox.Size = new Size ( 113 , 61 );
            SecondGroupBox.TabIndex = 5;
            SecondGroupBox.TabStop = false;
            SecondGroupBox.Text = "秒";
            // 
            // SecondTextBox
            // 
            SecondTextBox.Location = new Point ( 6 , 22 );
            SecondTextBox.Name = "SecondTextBox";
            SecondTextBox.Size = new Size ( 100 , 23 );
            SecondTextBox.TabIndex = 0;
            SecondTextBox.TextChanged +=  SecondTextBox_TextChanged ;
            // 
            // ChangeGroupBox
            // 
            ChangeGroupBox.Controls.Add ( ResetBtn );
            ChangeGroupBox.Controls.Add ( ChangeBtn );
            ChangeGroupBox.Controls.Add ( ChangeTextBox );
            ChangeGroupBox.Location = new Point ( 12 , 79 );
            ChangeGroupBox.Name = "ChangeGroupBox";
            ChangeGroupBox.Size = new Size ( 470 , 61 );
            ChangeGroupBox.TabIndex = 1;
            ChangeGroupBox.TabStop = false;
            ChangeGroupBox.Text = "変更";
            // 
            // ResetBtn
            // 
            ResetBtn.Location = new Point ( 363 , 22 );
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size ( 100 , 24 );
            ResetBtn.TabIndex = 2;
            ResetBtn.Text = "リセット";
            ResetBtn.UseVisualStyleBackColor = true;
            ResetBtn.Click +=  ResetBtn_Click ;
            // 
            // ChangeBtn
            // 
            ChangeBtn.Location = new Point ( 244 , 21 );
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.Size = new Size ( 100 , 24 );
            ChangeBtn.TabIndex = 1;
            ChangeBtn.Text = "変更";
            ChangeBtn.UseVisualStyleBackColor = true;
            ChangeBtn.Click +=  ChangeBtn_Click ;
            // 
            // ChangeTextBox
            // 
            ChangeTextBox.Location = new Point ( 6 , 22 );
            ChangeTextBox.Name = "ChangeTextBox";
            ChangeTextBox.ReadOnly = true;
            ChangeTextBox.Size = new Size ( 219 , 23 );
            ChangeTextBox.TabIndex = 0;
            // 
            // TimeStampChangeView
            // 
            AutoScaleDimensions = new SizeF ( 7F , 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size ( 733 , 156 );
            Controls.Add ( ChangeGroupBox );
            Controls.Add ( SecondGroupBox );
            Controls.Add ( MinutesGroupBox );
            Controls.Add ( HourGroupBox );
            Controls.Add ( DayGroupBox );
            Controls.Add ( MonthGroupBox );
            Controls.Add ( YearGroupBox );
            Name = "TimeStampChangeView";
            Text = "TimeStampChengeView";
            YearGroupBox.ResumeLayout ( false );
            YearGroupBox.PerformLayout ();
            MonthGroupBox.ResumeLayout ( false );
            MonthGroupBox.PerformLayout ();
            DayGroupBox.ResumeLayout ( false );
            DayGroupBox.PerformLayout ();
            HourGroupBox.ResumeLayout ( false );
            HourGroupBox.PerformLayout ();
            MinutesGroupBox.ResumeLayout ( false );
            MinutesGroupBox.PerformLayout ();
            SecondGroupBox.ResumeLayout ( false );
            SecondGroupBox.PerformLayout ();
            ChangeGroupBox.ResumeLayout ( false );
            ChangeGroupBox.PerformLayout ();
            ResumeLayout ( false );
        }

        #endregion

        private GroupBox YearGroupBox;
        private TextBox YearTextBox;
        private GroupBox MonthGroupBox;
        private TextBox MonthTextBox;
        private GroupBox DayGroupBox;
        private TextBox DayTextBox;
        private GroupBox HourGroupBox;
        private TextBox HourTextBox;
        private GroupBox MinutesGroupBox;
        private TextBox MinutesTextBox;
        private GroupBox SecondGroupBox;
        private TextBox SecondTextBox;
        private GroupBox ChangeGroupBox;
        private TextBox ChangeTextBox;
        private Button ChangeBtn;
        private Button ResetBtn;
    }
}