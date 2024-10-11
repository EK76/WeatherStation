using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;


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
        int addPoint = -1, chooseValue = 1, chooseItem = 1, recordSum;
        decimal avgTemp, avgHum, avgPressure;
        List<String> listDate = new List<String>();

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
                    Clipboard.SetText(minValue);
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
                    Clipboard.SetText(averageValue);
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
                    chartInfo.Series[0].LegendText = "Temperature";
                    chartInfo.ChartAreas[0].AxisY.Title = "Celsius";
                    yAxisText = "Temperature";
                    yAxisValue = " °C";
                    chartInfo.Update();
                    chartInfo.Series[0].Points.Clear();
                    conn.Open();
                    MySqlCommand command = new MySqlCommand(FormShowData.checkString, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        addPoint++;
                        chartInfo.Series[0].Points.AddXY(addPoint, reader.GetDecimal("outtemp"));
                        chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                        chartInfo.Series[0].MarkerSize = 8;
                        listBoxShowValue.Items.Add(reader.GetDecimal("outtemp") + " °C   " + reader.GetDateTime("datecreated"));
                        recordSum++;
                    }

                    chartInfo.ChartAreas[0].AxisY.Minimum = -40;
                    chartInfo.ChartAreas[0].AxisY.Maximum = 40;
                    conn.Close();
                    chooseItem = 1;
                    listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");
                    break;

                case 1:
                    maxValue = "select max(outhum) from (" + checkNewString + ")max;";
                    Clipboard.SetText(maxValue);
                    conn.Open();
                    MySqlCommand command7 = new MySqlCommand(maxValue, conn);
                    MySqlDataReader reader7 = command7.ExecuteReader();
                    while (reader7.Read())
                    {
                        listBoxShowValue.Items.Add("Maximum value: " + reader7.GetDecimal("max(outhum)").ToString() + " °C");
                    }
                    conn.Close();

                    minValue = "select min(outhum) from (" + checkNewString + ")min;";
                    Clipboard.SetText(minValue);
                    conn.Open();
                    MySqlCommand command8 = new MySqlCommand(minValue, conn);
                    MySqlDataReader reader8 = command8.ExecuteReader();
                    while (reader8.Read())
                    {
                        listBoxShowValue.Items.Add("Minimum value: " + reader8.GetDecimal("min(outhum)").ToString() + " °C");
                    }
                    conn.Close();

                    averageValue = FormShowData.checkString;
                    averageValue = "select avg(outhum) from (" + checkNewString + ")avg;";
                    Clipboard.SetText(averageValue);
                    conn.Open();
                    MySqlCommand command9 = new MySqlCommand(averageValue, conn);
                    MySqlDataReader reader9 = command9.ExecuteReader();
                    while (reader9.Read())
                    {
                        avgHum = Math.Round((Decimal)reader9.GetDecimal("avg(outhum)"), 2);
                        listBoxShowValue.Items.Add("Average value: " + avgHum.ToString() + " °C");

                    }
                    conn.Close();

                    listBoxShowValue.Items.Add("------------------------------------------------");
                    chartInfo.Series[0].LegendText = "Humitidy";
                    chartInfo.ChartAreas[0].AxisY.Title = "Procent";
                    yAxisText = "Procent";
                    yAxisValue = " %";
                    chartInfo.Update();
                    chartInfo.Series[0].Points.Clear();
                    conn.Open();
                    MySqlCommand command10 = new MySqlCommand(FormShowData.checkString, conn);
                    MySqlDataReader reader10 = command10.ExecuteReader();
                    while (reader10.Read())
                    {
                        addPoint++;
                        chartInfo.Series[0].Points.AddXY(addPoint, reader10.GetDecimal("outhum"));
                        chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                        chartInfo.Series[0].MarkerSize = 8;
                        listBoxShowValue.Items.Add(reader10.GetDecimal("outhum") + " %   " + reader10.GetDateTime("datecreated"));
                        recordSum++;
                    }

                    chartInfo.ChartAreas[0].AxisY.Minimum = 0;
                    chartInfo.ChartAreas[0].AxisY.Maximum = 100;
                    conn.Close();
                    chooseItem = 1;
                    listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");
                    break;

                case 2:
                    maxValue = "select max(pressure) from (" + checkNewString + ")max;";
                    Clipboard.SetText(maxValue);
                    conn.Open();
                    MySqlCommand command11 = new MySqlCommand(maxValue, conn);
                    MySqlDataReader reader11 = command11.ExecuteReader();
                    while (reader11.Read())
                    {
                        listBoxShowValue.Items.Add("Maximum value: " + reader11.GetDecimal("max(pressure)").ToString() + " hPA");
                    }
                    conn.Close();

                    minValue = "select min(pressure) from (" + checkNewString + ")min;";
                    Clipboard.SetText(minValue);
                    conn.Open();
                    MySqlCommand command12 = new MySqlCommand(minValue, conn);
                    MySqlDataReader reader12 = command12.ExecuteReader();
                    while (reader12.Read())
                    {
                        listBoxShowValue.Items.Add("Minimum value: " + reader12.GetDecimal("min(pressure)").ToString() + " hPA");
                    }
                    conn.Close();

                    averageValue = FormShowData.checkString;
                    averageValue = "select avg(pressure) from (" + checkNewString + ")avg;";
                    Clipboard.SetText(averageValue);
                    conn.Open();
                    MySqlCommand command13 = new MySqlCommand(averageValue, conn);
                    MySqlDataReader reader13 = command13.ExecuteReader();
                    while (reader13.Read())
                    {
                        avgPressure = Math.Round((Decimal)reader13.GetDecimal("avg(pressure)"), 2);
                        listBoxShowValue.Items.Add("Average value: " + avgPressure.ToString() + " hPA");
                    }
                    conn.Close();

                    listBoxShowValue.Items.Add("------------------------------------------------");
                    chartInfo.Series[0].LegendText = "Pressure";
                    chartInfo.ChartAreas[0].AxisY.Title = "hPA";
                    yAxisText = "Pressure";
                    yAxisValue = "hPA";
                    chartInfo.Update();
                    chartInfo.Series[0].Points.Clear();
                    conn.Open();
                    MySqlCommand command14 = new MySqlCommand(FormShowData.checkString, conn);
                    MySqlDataReader reader14 = command14.ExecuteReader();
                    while (reader14.Read())
                    {
                        addPoint++;
                        chartInfo.Series[0].Points.AddXY(addPoint, reader14.GetDecimal("pressure"));
                        chartInfo.Series[0].MarkerStyle = MarkerStyle.Circle;
                        chartInfo.Series[0].MarkerSize = 8;
                        listBoxShowValue.Items.Add(reader14.GetDecimal("pressure") + " hPA   " + reader14.GetDateTime("datecreated"));
                        recordSum++;
                    }

                    chartInfo.ChartAreas[0].AxisY.Minimum = 0;
                    chartInfo.ChartAreas[0].AxisY.Maximum = 1500;
                    conn.Close();
                    chooseItem = 1;
                    listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");
                    break;
            }

            conn.Close();
        }

        private void mainChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    FormViewMenuOption showMenuOptions = new FormViewMenuOption();
            //   showMenuOptions.Show();
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

        private void colorOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            using (MemoryStream ms = new MemoryStream())
            {
                chartInfo.SaveImage(ms, ChartImageFormat.Bmp);
                Bitmap bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }
            MessageBox.Show("Chart diagram copied!");
        }

        private void printChartToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void chartOne_GetToolTipText(object sender, DrawToolTipEventArgs e)
        {

        }

        private void chart3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                chartInfo.SaveImage(ms, ChartImageFormat.Bmp);
                Bitmap bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }
            MessageBox.Show("Details copied!");
        }


        private void FormViewGraph_Load(object sender, EventArgs e)
        {
            defautSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);
            chartInfoOrginal = new Rectangle(chartInfo.Location.X, chartInfo.Location.Y, chartInfo.Width, chartInfo.Height);
            listBoxShowValueOrginal = new Rectangle(listBoxShowValue.Location.X, listBoxShowValue.Location.Y, listBoxShowValue.Width, listBoxShowValue.Height);
            connString = chooseDatabase[0];
            MySqlConnection conn = new MySqlConnection(connString);

            dateString = FormShowData.checkString;
            dateString = dateString.Remove(dateString.Length - 1);
            dateString = dateString + " order by id asc limit 1;";

            conn.Open();
            MySqlCommand command2 = new MySqlCommand(dateString, conn);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                showBeginDate = reader2.GetDateTime("datecreated").ToString();
            }
            conn.Close();

            dateString2 = FormShowData.checkString;
            dateString2 = dateString2.Remove(dateString2.Length - 1);
            dateString2 = dateString2 + " order by id desc limit 1;";
            conn.Open();
            MySqlCommand command3 = new MySqlCommand(dateString2, conn);
            MySqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                showEndDate = reader3.GetDateTime("datecreated").ToString();
            }
            conn.Close();

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
            listBoxShowValue.Items.Add(recordSum.ToString() + " rows selected");

            chartInfo.ChartAreas[0].AxisY.Minimum = -40;
            chartInfo.ChartAreas[0].AxisY.Maximum = 40;
            conn.Close();



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
                DialogResult dialogResult = MessageBox.Show("Are you sure the replace the color?", "Weather Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    chartInfo.Series[0].Color = colorDialog1.Color;
                }
            }
        }

        private void chartBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure the replace the color?", "Weather Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    chartInfo.ChartAreas[0].BackColor = colorDialog1.Color;
                }
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
                DialogResult dialogResult = MessageBox.Show("Are you sure the replace the color?", "Weather Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    chartInfo.BackColor = colorDialog1.Color;
                }
            }
        }
    }
}

