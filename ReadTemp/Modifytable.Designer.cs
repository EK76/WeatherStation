namespace ReadTemp
{
    partial class FormModifyTable
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
            listViewShowData = new ListView();
            columnHeaderID = new ColumnHeader();
            columnHeaderOutTemp = new ColumnHeader();
            columnHeaderOutHum = new ColumnHeader();
            columnHeaderPressure = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            radioButtonAll = new RadioButton();
            radioButtonIntervall = new RadioButton();
            dateTimePickerStartDate = new DateTimePicker();
            dateTimePickerEndDate = new DateTimePicker();
            labelDate = new Label();
            labelDate2 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            backupTableToolStripMenuItem1 = new ToolStripMenuItem();
            restoreTableToolStripMenuItem1 = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteRowsToolStripMenuItem = new ToolStripMenuItem();
            editSelectedRowToolStripMenuItem = new ToolStripMenuItem();
            emptyTableToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            refreshTableToolStripMenuItem = new ToolStripMenuItem();
            buttonSearch = new Button();
            labelRows = new Label();
            trackBarSize = new TrackBar();
            labelSetFont = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).BeginInit();
            SuspendLayout();
            // 
            // listViewShowData
            // 
            listViewShowData.Columns.AddRange(new ColumnHeader[] { columnHeaderID, columnHeaderOutTemp, columnHeaderOutHum, columnHeaderPressure, columnHeaderDate });
            listViewShowData.Font = new Font("Calibri", 21.75F);
            listViewShowData.FullRowSelect = true;
            listViewShowData.Location = new Point(14, 112);
            listViewShowData.Margin = new Padding(4, 3, 4, 3);
            listViewShowData.Name = "listViewShowData";
            listViewShowData.Size = new Size(1521, 970);
            listViewShowData.TabIndex = 0;
            listViewShowData.UseCompatibleStateImageBehavior = false;
            listViewShowData.View = View.Details;
            listViewShowData.SelectedIndexChanged += listViewShowData_SelectedIndexChanged;
            listViewShowData.Click += listViewShowData_Click;
            // 
            // columnHeaderID
            // 
            columnHeaderID.Text = "ID value";
            columnHeaderID.Width = 188;
            // 
            // columnHeaderOutTemp
            // 
            columnHeaderOutTemp.Text = "Outdoor temperature";
            columnHeaderOutTemp.Width = 300;
            // 
            // columnHeaderOutHum
            // 
            columnHeaderOutHum.Text = "Outdoor humidity";
            columnHeaderOutHum.Width = 290;
            // 
            // columnHeaderPressure
            // 
            columnHeaderPressure.Text = "Pressure";
            columnHeaderPressure.Width = 255;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date Created";
            columnHeaderDate.Width = 255;
            // 
            // radioButtonAll
            // 
            radioButtonAll.AutoSize = true;
            radioButtonAll.Checked = true;
            radioButtonAll.Font = new Font("Calibri", 12F, FontStyle.Bold);
            radioButtonAll.ForeColor = Color.Black;
            radioButtonAll.Location = new Point(29, 55);
            radioButtonAll.Margin = new Padding(4, 3, 4, 3);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new Size(111, 23);
            radioButtonAll.TabIndex = 1;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "Whole table";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.Click += radioButtonAll_Click;
            // 
            // radioButtonIntervall
            // 
            radioButtonIntervall.AutoSize = true;
            radioButtonIntervall.Font = new Font("Calibri", 12F, FontStyle.Bold);
            radioButtonIntervall.ForeColor = Color.Black;
            radioButtonIntervall.Location = new Point(205, 55);
            radioButtonIntervall.Margin = new Padding(4, 3, 4, 3);
            radioButtonIntervall.Name = "radioButtonIntervall";
            radioButtonIntervall.Size = new Size(137, 23);
            radioButtonIntervall.TabIndex = 2;
            radioButtonIntervall.Text = "Choose intervall";
            radioButtonIntervall.UseVisualStyleBackColor = true;
            radioButtonIntervall.Click += radioButtonIntervall_Click;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Enabled = false;
            dateTimePickerStartDate.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePickerStartDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerStartDate.Location = new Point(387, 55);
            dateTimePickerStartDate.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(112, 20);
            dateTimePickerStartDate.TabIndex = 3;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Enabled = false;
            dateTimePickerEndDate.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateTimePickerEndDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerEndDate.Location = new Point(539, 55);
            dateTimePickerEndDate.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(114, 20);
            dateTimePickerEndDate.TabIndex = 4;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelDate.ForeColor = Color.Black;
            labelDate.Location = new Point(387, 87);
            labelDate.Margin = new Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(79, 19);
            labelDate.TabIndex = 5;
            labelDate.Text = "Start Date";
            // 
            // labelDate2
            // 
            labelDate2.AutoSize = true;
            labelDate2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            labelDate2.ForeColor = Color.Black;
            labelDate2.Location = new Point(539, 87);
            labelDate2.Margin = new Padding(4, 0, 4, 0);
            labelDate2.Name = "labelDate2";
            labelDate2.Size = new Size(71, 19);
            labelDate2.TabIndex = 6;
            labelDate2.Text = "End Date";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1552, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backupTableToolStripMenuItem1, restoreTableToolStripMenuItem1, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // backupTableToolStripMenuItem1
            // 
            backupTableToolStripMenuItem1.Name = "backupTableToolStripMenuItem1";
            backupTableToolStripMenuItem1.Size = new Size(144, 22);
            backupTableToolStripMenuItem1.Text = "Backup Table";
            backupTableToolStripMenuItem1.Click += backupTableToolStripMenuItem1_Click;
            // 
            // restoreTableToolStripMenuItem1
            // 
            restoreTableToolStripMenuItem1.Name = "restoreTableToolStripMenuItem1";
            restoreTableToolStripMenuItem1.Size = new Size(144, 22);
            restoreTableToolStripMenuItem1.Text = "Restore Table";
            restoreTableToolStripMenuItem1.Click += restoreTableToolStripMenuItem1_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(144, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteRowsToolStripMenuItem, editSelectedRowToolStripMenuItem, emptyTableToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteRowsToolStripMenuItem
            // 
            deleteRowsToolStripMenuItem.Enabled = false;
            deleteRowsToolStripMenuItem.Name = "deleteRowsToolStripMenuItem";
            deleteRowsToolStripMenuItem.Size = new Size(167, 22);
            deleteRowsToolStripMenuItem.Text = "Delete Rows";
            deleteRowsToolStripMenuItem.Click += deleteRowsToolStripMenuItem_Click;
            // 
            // editSelectedRowToolStripMenuItem
            // 
            editSelectedRowToolStripMenuItem.Enabled = false;
            editSelectedRowToolStripMenuItem.Name = "editSelectedRowToolStripMenuItem";
            editSelectedRowToolStripMenuItem.Size = new Size(167, 22);
            editSelectedRowToolStripMenuItem.Text = "Edit Selected Row";
            editSelectedRowToolStripMenuItem.Click += editSelectedRowToolStripMenuItem_Click;
            // 
            // emptyTableToolStripMenuItem
            // 
            emptyTableToolStripMenuItem.Name = "emptyTableToolStripMenuItem";
            emptyTableToolStripMenuItem.Size = new Size(167, 22);
            emptyTableToolStripMenuItem.Text = "Empty Table";
            emptyTableToolStripMenuItem.Click += emptyTableToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refreshTableToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // refreshTableToolStripMenuItem
            // 
            refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            refreshTableToolStripMenuItem.ShortcutKeys = Keys.F5;
            refreshTableToolStripMenuItem.Size = new Size(163, 22);
            refreshTableToolStripMenuItem.Text = "Refresh Table";
            refreshTableToolStripMenuItem.Click += refreshTableToolStripMenuItem_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(710, 57);
            buttonSearch.Margin = new Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(88, 27);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRows.Location = new Point(14, 1109);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(45, 17);
            labelRows.TabIndex = 10;
            labelRows.Text = "label1";
            // 
            // trackBarSize
            // 
            trackBarSize.Location = new Point(1411, 1088);
            trackBarSize.Maximum = 28;
            trackBarSize.Minimum = 12;
            trackBarSize.Name = "trackBarSize";
            trackBarSize.Size = new Size(124, 45);
            trackBarSize.TabIndex = 11;
            trackBarSize.Value = 15;
            trackBarSize.Scroll += trackBarSize_Scroll;
            // 
            // labelSetFont
            // 
            labelSetFont.AutoSize = true;
            labelSetFont.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            labelSetFont.Location = new Point(1303, 1092);
            labelSetFont.Name = "labelSetFont";
            labelSetFont.Size = new Size(84, 17);
            labelSetFont.TabIndex = 31;
            labelSetFont.Text = "Set font size";
            // 
            // FormModifyTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1552, 1135);
            Controls.Add(labelSetFont);
            Controls.Add(trackBarSize);
            Controls.Add(labelRows);
            Controls.Add(buttonSearch);
            Controls.Add(labelDate2);
            Controls.Add(labelDate);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(dateTimePickerStartDate);
            Controls.Add(radioButtonIntervall);
            Controls.Add(radioButtonAll);
            Controls.Add(listViewShowData);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormModifyTable";
            ShowIcon = false;
            Text = "Weather Station";
            Activated += FormModifyTable_Activated;
            Load += FormModifyTable_Load;
            Enter += FormModifyTable_Enter;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listViewShowData;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonIntervall;
        private System.Windows.Forms.ColumnHeader columnHeaderOutTemp;
        private System.Windows.Forms.ColumnHeader columnHeaderOutHum;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDate2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowsToolStripMenuItem;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ColumnHeader columnHeaderID;
        private System.Windows.Forms.ColumnHeader columnHeaderPressure;
        private System.Windows.Forms.ToolStripMenuItem backupTableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreTableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emptyTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshTableToolStripMenuItem;
        private System.Windows.Forms.Label labelRows;
        private TrackBar trackBarSize;
        private Label labelSetFont;
    }
}