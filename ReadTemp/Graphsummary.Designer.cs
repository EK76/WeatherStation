namespace ReadTemp
{
    partial class FormViewAll
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            buttonClose = new Button();
            labelBeginDate = new Label();
            labelEndDate = new Label();
            chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartHum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartHum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPressure).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(2819, 906);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelBeginDate
            // 
            labelBeginDate.AutoSize = true;
            labelBeginDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBeginDate.Location = new Point(40, 12);
            labelBeginDate.Name = "labelBeginDate";
            labelBeginDate.Size = new Size(45, 17);
            labelBeginDate.TabIndex = 4;
            labelBeginDate.Text = "label1";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEndDate.Location = new Point(399, 12);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(45, 17);
            labelEndDate.TabIndex = 5;
            labelEndDate.Text = "label1";
            // 
            // chartTemp
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.Name = "ChartArea1";
            chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTemp.Legends.Add(legend1);
            chartTemp.Location = new Point(12, 41);
            chartTemp.Name = "chartTemp";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerSize = 14;
            series1.Name = "Series1";
            chartTemp.Series.Add(series1);
            chartTemp.Size = new Size(920, 852);
            chartTemp.TabIndex = 6;
            chartTemp.Text = "chart1";
            // 
            // chartHum
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.Name = "ChartArea1";
            chartHum.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartHum.Legends.Add(legend2);
            chartHum.Location = new Point(990, 41);
            chartHum.Name = "chartHum";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.MarkerSize = 14;
            series2.Name = "Series1";
            chartHum.Series.Add(series2);
            chartHum.Size = new Size(920, 852);
            chartHum.TabIndex = 7;
            chartHum.Text = "chart1";
            // 
            // chartPressure
            // 
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.Name = "ChartArea1";
            chartPressure.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartPressure.Legends.Add(legend3);
            chartPressure.Location = new Point(1974, 41);
            chartPressure.Name = "chartPressure";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.MarkerSize = 14;
            series3.Name = "Series1";
            chartPressure.Series.Add(series3);
            chartPressure.Size = new Size(920, 852);
            chartPressure.TabIndex = 8;
            chartPressure.Text = "chart1";
            // 
            // FormViewAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(2908, 941);
            Controls.Add(chartPressure);
            Controls.Add(chartHum);
            Controls.Add(chartTemp);
            Controls.Add(labelEndDate);
            Controls.Add(labelBeginDate);
            Controls.Add(buttonClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormViewAll";
            ShowIcon = false;
            Text = "Weather Station";
            Load += FormViewAll_Load;
            ((System.ComponentModel.ISupportInitialize)chartTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartHum).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPressure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelBeginDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressure;
    }
}