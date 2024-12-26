using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using Windows.UI.Composition;
using DocumentFormat.OpenXml.Presentation;
using Control = System.Windows.Forms.Control;
using System.Linq;
using System.Data;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Drawing.Charts;
using System.Reflection;
using Windows.UI.StartScreen;
using Title = System.Windows.Forms.DataVisualization.Charting.Title;
using Size = System.Drawing.Size;
using Point = System.Drawing.Point;
using System.DirectoryServices.ActiveDirectory;
using DocumentFormat.OpenXml.Office2010.Excel;
using Color = System.Drawing.Color;
using MySqlX.XDevAPI.Common;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Windows.UI.Xaml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using Org.BouncyCastle.Asn1.Cmp;
using System.Security.Cryptography;
using System.Text;


namespace ReadTemp
{
    public partial class FormViewGraph : System.Windows.Forms.Form
    {
        private Rectangle chartInfoOrginal;
        private Rectangle listBoxShowValueOrginal;
        private Rectangle labelAverageValueOrginal;
        private Rectangle labelMaxValueOrginal;
        private Rectangle labelMinValueOrginal;
        private Rectangle defautSize;
        public FormViewGraph()
        {
            InitializeComponent();
        }


        string[] chooseDatabase = File.ReadAllLines(@"configdb.txt");
        string[] inputPass = File.ReadAllLines(@"input.txt");
        string connString, checkString, dateString, dateString2, showBeginDate, showEndDate, yAxisText, yAxisValue, maxValue, averageValue, minValue, checkNewString, checkSaveString, theValue;
        string choosenValue, legendText, yTitle, yValue, convertValue, colorHex;
        int addPoint = -1, chooseValue = 1, chooseItem = 1, recordSum, yMin, yMax, counterRows = -1, counterRowsSkip = -2, dateChoose = 0, markerSize, markerType, markerValue;
        decimal avgTemp, avgHum, avgPressure, averageValue2, convertValue2;
        string currentItem, passwordString;
        int index = 0, oldValue = 0;
        Boolean oneTime = false;
        List<String> listDate = new List<String>();
        List<String> listDate2 = new List<String>();
        List<decimal> listSum = new List<decimal>();
        List<decimal> listSumNew = new List<decimal>();

        void colorChoose(string value)
        {
            string color = colorDialog1.Color.ToArgb().ToString("x");
            color = color.Substring(2, 6);
            color = "#" + color;
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            checkString = "update settings set " + value + " = '" + color + "' where id = 1;";
            MySqlCommand command = new MySqlCommand(checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            conn.Close();
        }

        void markerShow()
        {
            if (oneTime == true)
            {
                oldValue = index;
                try
                {
                    chartInfo.Update();
                    chartInfo.Series[0].Points[index].MarkerSize = markerSize;
                    //  MessageBox.Show(markerSize.ToString());
                }
                catch
                {
                }
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                checkString = "select markersize from settings where id= 1;";
                MySqlCommand command2 = new MySqlCommand(checkString, conn);
                MySqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    markerSize = reader2.GetInt32("markersize");
                }
                conn.Close();
            }
            currentItem = listBoxShowValue.SelectedItem.ToString();
            index = listBoxShowValue.FindString(currentItem);
            index = index - 4;
            try
            {
                chartInfo.Update();
                chartInfo.Series[0].Points[index].MarkerSize = markerSize + 8;
            }
            catch
            {
            }
            oneTime = true;
        }


        private void intervallToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string unitValue = "°C";
            string line;
            int nthValue = 1;

            dateChoose = 1;
            chartInfo.Update();
            chartInfo.Series[0].Points.Clear();
            checkSaveString = checkNewString;
            addPoint = -1;

            switch (intervallToolStripComboBox.SelectedIndex)
            {
                case 0:
                    checkNewString += " and id mod 1 = 0";
                    nthValue = 1;
                    break;

                case 1:
                    checkNewString += " and id mod 3 = 0";
                    nthValue = 2;
                    break;

                case 2:
                    checkNewString += " and id mod 6 = 0";
                    nthValue = 3;
                    break;
            }

            connString = chooseDatabase[0];
            passwordString = FormShowData.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
            MySqlConnection conn = new MySqlConnection(connString);

            recordSum = 0;

            switch (chooseItem)
            {
                case 1:
                    chartInfo.Series[0].LegendText = "Temperature";
                    chartInfo.ChartAreas[0].AxisY.Title = "Celsius";
                    yAxisText = "Temperature";
                    yAxisValue = " °C";
                    unitValue = "°C";
                    chartInfo.ChartAreas[0].AxisY.Minimum = -40;
                    chartInfo.ChartAreas[0].AxisY.Maximum = 40;
                    break;

                case 2:
                    chartInfo.Series[0].LegendText = "Indoor Humidity";
                    chartInfo.ChartAreas[0].AxisY.Title = "Procent";
                    yAxisText = "Humidity";
                    yAxisValue = " %";
                    unitValue = "%";
                    chartInfo.ChartAreas[0].AxisY.Minimum = 0;
                    chartInfo.ChartAreas[0].AxisY.Maximum = 100;
                    break;

                case 3:
                    chartInfo.Series[0].LegendText = "Pressure";
                    chartInfo.ChartAreas[0].AxisY.Title = "Pressure";
                    yAxisText = "Pressure";
                    yAxisValue = " hPa";
                    unitValue = "hPa";
                    chartInfo.ChartAreas[0].AxisY.Minimum = 1000;
                    chartInfo.ChartAreas[0].AxisY.Maximum = 1200;
                    break;
            }

            chartInfo.Update();
            chartInfo.Series[0].Points.Clear();
            listBoxShowValue.Items.Clear();
            listSum.Clear();
            if (FormShowData.localData == false)
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(checkNewString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    addPoint++;
                    switch (chooseItem)
                    {
                        case 1:
                            chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outtemp"));
                            listBoxShowValue.Items.Add(reader.GetDecimal("outtemp") + " °C" + " " + reader.GetDateTime("datecreated"));
                            listSum.Add(reader.GetDecimal("outtemp"));
                            break;

                        case 2:
                            chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outhum"));
                            listBoxShowValue.Items.Add(reader.GetDecimal("outhum") + " %" + " " + reader.GetDateTime("datecreated"));
                            listSum.Add(reader.GetDecimal("outhum"));
                            break;

                        case 3:
                            chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("pressure"));
                            listBoxShowValue.Items.Add(reader.GetDecimal("pressure") + " hPa" + " " + reader.GetDateTime("datecreated"));
                            listSum.Add(reader.GetDecimal("pressure"));
                            break;
                    }
                    recordSum++;
                }

                conn.Close();
                listBoxShowValue.Items.Insert(0, "Average value: " + Math.Round(listSum.Average(), 1) + " " + unitValue);
                listBoxShowValue.Items.Insert(0, "Min value: " + listSum.Min() + " " + unitValue);
                listBoxShowValue.Items.Insert(0, "Max value: " + listSum.Max() + " " + unitValue);
                listBoxShowValue.Items.Insert(0, "-----------------------------------------------");
                listBoxShowValue.Items.Add("------------------------------------------------");
                listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");
            }
            else
            {
                StreamReader fileName3 = new StreamReader(FormShowData.fileName2);
                listSumNew.Clear();
                while ((line = fileName3.ReadLine()) != null)
                {
                    //  addPoint++;
                    recordSum++;

                    switch (chooseItem)
                    {
                        case 1:
                            convertValue = line.ToString().Split(';')[0].ToString();
                            var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                            foreach (var rc in removeChars)
                            {
                                convertValue = convertValue.Replace(rc, string.Empty);
                            }
                            convertValue2 = decimal.Parse(convertValue);
                            listSum.Add(convertValue2);
                            break;

                        case 2:
                            convertValue = line.ToString().Split(';')[1].ToString();
                            var removeChars2 = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                            foreach (var rc in removeChars2)
                            {
                                convertValue = convertValue.Replace(rc, string.Empty);
                            }
                            convertValue2 = decimal.Parse(convertValue);
                            listSum.Add(convertValue2);
                            break;

                        case 3:
                            convertValue = line.ToString().Split(';')[2].ToString();
                            var removeChars3 = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                            foreach (var rc in removeChars3)
                            {
                                convertValue = convertValue.Replace(rc, string.Empty);
                            }
                            convertValue2 = decimal.Parse(convertValue);
                            listSum.Add(convertValue2);
                            break;
                    }
                }

                recordSum = 0;
                listDate2.Clear();
                listBoxShowValue.Items.Clear();
                switch (nthValue)
                {
                    case 1:
                        var ListSum1 = listSum.Where((x, i) => i % 1 == 0);
                        foreach (var listItems in ListSum1)
                        {
                            counterRows++;
                            addPoint++;
                            recordSum++;
                            listSumNew.Add(listItems);
                            chartInfo.Series[0].Points.AddXY(addPoint, listItems);
                            listBoxShowValue.Items.Add(listItems + " " + unitValue + " " + listDate[counterRows]);
                            listDate2.Add(listDate[counterRows]);
                        }
                        counterRows = -1;
                        counterRowsSkip = -2;
                        dateChoose = 1;
                        break;

                    case 2:
                        var ListSum2 = listSum.Where((x, i) => i % 3 == 0);
                        foreach (var listItems in ListSum2)
                        {
                            counterRows++;
                            counterRowsSkip = counterRowsSkip + 3;
                            addPoint++;
                            recordSum++;
                            listSumNew.Add(listItems);
                            chartInfo.Series[0].Points.AddXY(addPoint, listItems);
                            listBoxShowValue.Items.Add(listItems + " " + unitValue + " " + listDate[counterRowsSkip]);
                            listDate2.Add(listDate[counterRowsSkip]);
                        }
                        counterRows = -1;
                        counterRowsSkip = -2;
                        dateChoose = 1;
                        break;

                    case 3:
                        var ListSum3 = listSum.Where((x, i) => i % 6 == 0);
                        foreach (var listItems in ListSum3)
                        {
                            addPoint++;
                            counterRows++;
                            recordSum++;
                            listSumNew.Add(listItems);
                            counterRowsSkip = counterRowsSkip + 6;
                            //       MessageBox.Show(listDate[counterRowsSkip].ToString());
                            chartInfo.Series[0].Points.AddXY(addPoint, listItems);
                            listBoxShowValue.Items.Add(listItems + " " + unitValue + " " + listDate[counterRowsSkip]);
                            listDate2.Add(listDate[counterRowsSkip]);
                        }
                        counterRows = -1;
                        counterRowsSkip = -2;
                        dateChoose = 1;
                        break;
                }
                listBoxShowValue.Items.Insert(0, "Average value: " + Math.Round(listSumNew.Average(), 1) + " " + unitValue);
                listBoxShowValue.Items.Insert(0, "Min value: " + listSumNew.Min() + " " + unitValue);
                listBoxShowValue.Items.Insert(0, "Max value: " + listSumNew.Max() + " " + unitValue);
                listBoxShowValue.Items.Insert(3, "-----------------------------------------------");
                listBoxShowValue.Items.Add("------------------------------------------------");
                listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");
            }
            checkNewString = checkSaveString;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showOneToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string line;
            decimal convertValue2;
            int index = 0;

            dateChoose = 1;
            connString = chooseDatabase[0];
            passwordString = FormShowData.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
            MySqlConnection conn = new MySqlConnection(connString);

            chartInfo.Update();
            chartInfo.Series[0].Points.Clear();
            addPoint = -1;
            intervallToolStripComboBox.Text = "10 minutes";
            recordSum = 0;
            listBoxShowValue.Items.Clear();
            switch (showOneToolStripComboBox.SelectedIndex)
            {
                case 0:
                    choosenValue = "outtemp";
                    legendText = "Temperature";
                    yTitle = "Celsius";
                    yValue = " °C";
                    index = 0;
                    yMin = -40;
                    yMax = 40;
                    chooseItem = 1;
                    break;

                case 1:
                    choosenValue = "outhum";
                    legendText = "Humitidy";
                    yTitle = "Procent";
                    yValue = " %";
                    index = 1;
                    yMin = 0;
                    yMax = 100;
                    chooseItem = 2;
                    break;

                case 2:
                    choosenValue = "pressure";
                    legendText = "Pressure";
                    yTitle = "hPA";
                    yValue = " hPA";
                    index = 2;
                    yMin = 1000;
                    yMax = 1200;
                    chooseItem = 3;
                    break;
            }

            if (FormShowData.localData == false)
            {
                maxValue = "select max(" + choosenValue + ") from (" + checkNewString + ")max;";
                Clipboard.SetText(maxValue);
                conn.Open();
                MySqlCommand command4 = new MySqlCommand(maxValue, conn);
                MySqlDataReader reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {
                    listBoxShowValue.Items.Add("Maximum value: " + reader4.GetDecimal("max(" + choosenValue + ")").ToString() + " " + yValue);
                }
                conn.Close();

                minValue = "select min(" + choosenValue + ") from (" + checkNewString + ")min;";
                Clipboard.SetText(minValue);
                conn.Open();
                MySqlCommand command5 = new MySqlCommand(minValue, conn);
                MySqlDataReader reader5 = command5.ExecuteReader();
                while (reader5.Read())
                {
                    listBoxShowValue.Items.Add("Minimum value: " + reader5.GetDecimal("min(" + choosenValue + ")").ToString() + " " + yValue);
                }
                conn.Close();

                averageValue = FormShowData.checkString;
                averageValue = "select avg(" + choosenValue + ") from (" + checkNewString + ")avg;";
                Clipboard.SetText(averageValue);
                conn.Open();
                MySqlCommand command6 = new MySqlCommand(averageValue, conn);
                MySqlDataReader reader6 = command6.ExecuteReader();

                while (reader6.Read())
                {
                    averageValue2 = Math.Round((Decimal)reader6.GetDecimal("avg(" + choosenValue + ")"), 2);
                    listBoxShowValue.Items.Add("Average value: " + averageValue2.ToString() + " " + yValue);
                }
                conn.Close();

                listBoxShowValue.Items.Add("------------------------------------------------");
                chartInfo.Series[0].LegendText = legendText;
                chartInfo.ChartAreas[0].AxisY.Title = yTitle;
                yAxisText = legendText;
                yAxisValue = yValue;
                chartInfo.Update();
                chartInfo.Series[0].Points.Clear();
                conn.Open();
                MySqlCommand command = new MySqlCommand(FormShowData.checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    addPoint++;
                    chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal(choosenValue));
                    listBoxShowValue.Items.Add(reader.GetDecimal(choosenValue) + " " + yValue + " " + reader.GetDateTime("datecreated"));
                    recordSum++;
                }

                chartInfo.ChartAreas[0].AxisY.Minimum = yMin;
                chartInfo.ChartAreas[0].AxisY.Maximum = yMax;
                conn.Close();
                chooseItem = 1;
                listBoxShowValue.Items.Add("------------------------------------------------");
                listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");
                conn.Close();
            }
            else
            {
                recordSum = 0;
                listSum.Clear();
                chartInfo.Update();
                chartInfo.Series[0].Points.Clear();
                chartInfo.Series[0].LegendText = legendText;
                chartInfo.ChartAreas[0].AxisY.Title = yTitle;
                yAxisText = legendText;
                yAxisValue = yValue;
                addPoint = -1;
                listBoxShowValue.Items.Clear();
                StreamReader fileName3 = new StreamReader(FormShowData.fileName2);
                while ((line = fileName3.ReadLine()) != null)
                {
                    addPoint++;
                    recordSum++;
                    listDate.Add(line.ToString().Split(';')[3].ToString());
                    convertValue = line.ToString().Split(';')[index].ToString();

                    var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                    foreach (var rc in removeChars)
                    {
                        convertValue = convertValue.Replace(rc, string.Empty);
                    }

                    convertValue2 = decimal.Parse(convertValue);
                    listSum.Add(convertValue2);
                    chartInfo.Series[0].Points.AddXY(addPoint, convertValue2);
                    listBoxShowValue.Items.Add(line.ToString().Split(';')[index].ToString() + line.ToString().Split(';')[3].ToString());
                }
                listBoxShowValue.Items.Insert(0, "------------------------------------------------");
                listBoxShowValue.Items.Insert(0, "Average value: " + Math.Round(listSum.Average(), 1) + " " + yValue);
                listBoxShowValue.Items.Insert(0, "Min value: " + listSum.Min() + " " + yValue);
                listBoxShowValue.Items.Insert(0, "Max value: " + listSum.Max() + " " + yValue);
                listBoxShowValue.Items.Add("------------------------------------------------");
                listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");

                chartInfo.ChartAreas[0].AxisY.Minimum = yMin;
                chartInfo.ChartAreas[0].AxisY.Maximum = yMax;
                conn.Close();
            }
        }

        private void chartInfo_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            switch (e.HitTestResult.ChartElementType)
            {

                case ChartElementType.DataPoint:
                    var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    if (dateChoose == 0)
                    {
                        e.Text = string.Format("Date: {0}\n" + yAxisText + ": {1} " + yAxisValue, listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
                        chartInfo.ChartAreas[0].AxisX.Title = string.Format("Date: {0} " + yAxisText + ":{1} " + yAxisValue, listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
                    }
                    else
                    {
                        e.Text = string.Format("Date: {0}\n" + yAxisText + ": {1} " + yAxisValue, listDate2[(int)dataPoint.XValue], dataPoint.YValues[0]);
                        chartInfo.ChartAreas[0].AxisX.Title = string.Format("Date: {0} " + yAxisText + ":{1} " + yAxisValue, listDate2[(int)dataPoint.XValue], dataPoint.YValues[0]);
                    }
                    break;

                default:
                    chartInfo.ChartAreas[0].AxisX.Title = "Date";
                    break;
            }
        }

        private void chart3ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                PrintPreviewDialog printPreview = new PrintPreviewDialog();
                printPreview.Document = this.chartInfo.Printing.PrintDocument;
                printPreview.Document.PrinterSettings = printDialog.PrinterSettings;
                printPreview.ShowDialog();
            }
        }

        private void saveChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "png Image|*.png|jpeg Image|*.jpg";
            saveFileDialog.Title = "Save Chart As Image File";
            saveFileDialog.FileName = "chart";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && saveFileDialog.FileName != "")
            {
                try
                {
                    if (saveFileDialog.CheckPathExists)
                    {
                        if (saveFileDialog.FilterIndex == 2)
                        {
                            chartInfo.SaveImage(saveFileDialog.FileName, ChartImageFormat.Jpeg);
                        }
                        else if (saveFileDialog.FilterIndex == 1)
                        {
                            chartInfo.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Given Path does not exist");
                    }
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.Message);

                }
            }
        }

        private void copyChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MemoryStream mStream = new MemoryStream())
            {
                chartInfo.SaveImage(mStream, ChartImageFormat.Bmp);
                Bitmap chartImage = new Bitmap(mStream);
                Clipboard.SetImage(chartImage);
            }
            MessageBox.Show("Chart diagram copied!");
        }

        private void printChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (DialogResult.OK == printDialog.ShowDialog())
            {
                PrintPreviewDialog printPreview = new PrintPreviewDialog();
                chartInfo.Printing.PrintDocument.DefaultPageSettings.Landscape = true;
                printPreview.Document = this.chartInfo.Printing.PrintDocument;
                printPreview.Document.PrinterSettings = printDialog.PrinterSettings;
                printPreview.ShowDialog();
            }
        }

        private void FormViewGraph_Load(object sender, EventArgs e)
        {
            defautSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            chartInfoOrginal = new Rectangle(chartInfo.Location.X, chartInfo.Location.Y, chartInfo.Width, chartInfo.Height);
            listBoxShowValueOrginal = new Rectangle(listBoxShowValue.Location.X, listBoxShowValue.Location.Y, listBoxShowValue.Width, listBoxShowValue.Height);

            string line, convertValue;
            decimal convertValue2;

            showBeginDate = FormShowData.firstItem.ToString();
            showEndDate = FormShowData.lastItem.ToString();
            choosenValue = "outtemp";

            connString = chooseDatabase[0];
            passwordString = FormShowData.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            chooseItem = 1;

            if (FormShowData.localData == false)
            {
                this.Text = "Weather Station (Data from database)";
                checkNewString = Regex.Replace(FormShowData.checkString, @";", "");
                maxValue = "select max(outtemp) from (" + checkNewString + ")max;";
                Clipboard.SetText(maxValue);
                conn.Open();
                MySqlCommand command4 = new MySqlCommand(maxValue, conn);
                MySqlDataReader reader4 = command4.ExecuteReader();
                while (reader4.Read())
                {
                    listBoxShowValue.Items.Add("Maximum value: " + reader4.GetDecimal("max(outtemp)").ToString() + " °C");
                }
                conn.Close();

                minValue = "select min(outtemp) from (" + checkNewString + ")min;";
                conn.Open();
                MySqlCommand command5 = new MySqlCommand(minValue, conn);
                MySqlDataReader reader5 = command5.ExecuteReader();
                while (reader5.Read())
                {
                    listBoxShowValue.Items.Add("Minimum value: " + reader5.GetDecimal("min(outtemp)").ToString() + " °C");
                }
                conn.Close();

                averageValue = FormShowData.checkString;
                averageValue = "select avg(outtemp) from (" + checkNewString + ")avg;";
                conn.Open();
                MySqlCommand command6 = new MySqlCommand(averageValue, conn);
                MySqlDataReader reader6 = command6.ExecuteReader();
                while (reader6.Read())
                {
                    avgTemp = Math.Round((Decimal)reader6.GetDecimal("avg(outtemp)"), 2);
                    listBoxShowValue.Items.Add("Average value: " + avgTemp.ToString() + " °C");
                }
                conn.Close();

                listBoxShowValue.Items.Add("------------------------------------------------");
                conn.Open();
                MySqlCommand command = new MySqlCommand(FormShowData.checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                recordSum = 0;
                chartInfo.Update();
                chartInfo.Series[0].LegendText = "Temperature";
                chartInfo.ChartAreas[0].AxisY.Title = "Celsius";
                yAxisText = "Temperature ";
                yAxisValue = " °C";
                yMax = 40;
                yMin = -40;
                addPoint = -1;

                while (reader.Read())
                {
                    addPoint++;
                    recordSum++;
                    listDate.Add(reader.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:mm"));
                    chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outtemp"));
                    listBoxShowValue.Items.Add(reader.GetDecimal("outtemp") + " °C   " + reader.GetDateTime("datecreated"));
                }
                listBoxShowValue.Items.Add("------------------------------------------------");
                listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");

                chartInfo.ChartAreas[0].AxisY.Minimum = -40;
                chartInfo.ChartAreas[0].AxisY.Maximum = 40;
                conn.Close();
            }
            else
            {
                this.Text = "Weather Station (Data from local file)";
                recordSum = 0;
                chartInfo.Update();
                chartInfo.Series[0].LegendText = "Temperature";
                chartInfo.ChartAreas[0].AxisY.Title = "Celsius";
                yAxisText = "Temperature ";
                yAxisValue = " °C";
                addPoint = -1;
                StreamReader fileName3 = new StreamReader(FormShowData.fileName2);

                while ((line = fileName3.ReadLine()) != null)
                {
                    addPoint++;
                    recordSum++;
                    listDate.Add(line.ToString().Split(';')[3].ToString());
                    convertValue = line.ToString().Split(';')[0].ToString();
                    var removeChars = new string[] { "°", "C", " " };

                    foreach (var rc in removeChars)
                    {
                        convertValue = convertValue.Replace(rc, string.Empty);
                    }

                    convertValue2 = decimal.Parse(convertValue);
                    listSum.Add(convertValue2);
                    chartInfo.Series[0].Points.AddXY(addPoint, convertValue2);
                    listBoxShowValue.Items.Add(line.ToString().Split(';')[0].ToString() + "  " + line.ToString().Split(';')[3].ToString());
                }
                listBoxShowValue.Items.Insert(0, "------------------------------------------------");
                listBoxShowValue.Items.Insert(0, "Average value: " + Math.Round(listSum.Average(), 1) + " °C");
                listBoxShowValue.Items.Insert(0, "Min value: " + listSum.Min() + " °C");
                listBoxShowValue.Items.Insert(0, "Max value: " + listSum.Max() + " °C");

                listBoxShowValue.Items.Add("------------------------------------------------");
                listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");

                chartInfo.ChartAreas[0].AxisY.Minimum = -40;
                chartInfo.ChartAreas[0].AxisY.Maximum = 40;
            }

            Title showOne = chartInfo.Titles.Add("Begin date " + showBeginDate + "\n\n End date " + showEndDate);
            showOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold);

            string[] value = { "chartcolor", "formcolor", "linecolor" };
            string[] value2 = { "markersize", "markertype" };
            int loadStyle = 0;

            for (int i = 0; i <= 2; i++)
            {
                conn.Open();
                checkString = "select " + value[i] + " from settings where id= 1;";
                MySqlCommand command = new MySqlCommand(checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    colorHex = reader.GetString(value[i]);
                }
                Color color = System.Drawing.ColorTranslator.FromHtml(colorHex);
                switch (i)
                {
                    case 0:
                        chartInfo.BackColor = color;
                        break;

                    case 1:
                        panelSettings.BackColor = color;
                        chartInfo.BackColor = color;
                        break;

                    case 2:
                        chartInfo.Series[0].Color = color;
                        break;
                }
                conn.Close();
            }


            for (int i = 0; i <= 1; i++)
            {
                conn.Open();
                checkString = "select " + value2[i] + " from settings where id= 1;";
                MySqlCommand command2 = new MySqlCommand(checkString, conn);
                MySqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                {
                    markerValue = reader2.GetInt32(value2[i]);
                }
                switch (i)
                {
                    case 0:
                        chartInfo.Series[0].MarkerSize = markerValue;
                        comboBoxMarkerSize.Text = markerValue.ToString();
                        break;
                    case 1:
                        loadStyle = markerValue;
                        break;
                }
                conn.Close();
            }

            switch (loadStyle)
            {
                case 1:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.None;
                    comboBoxMarkerType.Text = "None";
                    break;

                case 2:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                    comboBoxMarkerType.Text = "Circle";
                    break;

                case 3:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Square;
                    comboBoxMarkerType.Text = "Square";
                    break;

                case 4:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Triangle;
                    comboBoxMarkerType.Text = "Triangle";
                    break;

                case 5:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Cross;
                    comboBoxMarkerType.Text = "Cross";
                    break;

                case 6:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Star5;
                    comboBoxMarkerType.Text = "Star";
                    break;
            }

        }

        private void chartSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewAll showAll = new FormViewAll();
            showAll.Show();
        }

        private void diagramToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartInfo.Update();
            switch (diagramToolStripComboBox.SelectedIndex)
            {
                case 0:
                    chartInfo.Series[0].ChartType = SeriesChartType.Spline;
                    break;

                case 1:
                    chartInfo.Series[0].ChartType = SeriesChartType.Column;
                    break;
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

        private void FormViewGraph_Resize(object sender, EventArgs e)
        {
            checkResize(chartInfoOrginal, chartInfo);
            checkResize(listBoxShowValueOrginal, listBoxShowValue);
        }

        private void listBoxShowValue_Click(object sender, EventArgs e)
        {
            markerShow();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelSettings.Visible == false)
            {
                panelSettings.Visible = true;
                settingsToolStripMenuItem.Checked = true;
            }
            else
            {
                panelSettings.Visible = false;
                settingsToolStripMenuItem.Checked = false;
            }
        }

        private void panelSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxChartColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSetColor.Enabled = true;
        }

        private void defaultChartSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Weather Station", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MySqlConnection conn = new MySqlConnection(connString);
                chartInfo.BackColor = Color.LightGray;
                panelSettings.BackColor = Color.LightGray;
                chartInfo.Series[0].Color = Color.SeaGreen;
                chartInfo.ChartAreas[0].BackColor = Color.White;
                chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                chartInfo.Series[0].MarkerSize = 8;

                defaultChartSettingsToolStripMenuItem.Enabled = false;
                string[] color = { "#ffffff", "#d3d3d3", "#2e8b57" };
                string[] value = { "chartcolor", "formcolor", "linecolor" };
                string[] markers = { "markersize", "markertype" };
                int[] value2 = { 8, 2 };
                ;
                for (int i = 0; i <= 2; i++)
                {
                    conn.Open();
                    checkString = "update settings set " + value[i] + " = '" + color[i] + "' where id = 1;";
                    MySqlCommand command2 = new MySqlCommand(checkString, conn);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    conn.Close();
                }

                for (int i = 0; i <= 1; i++)
                {
                    conn.Open();
                    checkString = "update settings set " + markers[i] + " = " + value2[i] + "  where id = 1;";
                    MySqlCommand command = new MySqlCommand(checkString, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    conn.Close();
                }
            }
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            DialogResult result = colorDialog1.ShowDialog();
            switch (comboBoxChartColor.SelectedIndex)
            {
                case 0:
                    if (result == DialogResult.OK)
                    {
                        chartInfo.ChartAreas[0].BackColor = colorDialog1.Color;
                        defaultChartSettingsToolStripMenuItem.Enabled = true;
                        buttonSetColor.Enabled = false;
                        colorChoose("chartcolor");
                    }
                    break;

                case 1:
                    if (result == DialogResult.OK)
                    {
                        chartInfo.BackColor = colorDialog1.Color;
                        panelSettings.BackColor = colorDialog1.Color;
                        defaultChartSettingsToolStripMenuItem.Enabled = true;
                        buttonSetColor.Enabled = false;
                        colorChoose("formcolor");
                    }
                    break;

                case 2:
                    if (result == DialogResult.OK)
                    {
                        chartInfo.Series[0].Color = colorDialog1.Color;
                        defaultChartSettingsToolStripMenuItem.Enabled = true;
                        buttonSetColor.Enabled = false;
                        colorChoose("linecolor");
                    }
                    break;
            }
        }

        private void comboBoxMarkerSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            int value = 0;
            oneTime = false;

            switch (comboBoxMarkerSize.SelectedIndex)
            {
                case 0:
                    value = 8;
                    break;

                case 1:
                    value = 9;
                    break;

                case 2:
                    value = 10;
                    break;

                case 3:
                    value = 11;
                    break;

                case 4:
                    value = 12;
                    break;

                case 5:
                    value = 13;
                    break;

                case 6:
                    value = 14;
                    break;

                case 7:
                    value = 15;
                    break;

                case 8:
                    value = 16;
                    break;
            }

            for (int i = 0; i < recordSum; i++)
            {
                chartInfo.Series[0].Points[i].MarkerSize = value;
            }

            comboBoxMarkerSize.Text = value.ToString();

            conn.Open();
        //    chartInfo.Update();
            checkString = "update settings set markersize = " + value + " where id = 1;";
            MySqlCommand command = new MySqlCommand(checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            conn.Close();
        }

       

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBoxMarkerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            int value = 0;
            switch (comboBoxMarkerType.SelectedIndex)
            {
                case 0:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.None;
                    value = 1;
                    break;

                case 1:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                    value = 2;
                    break;

                case 2:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Square;
                    value = 3;
                    break;

                case 3:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Triangle;
                    value = 4;
                    break;

                case 4:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Cross;
                    value = 5;
                    break;

                case 5:
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Star5;
                    value = 6;
                    break;

            }
            conn.Open();
            checkString = "update settings set markertype = " + value + " where id = 1;";
            Clipboard.SetText(checkString);
            MySqlCommand command = new MySqlCommand(checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            conn.Close();

        }

        private void listBoxShowValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            markerShow();
        }
    }
}

