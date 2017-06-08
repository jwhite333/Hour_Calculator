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
            this.monStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
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
            // monStartTime
            // 
            this.monStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monStartTime.CustomFormat = "hh:mm:ss  tt";
            this.monStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monStartTime.Location = new System.Drawing.Point(237, 77);
            this.monStartTime.Name = "monStartTime";
            this.monStartTime.ShowUpDown = true;
            this.monStartTime.Size = new System.Drawing.Size(145, 20);
            this.monStartTime.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "hh:mm:ss  tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.CustomFormat = "hh:mm:ss  tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker2.Location = new System.Drawing.Point(237, 129);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker3.CustomFormat = "hh:mm:ss  tt";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker3.Location = new System.Drawing.Point(237, 155);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.ShowUpDown = true;
            this.dateTimePicker3.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker3.TabIndex = 24;
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
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monStartTime);
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
        private System.Windows.Forms.DateTimePicker monStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label labelLunchStart;
        private System.Windows.Forms.Label labelLunchEnd;
        private System.Windows.Forms.Label labelEndofDay;
        private System.Windows.Forms.Label labelTwoWeekCycle;
        private System.Windows.Forms.CheckBox checkBoxTwoWeekCycle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
    }
}