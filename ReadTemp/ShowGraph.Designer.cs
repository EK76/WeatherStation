namespace ReadTemp
{
    partial class FormViewGraph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            colorOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            chartLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            chartBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            formBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            defaultSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            oneChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showOneToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            timeIntervallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            intervallToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            diagramViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            diagramToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            chartSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            createRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            listBoxShowValue = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)chartInfo).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // chartInfo
            // 
            chartInfo.BackColor = System.Drawing.Color.LightGray;
            chartInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            chartInfo.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartInfo.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartInfo.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartInfo.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chartArea1.AxisY.Maximum = 40D;
            chartArea1.AxisY.Minimum = -40D;
            chartArea1.AxisY.Title = "Celsius";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chartArea1.Name = "ChartArea1";
            chartInfo.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            legend1.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chartInfo.Legends.Add(legend1);
            chartInfo.Location = new System.Drawing.Point(12, 38);
            chartInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chartInfo.Name = "chartInfo";
            chartInfo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            series1.Legend = "Legend1";
            series1.Name = "Outdoor Temperature";
            chartInfo.Series.Add(series1);
            chartInfo.Size = new System.Drawing.Size(3009, 1205);
            chartInfo.TabIndex = 2;
            chartInfo.Text = "Chart 3 (Outdoor Temperature).";
            chartInfo.GetToolTipText += chartInfo_GetToolTipText;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(3354, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { saveChartToolStripMenuItem, printChartToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveChartToolStripMenuItem
            // 
            saveChartToolStripMenuItem.Name = "saveChartToolStripMenuItem";
            saveChartToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            saveChartToolStripMenuItem.Text = "Save Chart";
            saveChartToolStripMenuItem.Click += saveChartToolStripMenuItem_Click;
            // 
            // printChartToolStripMenuItem
            // 
            printChartToolStripMenuItem.Name = "printChartToolStripMenuItem";
            printChartToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            printChartToolStripMenuItem.Text = "Print Chart";
            printChartToolStripMenuItem.Click += printChartToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyChartToolStripMenuItem, colorOptionToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyChartToolStripMenuItem
            // 
            copyChartToolStripMenuItem.Name = "copyChartToolStripMenuItem";
            copyChartToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            copyChartToolStripMenuItem.Text = "Copy Chart";
            copyChartToolStripMenuItem.Click += copyChartToolStripMenuItem_Click;
            // 
            // colorOptionToolStripMenuItem
            // 
            colorOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { chartLineToolStripMenuItem, chartBackgroundToolStripMenuItem, formBackgroundToolStripMenuItem, defaultSettingToolStripMenuItem });
            colorOptionToolStripMenuItem.Name = "colorOptionToolStripMenuItem";
            colorOptionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            colorOptionToolStripMenuItem.Text = "Color Option";
            // 
            // chartLineToolStripMenuItem
            // 
            chartLineToolStripMenuItem.Name = "chartLineToolStripMenuItem";
            chartLineToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            chartLineToolStripMenuItem.Text = "Chart Line";
            chartLineToolStripMenuItem.Click += chartLineToolStripMenuItem_Click;
            // 
            // chartBackgroundToolStripMenuItem
            // 
            chartBackgroundToolStripMenuItem.Name = "chartBackgroundToolStripMenuItem";
            chartBackgroundToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            chartBackgroundToolStripMenuItem.Text = "Chart Background";
            chartBackgroundToolStripMenuItem.Click += chartBackgroundToolStripMenuItem_Click;
            // 
            // formBackgroundToolStripMenuItem
            // 
            formBackgroundToolStripMenuItem.Name = "formBackgroundToolStripMenuItem";
            formBackgroundToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            formBackgroundToolStripMenuItem.Text = "Form Background";
            formBackgroundToolStripMenuItem.Click += formBackgroundToolStripMenuItem_Click;
            // 
            // defaultSettingToolStripMenuItem
            // 
            defaultSettingToolStripMenuItem.Enabled = false;
            defaultSettingToolStripMenuItem.Name = "defaultSettingToolStripMenuItem";
            defaultSettingToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            defaultSettingToolStripMenuItem.Text = "Default Setting";
            defaultSettingToolStripMenuItem.Click += defaultSettingToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { oneChartToolStripMenuItem, timeIntervallToolStripMenuItem, diagramViewToolStripMenuItem1, chartSummaryToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // oneChartToolStripMenuItem
            // 
            oneChartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { showOneToolStripComboBox });
            oneChartToolStripMenuItem.Name = "oneChartToolStripMenuItem";
            oneChartToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            oneChartToolStripMenuItem.Text = "Chart";
            // 
            // showOneToolStripComboBox
            // 
            showOneToolStripComboBox.DropDownWidth = 140;
            showOneToolStripComboBox.Items.AddRange(new object[] { "Temperature", "Humidity", "Pressure" });
            showOneToolStripComboBox.Name = "showOneToolStripComboBox";
            showOneToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            showOneToolStripComboBox.Text = "Temperature";
            showOneToolStripComboBox.SelectedIndexChanged += showOneToolStripComboBox_SelectedIndexChanged;
            // 
            // timeIntervallToolStripMenuItem
            // 
            timeIntervallToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { intervallToolStripComboBox });
            timeIntervallToolStripMenuItem.Name = "timeIntervallToolStripMenuItem";
            timeIntervallToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            timeIntervallToolStripMenuItem.Text = "Time intervall";
            // 
            // intervallToolStripComboBox
            // 
            intervallToolStripComboBox.Items.AddRange(new object[] { "10 minutes", "30 minutes", "60 minutes" });
            intervallToolStripComboBox.Name = "intervallToolStripComboBox";
            intervallToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            intervallToolStripComboBox.Text = "10 minutes";
            intervallToolStripComboBox.SelectedIndexChanged += intervallToolStripComboBox_SelectedIndexChanged;
            // 
            // diagramViewToolStripMenuItem1
            // 
            diagramViewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { diagramToolStripComboBox });
            diagramViewToolStripMenuItem1.Name = "diagramViewToolStripMenuItem1";
            diagramViewToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            diagramViewToolStripMenuItem1.Text = "Diagram View";
            // 
            // diagramToolStripComboBox
            // 
            diagramToolStripComboBox.Items.AddRange(new object[] { "Line", "Column" });
            diagramToolStripComboBox.Name = "diagramToolStripComboBox";
            diagramToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            diagramToolStripComboBox.Text = "Line";
            diagramToolStripComboBox.SelectedIndexChanged += diagramToolStripComboBox_SelectedIndexChanged;
            // 
            // chartSummaryToolStripMenuItem
            // 
            chartSummaryToolStripMenuItem.Name = "chartSummaryToolStripMenuItem";
            chartSummaryToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            chartSummaryToolStripMenuItem.Text = "Chart Summary";
            chartSummaryToolStripMenuItem.Click += chartSummaryToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { createRapportToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // createRapportToolStripMenuItem
            // 
            createRapportToolStripMenuItem.Name = "createRapportToolStripMenuItem";
            createRapportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            createRapportToolStripMenuItem.Text = "Create Rapport";
            createRapportToolStripMenuItem.Click += createRapportToolStripMenuItem_Click;
            // 
            // listBoxShowValue
            // 
            listBoxShowValue.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            listBoxShowValue.FormattingEnabled = true;
            listBoxShowValue.ItemHeight = 26;
            listBoxShowValue.Location = new System.Drawing.Point(3029, 43);
            listBoxShowValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBoxShowValue.Name = "listBoxShowValue";
            listBoxShowValue.Size = new System.Drawing.Size(312, 1200);
            listBoxShowValue.TabIndex = 9;
            // 
            // FormViewGraph
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.CadetBlue;
            ClientSize = new System.Drawing.Size(3354, 1255);
            Controls.Add(listBoxShowValue);
            Controls.Add(chartInfo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "FormViewGraph";
            ShowIcon = false;
            Text = "Weather Station";
            Load += FormViewGraph_Load;
            Resize += FormViewGraph_Resize;
            ((System.ComponentModel.ISupportInitialize)chartInfo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox showOneToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorOptionToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeIntervallToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox intervallToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem chartSummaryToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBoxShowValue;
        private System.Windows.Forms.ToolStripMenuItem chartLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagramViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox diagramToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem formBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultSettingToolStripMenuItem;
    }
}