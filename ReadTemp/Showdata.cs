using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ReadTemp
{
    public partial class FormInfo : System.Windows.Forms.Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public FormInfo()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private string getData;
        string getValue, getDataTemp, getDataHum, getDataTemp2, getDataHum2, stringCopy, errorInfo, checkString, setDate, defaultValue, delay, setTime, openFile, colorHex, endDate;
        public static string connString;
        string[] chooseDatabase;
        string[] lines;
        string[] values;

        int counter = 0, checkTable, week, month, year;
        int newGetDataTemp, newGetDataTemp2, newGetDataHum, newGetDataHum2, delayValue;
        int setDelay;
        Boolean checkOnce = true;

        public static Boolean checkPort = false;

        MySqlConnection conn = new MySqlConnection(connString);

        void fullView()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            menuStrip1.Visible = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            standardViewToolStripMenuItem.Text = "StandardView";
            screenShotToolStripMenuItem.Enabled = true;
        }

        void standardView()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            menuStrip1.Visible = true;
            standardViewToolStripMenuItem.Text = "FullView";
            screenShotToolStripMenuItem.Enabled = false;
        }

        void checkSystem()
        {
            chooseDatabase = File.ReadAllLines(@"configdb.txt");
            connString = chooseDatabase[0];
            MySqlConnection conn = new MySqlConnection(connString);

            conn.Open();
            checkString = "select * from weatherdata;";
            MySqlCommand command = new MySqlCommand(checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                labelTemp.Text = "Outdoor temperature: " + reader.GetDecimal("outtemp") + " °C";
                labelHum.Text = "Outdoor humidity: " + reader.GetDecimal("outhum") + " %";
                labelPressure.Text = "Pressure: " + reader.GetDecimal("pressure") + " hPa";
                labelDate.Text = "Latest available data: " + reader.GetDateTime("datecreated").ToString("dd-MM-yyyy HH:dd");
            }
            conn.Close();

            conn.Open();
            checkString = "(select outtemp from weatherdata order by outtemp desc limit 1) union (select outtemp from weatherdata order by outtemp asc limit 1);";
            MySqlCommand command2 = new MySqlCommand(checkString, conn);
            MySqlDataReader reader2 = command2.ExecuteReader();
            counter = 0;
            while (reader2.Read())
            {
                counter++;
                if (counter == 1)
                {
                    labelHighTemp.Text = "Highest outdoor temperature: " + reader2.GetDecimal("outtemp") + " °C";
                }
                if (counter == 2)
                {
                    labelLowTemp.Text = "Lowest outdoor temperature: " + reader2.GetDecimal("outtemp") + " °C";
                }
            }
            conn.Close();

            conn.Open();
            checkString = "(select outhum from weatherdata order by outhum desc limit 1) union (select outhum from weatherdata order by outhum asc limit 1);";
            MySqlCommand command3 = new MySqlCommand(checkString, conn);
            MySqlDataReader reader3 = command3.ExecuteReader();
            counter = 0;
            while (reader3.Read())
            {
                counter++;
                if (counter == 1)
                {
                    labelHighHum.Text = "Highest outdoor humidity: " + reader3.GetDecimal("outhum") + " %";
                }
                if (counter == 2)
                {
                    labelLowHum.Text = "Lowest outdoor humidity: " + reader3.GetDecimal("outhum") + " %";
                }
            }
            conn.Close();

            conn.Open();
            checkString = "(select pressure from weatherdata order by pressure desc limit 1) union (select pressure from weatherdata order by pressure asc limit 1);";
            MySqlCommand command4 = new MySqlCommand(checkString, conn);
            MySqlDataReader reader4 = command4.ExecuteReader();
            counter = 0;
            while (reader4.Read())
            {
                counter++;
                if (counter == 1)
                {
                    labelHighPressure.Text = "Highest outdoor pressure: " + reader4.GetDecimal("pressure") + " hPa";
                }
                if (counter == 2)
                {
                    labelLowPressure.Text = "Lowest outdoor pressure: " + reader4.GetDecimal("pressure") + " hPa";
                }
            }
            conn.Close();

            conn.Open();
            checkString = "(select datecreated from weatherdata order by datecreated desc limit 1) union (select datecreated from weatherdata order by datecreated asc limit 1);";
            MySqlCommand command5 = new MySqlCommand(checkString, conn);
            MySqlDataReader reader5 = command5.ExecuteReader();
            counter = 0;
            while (reader5.Read())
            {
                counter++;
                if (counter == 1)
                {
                    endDate = " - " + reader5.GetDateTime("datecreated").ToString("MM-dd-yyyy H:mm");
                }
                if (counter == 2)
                {
                    labelStartDate.Text = "Intervall between " + reader5.GetDateTime("datecreated").ToString("MM-dd-yyyy H:mm") + " - " + endDate;
                }
            }
            conn.Close();


            conn.Open();
            checkString = "select color from settings where id= 1";
            MySqlCommand command6 = new MySqlCommand(checkString, conn);
            MySqlDataReader reader6 = command6.ExecuteReader();

            while (reader6.Read())
            {
                colorHex = reader6.GetString("color");

            }
            conn.Close();

            Color color = System.Drawing.ColorTranslator.FromHtml(colorHex);
            this.Controls.OfType<Label>().ToList().ForEach(allLabels =>
        {
            allLabels.ForeColor = color;
        });
        }

        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            DialogResult result = colorDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure the replace the the text color?", "Weather Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Controls.OfType<Label>().ToList().ForEach(allLabels =>
                    {
                        allLabels.ForeColor = colorDialog1.Color;
                    });
                    string color = colorDialog1.Color.ToArgb().ToString("x");
                    color = color.Substring(2, 6);
                    color = "#" + color;

                    chooseDatabase = File.ReadAllLines(@"configdb.txt");
                    connString = chooseDatabase[0];
                    MySqlConnection conn = new MySqlConnection(connString);

                    conn.Open();
                    checkString = "update settings set color = '" + color + "' where id = 1;";
                    Clipboard.SetText(checkString);
                    MySqlCommand command = new MySqlCommand(checkString, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("The text color has been replaced");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            checkSystem();
            panelPicture.BackgroundImage = Image.FromFile(@"Pictures\Landscape\landscape.jpg");
            labelDate.Parent = panelPicture;
            labelDateTime.Parent = panelPicture;
            labelDateTime2.Parent = panelPicture;
            labelHighHum.Parent = panelPicture;
            labelLowHum.Parent = panelPicture;  
            labelHighHum.Parent = panelPicture;
            labelHighPressure.Parent = panelPicture;
            labelLowPressure.Parent = panelPicture;
            labelHighTemp.Parent = panelPicture;
            labelLowTemp.Parent = panelPicture; 
            labelTemp.Parent = panelPicture;
            labelHum.Parent = panelPicture;
            labelPressure.Parent = panelPicture;
            labelStartDate.Parent = panelPicture;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkSystem();
        }

        private void screenShotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap copyPic = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(copyPic, new Rectangle(0, 0, this.Width, this.Height));
            Clipboard.SetImage((Image)copyPic);
            MessageBox.Show("The view is copied to clipboard!");
        }

        private void setDelayToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout About = new FormAbout();
            About.Show();
        }


        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FormInfo_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormInfo_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void fullViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fullView();
        }

        private void FormInfo_DoubleClick(object sender, EventArgs e)
        {
            standardView();
        }

        private void exit2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void standardViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (standardViewToolStripMenuItem.Text == "StandardView")
            {
                standardView();
            }
            else
            {
                fullView();
            }
        }

        private void showDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowData showData = new FormShowData();
            showData.Show();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(stringCopy);
        }

        private void changeBackgroundPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "jpeg Image|*.jpg";
            openFileDialog.Title = "Replace the landscape picture";

            DialogResult result = openFileDialog.ShowDialog();
            openFileDialog.RestoreDirectory = true;

            if (result == DialogResult.OK && openFileDialog.FileName != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure the replace the landscape picture?", "Weather Info", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    panelPicture.BackgroundImage.Dispose();
                    openFile = openFileDialog.FileName;
                    File.Copy(openFile, @"Pictures\LandScape\landscape.jpg", true);
                    panelPicture.BackgroundImage = Image.FromFile(@"Pictures\Landscape\landscape.jpg");
                    MessageBox.Show("The landscape picture has been replaced");
                }
            }
        }
    }
}
