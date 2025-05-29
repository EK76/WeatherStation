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
            listViewShowData = new System.Windows.Forms.ListView();
            columnHeaderID = new System.Windows.Forms.ColumnHeader();
            columnHeaderOutTemp = new System.Windows.Forms.ColumnHeader();
            columnHeaderOutHum = new System.Windows.Forms.ColumnHeader();
            columnHeaderPressure = new System.Windows.Forms.ColumnHeader();
            columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            radioButtonAll = new System.Windows.Forms.RadioButton();
            radioButtonIntervall = new System.Windows.Forms.RadioButton();
            dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            labelDate = new System.Windows.Forms.Label();
            labelDate2 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            backupTableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            restoreTableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editSelectedRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            emptyTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            refreshTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            buttonSearch = new System.Windows.Forms.Button();
            labelRows = new System.Windows.Forms.Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listViewShowData
            // 
            listViewShowData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderID, columnHeaderOutTemp, columnHeaderOutHum, columnHeaderPressure, columnHeaderDate });
            listViewShowData.Font = new System.Drawing.Font("Calibri", 21.75F);
            listViewShowData.FullRowSelect = true;
            listViewShowData.Location = new System.Drawing.Point(14, 112);
            listViewShowData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listViewShowData.Name = "listViewShowData";
            listViewShowData.Size = new System.Drawing.Size(1521, 970);
            listViewShowData.TabIndex = 0;
            listViewShowData.UseCompatibleStateImageBehavior = false;
            listViewShowData.View = System.Windows.Forms.View.Details;
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
            radioButtonAll.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            radioButtonAll.ForeColor = System.Drawing.Color.Black;
            radioButtonAll.Location = new System.Drawing.Point(29, 55);
            radioButtonAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButtonAll.Name = "radioButtonAll";
            radioButtonAll.Size = new System.Drawing.Size(111, 23);
            radioButtonAll.TabIndex = 1;
            radioButtonAll.TabStop = true;
            radioButtonAll.Text = "Whole table";
            radioButtonAll.UseVisualStyleBackColor = true;
            radioButtonAll.Click += radioButtonAll_Click;
            // 
            // radioButtonIntervall
            // 
            radioButtonIntervall.AutoSize = true;
            radioButtonIntervall.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            radioButtonIntervall.ForeColor = System.Drawing.Color.Black;
            radioButtonIntervall.Location = new System.Drawing.Point(205, 55);
            radioButtonIntervall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            radioButtonIntervall.Name = "radioButtonIntervall";
            radioButtonIntervall.Size = new System.Drawing.Size(137, 23);
            radioButtonIntervall.TabIndex = 2;
            radioButtonIntervall.Text = "Choose intervall";
            radioButtonIntervall.UseVisualStyleBackColor = true;
            radioButtonIntervall.Click += radioButtonIntervall_Click;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Enabled = false;
            dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerStartDate.Location = new System.Drawing.Point(387, 55);
            dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new System.Drawing.Size(112, 20);
            dateTimePickerStartDate.TabIndex = 3;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Enabled = false;
            dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerEndDate.Location = new System.Drawing.Point(539, 55);
            dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new System.Drawing.Size(114, 20);
            dateTimePickerEndDate.TabIndex = 4;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            labelDate.ForeColor = System.Drawing.Color.Black;
            labelDate.Location = new System.Drawing.Point(387, 87);
            labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new System.Drawing.Size(79, 19);
            labelDate.TabIndex = 5;
            labelDate.Text = "Start Date";
            // 
            // labelDate2
            // 
            labelDate2.AutoSize = true;
            labelDate2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            labelDate2.ForeColor = System.Drawing.Color.Black;
            labelDate2.Location = new System.Drawing.Point(539, 87);
            labelDate2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDate2.Name = "labelDate2";
            labelDate2.Size = new System.Drawing.Size(71, 19);
            labelDate2.TabIndex = 6;
            labelDate2.Text = "End Date";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(1552, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { backupTableToolStripMenuItem1, restoreTableToolStripMenuItem1, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // backupTableToolStripMenuItem1
            // 
            backupTableToolStripMenuItem1.Name = "backupTableToolStripMenuItem1";
            backupTableToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            backupTableToolStripMenuItem1.Text = "Backup Table";
            backupTableToolStripMenuItem1.Click += backupTableToolStripMenuItem1_Click;
            // 
            // restoreTableToolStripMenuItem1
            // 
            restoreTableToolStripMenuItem1.Name = "restoreTableToolStripMenuItem1";
            restoreTableToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            restoreTableToolStripMenuItem1.Text = "Restore Table";
            restoreTableToolStripMenuItem1.Click += restoreTableToolStripMenuItem1_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { deleteRowsToolStripMenuItem, editSelectedRowToolStripMenuItem, emptyTableToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteRowsToolStripMenuItem
            // 
            deleteRowsToolStripMenuItem.Enabled = false;
            deleteRowsToolStripMenuItem.Name = "deleteRowsToolStripMenuItem";
            deleteRowsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            deleteRowsToolStripMenuItem.Text = "Delete Rows";
            deleteRowsToolStripMenuItem.Click += deleteRowsToolStripMenuItem_Click;
            // 
            // editSelectedRowToolStripMenuItem
            // 
            editSelectedRowToolStripMenuItem.Enabled = false;
            editSelectedRowToolStripMenuItem.Name = "editSelectedRowToolStripMenuItem";
            editSelectedRowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            editSelectedRowToolStripMenuItem.Text = "Edit Selected Row";
            editSelectedRowToolStripMenuItem.Click += editSelectedRowToolStripMenuItem_Click;
            // 
            // emptyTableToolStripMenuItem
            // 
            emptyTableToolStripMenuItem.Name = "emptyTableToolStripMenuItem";
            emptyTableToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            emptyTableToolStripMenuItem.Text = "Empty Table";
            emptyTableToolStripMenuItem.Click += emptyTableToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { refreshTableToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // refreshTableToolStripMenuItem
            // 
            refreshTableToolStripMenuItem.Name = "refreshTableToolStripMenuItem";
            refreshTableToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            refreshTableToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            refreshTableToolStripMenuItem.Text = "Refresh Table";
            refreshTableToolStripMenuItem.Click += refreshTableToolStripMenuItem_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new System.Drawing.Point(710, 57);
            buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(88, 27);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelRows.Location = new System.Drawing.Point(18, 1092);
            labelRows.Name = "labelRows";
            labelRows.Size = new System.Drawing.Size(45, 17);
            labelRows.TabIndex = 10;
            labelRows.Text = "label1";
            // 
            // FormModifyTable
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(1552, 1122);
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
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
    }
}