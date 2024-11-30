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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            saveChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            printChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            defaultChartSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            oneChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            showOneToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            timeIntervallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            intervallToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            diagramViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            diagramToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            chartSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            createRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            listBoxShowValue = new System.Windows.Forms.ListBox();
            panelSettings = new System.Windows.Forms.Panel();
            buttonSetColor = new System.Windows.Forms.Button();
            comboBoxChartColor = new System.Windows.Forms.ComboBox();
            labelPanelMarker3 = new System.Windows.Forms.Label();
            comboBoxMarkerSize = new System.Windows.Forms.ComboBox();
            comboBoxMarkerType = new System.Windows.Forms.ComboBox();
            labelPanelMarker2 = new System.Windows.Forms.Label();
            labelPanelMarker = new System.Windows.Forms.Label();
            labelColorPanel4 = new System.Windows.Forms.Label();
            labelPanel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)chartInfo).BeginInit();
            menuStrip1.SuspendLayout();
            panelSettings.SuspendLayout();
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
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Title = "Date";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chartArea2.AxisY.Maximum = 40D;
            chartArea2.AxisY.Minimum = -40D;
            chartArea2.AxisY.Title = "Celsius";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            chartArea2.Name = "ChartArea1";
            chartInfo.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Far;
            legend2.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            chartInfo.Legends.Add(legend2);
            chartInfo.Location = new System.Drawing.Point(0, 38);
            chartInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chartInfo.Name = "chartInfo";
            chartInfo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            series2.Legend = "Legend1";
            series2.Name = "Outdoor Temperature";
            chartInfo.Series.Add(series2);
            chartInfo.Size = new System.Drawing.Size(3021, 1205);
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
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyChartToolStripMenuItem, defaultChartSettingsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyChartToolStripMenuItem
            // 
            copyChartToolStripMenuItem.Name = "copyChartToolStripMenuItem";
            copyChartToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            copyChartToolStripMenuItem.Text = "Copy Chart";
            copyChartToolStripMenuItem.Click += copyChartToolStripMenuItem_Click;
            // 
            // defaultChartSettingsToolStripMenuItem
            // 
            defaultChartSettingsToolStripMenuItem.Name = "defaultChartSettingsToolStripMenuItem";
            defaultChartSettingsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            defaultChartSettingsToolStripMenuItem.Text = "Default Chart Settings";
            defaultChartSettingsToolStripMenuItem.Click += defaultChartSettingsToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { oneChartToolStripMenuItem, timeIntervallToolStripMenuItem, diagramViewToolStripMenuItem1, chartSummaryToolStripMenuItem, toolStripMenuItem1, settingsToolStripMenuItem });
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { createRapportToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // createRapportToolStripMenuItem
            // 
            createRapportToolStripMenuItem.Name = "createRapportToolStripMenuItem";
            createRapportToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            createRapportToolStripMenuItem.Text = "Create Rapport";
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
            listBoxShowValue.Click += listBoxShowValue_Click;
            listBoxShowValue.SelectedIndexChanged += listBoxShowValue_SelectedIndexChanged;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = System.Drawing.Color.LightGray;
            panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelSettings.Controls.Add(buttonSetColor);
            panelSettings.Controls.Add(comboBoxChartColor);
            panelSettings.Controls.Add(labelPanelMarker3);
            panelSettings.Controls.Add(comboBoxMarkerSize);
            panelSettings.Controls.Add(comboBoxMarkerType);
            panelSettings.Controls.Add(labelPanelMarker2);
            panelSettings.Controls.Add(labelPanelMarker);
            panelSettings.Controls.Add(labelColorPanel4);
            panelSettings.Controls.Add(labelPanel);
            panelSettings.Location = new System.Drawing.Point(12, 108);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new System.Drawing.Size(176, 324);
            panelSettings.TabIndex = 10;
            panelSettings.Visible = false;
            panelSettings.Paint += panelSettings_Paint;
            // 
            // buttonSetColor
            // 
            buttonSetColor.Enabled = false;
            buttonSetColor.Location = new System.Drawing.Point(8, 111);
            buttonSetColor.Name = "buttonSetColor";
            buttonSetColor.Size = new System.Drawing.Size(75, 23);
            buttonSetColor.TabIndex = 11;
            buttonSetColor.Text = "Set Color";
            buttonSetColor.UseVisualStyleBackColor = true;
            buttonSetColor.Click += buttonSetColor_Click;
            // 
            // comboBoxChartColor
            // 
            comboBoxChartColor.FormattingEnabled = true;
            comboBoxChartColor.Items.AddRange(new object[] { "Chart", "Background", "Line" });
            comboBoxChartColor.Location = new System.Drawing.Point(8, 73);
            comboBoxChartColor.Name = "comboBoxChartColor";
            comboBoxChartColor.Size = new System.Drawing.Size(139, 23);
            comboBoxChartColor.TabIndex = 10;
            comboBoxChartColor.SelectedIndexChanged += comboBoxChartColor_SelectedIndexChanged;
            // 
            // labelPanelMarker3
            // 
            labelPanelMarker3.AutoSize = true;
            labelPanelMarker3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelPanelMarker3.Location = new System.Drawing.Point(11, 174);
            labelPanelMarker3.Name = "labelPanelMarker3";
            labelPanelMarker3.Size = new System.Drawing.Size(48, 15);
            labelPanelMarker3.TabIndex = 9;
            labelPanelMarker3.Text = "Marker";
            // 
            // comboBoxMarkerSize
            // 
            comboBoxMarkerSize.FormattingEnabled = true;
            comboBoxMarkerSize.Items.AddRange(new object[] { "8", "9", "10", "11", "12", "13", "14", "15", "16" });
            comboBoxMarkerSize.Location = new System.Drawing.Point(51, 244);
            comboBoxMarkerSize.Name = "comboBoxMarkerSize";
            comboBoxMarkerSize.Size = new System.Drawing.Size(51, 23);
            comboBoxMarkerSize.TabIndex = 8;
            comboBoxMarkerSize.SelectedIndexChanged += comboBoxMarkerSize_SelectedIndexChanged;
            // 
            // comboBoxMarkerType
            // 
            comboBoxMarkerType.FormattingEnabled = true;
            comboBoxMarkerType.Items.AddRange(new object[] { "None", "Circle", "Square", "Triangle", "Cross", "Star" });
            comboBoxMarkerType.Location = new System.Drawing.Point(50, 204);
            comboBoxMarkerType.Name = "comboBoxMarkerType";
            comboBoxMarkerType.Size = new System.Drawing.Size(97, 23);
            comboBoxMarkerType.TabIndex = 7;
            comboBoxMarkerType.SelectedIndexChanged += comboBoxMarkerType_SelectedIndexChanged;
            // 
            // labelPanelMarker2
            // 
            labelPanelMarker2.AutoSize = true;
            labelPanelMarker2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelPanelMarker2.Location = new System.Drawing.Point(11, 247);
            labelPanelMarker2.Name = "labelPanelMarker2";
            labelPanelMarker2.Size = new System.Drawing.Size(30, 15);
            labelPanelMarker2.TabIndex = 6;
            labelPanelMarker2.Text = "Size";
            // 
            // labelPanelMarker
            // 
            labelPanelMarker.AutoSize = true;
            labelPanelMarker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelPanelMarker.Location = new System.Drawing.Point(11, 207);
            labelPanelMarker.Name = "labelPanelMarker";
            labelPanelMarker.Size = new System.Drawing.Size(33, 15);
            labelPanelMarker.TabIndex = 5;
            labelPanelMarker.Text = "Type";
            // 
            // labelColorPanel4
            // 
            labelColorPanel4.AutoSize = true;
            labelColorPanel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelColorPanel4.Location = new System.Drawing.Point(8, 50);
            labelColorPanel4.Name = "labelColorPanel4";
            labelColorPanel4.Size = new System.Drawing.Size(36, 15);
            labelColorPanel4.TabIndex = 4;
            labelColorPanel4.Text = "Color";
            // 
            // labelPanel
            // 
            labelPanel.AutoSize = true;
            labelPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelPanel.Location = new System.Drawing.Point(8, 12);
            labelPanel.Name = "labelPanel";
            labelPanel.Size = new System.Drawing.Size(117, 20);
            labelPanel.TabIndex = 0;
            labelPanel.Text = "Layout settings";
            // 
            // FormViewGraph
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.CadetBlue;
            ClientSize = new System.Drawing.Size(3354, 1255);
            Controls.Add(panelSettings);
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
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeIntervallToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox intervallToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem chartSummaryToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBoxShowValue;
        private System.Windows.Forms.ToolStripMenuItem diagramViewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripComboBox diagramToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRapportToolStripMenuItem;
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
    }
}