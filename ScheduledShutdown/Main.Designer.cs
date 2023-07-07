namespace ScheduledShutdown
{
    partial class Main
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip1 = new StatusStrip();
            mainToolStripStatusLabel2 = new ToolStripStatusLabel();
            mainToolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1 = new Panel();
            titleLabel = new Label();
            mainTabControl = new TabControl();
            tabPage1 = new TabPage();
            scheduleGroupBox = new GroupBox();
            scheduleGridView = new DataGridView();
            noteColumn = new DataGridViewTextBoxColumn();
            startColumn = new DataGridViewTextBoxColumn();
            endColumn = new DataGridViewTextBoxColumn();
            shutdownGroupBox = new GroupBox();
            disableCheckBox = new CheckBox();
            helpLabel1 = new Label();
            shutdownAlertCheckBox = new CheckBox();
            shutdownBeforeAfterUpDown = new NumericUpDown();
            shutdownBeforeLabel = new Label();
            shutdownTimePicker = new DateTimePicker();
            shutdownTimeLabel = new Label();
            shutdownDateLabel = new Label();
            shutdownDatePicker = new DateTimePicker();
            tabPage2 = new TabPage();
            addToStartupCheckBox = new CheckBox();
            espInstructionLabel = new Label();
            espSettingsGroupBox = new GroupBox();
            espSearchButton = new Button();
            espAreaListBox = new ListBox();
            espLookUpTextBox = new TextBox();
            espCheckAreaButton = new Button();
            areaLabel = new Label();
            espFreqNumericUpDown = new NumericUpDown();
            espFrequencyLabel = new Label();
            espTokenTextBox = new TextBox();
            espTokenLabel = new Label();
            espUseCheckBox = new CheckBox();
            espLinkLabel = new LinkLabel();
            mainTimer = new System.Windows.Forms.Timer(components);
            eskomTimer = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            mainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            scheduleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).BeginInit();
            shutdownGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shutdownBeforeAfterUpDown).BeginInit();
            tabPage2.SuspendLayout();
            espSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)espFreqNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.GripStyle = ToolStripGripStyle.Visible;
            statusStrip1.Items.AddRange(new ToolStripItem[] { mainToolStripStatusLabel2, mainToolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 426);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(801, 24);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "mainStatusStrip";
            // 
            // mainToolStripStatusLabel2
            // 
            mainToolStripStatusLabel2.AutoSize = false;
            mainToolStripStatusLabel2.BorderSides = ToolStripStatusLabelBorderSides.Right;
            mainToolStripStatusLabel2.ForeColor = Color.SteelBlue;
            mainToolStripStatusLabel2.Name = "mainToolStripStatusLabel2";
            mainToolStripStatusLabel2.Size = new Size(200, 19);
            mainToolStripStatusLabel2.Text = "Timer";
            mainToolStripStatusLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mainToolStripStatusLabel1
            // 
            mainToolStripStatusLabel1.Name = "mainToolStripStatusLabel1";
            mainToolStripStatusLabel1.Size = new Size(586, 19);
            mainToolStripStatusLabel1.Spring = true;
            mainToolStripStatusLabel1.Text = "Status";
            mainToolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(titleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 66);
            panel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.WhiteSmoke;
            titleLabel.Location = new Point(11, 9);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(336, 45);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Scheduled Shutdown";
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPage1);
            mainTabControl.Controls.Add(tabPage2);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 66);
            mainTabControl.Margin = new Padding(31, 30, 31, 30);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.Padding = new Point(6, 10);
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(801, 360);
            mainTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(scheduleGroupBox);
            tabPage1.Controls.Add(shutdownGroupBox);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(793, 318);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Shutdown";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // scheduleGroupBox
            // 
            scheduleGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            scheduleGroupBox.Controls.Add(scheduleGridView);
            scheduleGroupBox.Location = new Point(4, 149);
            scheduleGroupBox.Margin = new Padding(4, 3, 4, 3);
            scheduleGroupBox.Name = "scheduleGroupBox";
            scheduleGroupBox.Padding = new Padding(4, 3, 4, 3);
            scheduleGroupBox.Size = new Size(787, 163);
            scheduleGroupBox.TabIndex = 4;
            scheduleGroupBox.TabStop = false;
            scheduleGroupBox.Text = "Eskom Schedule";
            // 
            // scheduleGridView
            // 
            scheduleGridView.AllowUserToAddRows = false;
            scheduleGridView.AllowUserToDeleteRows = false;
            scheduleGridView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            scheduleGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            scheduleGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scheduleGridView.Columns.AddRange(new DataGridViewColumn[] { noteColumn, startColumn, endColumn });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            scheduleGridView.DefaultCellStyle = dataGridViewCellStyle2;
            scheduleGridView.Dock = DockStyle.Fill;
            scheduleGridView.Location = new Point(4, 19);
            scheduleGridView.Margin = new Padding(4, 3, 4, 3);
            scheduleGridView.Name = "scheduleGridView";
            scheduleGridView.ReadOnly = true;
            scheduleGridView.RowTemplate.Height = 25;
            scheduleGridView.Size = new Size(779, 141);
            scheduleGridView.TabIndex = 0;
            // 
            // noteColumn
            // 
            noteColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            noteColumn.DataPropertyName = "Note";
            noteColumn.HeaderText = "Note";
            noteColumn.MinimumWidth = 250;
            noteColumn.Name = "noteColumn";
            noteColumn.ReadOnly = true;
            // 
            // startColumn
            // 
            startColumn.DataPropertyName = "Start";
            startColumn.HeaderText = "Start";
            startColumn.MinimumWidth = 150;
            startColumn.Name = "startColumn";
            startColumn.ReadOnly = true;
            startColumn.Width = 150;
            // 
            // endColumn
            // 
            endColumn.DataPropertyName = "End";
            endColumn.HeaderText = "End";
            endColumn.MinimumWidth = 150;
            endColumn.Name = "endColumn";
            endColumn.ReadOnly = true;
            endColumn.Width = 150;
            // 
            // shutdownGroupBox
            // 
            shutdownGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            shutdownGroupBox.Controls.Add(disableCheckBox);
            shutdownGroupBox.Controls.Add(helpLabel1);
            shutdownGroupBox.Controls.Add(shutdownAlertCheckBox);
            shutdownGroupBox.Controls.Add(shutdownBeforeAfterUpDown);
            shutdownGroupBox.Controls.Add(shutdownBeforeLabel);
            shutdownGroupBox.Controls.Add(shutdownTimePicker);
            shutdownGroupBox.Controls.Add(shutdownTimeLabel);
            shutdownGroupBox.Controls.Add(shutdownDateLabel);
            shutdownGroupBox.Controls.Add(shutdownDatePicker);
            shutdownGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            shutdownGroupBox.Location = new Point(4, 3);
            shutdownGroupBox.Margin = new Padding(4, 3, 4, 3);
            shutdownGroupBox.Name = "shutdownGroupBox";
            shutdownGroupBox.Padding = new Padding(4, 3, 4, 3);
            shutdownGroupBox.Size = new Size(787, 140);
            shutdownGroupBox.TabIndex = 3;
            shutdownGroupBox.TabStop = false;
            shutdownGroupBox.Text = "Next Shutdown";
            // 
            // disableCheckBox
            // 
            disableCheckBox.AutoSize = true;
            disableCheckBox.Location = new Point(467, 31);
            disableCheckBox.Name = "disableCheckBox";
            disableCheckBox.Size = new Size(129, 19);
            disableCheckBox.TabIndex = 8;
            disableCheckBox.Text = "Disable shutdowns";
            disableCheckBox.UseVisualStyleBackColor = true;
            disableCheckBox.CheckedChanged += DisableCheckBox_CheckedChanged;
            // 
            // helpLabel1
            // 
            helpLabel1.AutoSize = true;
            helpLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            helpLabel1.ForeColor = Color.Teal;
            helpLabel1.Location = new Point(220, 65);
            helpLabel1.Margin = new Padding(4, 0, 4, 0);
            helpLabel1.Name = "helpLabel1";
            helpLabel1.Size = new Size(261, 15);
            helpLabel1.TabIndex = 7;
            helpLabel1.Text = "Allow some leeway on the shutdown time + or -";
            // 
            // shutdownAlertCheckBox
            // 
            shutdownAlertCheckBox.AutoSize = true;
            shutdownAlertCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            shutdownAlertCheckBox.Location = new Point(24, 95);
            shutdownAlertCheckBox.Margin = new Padding(4, 3, 4, 3);
            shutdownAlertCheckBox.Name = "shutdownAlertCheckBox";
            shutdownAlertCheckBox.Size = new Size(163, 19);
            shutdownAlertCheckBox.TabIndex = 6;
            shutdownAlertCheckBox.Text = "Alert me 5 minutes before";
            shutdownAlertCheckBox.UseVisualStyleBackColor = true;
            shutdownAlertCheckBox.CheckedChanged += ShutdownAlertCheckBox_CheckedChanged;
            // 
            // shutdownBeforeAfterUpDown
            // 
            shutdownBeforeAfterUpDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            shutdownBeforeAfterUpDown.Location = new Point(150, 61);
            shutdownBeforeAfterUpDown.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            shutdownBeforeAfterUpDown.Minimum = new decimal(new int[] { 30, 0, 0, int.MinValue });
            shutdownBeforeAfterUpDown.Name = "shutdownBeforeAfterUpDown";
            shutdownBeforeAfterUpDown.Size = new Size(56, 23);
            shutdownBeforeAfterUpDown.TabIndex = 5;
            shutdownBeforeAfterUpDown.TextAlign = HorizontalAlignment.Center;
            shutdownBeforeAfterUpDown.ValueChanged += ShutdownBeforeAfterUpDown_ValueChanged;
            // 
            // shutdownBeforeLabel
            // 
            shutdownBeforeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            shutdownBeforeLabel.Location = new Point(6, 60);
            shutdownBeforeLabel.Margin = new Padding(4, 0, 4, 0);
            shutdownBeforeLabel.Name = "shutdownBeforeLabel";
            shutdownBeforeLabel.Size = new Size(137, 23);
            shutdownBeforeLabel.TabIndex = 4;
            shutdownBeforeLabel.Text = "Minutes Before/After";
            shutdownBeforeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // shutdownTimePicker
            // 
            shutdownTimePicker.CustomFormat = " HH:mm";
            shutdownTimePicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            shutdownTimePicker.Format = DateTimePickerFormat.Custom;
            shutdownTimePicker.Location = new Point(346, 30);
            shutdownTimePicker.Margin = new Padding(4, 3, 4, 3);
            shutdownTimePicker.Name = "shutdownTimePicker";
            shutdownTimePicker.ShowUpDown = true;
            shutdownTimePicker.Size = new Size(78, 23);
            shutdownTimePicker.TabIndex = 3;
            shutdownTimePicker.Value = new DateTime(2023, 7, 4, 0, 0, 0, 0);
            shutdownTimePicker.ValueChanged += ShutdownTimePicker_ValueChanged;
            // 
            // shutdownTimeLabel
            // 
            shutdownTimeLabel.AutoSize = true;
            shutdownTimeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            shutdownTimeLabel.Location = new Point(304, 34);
            shutdownTimeLabel.Margin = new Padding(4, 0, 4, 0);
            shutdownTimeLabel.Name = "shutdownTimeLabel";
            shutdownTimeLabel.Size = new Size(35, 15);
            shutdownTimeLabel.TabIndex = 2;
            shutdownTimeLabel.Text = "Time";
            shutdownTimeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // shutdownDateLabel
            // 
            shutdownDateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            shutdownDateLabel.Location = new Point(6, 30);
            shutdownDateLabel.Margin = new Padding(4, 0, 4, 0);
            shutdownDateLabel.Name = "shutdownDateLabel";
            shutdownDateLabel.Size = new Size(137, 23);
            shutdownDateLabel.TabIndex = 1;
            shutdownDateLabel.Text = "Scheduled Date";
            shutdownDateLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // shutdownDatePicker
            // 
            shutdownDatePicker.CustomFormat = " yyyy/MM/dd";
            shutdownDatePicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            shutdownDatePicker.Format = DateTimePickerFormat.Custom;
            shutdownDatePicker.Location = new Point(150, 30);
            shutdownDatePicker.Margin = new Padding(4, 3, 4, 3);
            shutdownDatePicker.Name = "shutdownDatePicker";
            shutdownDatePicker.Size = new Size(133, 23);
            shutdownDatePicker.TabIndex = 0;
            shutdownDatePicker.Value = new DateTime(2023, 7, 4, 0, 0, 0, 0);
            shutdownDatePicker.ValueChanged += ShutdownDatePicker_ValueChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(addToStartupCheckBox);
            tabPage2.Controls.Add(espInstructionLabel);
            tabPage2.Controls.Add(espSettingsGroupBox);
            tabPage2.Controls.Add(espUseCheckBox);
            tabPage2.Controls.Add(espLinkLabel);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(793, 318);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // addToStartupCheckBox
            // 
            addToStartupCheckBox.AutoSize = true;
            addToStartupCheckBox.Location = new Point(167, 19);
            addToStartupCheckBox.Margin = new Padding(4, 3, 4, 3);
            addToStartupCheckBox.Name = "addToStartupCheckBox";
            addToStartupCheckBox.Size = new Size(151, 19);
            addToStartupCheckBox.TabIndex = 10;
            addToStartupCheckBox.Text = "Add program to startup";
            addToStartupCheckBox.UseVisualStyleBackColor = true;
            addToStartupCheckBox.CheckedChanged += AddToStartupCheckBox_CheckedChanged;
            // 
            // espInstructionLabel
            // 
            espInstructionLabel.AutoSize = true;
            espInstructionLabel.ForeColor = Color.Teal;
            espInstructionLabel.Location = new Point(28, 288);
            espInstructionLabel.Margin = new Padding(4, 0, 4, 0);
            espInstructionLabel.Name = "espInstructionLabel";
            espInstructionLabel.Size = new Size(401, 15);
            espInstructionLabel.TabIndex = 7;
            espInstructionLabel.Text = "To auto receive Eskom's load shedding schedule, you need  an ESP API key.";
            // 
            // espSettingsGroupBox
            // 
            espSettingsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            espSettingsGroupBox.Controls.Add(espSearchButton);
            espSettingsGroupBox.Controls.Add(espAreaListBox);
            espSettingsGroupBox.Controls.Add(espLookUpTextBox);
            espSettingsGroupBox.Controls.Add(espCheckAreaButton);
            espSettingsGroupBox.Controls.Add(areaLabel);
            espSettingsGroupBox.Controls.Add(espFreqNumericUpDown);
            espSettingsGroupBox.Controls.Add(espFrequencyLabel);
            espSettingsGroupBox.Controls.Add(espTokenTextBox);
            espSettingsGroupBox.Controls.Add(espTokenLabel);
            espSettingsGroupBox.Location = new Point(29, 55);
            espSettingsGroupBox.Margin = new Padding(4, 3, 4, 3);
            espSettingsGroupBox.Name = "espSettingsGroupBox";
            espSettingsGroupBox.Padding = new Padding(4, 3, 4, 3);
            espSettingsGroupBox.Size = new Size(746, 217);
            espSettingsGroupBox.TabIndex = 5;
            espSettingsGroupBox.TabStop = false;
            espSettingsGroupBox.Text = "Settings";
            espSettingsGroupBox.Visible = false;
            // 
            // espSearchButton
            // 
            espSearchButton.Location = new Point(137, 93);
            espSearchButton.Margin = new Padding(4, 3, 4, 3);
            espSearchButton.Name = "espSearchButton";
            espSearchButton.Size = new Size(118, 23);
            espSearchButton.TabIndex = 19;
            espSearchButton.Text = "Search ESP";
            espSearchButton.UseVisualStyleBackColor = true;
            espSearchButton.Click += EspSearchButton_Click;
            // 
            // espAreaListBox
            // 
            espAreaListBox.FormattingEnabled = true;
            espAreaListBox.ItemHeight = 15;
            espAreaListBox.Location = new Point(417, 25);
            espAreaListBox.Margin = new Padding(4, 3, 4, 3);
            espAreaListBox.Name = "espAreaListBox";
            espAreaListBox.Size = new Size(308, 169);
            espAreaListBox.TabIndex = 18;
            espAreaListBox.SelectedIndexChanged += EspAreaListBox_SelectedIndexChanged;
            // 
            // espLookUpTextBox
            // 
            espLookUpTextBox.Location = new Point(137, 57);
            espLookUpTextBox.Margin = new Padding(4, 3, 4, 3);
            espLookUpTextBox.Name = "espLookUpTextBox";
            espLookUpTextBox.Size = new Size(243, 23);
            espLookUpTextBox.TabIndex = 17;
            // 
            // espCheckAreaButton
            // 
            espCheckAreaButton.Location = new Point(17, 186);
            espCheckAreaButton.Margin = new Padding(4, 3, 4, 3);
            espCheckAreaButton.Name = "espCheckAreaButton";
            espCheckAreaButton.Size = new Size(144, 23);
            espCheckAreaButton.TabIndex = 12;
            espCheckAreaButton.Text = "Load schedule now";
            espCheckAreaButton.UseVisualStyleBackColor = true;
            espCheckAreaButton.Click += EspCheckAreaButton_Click;
            // 
            // areaLabel
            // 
            areaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            areaLabel.Location = new Point(22, 60);
            areaLabel.Margin = new Padding(4, 0, 4, 0);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(101, 23);
            areaLabel.TabIndex = 10;
            areaLabel.Text = "Your location";
            areaLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // espFreqNumericUpDown
            // 
            espFreqNumericUpDown.Location = new Point(137, 127);
            espFreqNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            espFreqNumericUpDown.Name = "espFreqNumericUpDown";
            espFreqNumericUpDown.Size = new Size(60, 23);
            espFreqNumericUpDown.TabIndex = 8;
            espFreqNumericUpDown.Value = new decimal(new int[] { 60, 0, 0, 0 });
            espFreqNumericUpDown.Visible = false;
            // 
            // espFrequencyLabel
            // 
            espFrequencyLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            espFrequencyLabel.Location = new Point(17, 127);
            espFrequencyLabel.Margin = new Padding(4, 0, 4, 0);
            espFrequencyLabel.Name = "espFrequencyLabel";
            espFrequencyLabel.Size = new Size(105, 23);
            espFrequencyLabel.TabIndex = 7;
            espFrequencyLabel.Text = "Frequency (min)";
            espFrequencyLabel.TextAlign = ContentAlignment.MiddleRight;
            espFrequencyLabel.Visible = false;
            // 
            // espTokenTextBox
            // 
            espTokenTextBox.AcceptsTab = true;
            espTokenTextBox.Location = new Point(137, 24);
            espTokenTextBox.Margin = new Padding(4, 3, 4, 3);
            espTokenTextBox.Name = "espTokenTextBox";
            espTokenTextBox.Size = new Size(246, 23);
            espTokenTextBox.TabIndex = 6;
            espTokenTextBox.Leave += EspTokenTextBox_TextChanged;
            // 
            // espTokenLabel
            // 
            espTokenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            espTokenLabel.Location = new Point(18, 24);
            espTokenLabel.Margin = new Padding(4, 0, 4, 0);
            espTokenLabel.Name = "espTokenLabel";
            espTokenLabel.Size = new Size(105, 23);
            espTokenLabel.TabIndex = 5;
            espTokenLabel.Text = "Token";
            espTokenLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // espUseCheckBox
            // 
            espUseCheckBox.AutoSize = true;
            espUseCheckBox.Location = new Point(29, 19);
            espUseCheckBox.Margin = new Padding(4, 3, 4, 3);
            espUseCheckBox.Name = "espUseCheckBox";
            espUseCheckBox.Size = new Size(121, 19);
            espUseCheckBox.TabIndex = 0;
            espUseCheckBox.Text = "Use EskomSePush";
            espUseCheckBox.UseVisualStyleBackColor = true;
            espUseCheckBox.CheckedChanged += EspUseCheckBox_CheckedChanged;
            // 
            // espLinkLabel
            // 
            espLinkLabel.AutoSize = true;
            espLinkLabel.Location = new Point(434, 288);
            espLinkLabel.Margin = new Padding(4, 0, 4, 0);
            espLinkLabel.Name = "espLinkLabel";
            espLinkLabel.Size = new Size(112, 15);
            espLinkLabel.TabIndex = 9;
            espLinkLabel.TabStop = true;
            espLinkLabel.Text = "Apply for ESP Token";
            espLinkLabel.LinkClicked += EspLinkLabel_LinkClicked;
            // 
            // mainTimer
            // 
            mainTimer.Enabled = true;
            mainTimer.Interval = 60000;
            mainTimer.Tick += MainTimer_Tick;
            // 
            // eskomTimer
            // 
            eskomTimer.Interval = 3600000;
            eskomTimer.Tick += EskomTimer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(mainTabControl);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Scheduled Shutdown";
            Load += Main_LoadAsync;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            mainTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            scheduleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)scheduleGridView).EndInit();
            shutdownGroupBox.ResumeLayout(false);
            shutdownGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shutdownBeforeAfterUpDown).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            espSettingsGroupBox.ResumeLayout(false);
            espSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)espFreqNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Panel panel1;
        private Label titleLabel;
        private TabControl mainTabControl;
        private TabPage tabPage1;
        private GroupBox shutdownGroupBox;
        private TabPage tabPage2;
        private CheckBox espUseCheckBox;
        private GroupBox espSettingsGroupBox;
        private NumericUpDown espFreqNumericUpDown;
        private Label espFrequencyLabel;
        private TextBox espTokenTextBox;
        private Label espTokenLabel;
        private LinkLabel espLinkLabel;
        private Label espInstructionLabel;
        private Label areaLabel;
        private Button espCheckAreaButton;
        private ToolStripStatusLabel mainToolStripStatusLabel1;
        private DateTimePicker shutdownTimePicker;
        private Label shutdownTimeLabel;
        private Label shutdownDateLabel;
        private DateTimePicker shutdownDatePicker;
        private NumericUpDown shutdownBeforeAfterUpDown;
        private Label shutdownBeforeLabel;
        private CheckBox shutdownAlertCheckBox;
        private Label helpLabel1;
        private System.Windows.Forms.Timer mainTimer;
        private GroupBox scheduleGroupBox;
        private DataGridView scheduleGridView;
        private DataGridViewTextBoxColumn noteColumn;
        private DataGridViewTextBoxColumn startColumn;
        private DataGridViewTextBoxColumn endColumn;
        private ToolStripStatusLabel mainToolStripStatusLabel2;
        private System.Windows.Forms.Timer eskomTimer;
        private ListBox espAreaListBox;
        private TextBox espLookUpTextBox;
        private Button espSearchButton;
        private CheckBox addToStartupCheckBox;
        private CheckBox disableCheckBox;
    }
}