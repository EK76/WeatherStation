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
            buttonClose = new System.Windows.Forms.Button();
            chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartHum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelBeginDate = new System.Windows.Forms.Label();
            labelEndDate = new System.Windows.Forms.Label();
            labelTemp = new System.Windows.Forms.Label();
            labelHum = new System.Windows.Forms.Label();
            labelPressure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)chartTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartHum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPressure).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new System.Drawing.Point(2833, 908);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new System.Drawing.Size(75, 23);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // chartTemp
            // 
            chartArea1.Name = "ChartArea1";
            chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTemp.Legends.Add(legend1);
            chartTemp.Location = new System.Drawing.Point(38, 43);
            chartTemp.Name = "chartTemp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            chartTemp.Series.Add(series1);
            chartTemp.Size = new System.Drawing.Size(933, 859);
            chartTemp.TabIndex = 1;
            chartTemp.Text = "chart1";
            // 
            // chartHum
            // 
            chartArea2.Name = "ChartArea1";
            chartHum.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartHum.Legends.Add(legend2);
            chartHum.Location = new System.Drawing.Point(997, 43);
            chartHum.Name = "chartHum";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Humitidy";
            chartHum.Series.Add(series2);
            chartHum.Size = new System.Drawing.Size(933, 859);
            chartHum.TabIndex = 2;
            chartHum.Text = "chart1";
            // 
            // chartPressure
            // 
            chartArea3.Name = "ChartArea1";
            chartPressure.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartPressure.Legends.Add(legend3);
            chartPressure.Location = new System.Drawing.Point(1975, 43);
            chartPressure.Name = "chartPressure";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Pressure";
            series3.YValuesPerPoint = 2;
            chartPressure.Series.Add(series3);
            chartPressure.Size = new System.Drawing.Size(933, 859);
            chartPressure.TabIndex = 3;
            chartPressure.Text = "chart1";
            // 
            // labelBeginDate
            // 
            labelBeginDate.AutoSize = true;
            labelBeginDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelBeginDate.Location = new System.Drawing.Point(40, 12);
            labelBeginDate.Name = "labelBeginDate";
            labelBeginDate.Size = new System.Drawing.Size(45, 17);
            labelBeginDate.TabIndex = 4;
            labelBeginDate.Text = "label1";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelEndDate.Location = new System.Drawing.Point(399, 12);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new System.Drawing.Size(45, 17);
            labelEndDate.TabIndex = 5;
            labelEndDate.Text = "label1";
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            labelTemp.Location = new System.Drawing.Point(40, 913);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new System.Drawing.Size(45, 17);
            labelTemp.TabIndex = 6;
            labelTemp.Text = "label1";
            // 
            // labelHum
            // 
            labelHum.AutoSize = true;
            labelHum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            labelHum.Location = new System.Drawing.Point(997, 913);
            labelHum.Name = "labelHum";
            labelHum.Size = new System.Drawing.Size(45, 17);
            labelHum.TabIndex = 7;
            labelHum.Text = "label1";
            // 
            // labelPressure
            // 
            labelPressure.AutoSize = true;
            labelPressure.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            labelPressure.Location = new System.Drawing.Point(1975, 915);
            labelPressure.Name = "labelPressure";
            labelPressure.Size = new System.Drawing.Size(45, 17);
            labelPressure.TabIndex = 8;
            labelPressure.Text = "label1";
            // 
            // FormViewAll
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(2920, 941);
            Controls.Add(labelPressure);
            Controls.Add(labelHum);
            Controls.Add(labelTemp);
            Controls.Add(labelEndDate);
            Controls.Add(labelBeginDate);
            Controls.Add(chartPressure);
            Controls.Add(chartHum);
            Controls.Add(chartTemp);
            Controls.Add(buttonClose);
            MinimizeBox = false;
            Name = "FormViewAll";
            Text = "Weather Station";
            Load += FormViewAll_Load;
            Resize += FormViewAll_Resize;
            ((System.ComponentModel.ISupportInitialize)chartTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartHum).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPressure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPressure;
        private System.Windows.Forms.Label labelBeginDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelHum;
        private System.Windows.Forms.Label labelPressure;
    }
}