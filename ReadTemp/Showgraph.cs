using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Locations;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Utilities.Collections;
using ReadTemp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Windows.UI.Composition;
using Windows.UI.StartScreen;
using Windows.UI.Xaml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using Color = System.Drawing.Color;
using Control = System.Windows.Forms.Control;
using MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle;
using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;
using Size = System.Drawing.Size;
using Title = System.Windows.Forms.DataVisualization.Charting.Title;

namespace ReadTemp
{
    public partial class FormViewGraph : System.Windows.Forms.Form
    {
        private Rectangle chartInfoOrginal;
        private Rectangle listBoxShowValueOrginal;
        private Rectangle labelDateOrginal;
        private Rectangle labelDateFirstOrginal;
        private Rectangle labelDateLastOrginal;
        private Rectangle panelDisplayOrginal;
        private Rectangle defautSize;
        public FormViewGraph()
        {
            InitializeComponent();
        }

        string[] chooseDatabase;
        string[] inputPass;

        string[] readSetting = File.ReadAllLines(System.Environment.CurrentDirectory + "\\settings.txt");
        string[] writeSetting = File.ReadAllLines(System.Environment.CurrentDirectory + "\\settings.txt");
        string path = System.Environment.CurrentDirectory + "\\settings.txt";
        string connString, checkString, dateString, dateString2, showBeginDate, showEndDate, yAxisText, yAxisValue, yAxisValue2, maxValue, averageValue, minValue, checkNewString, checkSaveString, theValue;
        string choosenValue, legendText, yTitle, yValue, colorHex, colorHex2, colorHex3;
        int addPoint = -1, chooseValue = 1, chooseItem = 1, recordSum, yMin, yMax, counterRows = -1, counterRowsSkip, dateChoose = 0, markerSize, markerType, setLineSize;
        decimal avgTemp, avgHum, avgPressure, averageValue2, convertValue;
        string currentItem, passwordString;
        int index = 0, index2, oldValue = 0, point = 0, selectIndex = 1;
        bool oneTime = false;
        List<decimal> listSum = new List<decimal>();
        string addNewValue;

        void markerShow(int checkValue)
        {
            if (oneTime == true)
            {

                oldValue = index;
                try
                {

                    chartInfo.Update();
                    chartInfo.Series[0].Points[index].MarkerSize = markerSize;

                }
                catch (Exception message)
                {
                    MessageBox.Show(message.ToString());
                }

            }
            else
            {
                //  markerSize = Convert.ToInt32(readSetting[3]);
            }
            switch (checkValue)
            {
                case 1:
                    currentItem = listBoxShowValue.SelectedItem.ToString();
                    index = listBoxShowValue.FindString(currentItem);
                    if (index >= 0)
                    {
                        chartInfo.Update();
                        chartInfo.Series[0].Points[index].MarkerSize = markerSize + 8;
                    }

                    break;
                case 2:
                    break;


            }
            oneTime = true;
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showOneToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = 0;
            listSum.Clear();

            labelDateUpdate.Text = "Date:\nTemperature:";

            labelDateFirst.Text = FormShowData.listDate.First();
            labelDateLast.Text = FormShowData.listDate.Last();

            addPoint = 0;
            foreach (var addValue in FormShowData.listDate)
            {
                chartInfo.Series[0].Points[addPoint].AxisLabel = FormShowData.listDate[addPoint];
                addPoint++;
            }

            chartInfo.Update();
            chartInfo.Series[0].Points.Clear();
            addPoint = -1;
            recordSum = 0;
            listBoxShowValue.Items.Clear();
            switch (showOneToolStripComboBox.SelectedIndex)
            {
                case 0:
                    try
                    {
                        chartInfo.Titles.Clear();
                        Title showOne = chartInfo.Titles.Add("Temperature");
                        showOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, FontStyle.Bold);

                        chartInfo.Update();
                        chartInfo.Series[0].LegendText = "Temperature";
                        chartInfo.ChartAreas[0].AxisY.Title = "Celsius";
                        chartInfo.ChartAreas[0].AxisY.Minimum = -40;
                        chartInfo.ChartAreas[0].AxisY.Maximum = 40;
                        chartInfo.ChartAreas[0].AxisY.Interval = 10;
                        chartInfo.ChartAreas[0].AxisY.MinorGrid.Interval = chartInfo.ChartAreas[0].AxisY.Interval / 2;
                        yAxisValue = "Temperature";
                        yAxisValue2 = "°C";
                        addPoint = -1;

                        foreach (var addValue in FormShowData.listTemp)
                        {

                            addPoint++;
                            recordSum++;

                            addNewValue = addValue;
                            var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                            foreach (var rc in removeChars)
                            {
                                addNewValue = addNewValue.Replace(rc, string.Empty);
                            }
                            convertValue = decimal.Parse(addNewValue);

                            chartInfo.Series[0].Points.AddXY(addPoint, convertValue);
                            listSum.Add(convertValue);
                            listBoxShowValue.Items.Add(FormShowData.listTemp[index] + "  " + FormShowData.listDate[index]);
                            index++;
                        }

                        labelAverage.Text = "Average value: " + Math.Round(listSum.Average(), 1) + " °C";
                        labelMin.Text = "Min value: " + listSum.Min() + " °C";
                        labelMax.Text = "Max value: " + listSum.Max() + " °C";
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString());
                    }
                    break;

                case 1:
                    try
                    {
                        chartInfo.Titles.Clear();
                        Title showOne = chartInfo.Titles.Add("Humidity");
                        showOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, FontStyle.Bold);

                        chartInfo.Update();
                        chartInfo.Series[0].LegendText = "Humidity";
                        chartInfo.ChartAreas[0].AxisY.Title = "Humidity %";
                        chartInfo.ChartAreas[0].AxisY.Minimum = 0;
                        chartInfo.ChartAreas[0].AxisY.Maximum = 100;
                        chartInfo.ChartAreas[0].AxisY.Interval = 10;
                        chartInfo.ChartAreas[0].AxisY.MinorGrid.Interval = chartInfo.ChartAreas[0].AxisY.Interval / 2;
                        addPoint = -1;
                        yAxisValue2 = "Humidity";
                        yAxisValue2 = "%";

                        foreach (var addValue in FormShowData.listHum)
                        {

                            addPoint++;
                            recordSum++;

                            addNewValue = addValue;
                            var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                            foreach (var rc in removeChars)
                            {
                                addNewValue = addNewValue.Replace(rc, string.Empty);
                            }
                            convertValue = decimal.Parse(addNewValue);

                            chartInfo.Series[0].Points.AddXY(addPoint, convertValue);
                            listSum.Add(convertValue);
                            listBoxShowValue.Items.Add(FormShowData.listHum[index] + "  " + FormShowData.listDate[index]);
                            index++;
                        }

                        labelAverage.Text = "Average value: " + Math.Round(listSum.Average(), 1) + " %";
                        labelMin.Text = "Min value: " + listSum.Min() + " %";
                        labelMax.Text = "Max value: " + listSum.Max() + " %";
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString());
                    }
                    break;

                case 2:
                    try
                    {
                        chartInfo.Titles.Clear();
                        Title showOne = chartInfo.Titles.Add("Pressure");
                        showOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, FontStyle.Bold);

                        chartInfo.Update();
                        chartInfo.Series[0].LegendText = "Pressure";
                        chartInfo.ChartAreas[0].AxisY.Title = "Pressure hPA";
                        chartInfo.ChartAreas[0].AxisY.Minimum = 800;
                        chartInfo.ChartAreas[0].AxisY.Maximum = 1200;
                        chartInfo.ChartAreas[0].AxisY.Interval = 100;
                        chartInfo.ChartAreas[0].AxisY.MinorGrid.Interval = chartInfo.ChartAreas[0].AxisY.Interval / 2;
                        addPoint = -1;
                        yAxisValue = "Pressure";
                        yAxisValue2 = "hPA";

                        foreach (var addValue in FormShowData.listPressure)
                        {

                            addPoint++;
                            recordSum++;

                            addNewValue = addValue;
                            var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                            foreach (var rc in removeChars)
                            {
                                addNewValue = addNewValue.Replace(rc, string.Empty);
                            }
                            convertValue = decimal.Parse(addNewValue);

                            chartInfo.Series[0].Points.AddXY(addPoint, convertValue);
                            listSum.Add(convertValue);
                            listBoxShowValue.Items.Add(FormShowData.listPressure[index] + "  " + FormShowData.listDate[index]);
                            index++;
                        }

                        labelAverage.Text = "Average value: " + Math.Round(listSum.Average(), 1) + " hPA";
                        labelMin.Text = "Min value: " + listSum.Min() + " hPA";
                        labelMax.Text = "Max value: " + listSum.Max() + " hPA";
                    }
                    catch (Exception message)
                    {
                        MessageBox.Show(message.ToString());
                    }
                    break;
            }
        }

        private void chartInfo_GetToolTipText(object sender, ToolTipEventArgs e)
        {

            var showValue = chartInfo.HitTest(e.X, e.Y);

            if ((e.HitTestResult.ChartElementType == ChartElementType.DataPoint))
            {
                var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                point = showValue.PointIndex;
                e.Text = string.Format("Date: {0}\n" + yAxisValue + ": {1} " + yAxisValue2, FormShowData.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
                labelDateUpdate.Text = string.Format("Date: {0}\n" + yAxisValue + ":{1} " + yAxisValue2, FormShowData.listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
            }
            else
            {
                labelDateUpdate.Text = "";
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
            labelDateOrginal = new Rectangle(labelDateUpdate.Location.X, labelDateUpdate.Location.Y, labelDateUpdate.Width, labelDateUpdate.Height);

            labelDateFirstOrginal = new Rectangle(labelDateFirst.Location.X, labelDateFirst.Location.Y, labelDateFirst.Width, labelDateFirst.Height);
            labelDateLastOrginal = new Rectangle(labelDateLast.Location.X, labelDateLast.Location.Y, labelDateLast.Width, labelDateLast.Height);
            panelDisplayOrginal = new Rectangle(panelDisplay.Location.X, panelDisplay.Location.Y, panelDisplay.Width, panelDisplay.Height);

            choosenValue = "outtemp";
            chooseItem = 1;
            recordSum = 0;
            index = 0;

            labelDateUpdate.Text = "Date:\nTemperature:";
            chartInfo.Update();
            chartInfo.Series[0].XValueType = ChartValueType.DateTime;
            chartInfo.ChartAreas[0].AxisX.IntervalType = (DateTimeIntervalType)DateRangeType.DayOfMonth;
            chartInfo.ChartAreas[0].AxisX.LabelStyle.Format = "dd-mm-yyyy hh.mm";

            try
            {
                chartInfo.Update();
                chartInfo.Series[0].LegendText = "Temperature";
                chartInfo.ChartAreas[0].AxisY.Title = "Celsius";
                chartInfo.ChartAreas[0].AxisY.Minimum = -40;
                chartInfo.ChartAreas[0].AxisY.Maximum = 40;
                chartInfo.ChartAreas[0].AxisY.Interval = 10;
                chartInfo.ChartAreas[0].AxisY.MinorGrid.Interval = chartInfo.ChartAreas[0].AxisY.Interval / 2;
                yAxisValue = "Temperature";
                yAxisValue2 = "°C";
                addPoint = -1;

                foreach (var addValue in FormShowData.listTemp)
                {
                    addPoint++;
                    recordSum++;

                    addNewValue = addValue;
                    var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                    foreach (var rc in removeChars)
                    {
                        addNewValue = addNewValue.Replace(rc, string.Empty);
                    }
                    convertValue = decimal.Parse(addNewValue);

                    chartInfo.Series[0].Points.AddXY(addPoint, convertValue);
                    listSum.Add(convertValue);
                    listBoxShowValue.Items.Add(FormShowData.listTemp[index] + "  " + FormShowData.listDate[index]);
                    index++;
                }

                labelAverage.Text = "Average value: " + Math.Round(listSum.Average(), 1) + " °C";
                labelMin.Text = "Min value: " + listSum.Min() + " °C";
                labelMax.Text = "Max value: " + listSum.Max() + " °C";
                labelDateFirst.Text = FormShowData.listDate.First();
                labelDateLast.Text = FormShowData.listDate.Last();
            }
            catch (Exception message)
            {
                MessageBox.Show(message.ToString());
            }

            Title showOne = chartInfo.Titles.Add("Temperature");
            showOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, FontStyle.Bold);

            colorHex = readSetting[0];
            Color color = System.Drawing.ColorTranslator.FromHtml(colorHex);
            chartInfo.ChartAreas[0].BackColor = color;

            colorHex2 = readSetting[1];
            Color color2 = System.Drawing.ColorTranslator.FromHtml(colorHex2);
            chartInfo.BackColor = color2;
            labelDateFirst.BackColor = color2;
            labelDateLast.BackColor = color2;

            colorHex3 = readSetting[2];
            Color color3 = System.Drawing.ColorTranslator.FromHtml(colorHex3);
            chartInfo.Series[0].Color = color3;

            markerSize = Convert.ToInt32(readSetting[3]);
            markerType = Convert.ToInt32(readSetting[4]);
            setLineSize = Convert.ToInt32(readSetting[5]);
     
            chartInfo.Series[0].MarkerSize = markerSize;
            comboBoxMarkerSize.Text = markerSize.ToString();
            chartInfo.Series[0].BorderWidth = setLineSize;
            comboBoxLineSize.Text = setLineSize.ToString();

            switch (markerType)
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
            checkResize(labelDateOrginal, labelDateUpdate);
            checkResize(panelDisplayOrginal, panelDisplay);
            checkResize(labelDateFirstOrginal, labelDateFirst);
            checkResize(labelDateLastOrginal, labelDateLast);
        }

        private void listBoxShowValue_Click(object sender, EventArgs e)
        {
            markerShow(1);
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
            if (comboBoxChartColor.Text == "")
            {
                buttonSetColor.Enabled = false;
            }
        }

        private void defaultChartSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Weather Station", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                chartInfo.BackColor = Color.LightGray;
                panelSettings.BackColor = Color.LightGray;
                labelDateFirst.BackColor = Color.LightGray;
                labelDateLast.BackColor = Color.LightGray;
                chartInfo.Series[0].Color = Color.SeaGreen;
                chartInfo.ChartAreas[0].BackColor = Color.White;
                chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                chartInfo.Series[0].MarkerSize = 8;
                chartInfo.Series[0].BorderWidth = 1;
                defaultChartSettingsToolStripMenuItem.Enabled = false;
                comboBoxMarkerType.Text = "2";
                comboBoxMarkerSize.Text = "8";
                comboBoxLineSize.Text = "2";

                writeSetting[0] = "#FFFFFF";
                writeSetting[1] = "#D3D3D3";
                writeSetting[2] = "#2E8B57";
                writeSetting[3] = "8";
                writeSetting[4] = "2";
                writeSetting[5] = "2";
                File.WriteAllLines(path, writeSetting);
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
                        string color = colorDialog1.Color.ToArgb().ToString("x");
                        color = color.Substring(2, 6);
                        color = "#" + color;
                        writeSetting[0] = color;
                        File.WriteAllLines(path, writeSetting);
                    }
                    break;

                case 1:
                    if (result == DialogResult.OK)
                    {
                        chartInfo.BackColor = colorDialog1.Color;
                        labelDateFirst.BackColor = colorDialog1.Color;
                        labelDateLast.BackColor = colorDialog1.Color;
                        panelSettings.BackColor = colorDialog1.Color;
                        defaultChartSettingsToolStripMenuItem.Enabled = true;
                        string color = colorDialog1.Color.ToArgb().ToString("x");
                        color = color.Substring(2, 6);
                        color = "#" + color;
                        writeSetting[1] = color;
                        File.WriteAllLines(path, writeSetting);
                    }
                    break;

                case 2:
                    if (result == DialogResult.OK)
                    {
                        chartInfo.Series[0].Color = colorDialog1.Color;
                        defaultChartSettingsToolStripMenuItem.Enabled = true;
                        string color = colorDialog1.Color.ToArgb().ToString("x");
                        color = color.Substring(2, 6);
                        color = "#" + color;
                        writeSetting[2] = color;
                        File.WriteAllLines(path, writeSetting);
                    }
                    break;
            }
        }

        private void comboBoxMarkerSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 0;
            oneTime = false;

            defaultChartSettingsToolStripMenuItem.Enabled = true;
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
            writeSetting[3] = value.ToString();
            File.WriteAllLines(path, writeSetting);
            markerSize = value;
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBoxMarkerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 0;

            defaultChartSettingsToolStripMenuItem.Enabled = true;
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
                    chartInfo.Series[0].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star5;
                    value = 6;
                    break;

            }

            writeSetting[4] = value.ToString();
            File.WriteAllLines(path, writeSetting);
        }

        private void listBoxShowValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            markerShow(1);
        }

        private void chartInfo_MouseClick(object sender, MouseEventArgs e)
        {

            int selectValue = 0;
            var showvalue = chartInfo.HitTest(e.X, e.Y);

            if (showvalue.ChartElementType == ChartElementType.DataPoint)
            {
                selectValue = showvalue.PointIndex;
                listBoxShowValue.SetSelected(selectValue, true);
            }
        }
        private void comboBoxLineSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = 0;

            defaultChartSettingsToolStripMenuItem.Enabled = true;

            switch (comboBoxLineSize.SelectedIndex)
            {
                case 0:
                    value = 1;
                    break;

                case 1:
                    value = 2;
                    break;

                case 2:
                    value = 3;
                    break;

                case 3:
                    value = 4;
                    break;

                case 4:
                    value = 5;
                    break;

                case 5:
                    value = 6;
                    break;

                case 6:
                    value = 7;
                    break;

                case 7:
                    value = 8;
                    break;

            }

            chartInfo.Series[0].BorderWidth = value;
            writeSetting[5] = value.ToString();
            File.WriteAllLines(path, writeSetting);
        }

        private void checkBoxNoMarker_Click(object sender, EventArgs e)
        {
            if (checkBoxNoMarker.Checked)
            {
                for (int i = 0; i < recordSum; i++)
                {
                    chartInfo.Series[0].Points[i].MarkerSize = 0;
                }
                comboBoxMarkerSize.Enabled = false;
            }
            else
            {
                for (int i = 0; i < recordSum; i++)
                {
                    chartInfo.Series[0].Points[i].MarkerSize = markerSize;
                }
                comboBoxMarkerSize.Enabled = true;

            }
        }
    }
}

