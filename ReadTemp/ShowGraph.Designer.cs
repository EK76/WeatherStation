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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            oneChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showOneToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            timeIntervallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            intervallToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            diagramViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            diagramToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            chartSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            labelMaxValue = new System.Windows.Forms.Label();
            labelAverageValue = new System.Windows.Forms.Label();
            labelMinValue = new System.Windows.Forms.Label();
            listBoxShowValue = new System.Windows.Forms.ListBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)chartInfo).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chartInfo
            // 
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            chartArea1.AxisY.Maximum = 40D;
            chartArea1.AxisY.Minimum = -40D;
            chartArea1.AxisY.Title = "Celsius";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            chartArea1.Name = "ChartArea1";
            chartInfo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend2.Name = "Legend2";
            legend2.Position.Auto = false;
            legend2.Position.Height = 6.25F;
            legend2.Position.Width = 5.425101F;
            legend2.Position.X = 90.64372F;
            legend2.Position.Y = 20F;
            legend2.Title = "jkkj";
            legend3.Name = "Legend3";
            legend3.Position.Auto = false;
            legend3.Position.Height = 6.25F;
            legend3.Position.Width = 5.425101F;
            legend3.Position.X = 90.64372F;
            legend3.Position.Y = 25F;
            chartInfo.Legends.Add(legend1);
            chartInfo.Legends.Add(legend2);
            chartInfo.Legends.Add(legend3);
            chartInfo.Location = new System.Drawing.Point(12, 39);
            chartInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chartInfo.Name = "chartInfo";
            chartInfo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            series1.Legend = "Legend1";
            series1.Name = "Outdoor Temperature";
            chartInfo.Series.Add(series1);
            chartInfo.Size = new System.Drawing.Size(3013, 1192);
            chartInfo.TabIndex = 2;
            chartInfo.Text = "Chart 3 (Outdoor Temperature).";
            chartInfo.GetToolTipText += chartInfo_GetToolTipText;
            chartInfo.Click += chartInfo_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(3386, 24);
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
            colorOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { chartLineToolStripMenuItem, chartBackgroundToolStripMenuItem });
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
            oneChartToolStripMenuItem.Text = "One Chart";
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
            // labelMaxValue
            // 
            labelMaxValue.AutoSize = true;
            labelMaxValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelMaxValue.Location = new System.Drawing.Point(3046, 105);
            labelMaxValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMaxValue.Name = "labelMaxValue";
            labelMaxValue.Size = new System.Drawing.Size(79, 19);
            labelMaxValue.TabIndex = 4;
            labelMaxValue.Text = "Max Value";
            // 
            // labelAverageValue
            // 
            labelAverageValue.AutoSize = true;
            labelAverageValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelAverageValue.Location = new System.Drawing.Point(3046, 156);
            labelAverageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAverageValue.Name = "labelAverageValue";
            labelAverageValue.Size = new System.Drawing.Size(106, 19);
            labelAverageValue.TabIndex = 6;
            labelAverageValue.Text = "Average Value";
            // 
            // labelMinValue
            // 
            labelMinValue.AutoSize = true;
            labelMinValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelMinValue.Location = new System.Drawing.Point(3046, 203);
            labelMinValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelMinValue.Name = "labelMinValue";
            labelMinValue.Size = new System.Drawing.Size(77, 19);
            labelMinValue.TabIndex = 8;
            labelMinValue.Text = "Min Value";
            // 
            // listBoxShowValue
            // 
            listBoxShowValue.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            listBoxShowValue.FormattingEnabled = true;
            listBoxShowValue.ItemHeight = 26;
            listBoxShowValue.Location = new System.Drawing.Point(3050, 239);
            listBoxShowValue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            listBoxShowValue.Name = "listBoxShowValue";
            listBoxShowValue.Size = new System.Drawing.Size(323, 992);
            listBoxShowValue.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(12, 385);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(88, 627);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // FormViewGraph
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ControlLight;
            ClientSize = new System.Drawing.Size(3386, 1241);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxShowValue);
            Controls.Add(labelMinValue);
            Controls.Add(labelAverageValue);
            Controls.Add(labelMaxValue);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.Windows.Forms.Label labelMaxValue;
        private System.Windows.Forms.Label labelAverageValue;
        private System.Windows.Forms.Label labelMinValue;
        private System.Windows.Forms.ListBox listBoxShowValue;
        private System.Windows.Forms.ToolStripMenuItem chartLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartBackgroundToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem diagramViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox diagramToolStripComboBox;
    }
}