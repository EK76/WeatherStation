using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Document = iTextSharp.text.Document;
using Font = System.Drawing.Font;
using PageSize = iTextSharp.text.PageSize;
using SortOrder = System.Windows.Forms.SortOrder;
using System.IO;
using System.Linq;
using static System.Windows.Forms.ListViewItem;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using Windows.UI.Xaml;
using System.Collections.Generic;
using MySqlX.XDevAPI.Common;
using ReadTemp.Properties;
using Locations;
using System.Linq.Expressions;

namespace ReadTemp
{
    public partial class FormShowData : System.Windows.Forms.Form
    {
        public FormShowData()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listViewShowData.ListViewItemSorter = lvwColumnSorter;
        }
        private ListViewColumnSorter lvwColumnSorter;
        string timeString, compareDay, checkDay, convertMonth, setValue, folderPdf, setDay, setDelay, passwordString;
        public static string forwardStartDate, newStartDate, newEndDate, currentDate, firstItem, lastItem, fileName2, connString;
        DateTime onlyTime, checkDay2, convertDate, startDate, endDate;
        int checkWeek, compareWeek = 0, checkMonth, compareMonth = 0, checkYear, compareYear = 0, setNewValue, setDelay2, delayStatus, checkNumbers;
        public static int checkForward, counterItems = 0, countItems = -1, localChoice = 1;
        long getYear;
        bool allowDelay = false, createDatabase = true;
        public static bool localData = false;
        private static string passWordString;
        string[] settingsStorage;




        private void delayToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            allowDelay = true;
        }

        private void listViewShowData_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            this.listViewShowData.Sort();
        }

        private void delayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowDelay = true;
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModifyTable modifyData = new FormModifyTable();
            modifyData.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int counterItems = 0, countItems = -1;
            Choice.localData = false;
            startDate = dateTimePickerStartDate.Value;
            endDate = dateTimePickerEndDate.Value;
            endDate = endDate.AddDays(1);

            newStartDate = startDate.ToString("yyyy-MM-dd");
            newEndDate = endDate.ToString("yyyy-MM-dd");
            try
            {
                if (endDate >= startDate)
                {
                    comboBoxMonth.Text = "";
                    checkForward = 1;
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    Choice.checkString = "select outtemp, outhum, pressure, datecreated from weatherdata where datecreated between '" + newStartDate + "' and '" + newEndDate + "';";
                    MySqlCommand command = new MySqlCommand(Choice.checkString, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        counterItems++;
                        if (counterItems == 1)
                        {
                            listViewShowData.Items.Clear();
                        }
                        countItems++;
                        listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("outtemp").ToString() + " °C", reader.GetDecimal("outhum").ToString() + " %", reader.GetDecimal("pressure").ToString() + " hPa", reader.GetDateTime("datecreated").ToString() }));
                    }
                    if (counterItems == 0)
                    {
                        MessageBox.Show("The search was not result!");
                    }
                    else
                    {
                        exportToPDFToolStripMenuItem.Enabled = true;
                        graphViewToolStripMenuItem.Enabled = true;
                        clearDataToolStripMenuItem.Enabled = true;
                        deleteSelectedRowsToolStripMenuItem.Enabled = true;
                        saveToolStripMenuItem.Enabled = true;
                        printToolStripMenuItem.Enabled = true;
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                        labelStatus.Text = "Data from server database.";
                        Choice.firstItem = listViewShowData.Items[0].SubItems[3].Text;
                        Choice.lastItem = listViewShowData.Items[countItems].SubItems[3].Text;
                    }
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("End date must be larger than Start date!");
                }
            }
            catch
            {
                MessageBox.Show("Database configuration fail! Check database settings!");
            }
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMonth.Enabled = true;
        }

        private void graphViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewGraph showGraph = new FormViewGraph();
            showGraph.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPrinter1.PrintPreview();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog saveContent = new SaveFileDialog();

            saveContent.Title = "Save Data";
            saveContent.Filter = "Weather File (.whf) | *.whf";

            try
            {
                if (saveContent.ShowDialog() == DialogResult.OK)
                {
                    filename = saveContent.FileName.ToString();
                    if (filename != "")
                    {
                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            foreach (ListViewItem item in listViewShowData.Items)
                            {
                                sw.WriteLine("{0}{1}{2}{3}", item.SubItems[0].Text + ";", item.SubItems[1].Text + ";", item.SubItems[2].Text + ";", item.SubItems[3].Text + ";");
                            }
                        }
                        MessageBox.Show("File " + filename + " is susccessfully saved!");
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void exportToPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PdfPTable pdfTable = new PdfPTable(listViewShowData.Columns.Count);
            pdfTable.DefaultCell.Padding = 5;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            SaveFileDialog savePDF = new SaveFileDialog();
            savePDF.Filter = "PDF ´files (*.pdf)|*.pdf";
            savePDF.FileName = "Data_" + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf";

            if (savePDF.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Export was aborted!");
            }
            else
            {
                foreach (ColumnHeader column in listViewShowData.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                    pdfTable.AddCell(cell);

                }

                foreach (ListViewItem itemRow in listViewShowData.Items)
                {
                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        pdfTable.AddCell(itemRow.SubItems[i].Text);
                    }
                }
                try
                {
                    using (FileStream stream = new FileStream(savePDF.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
                    MessageBox.Show("Data exported to PDF file" + savePDF.FileName + " was successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem to export data to PDF file! " + ex.Message.ToString());
                }
            }

        }

        private void comboBoxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewShowData.Items.Clear();
            comboBoxDay.Items.Clear();
            setValue = comboBoxMonth.Text;

            switch (setValue)
            {
                case "January":
                    setNewValue = 1;
                    break;
                case "February":
                    setNewValue = 2;
                    break;
                case "March":
                    setNewValue = 3;
                    break;
                case "April":
                    setNewValue = 4;
                    break;
                case "May":
                    setNewValue = 5;
                    break;
                case "June":
                    setNewValue = 6;
                    break;
                case "July":
                    setNewValue = 7;
                    break;
                case "August":
                    setNewValue = 8;
                    break;
                case "September":
                    setNewValue = 9;
                    break;
                case "October":
                    setNewValue = 10;
                    break;
                case "November":
                    setNewValue = 11;
                    break;
                case "December":
                    setNewValue = 12;
                    break;
            }
            comboBoxDay.Enabled = true;

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            Choice.checkString = "select outtemp, outhum, pressure, datecreated from weatherdata where month(datecreated) = " + setNewValue + " && year(datecreated) = " + comboBoxYear.Text + ";";
            MySqlCommand command = new MySqlCommand(Choice.checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                setDay = reader.GetDateTime("datecreated").ToString("yyyy-MM-dd");
                setDay = Regex.Match(setDay, @"^\S*").Value;
                if (setDay != compareDay)
                {
                    comboBoxDay.Items.Add(setDay);
                    compareDay = setDay;
                }
            }
            conn.Close();
        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choice.localData = false;
            listViewShowData.Items.Clear();
            counterItems = 0;
            comboBoxMonth.Text = "";
            setDay = comboBoxDay.Text;
            countItems = -1;
            convertDate = DateTime.Parse(setDay.ToString());
            setDay = convertDate.ToString("yyyy-MM-dd");
            forwardStartDate = comboBoxDay.Text;
            checkForward = 2;
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            Choice.checkString = "select outtemp, outhum, pressure, datecreated from weatherdata where datecreated like '" + comboBoxDay.Text + "%';";
            MySqlCommand command = new MySqlCommand(Choice.checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                counterItems++;
                countItems++;
                listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("outtemp") + " °C ", reader.GetDecimal("outhum") + " % ", reader.GetDecimal("pressure") + " hPa ", reader.GetDateTime("datecreated").ToString() }));
            }
            conn.Close();

            Choice.firstItem = listViewShowData.Items[0].SubItems[3].Text;
            Choice.lastItem = listViewShowData.Items[countItems].SubItems[3].Text;

            exportToPDFToolStripMenuItem.Enabled = true;
            graphViewToolStripMenuItem.Enabled = true;
            clearDataToolStripMenuItem.Enabled = true;
            deleteSelectedRowsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            printToolStripMenuItem.Enabled = true;
            labelRows.Text = "Numbers of rows: " + counterItems.ToString();
            labelStatus.Text = "Data from server database.";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //  showData();
        }

        private void FormShowData_Load(object sender, EventArgs e)
        {

            if (!File.Exists("input.txt"))
            {
                File.AppendAllText("input.txt", "password");
            }

            if (!File.Exists("configdb.txt"))
            {
                File.AppendAllText("configdb.txt", "SERVER=Server;DATABASE=weatherstation;UID=User;PASSWORD=");
                FormConfigDatabase configDatabase = new FormConfigDatabase();
                configDatabase.ShowDialog();
            }

            string[] chooseDatabase = File.ReadAllLines("configdb.txt");
            string[] inputPass = File.ReadAllLines("input.txt");
            int checkDatabase = 0;

            try
            {
                connString = chooseDatabase[0];
                passwordString = Choice.decrypt(inputPass[0], "weather");

                connString = connString + passwordString + ";";
                labelDate.Text = "To days date: " + DateTime.Now.ToString("dd.MM.yyyy");
                startDate = DateTime.Now;
                endDate = DateTime.Now;
                endDate = endDate.AddDays(1);
                newStartDate = startDate.ToString("yyyy-MM-dd");
                newEndDate = endDate.ToString("yyyy-MM-dd");
                trackBarSize.Value = 18;

                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                Choice.checkString = "select delay from settings where id =1";
                MySqlCommand command = new MySqlCommand(Choice.checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    delayValueToolStripComboBox.Text = reader.GetInt64("delay").ToString();
                }
                conn.Close();
                labelShowDelay.Text = "Delay value is set to " + delayValueToolStripComboBox.Text + " minutes.";
            }
            catch
            {
                MessageBox.Show("Database configuration fail! Check database settings!");
            }
        }
        private void technicalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTechnicalInfo showTech = new FormTechnicalInfo();
            showTech.Show();
        }

        private void softwareInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSoftwareInfo showSoftware = new FormSoftwareInfo();
            showSoftware.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void checkBoxDay_CheckedChanged(object sender, EventArgs e)
        {
            Choice.localData = false;

            counterItems = 0;
            countItems = -1;
            currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                if (checkBoxDay.Checked == true)
                {
                    dateTimePickerEndDate.Enabled = false;
                    dateTimePickerStartDate.Enabled = false;
                    buttonSearch.Enabled = false;
                    comboBoxYear.Enabled = false;
                    comboBoxMonth.Enabled = false;
                    comboBoxDay.Enabled = false;

                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    Choice.checkString = "select count(*) as 'numbers' from weatherdata where datecreated like '" + currentDate + "%';";
                    MySqlCommand command = new MySqlCommand(Choice.checkString, conn);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        checkNumbers = reader.GetInt32("numbers");
                    }

                    if (checkNumbers > 0)
                    {
                        listViewShowData.Items.Clear();
                        MessageBox.Show("Cleared " + checkNumbers);
                    }

                    conn.Close();
                    conn.Open();
                    Choice.checkString = "select outtemp, outhum, pressure, datecreated from weatherdata where datecreated like '" + currentDate + "%';";
                    MySqlCommand command2 = new MySqlCommand(Choice.checkString, conn);
                    MySqlDataReader reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        counterItems++;
                        countItems++;
                        listViewShowData.Items.Add(new ListViewItem(new string[] { reader2.GetDecimal("outtemp").ToString() + " °C", reader2.GetDecimal("outhum").ToString() + " %", reader2.GetDecimal("pressure").ToString() + " hPa", reader2.GetDateTime("datecreated").ToString() }));
                    }
                    if (counterItems == 0)
                    {
                        MessageBox.Show("The search gave no result!");
                    }
                    else
                    {
                        exportToPDFToolStripMenuItem.Enabled = true;
                        graphViewToolStripMenuItem.Enabled = true;
                        deleteSelectedRowsToolStripMenuItem.Enabled = true;
                        clearDataToolStripMenuItem.Enabled = true;
                        saveToolStripMenuItem.Enabled = true;
                        printToolStripMenuItem.Enabled = true;
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                        labelStatus.Text = "Data from server database.";
                        Choice.firstItem = listViewShowData.Items[0].SubItems[3].Text;
                        Choice.lastItem = listViewShowData.Items[countItems].SubItems[3].Text;

                    }
                    conn.Close();
                }
                else
                {
                    dateTimePickerEndDate.Enabled = true;
                    dateTimePickerStartDate.Enabled = true;
                    buttonSearch.Enabled = true;
                    comboBoxYear.Enabled = true;
                    comboBoxMonth.Enabled = true;
                    comboBoxDay.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Database configuration fail! Check database settings!");
            }
        }
        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewShowData.Items.Clear();
            labelStatus.Text = "";
            clearDataToolStripMenuItem.Enabled = false;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            listViewShowData.Font = new Font(listViewShowData.Font.FontFamily, trackBarSize.Value);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice.localData = true;
            string line = "";
            countItems = -1;
            counterItems = 0;
            OpenFileDialog openContent = new OpenFileDialog();

            openContent.Title = "Open Data";
            openContent.Filter = "Weather File (.whf) | *.whf";

            try
            {
                listViewShowData.Items.Clear();
                if (openContent.ShowDialog() == DialogResult.OK)
                {
                    StreamReader fileName = new StreamReader(openContent.FileName.ToString());
                    if (openContent.SafeFileName.Contains(".whf"))
                    {
                        while ((line = fileName.ReadLine()) != null)
                        {
                            counterItems++;
                            countItems++;
                            var itemAdd = new ListViewItem(new[] { line.ToString().Split(';')[0].ToString(), line.ToString().Split(';')[1].ToString(),
                        line.ToString().Split(';')[2].ToString(), line.ToString().Split(';')[3].ToString() });
                            listViewShowData.Items.Add(itemAdd);
                        }
                        fileName.Close();
                        MessageBox.Show("File " + openContent.FileName.ToString() + " is susccessfully imported!");
                        labelStatus.Text = "Data from local wht file (" + openContent.FileName.ToString() + ").";
                        clearDataToolStripMenuItem.Enabled = true;
                        exportToPDFToolStripMenuItem.Enabled = true;
                        graphViewToolStripMenuItem.Enabled = true;

                        Choice.firstItem = listViewShowData.Items[0].SubItems[3].Text;
                        Choice.lastItem = listViewShowData.Items[countItems].SubItems[3].Text;
                        Choice.fileName2 = openContent.FileName.ToString();
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                    }
                    else
                    {
                        MessageBox.Show(("This application supports only whf files"));
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Error message:" + i.Message);
            }

        }

        private void databaseConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigDatabase configDatabase = new FormConfigDatabase();
            configDatabase.ShowDialog();
        }

        private void comboBoxYear_Click(object sender, EventArgs e)
        {
            try
            {
                comboBoxYear.Items.Clear();
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                Choice.checkString = "select year(datecreated) from weatherdata group by year(datecreated) having count(*)>1;";
                MySqlCommand command = new MySqlCommand(Choice.checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    getYear = reader.GetInt64("year(datecreated)");
                    comboBoxYear.Items.Add(getYear);

                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Database configuration fail! Check database settings!");
            }
        }

        private void delayValueToolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            string delayValue;

            if (allowDelay == true)
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                delayValue = "update settings set delay = '" + delayValueToolStripComboBox.Text + "' where id = 1";
                MySqlCommand command = new MySqlCommand(delayValue, conn);
                MySqlDataReader reader = command.ExecuteReader();
                conn.Close();

                conn.Open();
                delayValue = "insert into delaylog(delayvalue) values('" + delayValueToolStripComboBox.Text + "')";
                MySqlCommand command2 = new MySqlCommand(delayValue, conn);
                MySqlDataReader reader2 = command2.ExecuteReader();
                conn.Close();

                conn.Open();
                delayValue = "call delaystatus()";
                MySqlCommand command3 = new MySqlCommand(delayValue, conn);
                command3.ExecuteReader();
                conn.Close();

                labelShowDelay.Text = "Delay value is set to " + delayValueToolStripComboBox.Text + " minutes.";
                try
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C ssh ken@raspberrypi5 sudo systemctl restart rc-local.service";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                catch
                {
                    MessageBox.Show("RaspberryPI device is down!");
                }
            }
            allowDelay = true;
        }

        private void showDelayTimeLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelayTimeLog delayLog = new FormDelayTimeLog();
            delayLog.Show();
        }

        private void deleteSelectedRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete selected rows?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem deleteValue in listViewShowData.Items)
                {
                    if (deleteValue.Selected)
                    {
                        this.listViewShowData.Items.Remove(deleteValue);

                    }
                }
            }
        }

        private void listViewShowData_Click(object sender, EventArgs e)
        {

        }

        private void clearDataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear data?", "Confirm clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteSelectedRowsToolStripMenuItem.Enabled = false;
                clearDataToolStripMenuItem.Enabled = false;
                listViewShowData.Items.Clear();
            }
        }

        private void createDatabaseWeatherstationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changeDatabasePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChangePassword changePassword = new FormChangePassword();
            changePassword.Show();
        }

        private void FormShowData_Activated(object sender, EventArgs e)
        {
            string[] chooseDatabase = File.ReadAllLines("configdb.txt");
            string[] inputPass = File.ReadAllLines("input.txt");
            connString = chooseDatabase[0];
            passwordString = Choice.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
        }
    }
}
