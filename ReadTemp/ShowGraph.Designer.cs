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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            saveChartToolStripMenuItem = new ToolStripMenuItem();
            printChartToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            copyChartToolStripMenuItem = new ToolStripMenuItem();
            defaultChartSettingsToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            oneChartToolStripMenuItem = new ToolStripMenuItem();
            showOneToolStripComboBox = new ToolStripComboBox();
            diagramViewToolStripMenuItem1 = new ToolStripMenuItem();
            diagramToolStripComboBox = new ToolStripComboBox();
            chartSummaryToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            colorDialog1 = new ColorDialog();
            listBoxShowValue = new ListBox();
            panelSettings = new Panel();
            comboBoxLineSize = new ComboBox();
            labelLineSixe = new Label();
            buttonSetColor = new Button();
            comboBoxChartColor = new ComboBox();
            labelPanelMarker3 = new Label();
            comboBoxMarkerSize = new ComboBox();
            comboBoxMarkerType = new ComboBox();
            labelPanelMarker2 = new Label();
            labelPanelMarker = new Label();
            labelColorPanel4 = new Label();
            labelPanel = new Label();
            labelDateUpdate = new Label();
            panelDisplay = new Panel();
            labelAverage = new Label();
            labelMin = new Label();
            labelMax = new Label();
            labelDateFirst = new Label();
            labelDateLast = new Label();
            chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1.SuspendLayout();
            panelSettings.SuspendLayout();
            panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartInfo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(3354, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveChartToolStripMenuItem, printChartToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // saveChartToolStripMenuItem
            // 
            saveChartToolStripMenuItem.Name = "saveChartToolStripMenuItem";
            saveChartToolStripMenuItem.Size = new Size(131, 22);
            saveChartToolStripMenuItem.Text = "Save Chart";
            saveChartToolStripMenuItem.Click += saveChartToolStripMenuItem_Click;
            // 
            // printChartToolStripMenuItem
            // 
            printChartToolStripMenuItem.Name = "printChartToolStripMenuItem";
            printChartToolStripMenuItem.Size = new Size(131, 22);
            printChartToolStripMenuItem.Text = "Print Chart";
            printChartToolStripMenuItem.Click += printChartToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(131, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyChartToolStripMenuItem, defaultChartSettingsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyChartToolStripMenuItem
            // 
            copyChartToolStripMenuItem.Name = "copyChartToolStripMenuItem";
            copyChartToolStripMenuItem.Size = new Size(189, 22);
            copyChartToolStripMenuItem.Text = "Copy Chart";
            copyChartToolStripMenuItem.Click += copyChartToolStripMenuItem_Click;
            // 
            // defaultChartSettingsToolStripMenuItem
            // 
            defaultChartSettingsToolStripMenuItem.Name = "defaultChartSettingsToolStripMenuItem";
            defaultChartSettingsToolStripMenuItem.Size = new Size(189, 22);
            defaultChartSettingsToolStripMenuItem.Text = "Default Chart Settings";
            defaultChartSettingsToolStripMenuItem.Click += defaultChartSettingsToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oneChartToolStripMenuItem, diagramViewToolStripMenuItem1, chartSummaryToolStripMenuItem, toolStripMenuItem1, settingsToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // oneChartToolStripMenuItem
            // 
            oneChartToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showOneToolStripComboBox });
            oneChartToolStripMenuItem.Name = "oneChartToolStripMenuItem";
            oneChartToolStripMenuItem.Size = new Size(157, 22);
            oneChartToolStripMenuItem.Text = "Chart";
            // 
            // showOneToolStripComboBox
            // 
            showOneToolStripComboBox.DropDownWidth = 140;
            showOneToolStripComboBox.Items.AddRange(new object[] { "Temperature", "Humidity", "Pressure" });
            showOneToolStripComboBox.Name = "showOneToolStripComboBox";
            showOneToolStripComboBox.Size = new Size(121, 23);
            showOneToolStripComboBox.Text = "Temperature";
            showOneToolStripComboBox.SelectedIndexChanged += showOneToolStripComboBox_SelectedIndexChanged;
            // 
            // diagramViewToolStripMenuItem1
            // 
            diagramViewToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { diagramToolStripComboBox });
            diagramViewToolStripMenuItem1.Name = "diagramViewToolStripMenuItem1";
            diagramViewToolStripMenuItem1.Size = new Size(157, 22);
            diagramViewToolStripMenuItem1.Text = "Diagram View";
            // 
            // diagramToolStripComboBox
            // 
            diagramToolStripComboBox.Items.AddRange(new object[] { "Line", "Column" });
            diagramToolStripComboBox.Name = "diagramToolStripComboBox";
            diagramToolStripComboBox.Size = new Size(121, 23);
            diagramToolStripComboBox.Text = "Line";
            diagramToolStripComboBox.SelectedIndexChanged += diagramToolStripComboBox_SelectedIndexChanged;
            // 
            // chartSummaryToolStripMenuItem
            // 
            chartSummaryToolStripMenuItem.Name = "chartSummaryToolStripMenuItem";
            chartSummaryToolStripMenuItem.Size = new Size(157, 22);
            chartSummaryToolStripMenuItem.Text = "Chart Summary";
            chartSummaryToolStripMenuItem.Click += chartSummaryToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(154, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(157, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // listBoxShowValue
            // 
            listBoxShowValue.Font = new Font("Calibri", 16F, FontStyle.Bold);
            listBoxShowValue.FormattingEnabled = true;
            listBoxShowValue.ItemHeight = 26;
            listBoxShowValue.Location = new Point(3029, 225);
            listBoxShowValue.Margin = new Padding(4, 3, 4, 3);
            listBoxShowValue.Name = "listBoxShowValue";
            listBoxShowValue.Size = new Size(312, 1018);
            listBoxShowValue.TabIndex = 9;
            listBoxShowValue.Click += listBoxShowValue_Click;
            listBoxShowValue.SelectedIndexChanged += listBoxShowValue_SelectedIndexChanged;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.LightGray;
            panelSettings.BorderStyle = BorderStyle.Fixed3D;
            panelSettings.Controls.Add(comboBoxLineSize);
            panelSettings.Controls.Add(labelLineSixe);
            panelSettings.Controls.Add(buttonSetColor);
            panelSettings.Controls.Add(comboBoxChartColor);
            panelSettings.Controls.Add(labelPanelMarker3);
            panelSettings.Controls.Add(comboBoxMarkerSize);
            panelSettings.Controls.Add(comboBoxMarkerType);
            panelSettings.Controls.Add(labelPanelMarker2);
            panelSettings.Controls.Add(labelPanelMarker);
            panelSettings.Controls.Add(labelColorPanel4);
            panelSettings.Controls.Add(labelPanel);
            panelSettings.Location = new Point(12, 108);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(176, 324);
            panelSettings.TabIndex = 10;
            panelSettings.Visible = false;
            panelSettings.Paint += panelSettings_Paint;
            // 
            // comboBoxLineSize
            // 
            comboBoxLineSize.FormattingEnabled = true;
            comboBoxLineSize.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            comboBoxLineSize.Location = new Point(81, 158);
            comboBoxLineSize.Name = "comboBoxLineSize";
            comboBoxLineSize.Size = new Size(32, 23);
            comboBoxLineSize.TabIndex = 13;
            comboBoxLineSize.SelectedIndexChanged += comboBoxLineSize_SelectedIndexChanged;
            // 
            // labelLineSixe
            // 
            labelLineSixe.AutoSize = true;
            labelLineSixe.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelLineSixe.Location = new Point(8, 158);
            labelLineSixe.Name = "labelLineSixe";
            labelLineSixe.Size = new Size(54, 15);
            labelLineSixe.TabIndex = 12;
            labelLineSixe.Text = "Line size";
            // 
            // buttonSetColor
            // 
            buttonSetColor.Enabled = false;
            buttonSetColor.Location = new Point(8, 111);
            buttonSetColor.Name = "buttonSetColor";
            buttonSetColor.Size = new Size(75, 23);
            buttonSetColor.TabIndex = 11;
            buttonSetColor.Text = "Set Color";
            buttonSetColor.UseVisualStyleBackColor = true;
            buttonSetColor.Click += buttonSetColor_Click;
            // 
            // comboBoxChartColor
            // 
            comboBoxChartColor.FormattingEnabled = true;
            comboBoxChartColor.Items.AddRange(new object[] { "Chart", "Background", "Line" });
            comboBoxChartColor.Location = new Point(8, 73);
            comboBoxChartColor.Name = "comboBoxChartColor";
            comboBoxChartColor.Size = new Size(139, 23);
            comboBoxChartColor.TabIndex = 10;
            comboBoxChartColor.SelectedIndexChanged += comboBoxChartColor_SelectedIndexChanged;
            // 
            // labelPanelMarker3
            // 
            labelPanelMarker3.AutoSize = true;
            labelPanelMarker3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPanelMarker3.Location = new Point(11, 205);
            labelPanelMarker3.Name = "labelPanelMarker3";
            labelPanelMarker3.Size = new Size(48, 15);
            labelPanelMarker3.TabIndex = 9;
            labelPanelMarker3.Text = "Marker";
            // 
            // comboBoxMarkerSize
            // 
            comboBoxMarkerSize.FormattingEnabled = true;
            comboBoxMarkerSize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "13", "14", "15", "16" });
            comboBoxMarkerSize.Location = new Point(51, 275);
            comboBoxMarkerSize.Name = "comboBoxMarkerSize";
            comboBoxMarkerSize.Size = new Size(51, 23);
            comboBoxMarkerSize.TabIndex = 8;
            comboBoxMarkerSize.SelectedIndexChanged += comboBoxMarkerSize_SelectedIndexChanged;
            // 
            // comboBoxMarkerType
            // 
            comboBoxMarkerType.FormattingEnabled = true;
            comboBoxMarkerType.Items.AddRange(new object[] { "None", "Circle", "Square", "Triangle", "Cross", "Star" });
            comboBoxMarkerType.Location = new Point(50, 235);
            comboBoxMarkerType.Name = "comboBoxMarkerType";
            comboBoxMarkerType.Size = new Size(97, 23);
            comboBoxMarkerType.TabIndex = 7;
            comboBoxMarkerType.SelectedIndexChanged += comboBoxMarkerType_SelectedIndexChanged;
            // 
            // labelPanelMarker2
            // 
            labelPanelMarker2.AutoSize = true;
            labelPanelMarker2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPanelMarker2.Location = new Point(11, 278);
            labelPanelMarker2.Name = "labelPanelMarker2";
            labelPanelMarker2.Size = new Size(30, 15);
            labelPanelMarker2.TabIndex = 6;
            labelPanelMarker2.Text = "Size";
            // 
            // labelPanelMarker
            // 
            labelPanelMarker.AutoSize = true;
            labelPanelMarker.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPanelMarker.Location = new Point(11, 238);
            labelPanelMarker.Name = "labelPanelMarker";
            labelPanelMarker.Size = new Size(33, 15);
            labelPanelMarker.TabIndex = 5;
            labelPanelMarker.Text = "Type";
            // 
            // labelColorPanel4
            // 
            labelColorPanel4.AutoSize = true;
            labelColorPanel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelColorPanel4.Location = new Point(8, 50);
            labelColorPanel4.Name = "labelColorPanel4";
            labelColorPanel4.Size = new Size(36, 15);
            labelColorPanel4.TabIndex = 4;
            labelColorPanel4.Text = "Color";
            // 
            // labelPanel
            // 
            labelPanel.AutoSize = true;
            labelPanel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPanel.Location = new Point(8, 12);
            labelPanel.Name = "labelPanel";
            labelPanel.Size = new Size(117, 20);
            labelPanel.TabIndex = 0;
            labelPanel.Text = "Layout settings";
            // 
            // labelDateUpdate
            // 
            labelDateUpdate.AutoSize = true;
            labelDateUpdate.BackColor = Color.LightGray;
            labelDateUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDateUpdate.Location = new Point(2674, 217);
            labelDateUpdate.Name = "labelDateUpdate";
            labelDateUpdate.Size = new Size(0, 25);
            labelDateUpdate.TabIndex = 11;
            // 
            // panelDisplay
            // 
            panelDisplay.Controls.Add(labelAverage);
            panelDisplay.Controls.Add(labelMin);
            panelDisplay.Controls.Add(labelMax);
            panelDisplay.Font = new Font("Calibri", 16F, FontStyle.Bold);
            panelDisplay.Location = new Point(3029, 38);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(312, 168);
            panelDisplay.TabIndex = 12;
            // 
            // labelAverage
            // 
            labelAverage.AllowDrop = true;
            labelAverage.AutoSize = true;
            labelAverage.Location = new Point(14, 122);
            labelAverage.Name = "labelAverage";
            labelAverage.Size = new Size(67, 27);
            labelAverage.TabIndex = 2;
            labelAverage.Text = "label3";
            // 
            // labelMin
            // 
            labelMin.AutoSize = true;
            labelMin.Location = new Point(14, 70);
            labelMin.Name = "labelMin";
            labelMin.Size = new Size(67, 27);
            labelMin.TabIndex = 1;
            labelMin.Text = "label2";
            // 
            // labelMax
            // 
            labelMax.AutoSize = true;
            labelMax.Location = new Point(14, 22);
            labelMax.Name = "labelMax";
            labelMax.Size = new Size(67, 27);
            labelMax.TabIndex = 0;
            labelMax.Text = "label1";
            // 
            // labelDateFirst
            // 
            labelDateFirst.AutoSize = true;
            labelDateFirst.BackColor = Color.LightGray;
            labelDateFirst.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateFirst.Location = new Point(232, 1133);
            labelDateFirst.Name = "labelDateFirst";
            labelDateFirst.Size = new Size(45, 17);
            labelDateFirst.TabIndex = 15;
            labelDateFirst.Text = "label3";
            // 
            // labelDateLast
            // 
            labelDateLast.AutoSize = true;
            labelDateLast.BackColor = Color.LightGray;
            labelDateLast.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDateLast.Location = new Point(2559, 1133);
            labelDateLast.Name = "labelDateLast";
            labelDateLast.Size = new Size(45, 17);
            labelDateLast.TabIndex = 16;
            labelDateLast.Text = "label4";
            // 
            // chartInfo
            // 
            chartInfo.BackColor = Color.LightGray;
            chartInfo.BackgroundImageLayout = ImageLayout.Zoom;
            chartInfo.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartInfo.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartInfo.BorderSkin.PageColor = Color.Transparent;
            chartInfo.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea1.AxisX.LabelStyle.ForeColor = Color.Transparent;
            chartArea1.AxisX.Title = "Date";
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.Maximum = 40D;
            chartArea1.AxisY.Minimum = -40D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Title = "Celsius";
            chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chartArea1.Name = "ChartArea1";
            chartInfo.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Transparent;
            legend1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = StringAlignment.Far;
            legend1.TitleFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartInfo.Legends.Add(legend1);
            chartInfo.Location = new Point(1, 27);
            chartInfo.Margin = new Padding(4, 3, 4, 3);
            chartInfo.Name = "chartInfo";
            chartInfo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            series1.Legend = "Legend1";
            series1.Name = "Outdoor Temperature";
            chartInfo.Series.Add(series1);
            chartInfo.Size = new Size(3021, 1225);
            chartInfo.SuppressExceptions = true;
            chartInfo.TabIndex = 2;
            chartInfo.Text = "Chart 3 ";
            chartInfo.GetToolTipText += chartInfo_GetToolTipText;
            // 
            // FormViewGraph
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(3354, 1255);
            Controls.Add(labelDateFirst);
            Controls.Add(labelDateLast);
            Controls.Add(panelDisplay);
            Controls.Add(labelDateUpdate);
            Controls.Add(panelSettings);
            Controls.Add(listBoxShowValue);
            Controls.Add(chartInfo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            MinimizeBox = false;
            Name = "FormViewGraph";
            ShowIcon = false;
            Text = "Weather Station";
            Load += FormViewGraph_Load;
            Resize += FormViewGraph_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            panelDisplay.ResumeLayout(false);
            panelDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox showOneToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyChartToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartSummaryToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBoxShowValue;
        private System.Windows.Forms.ToolStripMenuItem diagramViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox diagramToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Label labelPanelMarker2;
        private System.Windows.Forms.Label labelPanelMarker;
        private System.Windows.Forms.Label labelColorPanel4;
        private System.Windows.Forms.Label labelPanel;
        private System.Windows.Forms.ComboBox comboBoxMarkerSize;
        private System.Windows.Forms.ComboBox comboBoxMarkerType;
        private System.Windows.Forms.ComboBox comboBoxChartColor;
        private System.Windows.Forms.Label labelPanelMarker3;
        private System.Windows.Forms.Button buttonSetColor;
        private System.Windows.Forms.ToolStripMenuItem defaultChartSettingsToolStripMenuItem;
        private Label labelDateUpdate;
        private Panel panelDisplay;
        private Label labelAverage;
        private Label labelMin;
        private Label labelMax;
        private Label labelDateFirst;
        private Label labelDateLast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo;
        private Label labelLineSixe;
        private ComboBox comboBoxLineSize;
    }
}