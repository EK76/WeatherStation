namespace ReadTemp
{
    partial class FormShowData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowData));
            labelDate = new Label();
            comboBoxDay = new ComboBox();
            comboBoxMonth = new ComboBox();
            labelText2 = new Label();
            labelText4 = new Label();
            listViewShowData = new ListView();
            columnHeaderOutTemp = new ColumnHeader();
            columnHeaderOutHum = new ColumnHeader();
            columnHeaderPressure = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteRowsToolStripMenuItem = new ToolStripMenuItem();
            clearDataToolStripMenuItem = new ToolStripMenuItem();
            modifyCurrentDataToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            graphViewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            technicalInfoToolStripMenuItem = new ToolStripMenuItem();
            softwareInfoToolStripMenuItem = new ToolStripMenuItem();
            showDelayTimeLogToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            exportToPDFToolStripMenuItem = new ToolStripMenuItem();
            changeTimeToolStripMenuItem = new ToolStripMenuItem();
            delayValueToolStripComboBox = new ToolStripComboBox();
            modifyToolStripMenuItem = new ToolStripMenuItem();
            databaseConfigToolStripMenuItem = new ToolStripMenuItem();
            changeDatabasePasswordToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            printPreviewDialog1 = new PrintPreviewDialog();
            labelText = new Label();
            comboBoxYear = new ComboBox();
            dateTimePickerStartDate = new DateTimePicker();
            dateTimePickerEndDate = new DateTimePicker();
            labelStartDate = new Label();
            buttonSearch = new Button();
            labelEndDate = new Label();
            listViewPrinter1 = new BrightIdeasSoftware.ListViewPrinter();
            labelRows = new Label();
            checkBoxDay = new CheckBox();
            trackBarSize = new TrackBar();
            labelText3 = new Label();
            labelStatus = new Label();
            labelShowDelay = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).BeginInit();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelDate.ForeColor = Color.Black;
            labelDate.Location = new Point(12, 37);
            labelDate.Margin = new Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(50, 19);
            labelDate.TabIndex = 5;
            labelDate.Text = "label2";
            // 
            // comboBoxDay
            // 
            comboBoxDay.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDay.Enabled = false;
            comboBoxDay.Font = new Font("Calibri", 10F, FontStyle.Bold);
            comboBoxDay.ForeColor = Color.DarkSlateBlue;
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Location = new Point(494, 89);
            comboBoxDay.Margin = new Padding(4, 3, 4, 3);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new Size(215, 23);
            comboBoxDay.TabIndex = 7;
            comboBoxDay.SelectedIndexChanged += comboBoxDay_SelectedIndexChanged;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMonth.Enabled = false;
            comboBoxMonth.Font = new Font("Calibri", 10F, FontStyle.Bold);
            comboBoxMonth.ForeColor = Color.DarkSlateBlue;
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Location = new Point(255, 89);
            comboBoxMonth.Margin = new Padding(4, 3, 4, 3);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(215, 23);
            comboBoxMonth.TabIndex = 9;
            comboBoxMonth.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new Font("Calibri", 10F, FontStyle.Bold);
            labelText2.ForeColor = Color.Black;
            labelText2.Location = new Point(494, 65);
            labelText2.Margin = new Padding(4, 0, 4, 0);
            labelText2.Name = "labelText2";
            labelText2.Size = new Size(71, 17);
            labelText2.TabIndex = 14;
            labelText2.Text = "Select day.";
            // 
            // labelText4
            // 
            labelText4.AutoSize = true;
            labelText4.Enabled = false;
            labelText4.Font = new Font("Calibri", 10F, FontStyle.Bold);
            labelText4.ForeColor = Color.Black;
            labelText4.Location = new Point(255, 65);
            labelText4.Margin = new Padding(4, 0, 4, 0);
            labelText4.Name = "labelText4";
            labelText4.Size = new Size(90, 17);
            labelText4.TabIndex = 16;
            labelText4.Text = "Select month.";
            // 
            // listViewShowData
            // 
            listViewShowData.Columns.AddRange(new ColumnHeader[] { columnHeaderOutTemp, columnHeaderOutHum, columnHeaderPressure, columnHeaderDate });
            listViewShowData.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewShowData.FullRowSelect = true;
            listViewShowData.Location = new Point(0, 122);
            listViewShowData.Margin = new Padding(4, 3, 4, 3);
            listViewShowData.Name = "listViewShowData";
            listViewShowData.Size = new Size(1392, 879);
            listViewShowData.TabIndex = 17;
            listViewShowData.UseCompatibleStateImageBehavior = false;
            listViewShowData.View = View.Details;
            listViewShowData.ColumnClick += listViewShowData_ColumnClick;
            listViewShowData.SelectedIndexChanged += listViewShowData_SelectedIndexChanged;
            listViewShowData.Click += listViewShowData_Click;
            // 
            // columnHeaderOutTemp
            // 
            columnHeaderOutTemp.Text = "Outdoor temperature";
            columnHeaderOutTemp.Width = 340;
            // 
            // columnHeaderOutHum
            // 
            columnHeaderOutHum.Text = "Outdoor humidity";
            columnHeaderOutHum.Width = 340;
            // 
            // columnHeaderPressure
            // 
            columnHeaderPressure.Text = "Pressure";
            columnHeaderPressure.Width = 340;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date created";
            columnHeaderDate.Width = 322;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem1, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1392, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, printToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(103, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Enabled = false;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(103, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteRowsToolStripMenuItem, clearDataToolStripMenuItem, modifyCurrentDataToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteRowsToolStripMenuItem
            // 
            deleteRowsToolStripMenuItem.Enabled = false;
            deleteRowsToolStripMenuItem.Name = "deleteRowsToolStripMenuItem";
            deleteRowsToolStripMenuItem.Size = new Size(182, 22);
            deleteRowsToolStripMenuItem.Text = "Delete Rows";
            deleteRowsToolStripMenuItem.Click += deleteRowsToolStripMenuItem_Click;
            // 
            // clearDataToolStripMenuItem
            // 
            clearDataToolStripMenuItem.Enabled = false;
            clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            clearDataToolStripMenuItem.Size = new Size(182, 22);
            clearDataToolStripMenuItem.Text = "Clear Data";
            clearDataToolStripMenuItem.Click += clearDataToolStripMenuItem_Click_1;
            // 
            // modifyCurrentDataToolStripMenuItem
            // 
            modifyCurrentDataToolStripMenuItem.Enabled = false;
            modifyCurrentDataToolStripMenuItem.Name = "modifyCurrentDataToolStripMenuItem";
            modifyCurrentDataToolStripMenuItem.Size = new Size(182, 22);
            modifyCurrentDataToolStripMenuItem.Text = "Modify Current Data";
            modifyCurrentDataToolStripMenuItem.Click += modifyCurrentDataToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { graphViewToolStripMenuItem, toolStripSeparator1, technicalInfoToolStripMenuItem, softwareInfoToolStripMenuItem, showDelayTimeLogToolStripMenuItem });
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new Size(44, 20);
            viewToolStripMenuItem1.Text = "View";
            // 
            // graphViewToolStripMenuItem
            // 
            graphViewToolStripMenuItem.Enabled = false;
            graphViewToolStripMenuItem.Name = "graphViewToolStripMenuItem";
            graphViewToolStripMenuItem.Size = new Size(188, 22);
            graphViewToolStripMenuItem.Text = "Graph View";
            graphViewToolStripMenuItem.Click += graphViewToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(185, 6);
            // 
            // technicalInfoToolStripMenuItem
            // 
            technicalInfoToolStripMenuItem.Name = "technicalInfoToolStripMenuItem";
            technicalInfoToolStripMenuItem.Size = new Size(188, 22);
            technicalInfoToolStripMenuItem.Text = "Technical Info";
            technicalInfoToolStripMenuItem.Click += technicalInfoToolStripMenuItem_Click;
            // 
            // softwareInfoToolStripMenuItem
            // 
            softwareInfoToolStripMenuItem.Name = "softwareInfoToolStripMenuItem";
            softwareInfoToolStripMenuItem.Size = new Size(188, 22);
            softwareInfoToolStripMenuItem.Text = "Software Info";
            softwareInfoToolStripMenuItem.Click += softwareInfoToolStripMenuItem_Click;
            // 
            // showDelayTimeLogToolStripMenuItem
            // 
            showDelayTimeLogToolStripMenuItem.Name = "showDelayTimeLogToolStripMenuItem";
            showDelayTimeLogToolStripMenuItem.Size = new Size(188, 22);
            showDelayTimeLogToolStripMenuItem.Text = "Show Delay Time Log";
            showDelayTimeLogToolStripMenuItem.Click += showDelayTimeLogToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToPDFToolStripMenuItem, changeTimeToolStripMenuItem, modifyToolStripMenuItem, databaseConfigToolStripMenuItem, changeDatabasePasswordToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // exportToPDFToolStripMenuItem
            // 
            exportToPDFToolStripMenuItem.Enabled = false;
            exportToPDFToolStripMenuItem.Name = "exportToPDFToolStripMenuItem";
            exportToPDFToolStripMenuItem.Size = new Size(219, 22);
            exportToPDFToolStripMenuItem.Text = "Create table as PDF report";
            exportToPDFToolStripMenuItem.Click += exportToPDFToolStripMenuItem_Click;
            // 
            // changeTimeToolStripMenuItem
            // 
            changeTimeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { delayValueToolStripComboBox });
            changeTimeToolStripMenuItem.Name = "changeTimeToolStripMenuItem";
            changeTimeToolStripMenuItem.Size = new Size(219, 22);
            changeTimeToolStripMenuItem.Text = "Change Delay Time";
            // 
            // delayValueToolStripComboBox
            // 
            delayValueToolStripComboBox.Items.AddRange(new object[] { "10", "20", "30", "45", "60" });
            delayValueToolStripComboBox.Name = "delayValueToolStripComboBox";
            delayValueToolStripComboBox.Size = new Size(121, 23);
            delayValueToolStripComboBox.TextChanged += delayValueToolStripComboBox_TextChanged;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new Size(219, 22);
            modifyToolStripMenuItem.Text = "Modify Weather Table";
            modifyToolStripMenuItem.Click += modifyToolStripMenuItem_Click;
            // 
            // databaseConfigToolStripMenuItem
            // 
            databaseConfigToolStripMenuItem.Name = "databaseConfigToolStripMenuItem";
            databaseConfigToolStripMenuItem.Size = new Size(219, 22);
            databaseConfigToolStripMenuItem.Text = "Database Config";
            databaseConfigToolStripMenuItem.Click += databaseConfigToolStripMenuItem_Click;
            // 
            // changeDatabasePasswordToolStripMenuItem
            // 
            changeDatabasePasswordToolStripMenuItem.Name = "changeDatabasePasswordToolStripMenuItem";
            changeDatabasePasswordToolStripMenuItem.Size = new Size(219, 22);
            changeDatabasePasswordToolStripMenuItem.Text = "Change Database Password";
            changeDatabasePasswordToolStripMenuItem.Click += changeDatabasePasswordToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(178, 22);
            aboutToolStripMenuItem.Text = "About Weather Info";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Enabled = false;
            labelText.Font = new Font("Calibri", 10F, FontStyle.Bold);
            labelText.ForeColor = Color.Black;
            labelText.Location = new Point(12, 65);
            labelText.Margin = new Padding(4, 0, 4, 0);
            labelText.Name = "labelText";
            labelText.Size = new Size(75, 17);
            labelText.TabIndex = 20;
            labelText.Text = "Select year.";
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.Font = new Font("Calibri", 10F, FontStyle.Bold);
            comboBoxYear.ForeColor = Color.DarkSlateBlue;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(12, 89);
            comboBoxYear.Margin = new Padding(4, 3, 4, 3);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(215, 23);
            comboBoxYear.TabIndex = 19;
            comboBoxYear.SelectedIndexChanged += comboBoxYear_SelectedIndexChanged;
            comboBoxYear.Click += comboBoxYear_Click;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.Location = new Point(758, 89);
            dateTimePickerStartDate.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.RightToLeft = RightToLeft.No;
            dateTimePickerStartDate.Size = new Size(111, 23);
            dateTimePickerStartDate.TabIndex = 21;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndDate.Location = new Point(933, 89);
            dateTimePickerEndDate.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(111, 23);
            dateTimePickerEndDate.TabIndex = 22;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Calibri", 10F, FontStyle.Bold);
            labelStartDate.ForeColor = Color.Black;
            labelStartDate.Location = new Point(754, 61);
            labelStartDate.Margin = new Padding(4, 0, 4, 0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(67, 17);
            labelStartDate.TabIndex = 23;
            labelStartDate.Text = "Start date";
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Calibri", 10F, FontStyle.Bold);
            buttonSearch.Location = new Point(1062, 87);
            buttonSearch.Margin = new Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(88, 27);
            buttonSearch.TabIndex = 24;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Calibri", 10F, FontStyle.Bold);
            labelEndDate.ForeColor = Color.Black;
            labelEndDate.Location = new Point(929, 61);
            labelEndDate.Margin = new Padding(4, 0, 4, 0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(61, 17);
            labelEndDate.TabIndex = 25;
            labelEndDate.Text = "End date";
            // 
            // listViewPrinter1
            // 
            // 
            // 
            // 
            listViewPrinter1.CellFormat.CanWrap = true;
            listViewPrinter1.CellFormat.Font = new Font("Microsoft Sans Serif", 9F);
            // 
            // 
            // 
            listViewPrinter1.FooterFormat.Font = new Font("Verdana", 10F, FontStyle.Italic);
            // 
            // 
            // 
            listViewPrinter1.GroupHeaderFormat.Font = new Font("Verdana", 10F, FontStyle.Bold);
            // 
            // 
            // 
            listViewPrinter1.HeaderFormat.Font = new Font("Calibri", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // 
            // 
            listViewPrinter1.ListHeaderFormat.CanWrap = true;
            listViewPrinter1.ListHeaderFormat.Font = new Font("Verdana", 12F);
            listViewPrinter1.ListView = listViewShowData;
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRows.Location = new Point(14, 1004);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(122, 17);
            labelRows.TabIndex = 26;
            labelRows.Text = "Numbers of rows: ";
            // 
            // checkBoxDay
            // 
            checkBoxDay.AutoSize = true;
            checkBoxDay.Font = new Font("Calibri", 10F, FontStyle.Bold);
            checkBoxDay.Location = new Point(1234, 95);
            checkBoxDay.Name = "checkBoxDay";
            checkBoxDay.Size = new Size(98, 21);
            checkBoxDay.TabIndex = 27;
            checkBoxDay.Text = "Current Day";
            checkBoxDay.UseVisualStyleBackColor = true;
            checkBoxDay.CheckedChanged += checkBoxDay_CheckedChanged;
            // 
            // trackBarSize
            // 
            trackBarSize.Location = new Point(1217, 1004);
            trackBarSize.Maximum = 28;
            trackBarSize.Minimum = 12;
            trackBarSize.Name = "trackBarSize";
            trackBarSize.Size = new Size(169, 45);
            trackBarSize.TabIndex = 29;
            trackBarSize.Value = 15;
            trackBarSize.Scroll += trackBarSize_Scroll;
            // 
            // labelText3
            // 
            labelText3.AutoSize = true;
            labelText3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelText3.Location = new Point(1127, 1004);
            labelText3.Name = "labelText3";
            labelText3.Size = new Size(84, 17);
            labelText3.TabIndex = 30;
            labelText3.Text = "Set font size";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelStatus.Location = new Point(376, 1004);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(0, 17);
            labelStatus.TabIndex = 31;
            // 
            // labelShowDelay
            // 
            labelShowDelay.AutoSize = true;
            labelShowDelay.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelShowDelay.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            labelShowDelay.Location = new Point(805, 1010);
            labelShowDelay.Name = "labelShowDelay";
            labelShowDelay.Size = new Size(71, 17);
            labelShowDelay.TabIndex = 32;
            labelShowDelay.Tag = "z";
            labelShowDelay.Text = "Delay text";
            // 
            // FormShowData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1392, 1045);
            Controls.Add(labelShowDelay);
            Controls.Add(labelStatus);
            Controls.Add(labelText3);
            Controls.Add(trackBarSize);
            Controls.Add(checkBoxDay);
            Controls.Add(labelRows);
            Controls.Add(labelEndDate);
            Controls.Add(buttonSearch);
            Controls.Add(labelStartDate);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(labelText);
            Controls.Add(comboBoxYear);
            Controls.Add(listViewShowData);
            Controls.Add(labelText4);
            Controls.Add(labelText2);
            Controls.Add(comboBoxMonth);
            Controls.Add(comboBoxDay);
            Controls.Add(labelDate);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormShowData";
            ShowIcon = false;
            Text = "Weather Station";
            Activated += FormShowData_Activated;
            Load += FormShowData_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label labelText2;
        private System.Windows.Forms.Label labelText4;
        private System.Windows.Forms.ListView listViewShowData;
        private System.Windows.Forms.ColumnHeader columnHeaderOutTemp;
        private System.Windows.Forms.ColumnHeader columnHeaderOutHum;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToPDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeaderPressure;
        private BrightIdeasSoftware.ListViewPrinter listViewPrinter1;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.ToolStripMenuItem technicalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem softwareInfoToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxDay;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label labelText3;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ToolStripMenuItem databaseConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox delayValueToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDelayTimeLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.Label labelShowDelay;
        private ToolStripMenuItem changeDatabasePasswordToolStripMenuItem;
        private ToolStripMenuItem modifyCurrentDataToolStripMenuItem;
        private ToolStripMenuItem deleteRowsToolStripMenuItem;
    }
}