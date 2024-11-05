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
        string connString, checkString, dateString, dateString2, showBeginDate, showEndDate, yAxisText, yAxisValue, maxValue, averageValue, minValue, checkNewString, checkSaveString, theValue;
        string choosenValue, legendText, yTitle, yValue, convertValue;
        int addPoint = -1, chooseValue = 1, chooseItem = 1, recordSum, yMin, yMax;
        decimal avgTemp, avgHum, avgPressure, averageValue2;
        List<String> listDate = new List<String>();
        List<decimal> listSum = new List<decimal>();

        private void intervallToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartInfo.Update();
            chartInfo.Series[0].Points.Clear();
            checkSaveString = checkNewString;
            addPoint = -1;

            switch (intervallToolStripComboBox.SelectedIndex)
            {
                case 0:
                    checkNewString += " and id mod 1 = 0";
                    chooseValue = 1;
                    break;

                case 1:
                    checkNewString += " and id mod 3 = 0";
                    chooseValue = 2;
                    break;

                case 2:
                    checkNewString += " and id mod 6 = 0";
                    chooseValue = 3;
                    break;
            }

            connString = chooseDatabase[0];
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            Clipboard.SetText(checkNewString);
            MySqlCommand command = new MySqlCommand(checkNewString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            recordSum = 0;
            switch (chooseItem)
            {
                case 1:
                    chartInfo.Series[0].LegendText = "Temperature";
                    chartInfo.ChartAreas[0].AxisY.Title = "Celsius";
                    yAxisText = "Temperature";
                    yAxisValue = " °C";
                    chartInfo.ChartAreas[0].AxisY.Minimum = -40;
                    chartInfo.ChartAreas[0].AxisY.Maximum = 40;
                    break;

                case 2:
                    chartInfo.Series[0].LegendText = "Indoor Humidity";
                    chartInfo.ChartAreas[0].AxisY.Title = "Procent";
                    yAxisText = "Humidity";
                    yAxisValue = " %";
                    chartInfo.ChartAreas[0].AxisY.Minimum = 0;
                    chartInfo.ChartAreas[0].AxisY.Maximum = 100;
                    break;

                case 3:
                    chartInfo.Series[0].LegendText = "Pressure";
                    chartInfo.ChartAreas[0].AxisY.Title = "Pressure";
                    yAxisText = "Pressure";
                    yAxisValue = " hPa";
                    chartInfo.ChartAreas[0].AxisY.Minimum = 1000;
                    chartInfo.ChartAreas[0].AxisY.Maximum = 1200;
                    break;
            }

            switch (chooseValue)
            {
                case 1:

                    chartInfo.Update();
                    chartInfo.Series[0].Points.Clear();
                    listBoxShowValue.Items.Clear();
                    while (reader.Read())
                    {
                        addPoint++;
                        switch (chooseItem)
                        {
                            case 1:
                                chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outtemp"));
                                listBoxShowValue.Items.Add(reader.GetDecimal("outtemp") + " °C");
                                break;
                            case 2:
                                chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outhum"));
                                listBoxShowValue.Items.Add(reader.GetDecimal("outhum") + " %");
                                break;
                            case 3:
                                chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("pressure"));
                                listBoxShowValue.Items.Add(reader.GetDecimal("pressure") + " hPa");
                                break;

                        }
                        chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                        chartInfo.Series[0].MarkerSize = 8;
                        recordSum++;
                    }


                    conn.Close();
                    break;

                case 2:
                    chartInfo.Update();
                    chartInfo.Series[0].Points.Clear();
                    listBoxShowValue.Items.Clear();
                    while (reader.Read())
                    {
                        addPoint++;
                        switch (chooseItem)
                        {
                            case 1:
                                chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outtemp"));
                                listBoxShowValue.Items.Add(reader.GetDecimal("outtemp") + " °C");
                                break;
                            case 2:
                                chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outhum"));
                                listBoxShowValue.Items.Add(reader.GetDecimal("outhum") + " %");
                                break;
                            case 3:
                                chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("pressure"));
                                listBoxShowValue.Items.Add(reader.GetDecimal("pressure") + " hPa");
                                break;

                        }
                        chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                        chartInfo.Series[0].MarkerSize = 8;
                        recordSum++;

                    }

                    conn.Close();
                    break;

                case 3:

                    chartInfo.Update();
                    chartInfo.Series[0].Points.Clear();
                    listBoxShowValue.Items.Clear();
                    while (reader.Read())
                    {
                        addPoint++;
                        switch (chooseItem)
                        {
                            case 1:
                                chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outtemp"));
                                listBoxShowValue.Items.Add(reader.GetDecimal("outtemp") + " °C");
                                break;
                            case 2:
                                chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outhum"));
                                listBoxShowValue.Items.Add(reader.GetDecimal("outhum") + " %");
                                break;
                            case 3:
                                chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("pressure"));
                                listBoxShowValue.Items.Add(reader.GetDecimal("pressure") + " hPa");
                                break;

                        }
                        chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                        chartInfo.Series[0].MarkerSize = 8;
                        recordSum++;
                    }

                    conn.Close();
                    break;
            }
            listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");
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


            connString = chooseDatabase[0];
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
                    break;

                case 1:
                    choosenValue = "outhum";
                    legendText = "Humitidy";
                    yTitle = "Procent";
                    yValue = " %";
                    index = 1;
                    yMax = 100;
                    break;

                case 2:
                    choosenValue = "pressure";
                    legendText = "Pressure";
                    yTitle = "hPA";
                    yValue = "hPA";
                    index = 2;
                    yMin = 1000;
                    yMax = 1200;
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
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartInfo.Series[0].MarkerSize = 8;
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
                chartInfo.Series[0].LegendText = legendText;
                chartInfo.ChartAreas[0].AxisY.Title = yTitle;
                yAxisText = legendText;
                yAxisValue = yValue;
                addPoint = -1;
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
                   chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                   chartInfo.Series[0].MarkerSize = 8;
                   listBoxShowValue.Items.Add(line.ToString().Split(';')[index].ToString() + line.ToString().Split(';')[3].ToString());
                }
                listBoxShowValue.Items.Insert(0, "------------------------------------------------");
                listBoxShowValue.Items.Insert(0, "Average value: " + Math.Round(listSum.Average(), 1) + " " + yValue );
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
                    e.Text = string.Format("Date: {0}\n" + yAxisText + ": {1} " + yAxisValue, listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
                    chartInfo.ChartAreas[0].AxisX.Title = string.Format("Date: {0} " + yAxisText + ":{1} " + yAxisValue, listDate[(int)dataPoint.XValue], dataPoint.YValues[0]);
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

            connString = chooseDatabase[0];
            MySqlConnection conn = new MySqlConnection(connString);

            if (FormShowData.localData == false)
            {

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
                addPoint = -1;

                while (reader.Read())
                {
                    addPoint++;
                    recordSum++;
                    listDate.Add(reader.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:mm"));
                    chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outtemp"));
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartInfo.Series[0].MarkerSize = 8;
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
                    var removeChars = new string[] { "°", "C", " "};

                    foreach (var rc in removeChars)
                    {
                        convertValue = convertValue.Replace(rc, string.Empty);
                    }

                    convertValue2 =decimal.Parse(convertValue);
                    listSum.Add(convertValue2);
                    chartInfo.Series[0].Points.AddXY(addPoint, convertValue2);
                    chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                    chartInfo.Series[0].MarkerSize = 8;
                    listBoxShowValue.Items.Add(line.ToString().Split(';')[0].ToString() + "  " + line.ToString().Split(';')[3].ToString());
                }
                listBoxShowValue.Items.Insert(0,"------------------------------------------------");
                listBoxShowValue.Items.Insert(0, "Average value: " + Math.Round(listSum.Average(),1) + " °C");
                listBoxShowValue.Items.Insert(0, "Min value: " + listSum.Min() + " °C");
                listBoxShowValue.Items.Insert(0, "Max value: " + listSum.Max() + " °C");

                listBoxShowValue.Items.Add("------------------------------------------------");
                listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");

                chartInfo.ChartAreas[0].AxisY.Minimum = -40;
                chartInfo.ChartAreas[0].AxisY.Maximum = 40;
            }

            Title showOne = chartInfo.Titles.Add("Begin date " + showBeginDate + "\n\n End date " + showEndDate);
            showOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, FontStyle.Bold);
        }

        private void chartSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewAll showAll = new FormViewAll();
            showAll.Show();
        }

        private void chartLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                chartInfo.Series[0].Color = colorDialog1.Color;
                defaultSettingToolStripMenuItem.Enabled = true;
            }
        }

        private void chartBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                chartInfo.ChartAreas[0].BackColor = colorDialog1.Color;
                defaultSettingToolStripMenuItem.Enabled = true;
            }
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

        private void formBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                chartInfo.BackColor = colorDialog1.Color;
                defaultSettingToolStripMenuItem.Enabled = true;
            }
        }

        private void defaultSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Weather Station", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                chartInfo.BackColor = Color.LightGray;
                chartInfo.Series[0].Color = Color.SeaGreen;
                chartInfo.ChartAreas[0].BackColor = Color.White;
                defaultSettingToolStripMenuItem.Enabled = false;
            }
        }

        private void createRapportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

