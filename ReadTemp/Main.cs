using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Locations;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using ReadTemp.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Windows.UI.Xaml;
using static System.Windows.Forms.ListViewItem;
using Document = iTextSharp.text.Document;
using Font = System.Drawing.Font;
using PageSize = iTextSharp.text.PageSize;
using SortOrder = System.Windows.Forms.SortOrder;

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
        public static string forwardStartDate, newStartDate, newEndDate, currentDate, firstItem, lastItem, fileName2, connString, showString;
        DateTime onlyTime, checkDay2, convertDate, startDate, endDate;
        int checkWeek, compareWeek = 0, checkMonth, compareMonth = 0, checkYear, compareYear = 0, setNewValue, setDelay2, delayStatus, checkNumbers, setMonth;
        public static int checkForward, counterItems = 0, countItems = -1, localChoice = 1;
        long getYear;
        bool allowDelay = false, createDatabase = true, checkExist = false;
        public static bool localData = false, currentTable = false;
        private static string passWordString;
        public static List<string> listTemp = new List<string>();
        public static List<string> listHum = new List<string>();
        public static List<string> listPressure = new List<string>();
        public static List<string> listDate = new List<string>();
        public static string setLabelText; // Belongs to MessageBox.
        public static string setButtonText; // Belongs to Show Tables.
        public static bool multiSelect; // Belongs to Show Tables.
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
            currentTable = false;
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
                    Choice.checkString = "select id, outtemp, outhum, pressure, datecreated from weatherdata where datecreated between '" + newStartDate + "' and '" + newEndDate + "';";
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
                        modifyCurrentDataToolStripMenuItem.Enabled = true;
                        exportToPDFToolStripMenuItem.Enabled = true;
                        clearDataToolStripMenuItem.Enabled = true;
                        deleteRowsToolStripMenuItem.Enabled = false;
                        saveToolStripMenuItem.Enabled = true;
                        printToolStripMenuItem.Enabled = true;
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                        labelStatus.Text = "Data from server database.";
                        Choice.firstItem = listViewShowData.Items[0].SubItems[3].Text;
                        Choice.lastItem = listViewShowData.Items[countItems].SubItems[3].Text;

                        if (counterItems == 1)
                        {
                            graphViewToolStripMenuItem.Enabled = false;
                        }

                        else
                        {
                            graphViewToolStripMenuItem.Enabled = true;
                        }
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                        labelStatus.Text = "Data from server database.";
                        modifyCurrentDataToolStripMenuItem.Enabled = true;
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
            comboBoxMonth.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            Choice.checkString = "select month(datecreated) as 'month' from weatherdata where year(datecreated) = " + comboBoxYear.Text + " group by month(datecreated) having count(*)>1;";
            MySqlCommand command = new MySqlCommand(Choice.checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                setMonth = reader.GetInt32("month");

                switch (setMonth)
                {
                    case 1:
                        comboBoxMonth.Items.Add("January");
                        setNewValue = 1;
                        break;
                    case 2:
                        comboBoxMonth.Items.Add("February");
                        setNewValue = 2;
                        break;
                    case 3:
                        comboBoxMonth.Items.Add("March");
                        setNewValue = 3;
                        break;
                    case 4:
                        comboBoxMonth.Items.Add("April");
                        setNewValue = 4;
                        break;
                    case 5:
                        comboBoxMonth.Items.Add("May");
                        setNewValue = 5;
                        break;
                    case 6:
                        comboBoxMonth.Items.Add("June");
                        setNewValue = 6;
                        break;
                    case 7:
                        comboBoxMonth.Items.Add("July");
                        setNewValue = 7;
                        break;
                    case 8:
                        comboBoxMonth.Items.Add("August");
                        setNewValue = 8;
                        break;
                    case 9:
                        comboBoxMonth.Items.Add("September");
                        setNewValue = 9;
                        break;
                    case 10:
                        comboBoxMonth.Items.Add("October");
                        setNewValue = 10;
                        break;
                    case 11:
                        comboBoxMonth.Items.Add("November");
                        setNewValue = 11;
                        break;
                    case 12:
                        comboBoxMonth.Items.Add("December");
                        setNewValue = 12;
                        break;
                }
            }
        }

        private void graphViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice.localData = false;
            listTemp.Clear();
            listHum.Clear();
            listPressure.Clear();
            listDate.Clear();

            foreach (ListViewItem item in listViewShowData.Items)
            {
                listTemp.Add(item.SubItems[0].Text);
                listHum.Add(item.SubItems[1].Text);
                listPressure.Add(item.SubItems[2].Text);
                listDate.Add(item.SubItems[3].Text);
            }
            FormViewGraph showGraph = new FormViewGraph();
            showGraph.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPrinter1.PrintPreview();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            int index = 0, index2;

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
            Choice.checkString = "select outtemp, datecreated from weatherdata where month(datecreated) = " + setNewValue + " && year(datecreated) = " + comboBoxYear.Text + ";";
            Clipboard.SetText(Choice.checkString);
            MySqlCommand command = new MySqlCommand(Choice.checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                setDay = reader.GetDateTime("datecreated").ToString("dd-MM-yyyy");
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
            // forwardStartDate = comboBoxDay.Text;
            // checkForward = 2;
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            Choice.checkString = "select id, outtemp, outhum, pressure, datecreated from weatherdata where datecreated like '" + setDay + "%';";
            Clipboard.SetText(Choice.checkString);
            try
            {
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

                if (counterItems == 0)
                {
                    MessageBox.Show("The search was not result!");
                }
                else
                {
                    modifyCurrentDataToolStripMenuItem.Enabled = true;
                    exportToPDFToolStripMenuItem.Enabled = true;
                    clearDataToolStripMenuItem.Enabled = true;
                    deleteRowsToolStripMenuItem.Enabled = false;
                    saveToolStripMenuItem.Enabled = true;
                    printToolStripMenuItem.Enabled = true;
                    Choice.firstItem = listViewShowData.Items[0].SubItems[3].Text;
                    Choice.lastItem = listViewShowData.Items[countItems].SubItems[3].Text;
                    if (counterItems == 1)
                    {
                        graphViewToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        graphViewToolStripMenuItem.Enabled = true;
                    }
                    labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                    labelStatus.Text = "Data from server database.";
                    modifyCurrentDataToolStripMenuItem.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormShowData_Load(object sender, EventArgs e)
        {
            
            if (FormChoiceSystem.choiceSystem == false)
            {
                deleteTableToolStripMenuItem.Visible = false;
                modifyCurrentDataToolStripMenuItem.Visible=false;
                changeTimeToolStripMenuItem.Visible=false;
                modifyToolStripMenuItem.Visible = false;
                databaseConfigToolStripMenuItem.Visible = false;
                changeDatabasePasswordToolStripMenuItem.Visible = false;
                comboBoxYear.Visible = false;
                comboBoxMonth.Visible = false;
                comboBoxDay.Visible = false;
                dateTimePickerStartDate.Visible = false;
                dateTimePickerEndDate.Visible = false;
                buttonSearch.Visible = false;
                checkBoxDay.Visible = false;
                labelShowDelay.Visible = false;
                labelText.Visible = false;
                labelText2.Visible = false;
                labelText4.Visible = false;
                labelStartDate.Visible = false;
                labelEndDate.Visible = false;

                datebaseTableToolStripMenuItem.Enabled=false;
                databaseTableTool2StripMenuItem.Enabled=false;
            }
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
                    }

                    conn.Close();
                    conn.Open();
                    Choice.checkString = "select id, outtemp, outhum, pressure, datecreated from weatherdata where datecreated like '" + currentDate + "%';";
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
                        MessageBox.Show("The search gave no result!", "Weather Station.");
                        checkBoxDay.Checked = false;
                    }
                    else
                    {
                        modifyCurrentDataToolStripMenuItem.Enabled = true;
                        exportToPDFToolStripMenuItem.Enabled = true;
                        clearDataToolStripMenuItem.Enabled = true;
                        saveToolStripMenuItem.Enabled = true;
                        printToolStripMenuItem.Enabled = true;
                        deleteRowsToolStripMenuItem.Enabled = false;
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                        labelStatus.Text = "Data from server database.";
                        Choice.firstItem = listViewShowData.Items[0].SubItems[3].Text;
                        Choice.lastItem = listViewShowData.Items[countItems].SubItems[3].Text;

                        if (counterItems == 1)
                        {
                            graphViewToolStripMenuItem.Enabled = false;
                        }

                        else
                        {
                            graphViewToolStripMenuItem.Enabled = true;
                        }
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                        labelStatus.Text = "Data from server database.";
                        modifyCurrentDataToolStripMenuItem.Enabled = true;

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
                delayValue = "delete from delaylog where id not in (select id from(select id from delaylog order by id desc limit 20)info)";
                MySqlCommand command3 = new MySqlCommand(delayValue, conn);
                MySqlDataReader reader3 = command3.ExecuteReader();
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


        private void listViewShowData_Click(object sender, EventArgs e)
        {
            if (listViewShowData.SelectedItems.Count == 0)
            {
                deleteRowsToolStripMenuItem.Enabled = false;
            }
            else
            {
                deleteRowsToolStripMenuItem.Enabled = true;
            }
        }

        private void clearDataToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear data?", "Weather Station.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clearDataToolStripMenuItem.Enabled = false;
                listViewShowData.Items.Clear();
                labelRows.Text = "";
                labelStatus.Text = "";
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
            if (checkExist == true)
            {

                string[] chooseDatabase = File.ReadAllLines("configdb.txt");
                string[] inputPass = File.ReadAllLines("input.txt");
                connString = chooseDatabase[0];
                passwordString = Choice.decrypt(inputPass[0], "weather");
                connString = connString + passwordString + ";";
            }
            checkExist = true;
        }

        private void modifyCurrentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTable = true;
            FormModifyTable modifyData = new FormModifyTable();
            modifyData.ShowDialog();
        }

        private void deleteRowsToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void listViewShowData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewShowData.Items.Count > 1)
            {
                graphViewToolStripMenuItem.Enabled = true;
            }
            else
            {
                graphViewToolStripMenuItem.Enabled = false;
            } 
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void databaseTableToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void changeTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textFileToolStripMenuItem1_Click(object sender, EventArgs e)
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

                if (openContent.ShowDialog() == DialogResult.OK)
                {
                    listViewShowData.Items.Clear();
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
                        modifyCurrentDataToolStripMenuItem.Enabled = false;
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

        private void datebaseTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setButtonText = "Open Table";
            multiSelect = false;
            FormShowTables showTables = new FormShowTables();
            showTables.ShowDialog();
            if (FormShowTables.doChange == true)
            {
                counterItems = 0;
                countItems = -1;
                try
                {
                    if (checkBoxDay.Checked == true)
                    {
                        checkBoxDay.Checked = false;
                        dateTimePickerEndDate.Enabled = true;
                        dateTimePickerStartDate.Enabled = true;
                        buttonSearch.Enabled = true;
                        comboBoxYear.Enabled = true;
                        comboBoxMonth.Enabled = true;
                        comboBoxDay.Enabled = true;
                    }
                    listViewShowData.Items.Clear();
                    MySqlConnection conn = new MySqlConnection(connString);
                    conn.Open();
                    showString = "select * from " + FormShowTables.tableName + ";";

                    MySqlCommand command = new MySqlCommand(showString, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        counterItems++;
                        countItems++;
                        listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("outtemp").ToString() + " °C", reader.GetDecimal("outhum").ToString() + " %", reader.GetDecimal("pressure").ToString() + " hPa", reader.GetDateTime("datecreated").ToString() }));
                    }
                    if (counterItems == 0)
                    {
                        MessageBox.Show("The search gave no result!", "Weather Station.");
                        checkBoxDay.Checked = false;
                    }
                    else
                    {
                        modifyCurrentDataToolStripMenuItem.Enabled = true;
                        exportToPDFToolStripMenuItem.Enabled = true;
                        clearDataToolStripMenuItem.Enabled = true;
                        saveToolStripMenuItem.Enabled = true;
                        printToolStripMenuItem.Enabled = true;
                        deleteRowsToolStripMenuItem.Enabled = false;
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                        labelStatus.Text = "Data from server database. Table " + FormShowTables.tableName + " is selected.";
                        Choice.firstItem = listViewShowData.Items[0].SubItems[3].Text;
                        Choice.lastItem = listViewShowData.Items[countItems].SubItems[3].Text;

                        if (counterItems == 1)
                        {
                            graphViewToolStripMenuItem.Enabled = false;
                        }

                        else
                        {
                            graphViewToolStripMenuItem.Enabled = true;
                        }
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                        labelStatus.Text = "Data from server database. Table " + FormShowTables.tableName + " is selected.";
                        modifyCurrentDataToolStripMenuItem.Enabled = true;
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void deleteTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setButtonText = "Delete Table";
            multiSelect = false;
            FormShowTables showTables = new FormShowTables();
            showTables.ShowDialog();

            if (FormShowTables.doChange == true)
            {
                MySqlConnection conn = new MySqlConnection(connString);
                if (MessageBox.Show("Are you sure to delete selected " + FormShowTables.tableName + " table?", "Weather Station",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    showString = "drop table " + FormShowTables.tableName + ";";
                    Clipboard.SetText(showString);
                    MySqlCommand command = new MySqlCommand(showString, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Table" + FormShowTables.tableName + " is deleted", "Weather Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void databaseTableTool2StripMenuItem_Click(object sender, EventArgs e)
        {
            FormMessageBox showMessage = new FormMessageBox();
            showMessage.ShowDialog();
            setLabelText = "Write a name for the table.";

            if (FormMessageBox.addChoice == true)
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(FormShowData.connString);
                    conn.Open();
                    MySqlCommand createTable = new MySqlCommand(@"
                  create table " + FormMessageBox.textValue + @"  
                     (id int not null auto_increment,
                     outtemp decimal(3,1), 
                     outhum decimal(4,1),
                     pressure decimal(6,2),
                     datecreated datetime,
                     primary key (id));", conn);
                    createTable.ExecuteNonQuery();
                    conn.Close();



                    MessageBox.Show("Table " + FormMessageBox.textValue + " was created");
                    conn.Close();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 1050:
                            MessageBox.Show("Table " + FormMessageBox.textValue + " exist already!");
                            break;
                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                }
                try
                {

                    MySqlConnection conn = new MySqlConnection(FormShowData.connString);


                    foreach (ListViewItem item in listViewShowData.Items)
                    {
                        conn.Open();
                        var removeChars = new string[] { "°", "C", "%", "h", "P", "A", "a" };
                        DateTime convertDate;
                        foreach (var rc in removeChars)
                        {
                            item.SubItems[0].Text = item.SubItems[0].Text.Replace(rc, string.Empty);
                            item.SubItems[0].Text = item.SubItems[0].Text.Replace(",", ".");
                            item.SubItems[1].Text = item.SubItems[1].Text.Replace(rc, string.Empty);
                            item.SubItems[1].Text = item.SubItems[1].Text.Replace(",", ".");
                            item.SubItems[2].Text = item.SubItems[2].Text.Replace(rc, string.Empty);
                            item.SubItems[2].Text = item.SubItems[2].Text.Replace(",", ".");
                            convertDate = DateTime.Parse(item.SubItems[3].Text.ToString());
                            item.SubItems[3].Text = convertDate.ToString("yyyy-MM-dd hh:mm:ss");
                        }
                        string addmessuarement = "insert into " + FormMessageBox.textValue + "(outtemp,outhum,pressure,datecreated) values('" + item.SubItems[0].Text + "','" + item.SubItems[1].Text + "','" + item.SubItems[2].Text + "','" + item.SubItems[3].Text + "');";
                        MySqlCommand command = new MySqlCommand(addmessuarement, conn);
                        MySqlDataReader reader = command.ExecuteReader();
                        conn.Close();
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Creation of table was aborted!");
            }
        }
    }
}
