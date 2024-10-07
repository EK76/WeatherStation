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
            labelDate = new System.Windows.Forms.Label();
            comboBoxDay = new System.Windows.Forms.ComboBox();
            comboBoxMonth = new System.Windows.Forms.ComboBox();
            labelText2 = new System.Windows.Forms.Label();
            labelText4 = new System.Windows.Forms.Label();
            listViewShowData = new System.Windows.Forms.ListView();
            columnHeaderOutTemp = new System.Windows.Forms.ColumnHeader();
            columnHeaderOutHum = new System.Windows.Forms.ColumnHeader();
            columnHeaderPressure = new System.Windows.Forms.ColumnHeader();
            columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            graphViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            weatherDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            technicalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            softwareInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exportToPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            labelText = new System.Windows.Forms.Label();
            comboBoxYear = new System.Windows.Forms.ComboBox();
            dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            labelStartDate = new System.Windows.Forms.Label();
            buttonSearch = new System.Windows.Forms.Button();
            labelEndDate = new System.Windows.Forms.Label();
            listViewPrinter1 = new BrightIdeasSoftware.ListViewPrinter();
            labelRows = new System.Windows.Forms.Label();
            checkBoxDay = new System.Windows.Forms.CheckBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            labelDate.ForeColor = System.Drawing.Color.Black;
            labelDate.Location = new System.Drawing.Point(14, 37);
            labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(50, 19);
            labelDate.TabIndex = 5;
            labelDate.Text = "label1";
            // 
            // comboBoxDay
            // 
            comboBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxDay.Enabled = false;
            comboBoxDay.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            comboBoxDay.ForeColor = System.Drawing.Color.DarkSlateBlue;
            comboBoxDay.FormattingEnabled = true;
            comboBoxDay.Location = new System.Drawing.Point(499, 100);
            comboBoxDay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxDay.Name = "comboBoxDay";
            comboBoxDay.Size = new System.Drawing.Size(215, 23);
            comboBoxDay.TabIndex = 7;
            comboBoxDay.SelectedIndexChanged += comboBoxDay_SelectedIndexChanged;
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxMonth.Enabled = false;
            comboBoxMonth.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            comboBoxMonth.ForeColor = System.Drawing.Color.DarkSlateBlue;
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonth.Location = new System.Drawing.Point(257, 101);
            comboBoxMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new System.Drawing.Size(215, 23);
            comboBoxMonth.TabIndex = 9;
            comboBoxMonth.SelectedIndexChanged += comboBoxMonth_SelectedIndexChanged;
            // 
            // labelText2
            // 
            labelText2.AutoSize = true;
            labelText2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            labelText2.ForeColor = System.Drawing.Color.Black;
            labelText2.Location = new System.Drawing.Point(496, 77);
            labelText2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelText2.Name = "labelText2";
            labelText2.Size = new System.Drawing.Size(71, 17);
            labelText2.TabIndex = 14;
            labelText2.Text = "Select day.";
            // 
            // labelText4
            // 
            labelText4.AutoSize = true;
            labelText4.Enabled = false;
            labelText4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            labelText4.ForeColor = System.Drawing.Color.Black;
            labelText4.Location = new System.Drawing.Point(257, 77);
            labelText4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelText4.Name = "labelText4";
            labelText4.Size = new System.Drawing.Size(90, 17);
            labelText4.TabIndex = 16;
            labelText4.Text = "Select month.";
            // 
            // listViewShowData
            // 
            listViewShowData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderOutTemp, columnHeaderOutHum, columnHeaderPressure, columnHeaderDate });
            listViewShowData.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            listViewShowData.Location = new System.Drawing.Point(14, 151);
            listViewShowData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listViewShowData.Name = "listViewShowData";
            listViewShowData.Size = new System.Drawing.Size(1372, 838);
            listViewShowData.TabIndex = 17;
            listViewShowData.UseCompatibleStateImageBehavior = false;
            listViewShowData.View = System.Windows.Forms.View.Details;
            listViewShowData.ColumnClick += listViewShowData_ColumnClick;
            listViewShowData.SelectedIndexChanged += listViewShowData_SelectedIndexChanged;
            // 
            // columnHeaderOutTemp
            // 
            columnHeaderOutTemp.Text = "Outdoor temperature";
            columnHeaderOutTemp.Width = 290;
            // 
            // columnHeaderOutHum
            // 
            columnHeaderOutHum.Text = "Outdoor humidity";
            columnHeaderOutHum.Width = 260;
            // 
            // columnHeaderPressure
            // 
            columnHeaderPressure.Text = "Pressure";
            columnHeaderPressure.Width = 251;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date created";
            columnHeaderDate.Width = 235;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileStripMenuItem, viewToolStripMenuItem1, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1399, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileStripMenuItem
            // 
            fileStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saveToolStripMenuItem, printToolStripMenuItem, closeToolStripMenuItem });
            fileStripMenuItem.Name = "fileStripMenuItem";
            fileStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Enabled = false;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            printToolStripMenuItem.Text = "Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { graphViewToolStripMenuItem, weatherDataToolStripMenuItem, toolStripSeparator1, technicalInfoToolStripMenuItem, softwareInfoToolStripMenuItem });
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem1.Text = "View";
            // 
            // graphViewToolStripMenuItem
            // 
            graphViewToolStripMenuItem.Enabled = false;
            graphViewToolStripMenuItem.Name = "graphViewToolStripMenuItem";
            graphViewToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            graphViewToolStripMenuItem.Text = "Graph View";
            graphViewToolStripMenuItem.Click += graphViewToolStripMenuItem_Click;
            // 
            // weatherDataToolStripMenuItem
            // 
            weatherDataToolStripMenuItem.Name = "weatherDataToolStripMenuItem";
            weatherDataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            weatherDataToolStripMenuItem.Text = "Weather Data";
            weatherDataToolStripMenuItem.Click += weatherDataToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // technicalInfoToolStripMenuItem
            // 
            technicalInfoToolStripMenuItem.Name = "technicalInfoToolStripMenuItem";
            technicalInfoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            technicalInfoToolStripMenuItem.Text = "Technical Info";
            technicalInfoToolStripMenuItem.Click += technicalInfoToolStripMenuItem_Click;
            // 
            // softwareInfoToolStripMenuItem
            // 
            softwareInfoToolStripMenuItem.Name = "softwareInfoToolStripMenuItem";
            softwareInfoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            softwareInfoToolStripMenuItem.Text = "Software Info";
            softwareInfoToolStripMenuItem.Click += softwareInfoToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { exportToPDFToolStripMenuItem, modifyToolStripMenuItem, clearDataToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // exportToPDFToolStripMenuItem
            // 
            exportToPDFToolStripMenuItem.Enabled = false;
            exportToPDFToolStripMenuItem.Name = "exportToPDFToolStripMenuItem";
            exportToPDFToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            exportToPDFToolStripMenuItem.Text = "Create report in PDF";
            exportToPDFToolStripMenuItem.Click += exportToPDFToolStripMenuItem_Click;
            // 
            // modifyToolStripMenuItem
            // 
            modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            modifyToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            modifyToolStripMenuItem.Text = "Modify Weather Table";
            modifyToolStripMenuItem.Click += modifyToolStripMenuItem_Click;
            // 
            // clearDataToolStripMenuItem
            // 
            clearDataToolStripMenuItem.Enabled = false;
            clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            clearDataToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            clearDataToolStripMenuItem.Text = "Clear Data";
            clearDataToolStripMenuItem.Click += clearDataToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            aboutToolStripMenuItem.Text = "About Weather Info";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (System.Drawing.Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Enabled = false;
            labelText.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            labelText.ForeColor = System.Drawing.Color.Black;
            labelText.Location = new System.Drawing.Point(14, 77);
            labelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelText.Name = "labelText";
            labelText.Size = new System.Drawing.Size(75, 17);
            labelText.TabIndex = 20;
            labelText.Text = "Select year.";
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxYear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            comboBoxYear.ForeColor = System.Drawing.Color.DarkSlateBlue;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Items.AddRange(new object[] { "2024" });
            comboBoxYear.Location = new System.Drawing.Point(14, 101);
            comboBoxYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new System.Drawing.Size(215, 23);
            comboBoxYear.TabIndex = 19;
            comboBoxYear.SelectedIndexChanged += comboBoxYear_SelectedIndexChanged;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerStartDate.Location = new System.Drawing.Point(760, 101);
            dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dateTimePickerStartDate.Size = new System.Drawing.Size(111, 23);
            dateTimePickerStartDate.TabIndex = 21;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerEndDate.Location = new System.Drawing.Point(935, 101);
            dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new System.Drawing.Size(111, 23);
            dateTimePickerEndDate.TabIndex = 22;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            labelStartDate.ForeColor = System.Drawing.Color.Black;
            labelStartDate.Location = new System.Drawing.Point(756, 73);
            labelStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new System.Drawing.Size(67, 17);
            labelStartDate.TabIndex = 23;
            labelStartDate.Text = "Start date";
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            buttonSearch.Location = new System.Drawing.Point(1064, 99);
            buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(88, 27);
            buttonSearch.TabIndex = 24;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            labelEndDate.ForeColor = System.Drawing.Color.Black;
            labelEndDate.Location = new System.Drawing.Point(931, 73);
            labelEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new System.Drawing.Size(61, 17);
            labelEndDate.TabIndex = 25;
            labelEndDate.Text = "End date";
            // 
            // listViewPrinter1
            // 
            // 
            // 
            // 
            listViewPrinter1.CellFormat.CanWrap = true;
            listViewPrinter1.CellFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // 
            // 
            listViewPrinter1.FooterFormat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Italic);
            // 
            // 
            // 
            listViewPrinter1.GroupHeaderFormat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            // 
            // 
            // 
            listViewPrinter1.HeaderFormat.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            // 
            // 
            // 
            listViewPrinter1.ListHeaderFormat.CanWrap = true;
            listViewPrinter1.ListHeaderFormat.Font = new System.Drawing.Font("Verdana", 12F);
            listViewPrinter1.ListView = listViewShowData;
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelRows.Location = new System.Drawing.Point(14, 1004);
            labelRows.Name = "labelRows";
            labelRows.Size = new System.Drawing.Size(122, 17);
            labelRows.TabIndex = 26;
            labelRows.Text = "Numbers of rows: ";
            // 
            // checkBoxDay
            // 
            checkBoxDay.AutoSize = true;
            checkBoxDay.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            checkBoxDay.Location = new System.Drawing.Point(1240, 107);
            checkBoxDay.Name = "checkBoxDay";
            checkBoxDay.Size = new System.Drawing.Size(98, 21);
            checkBoxDay.TabIndex = 27;
            checkBoxDay.Text = "Current Day";
            checkBoxDay.UseVisualStyleBackColor = true;
            checkBoxDay.CheckedChanged += checkBoxDay_CheckedChanged;
            // 
            // FormShowData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1399, 1038);
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
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormShowData";
            ShowIcon = false;
            Text = "Weather Info";
            Load += FormShowData_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem fileStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.ToolStripMenuItem weatherDataToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
    }
}