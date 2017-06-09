namespace hourCalc
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSettingsHeader = new System.Windows.Forms.Label();
            this.labelDefaultTimes = new System.Windows.Forms.Label();
            this.labelStartofDay = new System.Windows.Forms.Label();
            this.StartOfDayTime = new System.Windows.Forms.DateTimePicker();
            this.LunchStartTime = new System.Windows.Forms.DateTimePicker();
            this.LunchEndTime = new System.Windows.Forms.DateTimePicker();
            this.EndOfDayTime = new System.Windows.Forms.DateTimePicker();
            this.labelLunchStart = new System.Windows.Forms.Label();
            this.labelLunchEnd = new System.Windows.Forms.Label();
            this.labelEndofDay = new System.Windows.Forms.Label();
            this.labelTwoWeekCycle = new System.Windows.Forms.Label();
            this.checkBoxTwoWeekCycle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSettingsHeader
            // 
            this.labelSettingsHeader.AutoSize = true;
            this.labelSettingsHeader.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettingsHeader.Location = new System.Drawing.Point(13, 13);
            this.labelSettingsHeader.Name = "labelSettingsHeader";
            this.labelSettingsHeader.Size = new System.Drawing.Size(184, 24);
            this.labelSettingsHeader.TabIndex = 0;
            this.labelSettingsHeader.Text = "Hour Calc Settings";
            // 
            // labelDefaultTimes
            // 
            this.labelDefaultTimes.AutoSize = true;
            this.labelDefaultTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefaultTimes.Location = new System.Drawing.Point(17, 77);
            this.labelDefaultTimes.Name = "labelDefaultTimes";
            this.labelDefaultTimes.Size = new System.Drawing.Size(99, 17);
            this.labelDefaultTimes.TabIndex = 1;
            this.labelDefaultTimes.Text = "Default Times:";
            // 
            // labelStartofDay
            // 
            this.labelStartofDay.AutoSize = true;
            this.labelStartofDay.Location = new System.Drawing.Point(153, 77);
            this.labelStartofDay.Name = "labelStartofDay";
            this.labelStartofDay.Size = new System.Drawing.Size(63, 13);
            this.labelStartofDay.TabIndex = 2;
            this.labelStartofDay.Text = "Start of Day";
            // 
            // StartOfDayTime
            // 
            this.StartOfDayTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartOfDayTime.CustomFormat = "hh:mm:ss  tt";
            this.StartOfDayTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartOfDayTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StartOfDayTime.Location = new System.Drawing.Point(237, 77);
            this.StartOfDayTime.Name = "StartOfDayTime";
            this.StartOfDayTime.ShowUpDown = true;
            this.StartOfDayTime.Size = new System.Drawing.Size(145, 20);
            this.StartOfDayTime.TabIndex = 21;
            this.StartOfDayTime.ValueChanged += new System.EventHandler(this.StartOfDayTime_ValueChanged);
            // 
            // LunchStartTime
            // 
            this.LunchStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LunchStartTime.CustomFormat = "hh:mm:ss  tt";
            this.LunchStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LunchStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LunchStartTime.Location = new System.Drawing.Point(237, 103);
            this.LunchStartTime.Name = "LunchStartTime";
            this.LunchStartTime.ShowUpDown = true;
            this.LunchStartTime.Size = new System.Drawing.Size(145, 20);
            this.LunchStartTime.TabIndex = 22;
            this.LunchStartTime.ValueChanged += new System.EventHandler(this.LunchStartTime_ValueChanged);
            // 
            // LunchEndTime
            // 
            this.LunchEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LunchEndTime.CustomFormat = "hh:mm:ss  tt";
            this.LunchEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LunchEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LunchEndTime.Location = new System.Drawing.Point(237, 129);
            this.LunchEndTime.Name = "LunchEndTime";
            this.LunchEndTime.ShowUpDown = true;
            this.LunchEndTime.Size = new System.Drawing.Size(145, 20);
            this.LunchEndTime.TabIndex = 23;
            this.LunchEndTime.ValueChanged += new System.EventHandler(this.LunchEndTime_ValueChanged);
            // 
            // EndOfDayTime
            // 
            this.EndOfDayTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndOfDayTime.CustomFormat = "hh:mm:ss  tt";
            this.EndOfDayTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndOfDayTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EndOfDayTime.Location = new System.Drawing.Point(237, 155);
            this.EndOfDayTime.Name = "EndOfDayTime";
            this.EndOfDayTime.ShowUpDown = true;
            this.EndOfDayTime.Size = new System.Drawing.Size(145, 20);
            this.EndOfDayTime.TabIndex = 24;
            this.EndOfDayTime.ValueChanged += new System.EventHandler(this.EndOfDayTime_ValueChanged);
            // 
            // labelLunchStart
            // 
            this.labelLunchStart.AutoSize = true;
            this.labelLunchStart.Location = new System.Drawing.Point(154, 103);
            this.labelLunchStart.Name = "labelLunchStart";
            this.labelLunchStart.Size = new System.Drawing.Size(62, 13);
            this.labelLunchStart.TabIndex = 25;
            this.labelLunchStart.Text = "Lunch Start";
            // 
            // labelLunchEnd
            // 
            this.labelLunchEnd.AutoSize = true;
            this.labelLunchEnd.Location = new System.Drawing.Point(153, 129);
            this.labelLunchEnd.Name = "labelLunchEnd";
            this.labelLunchEnd.Size = new System.Drawing.Size(59, 13);
            this.labelLunchEnd.TabIndex = 26;
            this.labelLunchEnd.Text = "Lunch End";
            // 
            // labelEndofDay
            // 
            this.labelEndofDay.AutoSize = true;
            this.labelEndofDay.Location = new System.Drawing.Point(152, 155);
            this.labelEndofDay.Name = "labelEndofDay";
            this.labelEndofDay.Size = new System.Drawing.Size(60, 13);
            this.labelEndofDay.TabIndex = 27;
            this.labelEndofDay.Text = "End of Day";
            // 
            // labelTwoWeekCycle
            // 
            this.labelTwoWeekCycle.AutoSize = true;
            this.labelTwoWeekCycle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTwoWeekCycle.Location = new System.Drawing.Point(17, 224);
            this.labelTwoWeekCycle.Name = "labelTwoWeekCycle";
            this.labelTwoWeekCycle.Size = new System.Drawing.Size(112, 17);
            this.labelTwoWeekCycle.TabIndex = 28;
            this.labelTwoWeekCycle.Text = "Two Week Cycle";
            // 
            // checkBoxTwoWeekCycle
            // 
            this.checkBoxTwoWeekCycle.AutoSize = true;
            this.checkBoxTwoWeekCycle.Location = new System.Drawing.Point(157, 224);
            this.checkBoxTwoWeekCycle.Name = "checkBoxTwoWeekCycle";
            this.checkBoxTwoWeekCycle.Size = new System.Drawing.Size(40, 17);
            this.checkBoxTwoWeekCycle.TabIndex = 29;
            this.checkBoxTwoWeekCycle.Text = "On";
            this.checkBoxTwoWeekCycle.UseVisualStyleBackColor = true;
            this.checkBoxTwoWeekCycle.CheckedChanged += new System.EventHandler(this.checkBoxTwoWeekCycle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "* If enabled hours will be tracked on a two week pay cycle,\r\n   targeting 80 hour" +
    "s instead of 40 (default - on)";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(427, 399);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 31;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 434);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxTwoWeekCycle);
            this.Controls.Add(this.labelTwoWeekCycle);
            this.Controls.Add(this.labelEndofDay);
            this.Controls.Add(this.labelLunchEnd);
            this.Controls.Add(this.labelLunchStart);
            this.Controls.Add(this.StartOfDayTime);
            this.Controls.Add(this.LunchStartTime);
            this.Controls.Add(this.LunchEndTime);
            this.Controls.Add(this.EndOfDayTime);
            this.Controls.Add(this.labelStartofDay);
            this.Controls.Add(this.labelDefaultTimes);
            this.Controls.Add(this.labelSettingsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSettingsHeader;
        private System.Windows.Forms.Label labelDefaultTimes;
        private System.Windows.Forms.Label labelStartofDay;
        private System.Windows.Forms.DateTimePicker StartOfDayTime;
        private System.Windows.Forms.DateTimePicker LunchStartTime;
        private System.Windows.Forms.DateTimePicker LunchEndTime;
        private System.Windows.Forms.DateTimePicker EndOfDayTime;
        private System.Windows.Forms.Label labelLunchStart;
        private System.Windows.Forms.Label labelLunchEnd;
        private System.Windows.Forms.Label labelEndofDay;
        private System.Windows.Forms.Label labelTwoWeekCycle;
        private System.Windows.Forms.CheckBox checkBoxTwoWeekCycle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
    }
}