using Google.Protobuf.WellKnownTypes;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Reflection;
using Type = System.Type;
using System.Net.NetworkInformation;
using ListView = System.Windows.Forms.ListView;
using SortOrder = System.Windows.Forms.SortOrder;
using System.Configuration;
using Mysqlx.Crud;
using DocumentFormat.OpenXml.VariantTypes;
using MiniExcelLibs;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Sheets = DocumentFormat.OpenXml.Spreadsheet.Sheets;
using Worksheet = DocumentFormat.OpenXml.Spreadsheet.Worksheet;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;

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
        string[] chooseDatabase = File.ReadAllLines("configdb.txt");
        string timeString, connString, compareDay, checkDay, convertMonth, setValue, folderPdf, setDay, setDelay;
        public static string checkString, forwardStartDate, newStartDate, newEndDate, currentDate;
        DateTime onlyTime, checkDay2, convertDate, startDate, endDate;
        int checkWeek, compareWeek = 0, checkMonth, compareMonth = 0, checkYear, compareYear = 0, setNewValue, setDelay2, delayStatus;
        public static int checkForward;
        bool allowDelay = false;

        private void delayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void delayToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            allowDelay = true;
        }

        private void listViewShowData_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
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
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
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
            int counterItems = 0;

            startDate = dateTimePickerStartDate.Value;
            endDate = dateTimePickerEndDate.Value;
            endDate = endDate.AddDays(1);

            newStartDate = startDate.ToString("yyyy-MM-dd");
            newEndDate = endDate.ToString("yyyy-MM-dd");

            if (endDate >= startDate)
            {


                comboBoxMonth.Text = "";
                checkForward = 1;
                connString = chooseDatabase[0];
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                checkString = "select outtemp, outhum, pressure, datecreated from weatherdata where datecreated between '" + newStartDate + "' and '" + newEndDate + "';";
                MySqlCommand command = new MySqlCommand(checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    counterItems++;
                    if (counterItems == 1)
                    {
                        listViewShowData.Items.Clear();
                    }
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
                    saveToolStripMenuItem.Enabled = true;
                    printToolStripMenuItem.Enabled = true;
                }
                conn.Close();


            }
            else
            {
                MessageBox.Show("End date must be larger than Start date!");
            }
        }

        private void weatherDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo infoData = new FormInfo();
            infoData.Show();
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMonth.Enabled = true;
        }

        Boolean checkValue, allowSave = true, allowSave2 = true;

        private void graphViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewGraph showGraph = new FormViewGraph();
            showGraph.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewPrinter1.PrintPreview();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "";
            SaveFileDialog saveContent = new SaveFileDialog();

            saveContent.Title = "Save Data";
            saveContent.Filter = "Text File (.txt) | *.txt| Word Document (.doc) | *.doc";

            try
            {
                if (saveContent.ShowDialog() == DialogResult.OK)
                {
                    filename = saveContent.FileName.ToString();
                    if (filename != "")
                    {
                        using (StreamWriter sw = new StreamWriter(filename))
                        {
                            sw.WriteLine("{0}{1}{2}{3}", "Outdoor Temperature ", "Outdoor Humidity ", "Pressure ", "Date created ");
                            foreach (ListViewItem item in listViewShowData.Items)
                            {
                                sw.WriteLine("{0}{1}{2}{3}", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);
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

      

        private void listViewShowData_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewShowData.Items.Clear();
            comboBoxMonth.Text = "";
            setDay = comboBoxDay.Text;
            forwardStartDate = comboBoxDay.Text;
            convertDate = DateTime.Parse(setDay.ToString());
            setDay = convertDate.ToString("yyyy-MM-dd");
            connString = chooseDatabase[0];
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            checkString = "select intemp, inhum, outtemp, outhum, pressure, datecreated from weatherdata where datecreated like '" + comboBoxDay.Text + "%' &&;";
            Clipboard.SetText(checkString);
            MySqlCommand command = new MySqlCommand(checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetString("outtemp") + " °C", reader.GetString("intemp") + " °C", reader.GetString("outhum") + " %", reader.GetString("inhum") + " %", reader.GetString("pressure") + " hPa", reader.GetDateTime("datecreated").ToString() }));
            }
            conn.Close();

            exportToPDFToolStripMenuItem.Enabled = true;
            graphViewToolStripMenuItem.Enabled = true;
            clearDataToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            printToolStripMenuItem.Enabled = true;
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
                allowSave = false;
                MessageBox.Show("Export was aborted!");
            }
            else
            {
                allowSave = true;
            }

            if (allowSave == true)
            {
                foreach (ColumnHeader column in listViewShowData.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                    pdfTable.AddCell(cell);

                }

                foreach (ListViewItem itemRow in listViewShowData.Items)
                {
                    int i = 0;
                    for (i = 0; i < itemRow.SubItems.Count; i++)
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

            connString = chooseDatabase[0];
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            checkString = "select outtemp, outhum, pressure, datecreated from weatherdata where month(datecreated) = " + setNewValue + " && year(datecreated) = " + comboBoxYear.Text + ";";
            MySqlCommand command = new MySqlCommand(checkString, conn);
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
            listViewShowData.Items.Clear();
            comboBoxMonth.Text = "";
            setDay = comboBoxDay.Text;
            convertDate = DateTime.Parse(setDay.ToString());
            setDay = convertDate.ToString("yyyy-MM-dd");
            forwardStartDate = comboBoxDay.Text;
            checkForward = 2;
            connString = chooseDatabase[0];
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            checkString = "select outtemp, outhum, pressure, datecreated from weatherdata where datecreated like '" + comboBoxDay.Text + "%';";
            MySqlCommand command = new MySqlCommand(checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("outtemp") + " °C", reader.GetDecimal("outhum") + " %", reader.GetDecimal("pressure") + " hPa", reader.GetDateTime("datecreated").ToString() }));
            }
            conn.Close();

            exportToPDFToolStripMenuItem.Enabled = true;
            graphViewToolStripMenuItem.Enabled = true;
            clearDataToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            printToolStripMenuItem.Enabled = true;
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
            labelDate.Text = "To days date: " + DateTime.Now.ToString("dd.MM.yyyy");
            connString = chooseDatabase[0];

            startDate = DateTime.Now;
            endDate = DateTime.Now;
            endDate = endDate.AddDays(1);
            newStartDate = startDate.ToString("yyyy-MM-dd");
            newEndDate = endDate.ToString("yyyy-MM-dd");
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
            int counterItems = 0;
            listViewShowData.Items.Clear();
            currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            connString = chooseDatabase[0];
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
                checkString = "select outtemp, outhum, pressure, datecreated from weatherdata where datecreated like '" + currentDate + "%';";
                MySqlCommand command = new MySqlCommand(checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    counterItems++;
                    listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetDecimal("outtemp").ToString() + " °C", reader.GetDecimal("outhum").ToString() + " %", reader.GetDecimal("pressure").ToString() + " hPa", reader.GetDateTime("datecreated").ToString() }));
                }
                if (counterItems == 0)
                {
                    MessageBox.Show("The search gave no result!");
                }
                else
                {
                    exportToPDFToolStripMenuItem.Enabled = true;
                    graphViewToolStripMenuItem.Enabled = true;
                    clearDataToolStripMenuItem.Enabled = true;
                    saveToolStripMenuItem.Enabled = true;
                    printToolStripMenuItem.Enabled = true;
                }

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
        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewShowData.Items.Clear();
        }
    }
}
