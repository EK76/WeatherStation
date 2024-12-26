using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Google.Protobuf.Collections;
using Point = System.Drawing.Point;
using System.Linq;

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
        string[] chooseDatabase = File.ReadAllLines(@"configdb.txt");
        string[] inputPass = File.ReadAllLines(@"input.txt");
        string connString, checkString, dateString, dateString2, passwordString;
        string maxValue, minValue, averageValue, minData, maxData, checkNewString, line, convertValue, convertValue2, convertValue3;
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

            labelBeginDate.Text = FormShowData.firstItem.ToString();
            labelEndDate.Text = FormShowData.lastItem.ToString();

            connString = chooseDatabase[0];
            passwordString = FormShowData.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
            MySqlConnection conn = new MySqlConnection(connString);
           
            chartTemp.Update();
            chartTemp.Series[0].Points.Clear();
            addPoint = -1;
            chartTemp.Series[0].LegendText = "Temperature";
            chartTemp.ChartAreas[0].AxisY.Title = "Celsius";
            chartTemp.Update();
            chartTemp.Series[0].Points.Clear();

            chartHum.Update();
            chartHum.Series[0].Points.Clear();
            addPoint = -1;
            chartHum.Series[0].LegendText = "Humidity";
            chartHum.ChartAreas[0].AxisY.Title = "Procent";
            chartHum.Update();
            chartHum.Series[0].Points.Clear();

            chartPressure.Update();
            chartPressure.Series[0].Points.Clear();
            addPoint = -1;
            chartPressure.Series[0].LegendText = "Pressure";
            chartPressure.ChartAreas[0].AxisY.Title = "HPa";
            chartPressure.Update();
            chartPressure.Series[0].Points.Clear();



            if (FormShowData.localData == false)
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(FormShowData.checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    addPoint++;
                    chartTemp.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outtemp"));
                    chartTemp.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartTemp.Series[0].MarkerSize = 8;


                    chartHum.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outhum"));
                    chartHum.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartHum.Series[0].MarkerSize = 8;

                    chartPressure.Series[0].Points.AddXY(addPoint, reader.GetDecimal("pressure"));
                    chartPressure.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartPressure.Series[0].MarkerSize = 8;
                }
                conn.Close();
                checkNewString = Regex.Replace(FormShowData.checkString, @";", "");

                maxValue = "select max(outtemp) from (" + checkNewString + ")max;";
                conn.Open();
                MySqlCommand command4 = new MySqlCommand(maxValue, conn);
                MySqlDataReader reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {
                    maxData = "Maximum temperature: " + reader4.GetDecimal("max(outtemp)").ToString() + " °C ";
                }
                conn.Close();

                minValue = "select min(outtemp) from (" + checkNewString + ")min;";
                conn.Open();
                MySqlCommand command5 = new MySqlCommand(minValue, conn);
                MySqlDataReader reader5 = command5.ExecuteReader();
                while (reader5.Read())
                {
                    minData = "Minimum temperature: " + reader5.GetDecimal("min(outtemp)").ToString() + " °C ";
                }
                conn.Close();


                averageValue = "select avg(outtemp) from (" + checkNewString + ")avg;";
                conn.Open();
                MySqlCommand command6 = new MySqlCommand(averageValue, conn);
                MySqlDataReader reader6 = command6.ExecuteReader();
                while (reader6.Read())
                {
                    avgData = Math.Round((decimal)reader6.GetDecimal("avg(outtemp)"), 2);
                }
                conn.Close();

                labelTemp.Text = maxData + minData + " Avarage temperature: " + avgData + " °C";


                maxValue = "select max(outhum) from (" + checkNewString + ")max;";
                conn.Open();
                MySqlCommand command7 = new MySqlCommand(maxValue, conn);
                MySqlDataReader reader7 = command7.ExecuteReader();
                while (reader7.Read())
                {
                    maxData = "Maximum humitidy: " + reader7.GetDecimal("max(outhum)").ToString() + " % ";
                }
                conn.Close();

                minValue = "select min(outhum) from (" + checkNewString + ")min;";
                conn.Open();
                MySqlCommand command8 = new MySqlCommand(minValue, conn);
                MySqlDataReader reader8 = command8.ExecuteReader();
                while (reader8.Read())
                {
                    minData = "Minimum humitidy: " + reader8.GetDecimal("min(outhum)").ToString() + " % ";
                }
                conn.Close();


                averageValue = "select avg(outhum) from (" + checkNewString + ")avg;";
                conn.Open();
                MySqlCommand command9 = new MySqlCommand(averageValue, conn);
                MySqlDataReader reader9 = command9.ExecuteReader();
                while (reader9.Read())
                {
                    avgData = Math.Round((decimal)reader9.GetDecimal("avg(outhum)"), 2);
                }
                conn.Close();

                labelHum.Text = maxData + minData + " Avarage humitidy: " + avgData + " %";


                maxValue = "select max(pressure) from (" + checkNewString + ")max;";
                conn.Open();
                MySqlCommand command10 = new MySqlCommand(maxValue, conn);
                MySqlDataReader reader10 = command10.ExecuteReader();
                while (reader10.Read())
                {
                    maxData = "Maximum pressure: " + reader10.GetDecimal("max(pressure)").ToString() + " hPA ";
                }
                conn.Close();

                minValue = "select min(pressure) from (" + checkNewString + ")min;";
                conn.Open();
                MySqlCommand command11 = new MySqlCommand(minValue, conn);
                MySqlDataReader reader11 = command11.ExecuteReader();
                while (reader11.Read())
                {
                    minData = "Minimum pressure: " + reader11.GetDecimal("min(pressure)").ToString() + " hPA ";
                }
                conn.Close();


                averageValue = "select avg(pressure) from (" + checkNewString + ")avg;";
                conn.Open();
                MySqlCommand command12 = new MySqlCommand(averageValue, conn);
                MySqlDataReader reader12 = command12.ExecuteReader();
                while (reader12.Read())
                {
                    avgData = Math.Round((decimal)reader12.GetDecimal("avg(pressure)"), 2);
                }
                conn.Close();

                labelPressure.Text = maxData + minData + " Avarage pressure: " + avgData + " hPA";

            }
            else
            {
                addPoint = 0;
                StreamReader fileName3 = new StreamReader(FormShowData.fileName2);

                while ((line = fileName3.ReadLine()) != null)
                {
                    addPoint++;
                    convertValue = line.ToString().Split(';')[0].ToString();
                    convertValue2 = line.ToString().Split(';')[1].ToString();
                    convertValue3 = line.ToString().Split(';')[2].ToString();
                    var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };

                    foreach (var rc in removeChars)
                    {
                        convertValue = convertValue.Replace(rc, string.Empty);
                        convertValue2 = convertValue2.Replace(rc, string.Empty);
                        convertValue3 = convertValue3.Replace(rc, string.Empty);
                    }

                    decimalValue = decimal.Parse(convertValue);
                    decimalValue2 = decimal.Parse(convertValue2);
                    decimalValue3 = decimal.Parse(convertValue3);
                    listSum.Add(decimalValue);
                    listSum2.Add(decimalValue2);
                    listSum3.Add(decimalValue3);

                    chartTemp.Series[0].Points.AddXY(addPoint, decimalValue);
                    chartTemp.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartTemp.Series[0].MarkerSize = 8;

                    chartHum.Series[0].Points.AddXY(addPoint, decimalValue2);
                    chartHum.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartHum.Series[0].MarkerSize = 8;

                    chartPressure.Series[0].Points.AddXY(addPoint, decimalValue3);
                    chartPressure.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartPressure.Series[0].MarkerSize = 8;
                }

                chartTemp.ChartAreas[0].AxisY.Minimum = -40;
                chartTemp.ChartAreas[0].AxisY.Maximum = 40;
                chartTemp.ChartAreas[0].AxisX.Minimum = 0;
                chartTemp.ChartAreas[0].AxisX.Maximum = addPoint + 1;

                chartHum.ChartAreas[0].AxisY.Minimum = 0;
                chartHum.ChartAreas[0].AxisY.Maximum = 100;
                chartHum.ChartAreas[0].AxisX.Minimum = 0;
                chartHum.ChartAreas[0].AxisX.Maximum = addPoint + 1;

                chartPressure.ChartAreas[0].AxisY.Minimum = 1000;
                chartPressure.ChartAreas[0].AxisY.Maximum = 1200;
                chartPressure.ChartAreas[0].AxisX.Minimum = 0;
                chartPressure.ChartAreas[0].AxisX.Maximum = addPoint + 1;

                labelTemp.Text = "Maximum temperature: " + listSum.Max() + "°C Minimum temperature: " + listSum.Min() + " °C Average temperature: " + Math.Round(listSum.Average(), 1) + " °C";
                labelHum.Text = "Maximum humitidy: " + listSum2.Max() + " % Minimum humitidy: " + listSum2.Min() + " % Average humitidy: " + Math.Round(listSum2.Average(), 1) + "%";
                labelPressure.Text = "Maximum pressure: " + listSum3.Max() + " hPa Minimum pressure: " + listSum3.Min() + " hPA Average pressure: " + Math.Round(listSum3.Average(), 1) + "hPa";
            }

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
