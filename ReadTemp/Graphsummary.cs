using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Google.Protobuf.Collections;
using Locations;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using MySql.Data.MySqlClient;
using ReadTemp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Point = System.Drawing.Point;

namespace ReadTemp
{
    public partial class FormViewAll : Form
    {
        private Rectangle chartTempOrginal;
        private Rectangle chartHumOrginal;
        private Rectangle chartPressureOrginal;
        private Rectangle buttonCloseOrginal;
        private Rectangle labelTempOrginal;
        private Rectangle labelHumOrginal;
        private Rectangle labelPressureOrginal;
        private Rectangle defautSize;
        public FormViewAll()
        {
            InitializeComponent();
        }
        string[] chooseDatabase;
        string[] inputPass;
        string connString, checkString, dateString, dateString2, passwordString, addNewValue;
        string maxValue, minValue, averageValue, minData, maxData, checkNewString, line, convertValue2, convertValue3;
        decimal convertValue;
        int addPoint;
        decimal avgData, decimalValue, decimalValue2, decimalValue3;
        List<decimal> listSum = new List<decimal>();
        List<decimal> listSum2 = new List<decimal>();
        List<decimal> listSum3 = new List<decimal>();
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormViewAll_Load(object sender, EventArgs e)
        {
            defautSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            chartTempOrginal = new Rectangle(chartTemp.Location.X, chartTemp.Location.Y, chartTemp.Width, chartTemp.Height);
            chartHumOrginal = new Rectangle(chartHum.Location.X, chartHum.Location.Y, chartHum.Width, chartHum.Height);
            chartPressureOrginal = new Rectangle(chartPressure.Location.X, chartPressure.Location.Y, chartPressure.Width, chartPressure.Height);
            buttonCloseOrginal = new Rectangle(buttonClose.Location.X, buttonClose.Location.Y, buttonClose.Width, buttonClose.Height);
            labelTempOrginal = new Rectangle(labelTemp.Location.X, labelTemp.Location.Y, labelTemp.Width, labelTemp.Height);
            labelHumOrginal = new Rectangle(labelHum.Location.X, labelHum.Location.Y, labelHum.Width, labelHum.Height);
            labelPressureOrginal = new Rectangle(labelPressure.Location.X, labelPressure.Location.Y, labelPressure.Width, labelPressure.Height);
        
            labelBeginDate.Text = FormShowData.listDate.First();
            labelEndDate.Text = FormShowData.listDate.Last();

            chartTemp.Update();
            chartTemp.Series[0].LegendText = "Temperature";
            chartTemp.ChartAreas[0].AxisY.Title = "Celsius";
            chartTemp.ChartAreas[0].AxisY.Minimum = -40;
            chartTemp.ChartAreas[0].AxisY.Maximum = 40;

            chartTemp.Series[0].XValueType = ChartValueType.DateTime;
            chartTemp.ChartAreas[0].AxisX.IntervalType = (DateTimeIntervalType)DateRangeType.DayOfMonth;
            chartTemp.ChartAreas[0].AxisX.LabelStyle.Format = "mm-hh-dd";

            addPoint = 0;
            foreach (var addValue in FormShowData.listDate)
            {
                chartTemp.Series[0].Points[addPoint].AxisLabel = FormShowData.listDate[addPoint];
                addPoint++;
            }

            addPoint = -1;
            try { 
               foreach (var addValue in FormShowData.listTemp)
               {
                  addPoint++;
                  addNewValue = addValue;
                  var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                  foreach (var rc in removeChars)
                  {
                     addNewValue = addNewValue.Replace(rc, string.Empty);
                  }
                  convertValue = decimal.Parse(addNewValue);
                  chartTemp.Series[0].Points.AddXY(addPoint, convertValue);
                  listSum.Add(convertValue);
               }

            }
            catch (Exception message)
            {
                MessageBox.Show(message.ToString());
            }

            try
            {
               chartHum.Update();
               chartHum.Series[0].LegendText = "Humidity";
               chartHum.ChartAreas[0].AxisY.Title = "Humidity %";
               chartHum.ChartAreas[0].AxisY.Minimum = 0;
               chartHum.ChartAreas[0].AxisY.Maximum = 100;

                chartHum.Series[0].XValueType = ChartValueType.DateTime;
                chartHum.ChartAreas[0].AxisX.IntervalType = (DateTimeIntervalType)DateRangeType.DayOfMonth;
                chartHum.ChartAreas[0].AxisX.LabelStyle.Format = "mm-hh-dd";

                addPoint = 0;
            /*    foreach (var addValue in FormShowData.listDate)
                {
                    chartHum.Series[0].Points[addPoint].AxisLabel = FormShowData.listDate[addPoint];
                    addPoint++;
                }*/

                addPoint = -1;

               foreach (var addValue in FormShowData.listHum)
               {
                  addPoint++;
                  addNewValue = addValue;
                  var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                  foreach (var rc in removeChars)
                  {
                    addNewValue = addNewValue.Replace(rc, string.Empty);
                  }
                  convertValue = decimal.Parse(addNewValue);
                  chartHum.Series[0].Points.AddXY(addPoint, convertValue);
                  listSum2.Add(convertValue);
               }
            }
            catch (Exception message)
            {
               MessageBox.Show(message.ToString());
            }
    
            try 
            { 
               chartPressure.Update();
               chartPressure.Series[0].LegendText = "Pressure";
               chartPressure.ChartAreas[0].AxisY.Title = "Pressure hPA";
               chartPressure.ChartAreas[0].AxisY.Minimum = 800;
               chartPressure.ChartAreas[0].AxisY.Maximum = 1200;

               chartPressure.Series[0].XValueType = ChartValueType.DateTime;
               chartPressure.ChartAreas[0].AxisX.IntervalType = (DateTimeIntervalType)DateRangeType.DayOfMonth;
               chartPressure.ChartAreas[0].AxisX.LabelStyle.Format = "mm-hh-dd";

               addPoint = 0;
              /* foreach (var addValue in FormShowData.listDate)
               {
                  chartPressure.Series[0].Points[addPoint].AxisLabel = FormShowData.listDate[addPoint];
                  addPoint++;
               }*/

               addPoint = -1;
               foreach (var addValue in FormShowData.listPressure)
               {
                  addPoint++;
                  addNewValue = addValue;
                  var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                  foreach (var rc in removeChars)
                  {
                     addNewValue = addNewValue.Replace(rc, string.Empty);
                  }
                  convertValue = decimal.Parse(addNewValue);
                  chartPressure.Series[0].Points.AddXY(addPoint, convertValue);
                  listSum3.Add(convertValue);
               }

            }
            catch (Exception message)
            {
               MessageBox.Show(message.ToString());
            }
            labelTemp.Text = "Maximum temperature: " + listSum.Max() + "°C Minimum temperature: " + listSum.Min() + " °C Average temperature: " + Math.Round(listSum.Average(), 1) + " °C";
            labelHum.Text = "Maximum humitidy: " + listSum2.Max() + " % Minimum humitidy: " + listSum2.Min() + " % Average humitidy: " + Math.Round(listSum2.Average(), 1) + "%";
            labelPressure.Text = "Maximum pressure: " + listSum3.Max() + " hPa Minimum pressure: " + listSum3.Min() + " hPA Average pressure: " + Math.Round(listSum3.Average(), 1) + "hPa";      
        }
        private void checkResize(Rectangle rect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(defautSize.Width);
            float yRatio = (float)(this.Height) / (float)(defautSize.Height);

            int xNew = (int)(rect.Location.X * xRatio);
            int yNew = (int)(rect.Location.Y * yRatio);

            int widthNew = (int)(rect.Width * xRatio);
            int heightNew = (int)(rect.Height * yRatio);

            control.Location = new Point(xNew, yNew);
            control.Size = new Size(widthNew, heightNew);
        }

        private void FormViewAll_Resize(object sender, EventArgs e)
        {
            checkResize(chartTempOrginal, chartTemp);
            checkResize(chartHumOrginal, chartHum);
            checkResize(chartPressureOrginal, chartPressure);
            checkResize(buttonCloseOrginal, buttonClose);
            checkResize(labelTempOrginal, labelTemp);
            checkResize(labelHumOrginal, labelHum);
            checkResize(labelPressureOrginal, labelPressure);
        }
    }
}
