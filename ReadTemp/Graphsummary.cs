using DocumentFormat.OpenXml.Drawing.Charts;
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
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace ReadTemp
{
    public partial class FormViewAll : Form
    {
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
        
            labelBeginDate.Text = "Start Date: " + FormShowData.listDate.First();
            labelEndDate.Text = "End Date: "+ FormShowData.listDate.Last();
            try 
            { 
            chartTemp.Update();
            chartTemp.Series[0].LegendText = "Temperature";
            chartTemp.ChartAreas[0].AxisY.Title = "Celsius";
            chartTemp.ChartAreas[0].AxisY.Minimum = -40;
            chartTemp.ChartAreas[0].AxisY.Maximum = 40;
            chartTemp.ChartAreas[0].AxisY.Interval = 10;
            chartTemp.ChartAreas[0].AxisY.MinorGrid.Interval = chartTemp.ChartAreas[0].AxisY.Interval / 2;
            addPoint = -1;

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
                chartHum.ChartAreas[0].AxisY.Interval = 10;
                chartHum.ChartAreas[0].AxisY.MinorGrid.Interval = chartHum.ChartAreas[0].AxisY.Interval / 2;
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
                    listSum.Add(convertValue);
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
                chartPressure.ChartAreas[0].AxisY.Interval = 100;
                chartPressure.ChartAreas[0].AxisY.MinorGrid.Interval = chartPressure.ChartAreas[0].AxisY.Interval / 2;
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
                    listSum.Add(convertValue);

                }
            }
            catch (Exception message)
            {
               MessageBox.Show(message.ToString());
            } 
        }


        private void FormViewAll_Resize(object sender, EventArgs e)
        {

        }
    }
}
