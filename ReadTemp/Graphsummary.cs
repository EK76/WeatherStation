using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;
using DocumentFormat.OpenXml.Vml.Spreadsheet;

namespace ReadTemp
{
    public partial class FormViewAll : Form
    {
        private Rectangle chartTempOrginal;
        private Rectangle chartHumOrginal;
        private Rectangle chartPressureOrginal;
        private Rectangle buttonCloseOrginal;
        private Rectangle defautSize;
        public FormViewAll()
        {
            InitializeComponent();
        }
        string[] chooseDatabase = File.ReadAllLines(@"configdb.txt");
        string connString, checkString, dateString, dateString2, showBeginDate, showEndDate;
        int addPoint;
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

            connString = chooseDatabase[0];
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand command = new MySqlCommand(FormShowData.checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();

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
            chartTemp.Update();
            chartHum.Series[0].Points.Clear();

            chartPressure.Update();
            chartPressure.Series[0].Points.Clear();
            addPoint = -1;
            chartPressure.Series[0].LegendText = "Pressure";
            chartPressure.ChartAreas[0].AxisY.Title = "HPa";
            chartPressure.Update();
            chartPressure.Series[0].Points.Clear();

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

            chartTemp.ChartAreas[0].AxisY.Minimum = -40;
            chartTemp.ChartAreas[0].AxisY.Maximum = 40;
            chartHum.ChartAreas[0].AxisY.Minimum = 0;
            chartHum.ChartAreas[0].AxisY.Maximum = 100;
            chartPressure.ChartAreas[0].AxisY.Minimum = 1000;
            chartPressure.ChartAreas[0].AxisY.Maximum = 1200;
            conn.Close();

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
            labelBeginDate.Text = "Begin date: " + showBeginDate;
            labelEndDate.Text = "End date: " + showEndDate;
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
        }
    }
}
