using Locations;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Color = System.Drawing.Color;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Font = System.Drawing.Font;

namespace ReadTemp
{
    public partial class FormModifyTable : System.Windows.Forms.Form
    {
        public FormModifyTable()
        {
            InitializeComponent();
        }

        string[] chooseDatabase = File.ReadAllLines(@"configdb.txt");
        string[] inputPass = File.ReadAllLines(@"input.txt");
        public static string checkString, showCurrentTable;
        public static int rowIndex;
        string connString, newStartDate, newEndDate, checkString2, backupFolder, fileName, sqlQuery, passwordString, showTable;
        DateTime startDate, endDate;
        int colorIndex, tableView, countRow, indexRow;
        public static bool refreshTable, tableAll;


        void wholeTable()
        {
            colorIndex = 0;
            countRow = 0;
            tableView = 1;
            listViewShowData.Items.Clear();
            connString = chooseDatabase[0];
            passwordString = Choice.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
            MySqlConnection conn = new MySqlConnection(connString);

            if (FormShowData.currentTable == true)
            {
                tableAll = false;
                buttonSearch.Visible = false;
                radioButtonAll.Visible = false;
                radioButtonIntervall.Visible = false;
                labelDate.Visible = false;
                labelDate2.Visible = false;
                dateTimePickerStartDate.Visible = false;
                dateTimePickerEndDate.Visible = false;
                emptyTableToolStripMenuItem.Visible = false;
                restoreTableToolStripMenuItem1.Visible = false;
                backupTableToolStripMenuItem1.Visible = false;
                conn.Open();
                MySqlCommand command = new MySqlCommand(FormShowData.showString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colorIndex++;
                    countRow++;
                    listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetInt32("id").ToString(), reader.GetMySqlDecimal("outtemp").ToString() + " °C", reader.GetMySqlDecimal("outhum").ToString() + " %", reader.GetMySqlDecimal("pressure").ToString() + " hPa", reader.GetDateTime("datecreated").ToString() }));
                }
                conn.Close();
                labelRows.Text = "Number of rows: " + countRow;
                showTable = FormShowData.showString;
                showTable = showTable.Substring(14);
                showTable = showTable.Remove(showTable.Length - 1);
                showCurrentTable = showTable;
                labelTable.Text = "Table " + showTable + " is selected.";
            }
            else
            {
                tableAll = true;
                buttonSearch.Visible = true;
                radioButtonAll.Visible = true;
                radioButtonIntervall.Visible = true;
                labelDate.Visible = true;
                labelDate2.Visible = true;
                dateTimePickerStartDate.Visible = true;
                dateTimePickerEndDate.Visible = true;
                emptyTableToolStripMenuItem.Visible = true;
                restoreTableToolStripMenuItem1.Visible = true;
                backupTableToolStripMenuItem1.Visible = true;
                conn.Open();
                MySqlCommand command = new MySqlCommand("select id, outtemp, outhum, pressure, datecreated from weatherdata", conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colorIndex++;
                    countRow++;
                    listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetInt32("id").ToString(), reader.GetMySqlDecimal("outtemp").ToString() + " °C", reader.GetMySqlDecimal("outhum").ToString() + " %", reader.GetMySqlDecimal("pressure").ToString() + " hPa", reader.GetDateTime("datecreated").ToString() }));
                }
                conn.Close();
                labelRows.Text = "Number of rows: " + countRow;
                labelTable.Text = "Table weatherdata is selected.";
                if (listViewShowData.Items.Count == 0)
                {
                    emptyTableToolStripMenuItem.Enabled = false;
                    backupTableToolStripMenuItem1.Enabled = false;
                }
                else
                {
                    emptyTableToolStripMenuItem.Enabled = true;
                    backupTableToolStripMenuItem1.Enabled = true;
                }
            }
        }

        private void FormModifyTable_Load(object sender, EventArgs e)
        {
            listViewShowData.Items.Clear();
            wholeTable();
            refreshTable = false;
        }

        private void radioButtonAll_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Enabled = false;
            dateTimePickerEndDate.Enabled = false;
            buttonSearch.Enabled = false;
            wholeTable();
        }

        private void listViewShowData_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewShowData.SelectedItems[0];
            rowIndex = int.Parse(selectedItem.SubItems[0].Text);

            if (listViewShowData.SelectedItems.Count == 1)
            {
                editSelectedRowToolStripMenuItem.Enabled = true;
            }
            else
            {
                editSelectedRowToolStripMenuItem.Enabled = false;
            }
        }

        private void editSelectedRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditRow showEditRow = new FormEditRow();
            showEditRow.Show();
        }

        private void emptyTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connString = chooseDatabase[0];
            passwordString = Choice.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            if (MessageBox.Show("Are you sure to delete the weather table?", "Weather Station",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                sqlQuery = "delete from weatherdata;";
                Clipboard.SetText(sqlQuery);
                MySqlCommand command2 = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader2 = command2.ExecuteReader();
                conn.Close();

                conn.Open();
                sqlQuery = "alter table weatherdata auto_increment = 0;";
                MySqlCommand command3 = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader3 = command2.ExecuteReader();
                conn.Close();
                listViewShowData.Items.Clear();
                Clipboard.SetText(sqlQuery);
                emptyTableToolStripMenuItem.Enabled = false;
                backupTableToolStripMenuItem1.Enabled = false;
            }
        }

        private void FormModifyTable_Enter(object sender, EventArgs e)
        {
            // wholeTable();
        }

        private void FormModifyTable_Activated(object sender, EventArgs e)
        {
            if (refreshTable == true)
            {
                listViewShowData.Items.Clear();
                colorIndex = 0;
                tableView = 1;
                connString = chooseDatabase[0];
                passwordString = Choice.decrypt(inputPass[0], "weather");
                connString = connString + passwordString + ";";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                if (FormShowData.currentTable == false)
                {
                    checkString = "select id, outtemp, outhum, pressure, datecreated from weatherdata";
                }
                else
                {
                    checkString = FormShowData.showString;
                }
                    Clipboard.SetText(checkString);
                MySqlCommand command = new MySqlCommand(checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    colorIndex++;
                    listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetInt32("id").ToString(), reader.GetMySqlDecimal("outtemp").ToString() + " °C", reader.GetMySqlDecimal("outhum").ToString() + " %", reader.GetMySqlDecimal("pressure").ToString() + " hPa", reader.GetDateTime("datecreated").ToString() }));
                }
                /* foreach (ListViewItem item in listViewShowData.Items)
                 {
                     item.BackColor = item.Index % 2 == 0 ? Color.Red : Color.Black;
                 }*/
                conn.Close();
                refreshTable = false;
            }
        }

        private void refreshTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewShowData.Items.Clear();
            wholeTable();
        }

        private void restoreTableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "sql files|*.sql";
            openFileDialog.Title = "Restore Table";

            DialogResult result = openFileDialog.ShowDialog();
            openFileDialog.RestoreDirectory = true;
            connString = chooseDatabase[0];
            passwordString = Choice.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
            if (result == DialogResult.OK)
            {
                fileName = System.IO.Path.GetFullPath(openFileDialog.FileName);

                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ImportFromFile(fileName);
                            conn.Close();
                        }
                    }
                }
                MessageBox.Show("Restore done!");
                listViewShowData.Items.Clear();
                wholeTable();
            }
        }

        private void radioButtonIntervall_Click(object sender, EventArgs e)
        {
            dateTimePickerStartDate.Enabled = true;
            dateTimePickerEndDate.Enabled = true;
            buttonSearch.Enabled = true;
            deleteRowsToolStripMenuItem.Enabled = false;
            listViewShowData.Items.Clear();
        }

        private void listViewShowData_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewShowData.SelectedItems.Count >= 1)
            {
                deleteRowsToolStripMenuItem.Enabled = true;
            }
            else
            {
                deleteRowsToolStripMenuItem.Enabled = false;
                editSelectedRowToolStripMenuItem.Enabled = false;
            }

            if (listViewShowData.Items.Count == 0)
            {
                emptyTableToolStripMenuItem.Enabled = false;
                backupTableToolStripMenuItem1.Enabled = false;
            }
            else
            {
                emptyTableToolStripMenuItem.Enabled = true;
                backupTableToolStripMenuItem1.Enabled = true;
            }
        }

        private void backupTableToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "sql files|*.sql";
            saveFileDialog.Title = "Backup Table";
            saveFileDialog.FileName = "weatherdata";

            DialogResult result = saveFileDialog.ShowDialog();
            saveFileDialog.RestoreDirectory = true;
            if (result == DialogResult.OK)
            {
                backupFolder = saveFileDialog.FileName.Substring(0, saveFileDialog.FileName.LastIndexOf("."));
                connString = chooseDatabase[0];
                passwordString = Choice.decrypt(inputPass[0], "weather");
                connString = connString + passwordString + ";";
                if (tableView == 1)
                {
                    using (MySqlConnection conn = new MySqlConnection(connString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                                cmd.Connection = conn;
                                conn.Open();
                                mb.ExportInfo.ExportTriggers = false;
                                mb.ExportInfo.TablesToBeExportedList = new List<string>
                            {
                                "weatherdata"
                            };
                                if (result == DialogResult.OK)
                                {
                                    mb.ExportToFile(backupFolder + "_" + DateTime.Now.ToString("dd_MM_yyyy HH:d") + ".sql");
                                    MessageBox.Show("Backup done!");
                                }
                            }
                        }
                    }
                }
                else
                {

                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passwordString = Choice.decrypt(inputPass[0], "weather");
            connString = chooseDatabase[0];
            connString = connString + passwordString + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            indexRow = 0;
            if (MessageBox.Show("Are you sure to delete selected values?", "Weather Station",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (FormShowData.currentTable == false)
                {
                    foreach (ListViewItem deleteValue in listViewShowData.Items)
                    {
                        if (deleteValue.Selected)
                        {
                            conn.Open();
                            sqlQuery = "delete from weatherdata where id = " + listViewShowData.Items[indexRow].SubItems[0].Text + ";";
                            MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                            MySqlDataReader reader = command.ExecuteReader();
                            conn.Close();
                            listViewShowData.Items.Remove(deleteValue);
                            indexRow--;

                        }
                        indexRow++;
                    }
                }
                else 
                {
                    foreach (ListViewItem deleteValue in listViewShowData.Items)
                    {
                        if (deleteValue.Selected)
                        {
                            conn.Open();
                            sqlQuery = "delete from " + showTable +" where id = " + listViewShowData.Items[indexRow].SubItems[0].Text + ";";
                            MessageBox.Show(sqlQuery);
                            MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                            MySqlDataReader reader = command.ExecuteReader();
                            conn.Close();
                            listViewShowData.Items.Remove(deleteValue);
                            indexRow--;
                        }
                        indexRow++;
                    }
                }

                    MessageBox.Show("Values are deleted", "Weather Station", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deleteRowsToolStripMenuItem.Enabled = false;
            }
            labelRows.Text = "Number of rows: " + countRow;
            if (listViewShowData.Items.Count == 0)
            {
                emptyTableToolStripMenuItem.Enabled = false;
                backupTableToolStripMenuItem1.Enabled = false;
            }
            else
            {
                emptyTableToolStripMenuItem.Enabled = true;
                backupTableToolStripMenuItem1.Enabled = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DateTime dt;
            dt = Convert.ToDateTime(dateTimePickerEndDate.Value);

            startDate = dateTimePickerStartDate.Value;
            endDate = dateTimePickerEndDate.Value;
            endDate = endDate.AddDays(1);

            newStartDate = startDate.ToString("yyyy-MM-dd");
            newEndDate = endDate.ToString("yyyy-MM-dd");

            if (dateTimePickerEndDate.Value >= dateTimePickerStartDate.Value)
            {
                countRow = 0;
                listViewShowData.Items.Clear();
                deleteRowsToolStripMenuItem.Enabled = true;
                connString = chooseDatabase[0];
                passwordString = Choice.decrypt(inputPass[0], "weather");
                connString = connString + passwordString + ";";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                checkString = "select id, outtemp, outhum, pressure, datecreated from weatherdata where (datecreated between '" + newStartDate + "' and '" + newEndDate + "');";
                MySqlCommand command = new MySqlCommand(checkString, conn);
                MySqlDataReader reader = command.ExecuteReader();
                tableView = 2;
                while (reader.Read())
                {
                    countRow++;
                    listViewShowData.Items.Add(new ListViewItem(new string[] { reader.GetInt32("id").ToString(), reader.GetMySqlDecimal("outtemp").ToString() + " °C", reader.GetMySqlDecimal("outhum").ToString() + " %", reader.GetMySqlDecimal("pressure").ToString() + " hPa", reader.GetDateTime("datecreated").ToString() }));
                }
                conn.Close();
                labelRows.Text = "Number of rows: " + countRow;
            }
            else
            {
                MessageBox.Show("End date must be larger than Start date!");
                deleteRowsToolStripMenuItem.Enabled = false;
            }
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            listViewShowData.Font = new Font(listViewShowData.Font.FontFamily, trackBarSize.Value);
        }
    }
}
