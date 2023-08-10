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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip1 = new StatusStrip();
            timerToolStripStatusLabel = new ToolStripStatusLabel();
            espToolStripStatusLabel = new ToolStripStatusLabel();
            nutStripStatusLabel = new ToolStripStatusLabel();
            nutToolStripStatusLabel = new ToolStripStatusLabel();
            panel1 = new Panel();
            titleLabel = new Label();
            mainTabControl = new TabControl();
            tabPage1 = new TabPage();
            nutGroupBox = new GroupBox();
            nutGridView = new DataGridView();
            NutDescription = new DataGridViewTextBoxColumn();
            NutValue = new DataGridViewTextBoxColumn();
            espGroupBox = new GroupBox();
            espGridView = new DataGridView();
            noteColumn = new DataGridViewTextBoxColumn();
            startColumn = new DataGridViewTextBoxColumn();
            endColumn = new DataGridViewTextBoxColumn();
            shutdownGroupBox = new GroupBox();
            disableCheckBox = new CheckBox();
            shutdownAlertCheckBox = new CheckBox();
            shutdownTimePicker = new DateTimePicker();
            shutdownTimeLabel = new Label();
            shutdownDateLabel = new Label();
            shutdownDatePicker = new DateTimePicker();
            tabPage2 = new TabPage();
            nutUseCheckBox = new CheckBox();
            addToStartupCheckBox = new CheckBox();
            espUseCheckBox = new CheckBox();
            tabPage3 = new TabPage();
            nutInstructionLabel = new Label();
            nutSettingsGroupBox = new GroupBox();
            nutShutdownLabel = new Label();
            nutShutdownTime = new NumericUpDown();
            nutPasswordTextBox = new TextBox();
            nutUserNameTextBox = new TextBox();
            nutTestButton = new Button();
            nutHostTextBox = new TextBox();
            nutPasswordLabel = new Label();
            nutUserNameLabel = new Label();
            nutHostLabel = new Label();
            tabPage4 = new TabPage();
            espInstructionLabel = new Label();
            espSettingsGroupBox = new GroupBox();
            helpLabel2 = new Label();
            helpLabel1 = new Label();
            shutdownBeforeAfterUpDown = new NumericUpDown();
            shutdownBeforeLabel = new Label();
            espSearchButton = new Button();
            espAreaListBox = new ListBox();
            espLookUpTextBox = new TextBox();
            espCheckAreaButton = new Button();
            areaLabel = new Label();
            espFreqNumericUpDown = new NumericUpDown();
            espFrequencyLabel = new Label();
            espTokenTextBox = new TextBox();
            espTokenLabel = new Label();
            espLinkLabel = new LinkLabel();
            mainTimer = new System.Windows.Forms.Timer(components);
            espTimer = new System.Windows.Forms.Timer(components);
            nutTimer = new System.Windows.Forms.Timer(components);
            nutShutdownTimer = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            mainTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            nutGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nutGridView).BeginInit();
            espGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)espGridView).BeginInit();
            shutdownGroupBox.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            nutSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nutShutdownTime).BeginInit();
            tabPage4.SuspendLayout();
            espSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shutdownBeforeAfterUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)espFreqNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.GripStyle = ToolStripGripStyle.Visible;
            statusStrip1.Items.AddRange(new ToolStripItem[] { timerToolStripStatusLabel, espToolStripStatusLabel, nutStripStatusLabel, nutToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 552);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(801, 24);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "mainStatusStrip";
            // 
            // timerToolStripStatusLabel
            // 
            timerToolStripStatusLabel.AutoSize = false;
            timerToolStripStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Right;
            timerToolStripStatusLabel.ForeColor = Color.SteelBlue;
            timerToolStripStatusLabel.Name = "timerToolStripStatusLabel";
            timerToolStripStatusLabel.Size = new Size(200, 19);
            timerToolStripStatusLabel.Text = "Timer";
            timerToolStripStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // espToolStripStatusLabel
            // 
            espToolStripStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Right;
            espToolStripStatusLabel.Name = "espToolStripStatusLabel";
            espToolStripStatusLabel.Size = new Size(366, 19);
            espToolStripStatusLabel.Spring = true;
            espToolStripStatusLabel.Text = "Status";
            espToolStripStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nutStripStatusLabel
            // 
            nutStripStatusLabel.Name = "nutStripStatusLabel";
            nutStripStatusLabel.Size = new Size(0, 19);
            // 
            // nutToolStripStatusLabel
            // 
            nutToolStripStatusLabel.AutoSize = false;
            nutToolStripStatusLabel.Name = "nutToolStripStatusLabel";
            nutToolStripStatusLabel.Size = new Size(220, 19);
            nutToolStripStatusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(titleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 60);
            panel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.WhiteSmoke;
            titleLabel.Location = new Point(5, 4);
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
            mainTabControl.Controls.Add(tabPage3);
            mainTabControl.Controls.Add(tabPage4);
            mainTabControl.Dock = DockStyle.Fill;
            mainTabControl.Location = new Point(0, 60);
            mainTabControl.Margin = new Padding(31, 30, 31, 30);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.Padding = new Point(6, 10);
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(801, 492);
            mainTabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(nutGroupBox);
            tabPage1.Controls.Add(espGroupBox);
            tabPage1.Controls.Add(shutdownGroupBox);
            tabPage1.Location = new Point(4, 38);
            tabPage1.Margin = new Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 3, 4, 3);
            tabPage1.Size = new Size(793, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Shutdown";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // nutGroupBox
            // 
            nutGroupBox.AutoSize = true;
            nutGroupBox.Controls.Add(nutGridView);
            nutGroupBox.Location = new Point(4, 277);
            nutGroupBox.Name = "nutGroupBox";
            nutGroupBox.Size = new Size(777, 176);
            nutGroupBox.TabIndex = 6;
            nutGroupBox.TabStop = false;
            nutGroupBox.Text = "NUT Status";
            // 
            // nutGridView
            // 
            nutGridView.AllowUserToAddRows = false;
            nutGridView.AllowUserToDeleteRows = false;
            nutGridView.AllowUserToOrderColumns = true;
            nutGridView.AllowUserToResizeColumns = false;
            nutGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nutGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nutGridView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            nutGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            nutGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nutGridView.Columns.AddRange(new DataGridViewColumn[] { NutDescription, NutValue });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            nutGridView.DefaultCellStyle = dataGridViewCellStyle2;
            nutGridView.Location = new Point(6, 22);
            nutGridView.Name = "nutGridView";
            nutGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            nutGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            nutGridView.RowTemplate.Height = 25;
            nutGridView.Size = new Size(765, 132);
            nutGridView.TabIndex = 6;
            // 
            // NutDescription
            // 
            NutDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NutDescription.DataPropertyName = "NutDescription";
            NutDescription.HeaderText = "Description";
            NutDescription.Name = "NutDescription";
            NutDescription.ReadOnly = true;
            // 
            // NutValue
            // 
            NutValue.DataPropertyName = "NutValue";
            NutValue.HeaderText = "Value";
            NutValue.Name = "NutValue";
            NutValue.ReadOnly = true;
            // 
            // espGroupBox
            // 
            espGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            espGroupBox.AutoSize = true;
            espGroupBox.Controls.Add(espGridView);
            espGroupBox.Location = new Point(4, 108);
            espGroupBox.Margin = new Padding(4, 3, 4, 3);
            espGroupBox.Name = "espGroupBox";
            espGroupBox.Padding = new Padding(4, 3, 4, 3);
            espGroupBox.Size = new Size(787, 163);
            espGroupBox.TabIndex = 4;
            espGroupBox.TabStop = false;
            espGroupBox.Text = "Eskom Schedule";
            // 
            // espGridView
            // 
            espGridView.AllowUserToAddRows = false;
            espGridView.AllowUserToDeleteRows = false;
            espGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            espGridView.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            espGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            espGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            espGridView.Columns.AddRange(new DataGridViewColumn[] { noteColumn, startColumn, endColumn });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            espGridView.DefaultCellStyle = dataGridViewCellStyle5;
            espGridView.Location = new Point(4, 19);
            espGridView.Margin = new Padding(4, 3, 4, 3);
            espGridView.Name = "espGridView";
            espGridView.ReadOnly = true;
            espGridView.RowTemplate.Height = 25;
            espGridView.Size = new Size(775, 138);
            espGridView.TabIndex = 0;
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
            shutdownGroupBox.Controls.Add(shutdownAlertCheckBox);
            shutdownGroupBox.Controls.Add(shutdownTimePicker);
            shutdownGroupBox.Controls.Add(shutdownTimeLabel);
            shutdownGroupBox.Controls.Add(shutdownDateLabel);
            shutdownGroupBox.Controls.Add(shutdownDatePicker);
            shutdownGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            shutdownGroupBox.Location = new Point(4, 3);
            shutdownGroupBox.Margin = new Padding(4, 3, 4, 3);
            shutdownGroupBox.Name = "shutdownGroupBox";
            shutdownGroupBox.Padding = new Padding(4, 3, 4, 3);
            shutdownGroupBox.Size = new Size(787, 98);
            shutdownGroupBox.TabIndex = 3;
            shutdownGroupBox.TabStop = false;
            shutdownGroupBox.Text = "Next Shutdown";
            // 
            // disableCheckBox
            // 
            disableCheckBox.AutoSize = true;
            disableCheckBox.Location = new Point(549, 33);
            disableCheckBox.Name = "disableCheckBox";
            disableCheckBox.Size = new Size(129, 19);
            disableCheckBox.TabIndex = 8;
            disableCheckBox.Text = "Disable shutdowns";
            disableCheckBox.UseVisualStyleBackColor = true;
            disableCheckBox.CheckedChanged += DisableCheckBox_CheckedChanged;
            // 
            // shutdownAlertCheckBox
            // 
            shutdownAlertCheckBox.AutoSize = true;
            shutdownAlertCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            shutdownAlertCheckBox.Location = new Point(549, 61);
            shutdownAlertCheckBox.Margin = new Padding(4, 3, 4, 3);
            shutdownAlertCheckBox.Name = "shutdownAlertCheckBox";
            shutdownAlertCheckBox.Size = new Size(174, 19);
            shutdownAlertCheckBox.TabIndex = 6;
            shutdownAlertCheckBox.Text = "Alert me before shutdown";
            shutdownAlertCheckBox.UseVisualStyleBackColor = true;
            shutdownAlertCheckBox.CheckedChanged += ShutdownAlertCheckBox_CheckedChanged;
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
            tabPage2.Controls.Add(nutUseCheckBox);
            tabPage2.Controls.Add(addToStartupCheckBox);
            tabPage2.Controls.Add(espUseCheckBox);
            tabPage2.Location = new Point(4, 38);
            tabPage2.Margin = new Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 3, 4, 3);
            tabPage2.Size = new Size(793, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Settings";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // nutUseCheckBox
            // 
            nutUseCheckBox.AutoSize = true;
            nutUseCheckBox.Location = new Point(32, 71);
            nutUseCheckBox.Name = "nutUseCheckBox";
            nutUseCheckBox.Size = new Size(181, 19);
            nutUseCheckBox.TabIndex = 11;
            nutUseCheckBox.Text = "Use Network UPS Tools (NUT)";
            nutUseCheckBox.UseVisualStyleBackColor = true;
            nutUseCheckBox.CheckedChanged += NutUseCheckBox_CheckedChanged;
            // 
            // addToStartupCheckBox
            // 
            addToStartupCheckBox.AutoSize = true;
            addToStartupCheckBox.Location = new Point(32, 19);
            addToStartupCheckBox.Margin = new Padding(4, 3, 4, 3);
            addToStartupCheckBox.Name = "addToStartupCheckBox";
            addToStartupCheckBox.Size = new Size(151, 19);
            addToStartupCheckBox.TabIndex = 10;
            addToStartupCheckBox.Text = "Add program to startup";
            addToStartupCheckBox.UseVisualStyleBackColor = true;
            addToStartupCheckBox.CheckedChanged += AddToStartupCheckBox_CheckedChanged;
            // 
            // espUseCheckBox
            // 
            espUseCheckBox.AutoSize = true;
            espUseCheckBox.Location = new Point(32, 45);
            espUseCheckBox.Margin = new Padding(4, 3, 4, 3);
            espUseCheckBox.Name = "espUseCheckBox";
            espUseCheckBox.Size = new Size(121, 19);
            espUseCheckBox.TabIndex = 0;
            espUseCheckBox.Text = "Use EskomSePush";
            espUseCheckBox.UseVisualStyleBackColor = true;
            espUseCheckBox.CheckedChanged += EspUseCheckBox_CheckedChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(nutInstructionLabel);
            tabPage3.Controls.Add(nutSettingsGroupBox);
            tabPage3.Location = new Point(4, 38);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(793, 450);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "NUT";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // nutInstructionLabel
            // 
            nutInstructionLabel.AutoSize = true;
            nutInstructionLabel.ForeColor = Color.Teal;
            nutInstructionLabel.Location = new Point(9, 214);
            nutInstructionLabel.Margin = new Padding(4, 0, 4, 0);
            nutInstructionLabel.Name = "nutInstructionLabel";
            nutInstructionLabel.Size = new Size(520, 15);
            nutInstructionLabel.TabIndex = 12;
            nutInstructionLabel.Text = "If you have a UPS that is connected to a server that supports NUT, you can monitor the UPS status";
            // 
            // nutSettingsGroupBox
            // 
            nutSettingsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nutSettingsGroupBox.Controls.Add(nutShutdownLabel);
            nutSettingsGroupBox.Controls.Add(nutShutdownTime);
            nutSettingsGroupBox.Controls.Add(nutPasswordTextBox);
            nutSettingsGroupBox.Controls.Add(nutUserNameTextBox);
            nutSettingsGroupBox.Controls.Add(nutTestButton);
            nutSettingsGroupBox.Controls.Add(nutHostTextBox);
            nutSettingsGroupBox.Controls.Add(nutPasswordLabel);
            nutSettingsGroupBox.Controls.Add(nutUserNameLabel);
            nutSettingsGroupBox.Controls.Add(nutHostLabel);
            nutSettingsGroupBox.Location = new Point(8, 16);
            nutSettingsGroupBox.Name = "nutSettingsGroupBox";
            nutSettingsGroupBox.Size = new Size(777, 195);
            nutSettingsGroupBox.TabIndex = 1;
            nutSettingsGroupBox.TabStop = false;
            nutSettingsGroupBox.Text = "Settings";
            // 
            // nutShutdownLabel
            // 
            nutShutdownLabel.AutoSize = true;
            nutShutdownLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nutShutdownLabel.Location = new Point(15, 124);
            nutShutdownLabel.Name = "nutShutdownLabel";
            nutShutdownLabel.Size = new Size(96, 15);
            nutShutdownLabel.TabIndex = 7;
            nutShutdownLabel.Text = "Shutdown (min)";
            // 
            // nutShutdownTime
            // 
            nutShutdownTime.Location = new Point(121, 124);
            nutShutdownTime.Name = "nutShutdownTime";
            nutShutdownTime.Size = new Size(82, 23);
            nutShutdownTime.TabIndex = 6;
            nutShutdownTime.ValueChanged += NutShutdownTime_ValueChanged;
            // 
            // nutPasswordTextBox
            // 
            nutPasswordTextBox.Location = new Point(121, 90);
            nutPasswordTextBox.Name = "nutPasswordTextBox";
            nutPasswordTextBox.Size = new Size(203, 23);
            nutPasswordTextBox.TabIndex = 5;
            nutPasswordTextBox.UseSystemPasswordChar = true;
            nutPasswordTextBox.TextChanged += NutPasswordTextBox_TextChanged;
            // 
            // nutUserNameTextBox
            // 
            nutUserNameTextBox.Location = new Point(121, 59);
            nutUserNameTextBox.Name = "nutUserNameTextBox";
            nutUserNameTextBox.Size = new Size(203, 23);
            nutUserNameTextBox.TabIndex = 4;
            nutUserNameTextBox.TextChanged += NutUserNameTextBox_TextChanged;
            // 
            // nutTestButton
            // 
            nutTestButton.Location = new Point(14, 159);
            nutTestButton.Name = "nutTestButton";
            nutTestButton.Size = new Size(111, 23);
            nutTestButton.TabIndex = 0;
            nutTestButton.Text = "Test Connection";
            nutTestButton.UseVisualStyleBackColor = true;
            nutTestButton.Click += NutTestButton_Click;
            // 
            // nutHostTextBox
            // 
            nutHostTextBox.Location = new Point(121, 28);
            nutHostTextBox.Name = "nutHostTextBox";
            nutHostTextBox.Size = new Size(203, 23);
            nutHostTextBox.TabIndex = 3;
            nutHostTextBox.TextChanged += NutHostTextBox_TextChanged;
            // 
            // nutPasswordLabel
            // 
            nutPasswordLabel.AutoSize = true;
            nutPasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nutPasswordLabel.Location = new Point(15, 93);
            nutPasswordLabel.Name = "nutPasswordLabel";
            nutPasswordLabel.Size = new Size(87, 15);
            nutPasswordLabel.TabIndex = 2;
            nutPasswordLabel.Text = "NUT Password";
            nutPasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nutUserNameLabel
            // 
            nutUserNameLabel.AutoSize = true;
            nutUserNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nutUserNameLabel.Location = new Point(15, 62);
            nutUserNameLabel.Name = "nutUserNameLabel";
            nutUserNameLabel.Size = new Size(97, 15);
            nutUserNameLabel.TabIndex = 1;
            nutUserNameLabel.Text = "NUT User Name";
            nutUserNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nutHostLabel
            // 
            nutHostLabel.AutoSize = true;
            nutHostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nutHostLabel.Location = new Point(15, 31);
            nutHostLabel.Name = "nutHostLabel";
            nutHostLabel.Size = new Size(61, 15);
            nutHostLabel.TabIndex = 0;
            nutHostLabel.Text = "NUT Host";
            nutHostLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(espInstructionLabel);
            tabPage4.Controls.Add(espSettingsGroupBox);
            tabPage4.Controls.Add(espLinkLabel);
            tabPage4.Location = new Point(4, 38);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(793, 450);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Eskom";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // espInstructionLabel
            // 
            espInstructionLabel.AutoSize = true;
            espInstructionLabel.ForeColor = Color.Teal;
            espInstructionLabel.Location = new Point(9, 278);
            espInstructionLabel.Margin = new Padding(4, 0, 4, 0);
            espInstructionLabel.Name = "espInstructionLabel";
            espInstructionLabel.Size = new Size(401, 15);
            espInstructionLabel.TabIndex = 11;
            espInstructionLabel.Text = "To auto receive Eskom's load shedding schedule, you need  an ESP API key.";
            // 
            // espSettingsGroupBox
            // 
            espSettingsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            espSettingsGroupBox.Controls.Add(helpLabel2);
            espSettingsGroupBox.Controls.Add(helpLabel1);
            espSettingsGroupBox.Controls.Add(shutdownBeforeAfterUpDown);
            espSettingsGroupBox.Controls.Add(shutdownBeforeLabel);
            espSettingsGroupBox.Controls.Add(espSearchButton);
            espSettingsGroupBox.Controls.Add(espAreaListBox);
            espSettingsGroupBox.Controls.Add(espLookUpTextBox);
            espSettingsGroupBox.Controls.Add(espCheckAreaButton);
            espSettingsGroupBox.Controls.Add(areaLabel);
            espSettingsGroupBox.Controls.Add(espFreqNumericUpDown);
            espSettingsGroupBox.Controls.Add(espFrequencyLabel);
            espSettingsGroupBox.Controls.Add(espTokenTextBox);
            espSettingsGroupBox.Controls.Add(espTokenLabel);
            espSettingsGroupBox.Location = new Point(9, 19);
            espSettingsGroupBox.Margin = new Padding(4, 3, 4, 3);
            espSettingsGroupBox.Name = "espSettingsGroupBox";
            espSettingsGroupBox.Padding = new Padding(4, 3, 4, 3);
            espSettingsGroupBox.Size = new Size(775, 242);
            espSettingsGroupBox.TabIndex = 10;
            espSettingsGroupBox.TabStop = false;
            espSettingsGroupBox.Text = "Settings";
            espSettingsGroupBox.Visible = false;
            // 
            // helpLabel2
            // 
            helpLabel2.AutoSize = true;
            helpLabel2.ForeColor = Color.Teal;
            helpLabel2.Location = new Point(209, 97);
            helpLabel2.Name = "helpLabel2";
            helpLabel2.Size = new Size(200, 15);
            helpLabel2.TabIndex = 23;
            helpLabel2.Text = "How often to check Eskom Schedule";
            // 
            // helpLabel1
            // 
            helpLabel1.AutoSize = true;
            helpLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            helpLabel1.ForeColor = Color.Teal;
            helpLabel1.Location = new Point(209, 139);
            helpLabel1.Margin = new Padding(4, 0, 4, 0);
            helpLabel1.Name = "helpLabel1";
            helpLabel1.Size = new Size(261, 15);
            helpLabel1.TabIndex = 22;
            helpLabel1.Text = "Allow some leeway on the shutdown time + or -";
            // 
            // shutdownBeforeAfterUpDown
            // 
            shutdownBeforeAfterUpDown.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            shutdownBeforeAfterUpDown.Location = new Point(137, 137);
            shutdownBeforeAfterUpDown.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            shutdownBeforeAfterUpDown.Minimum = new decimal(new int[] { 30, 0, 0, int.MinValue });
            shutdownBeforeAfterUpDown.Name = "shutdownBeforeAfterUpDown";
            shutdownBeforeAfterUpDown.Size = new Size(56, 23);
            shutdownBeforeAfterUpDown.TabIndex = 21;
            // 
            // shutdownBeforeLabel
            // 
            shutdownBeforeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            shutdownBeforeLabel.Location = new Point(8, 135);
            shutdownBeforeLabel.Margin = new Padding(4, 0, 4, 0);
            shutdownBeforeLabel.Name = "shutdownBeforeLabel";
            shutdownBeforeLabel.Size = new Size(137, 23);
            shutdownBeforeLabel.TabIndex = 20;
            shutdownBeforeLabel.Text = "Minutes Before/After";
            shutdownBeforeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // espSearchButton
            // 
            espSearchButton.Location = new Point(388, 56);
            espSearchButton.Margin = new Padding(4, 3, 4, 3);
            espSearchButton.Name = "espSearchButton";
            espSearchButton.Size = new Size(118, 23);
            espSearchButton.TabIndex = 19;
            espSearchButton.Text = "Search ESP";
            espSearchButton.UseVisualStyleBackColor = true;
            // 
            // espAreaListBox
            // 
            espAreaListBox.FormattingEnabled = true;
            espAreaListBox.ItemHeight = 15;
            espAreaListBox.Location = new Point(535, 13);
            espAreaListBox.Margin = new Padding(4, 3, 4, 3);
            espAreaListBox.Name = "espAreaListBox";
            espAreaListBox.Size = new Size(232, 169);
            espAreaListBox.TabIndex = 18;
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
            espCheckAreaButton.Location = new Point(8, 182);
            espCheckAreaButton.Margin = new Padding(4, 3, 4, 3);
            espCheckAreaButton.Name = "espCheckAreaButton";
            espCheckAreaButton.Size = new Size(144, 23);
            espCheckAreaButton.TabIndex = 12;
            espCheckAreaButton.Text = "Load schedule now";
            espCheckAreaButton.UseVisualStyleBackColor = true;
            // 
            // areaLabel
            // 
            areaLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            areaLabel.Location = new Point(8, 61);
            areaLabel.Margin = new Padding(4, 0, 4, 0);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(101, 23);
            areaLabel.TabIndex = 10;
            areaLabel.Text = "Your location";
            areaLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // espFreqNumericUpDown
            // 
            espFreqNumericUpDown.Location = new Point(137, 95);
            espFreqNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            espFreqNumericUpDown.Name = "espFreqNumericUpDown";
            espFreqNumericUpDown.Size = new Size(56, 23);
            espFreqNumericUpDown.TabIndex = 8;
            espFreqNumericUpDown.Value = new decimal(new int[] { 60, 0, 0, 0 });
            espFreqNumericUpDown.Visible = false;
            // 
            // espFrequencyLabel
            // 
            espFrequencyLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            espFrequencyLabel.Location = new Point(8, 98);
            espFrequencyLabel.Margin = new Padding(4, 0, 4, 0);
            espFrequencyLabel.Name = "espFrequencyLabel";
            espFrequencyLabel.Size = new Size(105, 23);
            espFrequencyLabel.TabIndex = 7;
            espFrequencyLabel.Text = "Frequency (min)";
            espFrequencyLabel.TextAlign = ContentAlignment.MiddleLeft;
            espFrequencyLabel.Visible = false;
            // 
            // espTokenTextBox
            // 
            espTokenTextBox.AcceptsTab = true;
            espTokenTextBox.Location = new Point(137, 28);
            espTokenTextBox.Margin = new Padding(4, 3, 4, 3);
            espTokenTextBox.Name = "espTokenTextBox";
            espTokenTextBox.Size = new Size(246, 23);
            espTokenTextBox.TabIndex = 6;
            espTokenTextBox.TextChanged += EspTokenTextBox_TextChanged;
            // 
            // espTokenLabel
            // 
            espTokenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            espTokenLabel.Location = new Point(8, 24);
            espTokenLabel.Margin = new Padding(4, 0, 4, 0);
            espTokenLabel.Name = "espTokenLabel";
            espTokenLabel.Size = new Size(105, 23);
            espTokenLabel.TabIndex = 5;
            espTokenLabel.Text = "Token";
            espTokenLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // espLinkLabel
            // 
            espLinkLabel.AutoSize = true;
            espLinkLabel.Location = new Point(426, 278);
            espLinkLabel.Margin = new Padding(4, 0, 4, 0);
            espLinkLabel.Name = "espLinkLabel";
            espLinkLabel.Size = new Size(112, 15);
            espLinkLabel.TabIndex = 12;
            espLinkLabel.TabStop = true;
            espLinkLabel.Text = "Apply for ESP Token";
            // 
            // mainTimer
            // 
            mainTimer.Enabled = true;
            mainTimer.Interval = 60000;
            mainTimer.Tick += MainTimer_Tick;
            // 
            // espTimer
            // 
            espTimer.Enabled = true;
            espTimer.Interval = 3600000;
            espTimer.Tick += EskomTimer_Tick;
            // 
            // nutTimer
            // 
            nutTimer.Interval = 15000;
            nutTimer.Tick += NutTimer_Tick;
            // 
            // nutShutdownTimer
            // 
            nutShutdownTimer.Interval = 60000;
            nutShutdownTimer.Tick += NutShutdownTimer_Tick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 576);
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
            tabPage1.PerformLayout();
            nutGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nutGridView).EndInit();
            espGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)espGridView).EndInit();
            shutdownGroupBox.ResumeLayout(false);
            shutdownGroupBox.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            nutSettingsGroupBox.ResumeLayout(false);
            nutSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nutShutdownTime).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            espSettingsGroupBox.ResumeLayout(false);
            espSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shutdownBeforeAfterUpDown).EndInit();
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
        private DateTimePicker shutdownTimePicker;
        private Label shutdownTimeLabel;
        private Label shutdownDateLabel;
        private DateTimePicker shutdownDatePicker;
        private CheckBox shutdownAlertCheckBox;
        private System.Windows.Forms.Timer mainTimer;
        private GroupBox espGroupBox;
        private DataGridView espGridView;
        private DataGridViewTextBoxColumn noteColumn;
        private DataGridViewTextBoxColumn startColumn;
        private DataGridViewTextBoxColumn endColumn;
        private ToolStripStatusLabel timerToolStripStatusLabel;
        private System.Windows.Forms.Timer espTimer;
        private CheckBox addToStartupCheckBox;
        private CheckBox disableCheckBox;
        private TabPage tabPage3;
        private Button nutTestButton;
        private TabPage tabPage4;
        private Label espInstructionLabel;
        private GroupBox espSettingsGroupBox;
        private Button espSearchButton;
        private ListBox espAreaListBox;
        private TextBox espLookUpTextBox;
        private Button espCheckAreaButton;
        private Label areaLabel;
        private NumericUpDown espFreqNumericUpDown;
        private Label espFrequencyLabel;
        private TextBox espTokenTextBox;
        private Label espTokenLabel;
        private LinkLabel espLinkLabel;
        private CheckBox nutUseCheckBox;
        private GroupBox nutSettingsGroupBox;
        private Label nutInstructionLabel;
        private ToolStripStatusLabel espToolStripStatusLabel;
        private GroupBox nutGroupBox;
        private DataGridView nutGridView;
        private System.Windows.Forms.Timer nutTimer;
        private TextBox nutPasswordTextBox;
        private TextBox nutUserNameTextBox;
        private TextBox nutHostTextBox;
        private Label nutPasswordLabel;
        private Label nutUserNameLabel;
        private Label nutHostLabel;
        private DataGridViewTextBoxColumn NutDescription;
        private DataGridViewTextBoxColumn NutValue;
        private ToolStripStatusLabel nutStripStatusLabel;
        private ToolStripStatusLabel nutToolStripStatusLabel;
        private Label helpLabel2;
        private Label helpLabel1;
        private NumericUpDown shutdownBeforeAfterUpDown;
        private Label shutdownBeforeLabel;
        private Label nutShutdownLabel;
        private NumericUpDown nutShutdownTime;
        private System.Windows.Forms.Timer nutShutdownTimer;
    }
}