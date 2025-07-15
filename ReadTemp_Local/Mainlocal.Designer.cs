namespace ReadTemp_Local
{
    partial class FormShowData2
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
            columnHeaderOutTemp = new System.Windows.Forms.ColumnHeader();
            columnHeaderOutHum = new System.Windows.Forms.ColumnHeader();
            columnHeaderPressure = new System.Windows.Forms.ColumnHeader();
            columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editTolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            graphViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutWeatherInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            trackBarSize = new System.Windows.Forms.TrackBar();
            labelText = new System.Windows.Forms.Label();
            labelRows = new System.Windows.Forms.Label();
            listViewPrinter1 = new BrightIdeasSoftware.ListViewPrinter();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).BeginInit();
            SuspendLayout();
            // 
            // listViewShowData
            // 
            listViewShowData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeaderOutTemp, columnHeaderOutHum, columnHeaderPressure, columnHeaderDate });
            listViewShowData.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            listViewShowData.FullRowSelect = true;
            listViewShowData.Location = new System.Drawing.Point(0, 39);
            listViewShowData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listViewShowData.Name = "listViewShowData";
            listViewShowData.Size = new System.Drawing.Size(1393, 867);
            listViewShowData.TabIndex = 18;
            listViewShowData.UseCompatibleStateImageBehavior = false;
            listViewShowData.View = System.Windows.Forms.View.Details;
            listViewShowData.SelectedIndexChanged += listViewShowData_SelectedIndexChanged;
            listViewShowData.Click += listViewShowData_Click;
            // 
            // columnHeaderOutTemp
            // 
            columnHeaderOutTemp.Text = "Outdoor temperature";
            columnHeaderOutTemp.Width = 330;
            // 
            // columnHeaderOutHum
            // 
            columnHeaderOutHum.Text = "Outdoor humidity";
            columnHeaderOutHum.Width = 330;
            // 
            // columnHeaderPressure
            // 
            columnHeaderPressure.Text = "Pressure";
            columnHeaderPressure.Width = 330;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Date created";
            columnHeaderDate.Width = 360;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editTolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1393, 24);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, printStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // printStripMenuItem
            // 
            printStripMenuItem.Enabled = false;
            printStripMenuItem.Name = "printStripMenuItem";
            printStripMenuItem.Size = new System.Drawing.Size(180, 22);
            printStripMenuItem.Text = "Print";
            printStripMenuItem.Click += printStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editTolStripMenuItem
            // 
            editTolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { deleteRowsToolStripMenuItem, clearDataToolStripMenuItem });
            editTolStripMenuItem.Name = "editTolStripMenuItem";
            editTolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editTolStripMenuItem.Text = "Edit";
            // 
            // deleteRowsToolStripMenuItem
            // 
            deleteRowsToolStripMenuItem.Enabled = false;
            deleteRowsToolStripMenuItem.Name = "deleteRowsToolStripMenuItem";
            deleteRowsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            deleteRowsToolStripMenuItem.Text = "Delete Rows";
            deleteRowsToolStripMenuItem.Click += deleteRowsToolStripMenuItem_Click;
            // 
            // clearDataToolStripMenuItem
            // 
            clearDataToolStripMenuItem.Enabled = false;
            clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            clearDataToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            clearDataToolStripMenuItem.Text = "Clear Data";
            clearDataToolStripMenuItem.Click += clearDataToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { graphViewToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // graphViewToolStripMenuItem
            // 
            graphViewToolStripMenuItem.Enabled = false;
            graphViewToolStripMenuItem.Name = "graphViewToolStripMenuItem";
            graphViewToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            graphViewToolStripMenuItem.Text = "Graph View";
            graphViewToolStripMenuItem.Click += graphViewToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { reportToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Enabled = false;
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            reportToolStripMenuItem.Text = "Create table as PDF report";
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutWeatherInfoToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutWeatherInfoToolStripMenuItem
            // 
            aboutWeatherInfoToolStripMenuItem.Name = "aboutWeatherInfoToolStripMenuItem";
            aboutWeatherInfoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            aboutWeatherInfoToolStripMenuItem.Text = "About Weather Info";
            aboutWeatherInfoToolStripMenuItem.Click += aboutWeatherInfoToolStripMenuItem_Click;
            // 
            // trackBarSize
            // 
            trackBarSize.Location = new System.Drawing.Point(1212, 912);
            trackBarSize.Maximum = 28;
            trackBarSize.Minimum = 12;
            trackBarSize.Name = "trackBarSize";
            trackBarSize.Size = new System.Drawing.Size(169, 45);
            trackBarSize.TabIndex = 30;
            trackBarSize.Value = 15;
            trackBarSize.Scroll += trackBarSize_Scroll;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            labelText.Location = new System.Drawing.Point(1105, 912);
            labelText.Name = "labelText";
            labelText.Size = new System.Drawing.Size(84, 17);
            labelText.TabIndex = 31;
            labelText.Text = "Set font size";
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelRows.Location = new System.Drawing.Point(21, 912);
            labelRows.Name = "labelRows";
            labelRows.Size = new System.Drawing.Size(122, 17);
            labelRows.TabIndex = 32;
            labelRows.Text = "Numbers of rows: ";
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
            listViewPrinter1.HeaderFormat.Font = new System.Drawing.Font("Verdana", 24F);
            // 
            // 
            // 
            listViewPrinter1.ListHeaderFormat.CanWrap = true;
            listViewPrinter1.ListHeaderFormat.Font = new System.Drawing.Font("Verdana", 12F);
            listViewPrinter1.ListView = listViewShowData;
            // 
            // FormShowData2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1393, 960);
            Controls.Add(labelRows);
            Controls.Add(labelText);
            Controls.Add(trackBarSize);
            Controls.Add(listViewShowData);
            Controls.Add(menuStrip1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormShowData2";
            Text = "Weather Station";
            Load += FormShowData2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarSize).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewShowData;
        private System.Windows.Forms.ColumnHeader columnHeaderOutTemp;
        private System.Windows.Forms.ColumnHeader columnHeaderOutHum;
        private System.Windows.Forms.ColumnHeader columnHeaderPressure;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.ToolStripMenuItem editTolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printStripMenuItem;
        private BrightIdeasSoftware.ListViewPrinter listViewPrinter1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutWeatherInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

