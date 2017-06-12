namespace hourCalc
{
    partial class hourCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hourCalc));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTue = new System.Windows.Forms.Label();
            this.labelWed = new System.Windows.Forms.Label();
            this.labelThu = new System.Windows.Forms.Label();
            this.labelFri = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelLunchStart = new System.Windows.Forms.Label();
            this.labelLunchEnd = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelMon = new System.Windows.Forms.Label();
            this.monStartTime = new System.Windows.Forms.DateTimePicker();
            this.tueStartTime = new System.Windows.Forms.DateTimePicker();
            this.wedStartTime = new System.Windows.Forms.DateTimePicker();
            this.thuStartTime = new System.Windows.Forms.DateTimePicker();
            this.friStartTime = new System.Windows.Forms.DateTimePicker();
            this.monLunchStartTime = new System.Windows.Forms.DateTimePicker();
            this.tueLunchStartTime = new System.Windows.Forms.DateTimePicker();
            this.wedLunchStartTime = new System.Windows.Forms.DateTimePicker();
            this.thuLunchStartTime = new System.Windows.Forms.DateTimePicker();
            this.friLunchStartTime = new System.Windows.Forms.DateTimePicker();
            this.monLunchEndTime = new System.Windows.Forms.DateTimePicker();
            this.tueLunchEndTime = new System.Windows.Forms.DateTimePicker();
            this.wedLunchEndTime = new System.Windows.Forms.DateTimePicker();
            this.thuLunchEndTime = new System.Windows.Forms.DateTimePicker();
            this.friLunchEndTime = new System.Windows.Forms.DateTimePicker();
            this.monEndTime = new System.Windows.Forms.DateTimePicker();
            this.tueEndTime = new System.Windows.Forms.DateTimePicker();
            this.wedEndTime = new System.Windows.Forms.DateTimePicker();
            this.thuEndTime = new System.Windows.Forms.DateTimePicker();
            this.friEndTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSelectDay = new System.Windows.Forms.ComboBox();
            this.buttonCalcDay = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCalcWeek = new System.Windows.Forms.Button();
            this.calcDprtDayOutput = new System.Windows.Forms.TextBox();
            this.calcDprtFriOutput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCalcDprtDay = new System.Windows.Forms.Label();
            this.labelCalcDprtFri = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.labelCarryOverHours = new System.Windows.Forms.Label();
            this.textBoxCarryOverHours = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66944F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelTue, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelWed, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelThu, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFri, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelStart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLunchStart, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelLunchEnd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelEnd, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelMon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.monStartTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tueStartTime, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.wedStartTime, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.thuStartTime, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.friStartTime, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.monLunchStartTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tueLunchStartTime, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.wedLunchStartTime, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.thuLunchStartTime, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.friLunchStartTime, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.monLunchEndTime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tueLunchEndTime, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.wedLunchEndTime, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.thuLunchEndTime, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.friLunchEndTime, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.monEndTime, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tueEndTime, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.wedEndTime, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.thuEndTime, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.friEndTime, 5, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(399, 216);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 517);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelTue
            // 
            this.labelTue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTue.AutoSize = true;
            this.labelTue.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTue.Location = new System.Drawing.Point(337, 40);
            this.labelTue.Name = "labelTue";
            this.labelTue.Size = new System.Drawing.Size(94, 24);
            this.labelTue.TabIndex = 10;
            this.labelTue.Text = "Tuesday";
            // 
            // labelWed
            // 
            this.labelWed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWed.AutoSize = true;
            this.labelWed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWed.Location = new System.Drawing.Point(473, 40);
            this.labelWed.Name = "labelWed";
            this.labelWed.Size = new System.Drawing.Size(129, 24);
            this.labelWed.TabIndex = 11;
            this.labelWed.Text = "Wednesday";
            // 
            // labelThu
            // 
            this.labelThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelThu.AutoSize = true;
            this.labelThu.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThu.Location = new System.Drawing.Point(638, 40);
            this.labelThu.Name = "labelThu";
            this.labelThu.Size = new System.Drawing.Size(105, 24);
            this.labelThu.TabIndex = 12;
            this.labelThu.Text = "Thursday";
            // 
            // labelFri
            // 
            this.labelFri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFri.AutoSize = true;
            this.labelFri.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFri.Location = new System.Drawing.Point(810, 40);
            this.labelFri.Name = "labelFri";
            this.labelFri.Size = new System.Drawing.Size(72, 24);
            this.labelFri.TabIndex = 13;
            this.labelFri.Text = "Friday";
            // 
            // labelStart
            // 
            this.labelStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(14, 143);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(128, 24);
            this.labelStart.TabIndex = 15;
            this.labelStart.Text = "Start of Day";
            // 
            // labelLunchStart
            // 
            this.labelLunchStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLunchStart.AutoSize = true;
            this.labelLunchStart.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunchStart.Location = new System.Drawing.Point(14, 246);
            this.labelLunchStart.Name = "labelLunchStart";
            this.labelLunchStart.Size = new System.Drawing.Size(128, 24);
            this.labelLunchStart.TabIndex = 16;
            this.labelLunchStart.Text = "Lunch Start";
            // 
            // labelLunchEnd
            // 
            this.labelLunchEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLunchEnd.AutoSize = true;
            this.labelLunchEnd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunchEnd.Location = new System.Drawing.Point(18, 349);
            this.labelLunchEnd.Name = "labelLunchEnd";
            this.labelLunchEnd.Size = new System.Drawing.Size(120, 24);
            this.labelLunchEnd.TabIndex = 17;
            this.labelLunchEnd.Text = "Lunch End";
            // 
            // labelEnd
            // 
            this.labelEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnd.AutoSize = true;
            this.labelEnd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnd.Location = new System.Drawing.Point(18, 452);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(120, 24);
            this.labelEnd.TabIndex = 18;
            this.labelEnd.Text = "End of Day";
            // 
            // labelMon
            // 
            this.labelMon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMon.AutoSize = true;
            this.labelMon.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMon.Location = new System.Drawing.Point(187, 40);
            this.labelMon.Name = "labelMon";
            this.labelMon.Size = new System.Drawing.Size(89, 24);
            this.labelMon.TabIndex = 9;
            this.labelMon.Text = "Monday";
            // 
            // monStartTime
            // 
            this.monStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monStartTime.CustomFormat = "hh:mm:ss  tt";
            this.monStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monStartTime.Location = new System.Drawing.Point(159, 145);
            this.monStartTime.Name = "monStartTime";
            this.monStartTime.ShowUpDown = true;
            this.monStartTime.Size = new System.Drawing.Size(145, 20);
            this.monStartTime.TabIndex = 20;
            // 
            // tueStartTime
            // 
            this.tueStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tueStartTime.CustomFormat = "hh:mm:ss  tt";
            this.tueStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tueStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tueStartTime.Location = new System.Drawing.Point(312, 145);
            this.tueStartTime.Name = "tueStartTime";
            this.tueStartTime.ShowUpDown = true;
            this.tueStartTime.Size = new System.Drawing.Size(145, 20);
            this.tueStartTime.TabIndex = 19;
            // 
            // wedStartTime
            // 
            this.wedStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wedStartTime.CustomFormat = "hh:mm:ss  tt";
            this.wedStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.wedStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wedStartTime.Location = new System.Drawing.Point(465, 145);
            this.wedStartTime.Name = "wedStartTime";
            this.wedStartTime.ShowUpDown = true;
            this.wedStartTime.Size = new System.Drawing.Size(145, 20);
            this.wedStartTime.TabIndex = 21;
            // 
            // thuStartTime
            // 
            this.thuStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thuStartTime.CustomFormat = "hh:mm:ss  tt";
            this.thuStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.thuStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.thuStartTime.Location = new System.Drawing.Point(618, 145);
            this.thuStartTime.Name = "thuStartTime";
            this.thuStartTime.ShowUpDown = true;
            this.thuStartTime.Size = new System.Drawing.Size(145, 20);
            this.thuStartTime.TabIndex = 20;
            // 
            // friStartTime
            // 
            this.friStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.friStartTime.CustomFormat = "hh:mm:ss  tt";
            this.friStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.friStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.friStartTime.Location = new System.Drawing.Point(773, 145);
            this.friStartTime.Name = "friStartTime";
            this.friStartTime.ShowUpDown = true;
            this.friStartTime.Size = new System.Drawing.Size(145, 20);
            this.friStartTime.TabIndex = 22;
            // 
            // monLunchStartTime
            // 
            this.monLunchStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monLunchStartTime.CustomFormat = "hh:mm:ss  tt";
            this.monLunchStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monLunchStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monLunchStartTime.Location = new System.Drawing.Point(159, 248);
            this.monLunchStartTime.Name = "monLunchStartTime";
            this.monLunchStartTime.ShowUpDown = true;
            this.monLunchStartTime.Size = new System.Drawing.Size(145, 20);
            this.monLunchStartTime.TabIndex = 23;
            // 
            // tueLunchStartTime
            // 
            this.tueLunchStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tueLunchStartTime.CustomFormat = "hh:mm:ss  tt";
            this.tueLunchStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tueLunchStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tueLunchStartTime.Location = new System.Drawing.Point(312, 248);
            this.tueLunchStartTime.Name = "tueLunchStartTime";
            this.tueLunchStartTime.ShowUpDown = true;
            this.tueLunchStartTime.Size = new System.Drawing.Size(145, 20);
            this.tueLunchStartTime.TabIndex = 24;
            // 
            // wedLunchStartTime
            // 
            this.wedLunchStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wedLunchStartTime.CustomFormat = "hh:mm:ss  tt";
            this.wedLunchStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.wedLunchStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wedLunchStartTime.Location = new System.Drawing.Point(465, 248);
            this.wedLunchStartTime.Name = "wedLunchStartTime";
            this.wedLunchStartTime.ShowUpDown = true;
            this.wedLunchStartTime.Size = new System.Drawing.Size(145, 20);
            this.wedLunchStartTime.TabIndex = 25;
            // 
            // thuLunchStartTime
            // 
            this.thuLunchStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thuLunchStartTime.CustomFormat = "hh:mm:ss  tt";
            this.thuLunchStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.thuLunchStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.thuLunchStartTime.Location = new System.Drawing.Point(618, 248);
            this.thuLunchStartTime.Name = "thuLunchStartTime";
            this.thuLunchStartTime.ShowUpDown = true;
            this.thuLunchStartTime.Size = new System.Drawing.Size(145, 20);
            this.thuLunchStartTime.TabIndex = 26;
            // 
            // friLunchStartTime
            // 
            this.friLunchStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.friLunchStartTime.CustomFormat = "hh:mm:ss  tt";
            this.friLunchStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.friLunchStartTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.friLunchStartTime.Location = new System.Drawing.Point(773, 248);
            this.friLunchStartTime.Name = "friLunchStartTime";
            this.friLunchStartTime.ShowUpDown = true;
            this.friLunchStartTime.Size = new System.Drawing.Size(145, 20);
            this.friLunchStartTime.TabIndex = 27;
            // 
            // monLunchEndTime
            // 
            this.monLunchEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monLunchEndTime.CustomFormat = "hh:mm:ss  tt";
            this.monLunchEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monLunchEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monLunchEndTime.Location = new System.Drawing.Point(159, 351);
            this.monLunchEndTime.Name = "monLunchEndTime";
            this.monLunchEndTime.ShowUpDown = true;
            this.monLunchEndTime.Size = new System.Drawing.Size(145, 20);
            this.monLunchEndTime.TabIndex = 28;
            // 
            // tueLunchEndTime
            // 
            this.tueLunchEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tueLunchEndTime.CustomFormat = "hh:mm:ss  tt";
            this.tueLunchEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tueLunchEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tueLunchEndTime.Location = new System.Drawing.Point(312, 351);
            this.tueLunchEndTime.Name = "tueLunchEndTime";
            this.tueLunchEndTime.ShowUpDown = true;
            this.tueLunchEndTime.Size = new System.Drawing.Size(145, 20);
            this.tueLunchEndTime.TabIndex = 29;
            // 
            // wedLunchEndTime
            // 
            this.wedLunchEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wedLunchEndTime.CustomFormat = "hh:mm:ss  tt";
            this.wedLunchEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.wedLunchEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wedLunchEndTime.Location = new System.Drawing.Point(465, 351);
            this.wedLunchEndTime.Name = "wedLunchEndTime";
            this.wedLunchEndTime.ShowUpDown = true;
            this.wedLunchEndTime.Size = new System.Drawing.Size(145, 20);
            this.wedLunchEndTime.TabIndex = 30;
            // 
            // thuLunchEndTime
            // 
            this.thuLunchEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thuLunchEndTime.CustomFormat = "hh:mm:ss  tt";
            this.thuLunchEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.thuLunchEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.thuLunchEndTime.Location = new System.Drawing.Point(618, 351);
            this.thuLunchEndTime.Name = "thuLunchEndTime";
            this.thuLunchEndTime.ShowUpDown = true;
            this.thuLunchEndTime.Size = new System.Drawing.Size(145, 20);
            this.thuLunchEndTime.TabIndex = 31;
            // 
            // friLunchEndTime
            // 
            this.friLunchEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.friLunchEndTime.CustomFormat = "hh:mm:ss  tt";
            this.friLunchEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.friLunchEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.friLunchEndTime.Location = new System.Drawing.Point(773, 351);
            this.friLunchEndTime.Name = "friLunchEndTime";
            this.friLunchEndTime.ShowUpDown = true;
            this.friLunchEndTime.Size = new System.Drawing.Size(145, 20);
            this.friLunchEndTime.TabIndex = 32;
            // 
            // monEndTime
            // 
            this.monEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monEndTime.CustomFormat = "hh:mm:ss  tt";
            this.monEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.monEndTime.Location = new System.Drawing.Point(159, 454);
            this.monEndTime.Name = "monEndTime";
            this.monEndTime.ShowUpDown = true;
            this.monEndTime.Size = new System.Drawing.Size(145, 20);
            this.monEndTime.TabIndex = 33;
            // 
            // tueEndTime
            // 
            this.tueEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tueEndTime.CustomFormat = "hh:mm:ss  tt";
            this.tueEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tueEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tueEndTime.Location = new System.Drawing.Point(312, 454);
            this.tueEndTime.Name = "tueEndTime";
            this.tueEndTime.ShowUpDown = true;
            this.tueEndTime.Size = new System.Drawing.Size(145, 20);
            this.tueEndTime.TabIndex = 34;
            // 
            // wedEndTime
            // 
            this.wedEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wedEndTime.CustomFormat = "hh:mm:ss  tt";
            this.wedEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.wedEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wedEndTime.Location = new System.Drawing.Point(465, 454);
            this.wedEndTime.Name = "wedEndTime";
            this.wedEndTime.ShowUpDown = true;
            this.wedEndTime.Size = new System.Drawing.Size(145, 20);
            this.wedEndTime.TabIndex = 35;
            // 
            // thuEndTime
            // 
            this.thuEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thuEndTime.CustomFormat = "hh:mm:ss  tt";
            this.thuEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.thuEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.thuEndTime.Location = new System.Drawing.Point(618, 454);
            this.thuEndTime.Name = "thuEndTime";
            this.thuEndTime.ShowUpDown = true;
            this.thuEndTime.Size = new System.Drawing.Size(145, 20);
            this.thuEndTime.TabIndex = 36;
            // 
            // friEndTime
            // 
            this.friEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.friEndTime.CustomFormat = "hh:mm:ss  tt";
            this.friEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.friEndTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.friEndTime.Location = new System.Drawing.Point(773, 454);
            this.friEndTime.Name = "friEndTime";
            this.friEndTime.ShowUpDown = true;
            this.friEndTime.Size = new System.Drawing.Size(145, 20);
            this.friEndTime.TabIndex = 37;
            // 
            // comboBoxSelectDay
            // 
            this.comboBoxSelectDay.DisplayMember = "(none)";
            this.comboBoxSelectDay.FormattingEnabled = true;
            this.comboBoxSelectDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.comboBoxSelectDay.Location = new System.Drawing.Point(248, 364);
            this.comboBoxSelectDay.Name = "comboBoxSelectDay";
            this.comboBoxSelectDay.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectDay.TabIndex = 2;
            this.comboBoxSelectDay.Text = "Monday";
            // 
            // buttonCalcDay
            // 
            this.buttonCalcDay.Location = new System.Drawing.Point(54, 449);
            this.buttonCalcDay.Name = "buttonCalcDay";
            this.buttonCalcDay.Size = new System.Drawing.Size(120, 35);
            this.buttonCalcDay.TabIndex = 3;
            this.buttonCalcDay.Text = "Calculate";
            this.buttonCalcDay.UseVisualStyleBackColor = true;
            this.buttonCalcDay.Click += new System.EventHandler(this.buttonCalcDay_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(1116, 773);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(209, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save Data";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCalcWeek
            // 
            this.buttonCalcWeek.Location = new System.Drawing.Point(54, 657);
            this.buttonCalcWeek.Name = "buttonCalcWeek";
            this.buttonCalcWeek.Size = new System.Drawing.Size(120, 35);
            this.buttonCalcWeek.TabIndex = 5;
            this.buttonCalcWeek.Text = "Calculate";
            this.buttonCalcWeek.UseVisualStyleBackColor = true;
            this.buttonCalcWeek.Click += new System.EventHandler(this.buttonCalcWeek_Click);
            // 
            // calcDprtDayOutput
            // 
            this.calcDprtDayOutput.BackColor = System.Drawing.SystemColors.Window;
            this.calcDprtDayOutput.Location = new System.Drawing.Point(234, 449);
            this.calcDprtDayOutput.Multiline = true;
            this.calcDprtDayOutput.Name = "calcDprtDayOutput";
            this.calcDprtDayOutput.ReadOnly = true;
            this.calcDprtDayOutput.Size = new System.Drawing.Size(135, 30);
            this.calcDprtDayOutput.TabIndex = 6;
            // 
            // calcDprtFriOutput
            // 
            this.calcDprtFriOutput.BackColor = System.Drawing.SystemColors.Window;
            this.calcDprtFriOutput.Location = new System.Drawing.Point(234, 657);
            this.calcDprtFriOutput.Multiline = true;
            this.calcDprtFriOutput.Name = "calcDprtFriOutput";
            this.calcDprtFriOutput.ReadOnly = true;
            this.calcDprtFriOutput.Size = new System.Drawing.Size(135, 30);
            this.calcDprtFriOutput.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(324, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 148);
            this.panel1.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(350, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(403, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Doble Hour Calculator";
            // 
            // labelCalcDprtDay
            // 
            this.labelCalcDprtDay.AutoSize = true;
            this.labelCalcDprtDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalcDprtDay.Location = new System.Drawing.Point(12, 367);
            this.labelCalcDprtDay.Name = "labelCalcDprtDay";
            this.labelCalcDprtDay.Size = new System.Drawing.Size(216, 16);
            this.labelCalcDprtDay.TabIndex = 9;
            this.labelCalcDprtDay.Text = "Calculate Departure Time For:";
            // 
            // labelCalcDprtFri
            // 
            this.labelCalcDprtFri.AutoSize = true;
            this.labelCalcDprtFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalcDprtFri.Location = new System.Drawing.Point(12, 573);
            this.labelCalcDprtFri.Name = "labelCalcDprtFri";
            this.labelCalcDprtFri.Size = new System.Drawing.Size(237, 16);
            this.labelCalcDprtFri.TabIndex = 10;
            this.labelCalcDprtFri.Text = "Calculate Friday Departure Time:";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(876, 773);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(150, 23);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear Table";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.Location = new System.Drawing.Point(682, 773);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(150, 23);
            this.buttonSettings.TabIndex = 12;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ConfigButton_Click);
            // 
            // labelCarryOverHours
            // 
            this.labelCarryOverHours.AutoSize = true;
            this.labelCarryOverHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarryOverHours.Location = new System.Drawing.Point(12, 216);
            this.labelCarryOverHours.Name = "labelCarryOverHours";
            this.labelCarryOverHours.Size = new System.Drawing.Size(130, 16);
            this.labelCarryOverHours.TabIndex = 13;
            this.labelCarryOverHours.Text = "Last Week Hours:";
            // 
            // textBoxCarryOverHours
            // 
            this.textBoxCarryOverHours.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCarryOverHours.Location = new System.Drawing.Point(54, 261);
            this.textBoxCarryOverHours.Multiline = true;
            this.textBoxCarryOverHours.Name = "textBoxCarryOverHours";
            this.textBoxCarryOverHours.ReadOnly = true;
            this.textBoxCarryOverHours.Size = new System.Drawing.Size(135, 30);
            this.textBoxCarryOverHours.TabIndex = 14;
            // 
            // hourCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1415, 821);
            this.Controls.Add(this.textBoxCarryOverHours);
            this.Controls.Add(this.labelCarryOverHours);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelCalcDprtFri);
            this.Controls.Add(this.labelCalcDprtDay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calcDprtFriOutput);
            this.Controls.Add(this.calcDprtDayOutput);
            this.Controls.Add(this.buttonCalcWeek);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCalcDay);
            this.Controls.Add(this.comboBoxSelectDay);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "hourCalc";
            this.Text = "Doble Hour Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxSelectDay;
        private System.Windows.Forms.Button buttonCalcDay;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCalcWeek;
        private System.Windows.Forms.TextBox calcDprtDayOutput;
        private System.Windows.Forms.TextBox calcDprtFriOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelLunchEnd;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelLunchStart;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelFri;
        private System.Windows.Forms.Label labelThu;
        private System.Windows.Forms.Label labelWed;
        private System.Windows.Forms.Label labelTue;
        private System.Windows.Forms.Label labelMon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCalcDprtDay;
        private System.Windows.Forms.Label labelCalcDprtFri;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DateTimePicker monStartTime;
        private System.Windows.Forms.DateTimePicker tueStartTime;
        private System.Windows.Forms.DateTimePicker wedStartTime;
        private System.Windows.Forms.DateTimePicker thuStartTime;
        private System.Windows.Forms.DateTimePicker friStartTime;
        private System.Windows.Forms.DateTimePicker monLunchStartTime;
        private System.Windows.Forms.DateTimePicker tueLunchStartTime;
        private System.Windows.Forms.DateTimePicker wedLunchStartTime;
        private System.Windows.Forms.DateTimePicker thuLunchStartTime;
        private System.Windows.Forms.DateTimePicker friLunchStartTime;
        private System.Windows.Forms.DateTimePicker monLunchEndTime;
        private System.Windows.Forms.DateTimePicker tueLunchEndTime;
        private System.Windows.Forms.DateTimePicker wedLunchEndTime;
        private System.Windows.Forms.DateTimePicker thuLunchEndTime;
        private System.Windows.Forms.DateTimePicker friLunchEndTime;
        private System.Windows.Forms.DateTimePicker monEndTime;
        private System.Windows.Forms.DateTimePicker tueEndTime;
        private System.Windows.Forms.DateTimePicker wedEndTime;
        private System.Windows.Forms.DateTimePicker thuEndTime;
        private System.Windows.Forms.DateTimePicker friEndTime;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Label labelCarryOverHours;
        private System.Windows.Forms.TextBox textBoxCarryOverHours;
    }
}

