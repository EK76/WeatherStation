using Locations;
using DocumentFormat.OpenXml.Drawing;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTemp
{
    public partial class FormEditRow : Form
    {
        public FormEditRow()
        {
            InitializeComponent();
        }

        string[] chooseDatabase = File.ReadAllLines(@"configdb.txt");
        string[] inputPass = File.ReadAllLines(@"input.txt");
        string connString, sqlQuery, textTemp, textHum, textPressure, passwordString, newString;
        bool checkSave = false, checkClose = true;
        int checkValue;

        void updateTable()
        {
            try
            {
                connString = chooseDatabase[0];
                passwordString = Choice.decrypt(inputPass[0], "weather");
                connString = connString + passwordString + ";";
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                if (FormModifyTable.tableAll == true)
                {
                    FormShowData.currentTable = false;
                    sqlQuery = "update weatherdata set outtemp = '" + textBoxTemp.Text + "', outhum = '" + textBoxHum.Text + "', pressure = '" + textBoxPressure.Text + "' where id = '" + FormModifyTable.rowIndex + "'";
                }
                else
                {
                    FormShowData.currentTable = true;
                    sqlQuery = "update " + FormModifyTable.showCurrentTable + " set outtemp = '" + textBoxTemp.Text + "', outhum = '" + textBoxHum.Text + "', pressure = '" + textBoxPressure.Text + "' where id = '" + FormModifyTable.rowIndex + "'";
                }
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                conn.Close();
                FormModifyTable.refreshTable = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Last digit must a number!");
                switch (checkValue)
                {
                    case 1:
                        textBoxTemp.Text = textTemp;
                        break;

                    case 2:
                        textBoxHum.Text = textHum;
                        break;

                    case 3:
                        textBoxPressure.Text = textPressure;
                        break;
                }
                checkClose = false;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void textBoxPressure_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = true;
            checkSave = false;
        }

        private void textBoxHum_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = true;
            checkSave = false;
        }

        private void textBoxTemp_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = true;
            checkSave = false;
        }

        private void textBoxHum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 46)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    textBoxHum.Text = textHum;
                    MessageBox.Show("Only number, not letters!");
                }
            }
            checkValue = 2;
        }

        private void textBoxPressure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 46)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    textBoxPressure.Text = textPressure;
                    MessageBox.Show("Only number, not letters!");
                }
            }
            checkValue = 3;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            updateTable();
            checkSave = true;
            Close();
        }

        private void FormEditRow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkSave == false)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save the changes?", "Weather Station", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    updateTable();
                }
            }
            if (checkClose == false)
            {
                e.Cancel = true;
                checkClose = true;
            }
        }

        private void textBoxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 46)
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    textBoxTemp.Text = textTemp;
                    MessageBox.Show("Only number, not letters!");
                }
            }
            checkValue = 1;
        }

        private void FormEditRow_Load(object sender, EventArgs e)
        {
            connString = chooseDatabase[0];
            passwordString = Choice.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            if (FormModifyTable.tableAll == true)
            {
                sqlQuery = "select * from weatherdata where id = '" + FormModifyTable.rowIndex + "'";
            }
            else
            {
                newString = FormShowData.showString;
                newString = newString.Remove(newString.Length - 1);
                sqlQuery =  newString + " where id = '" + FormModifyTable.rowIndex + "'";
                Clipboard.SetText(newString);
                MessageBox.Show(sqlQuery);
            }
            MySqlCommand command = new MySqlCommand(sqlQuery, conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                textBoxTemp.Text = ((Decimal)reader["outtemp"]).ToString();
                textBoxTemp.Text = textBoxTemp.Text.Replace(@",", @".");
                textTemp = textBoxTemp.Text;
                textBoxHum.Text = ((Decimal)reader["outhum"]).ToString();
                textBoxHum.Text = textBoxHum.Text.Replace(@",", @".");
                textHum = textBoxHum.Text;
                textBoxPressure.Text = ((Decimal)reader["pressure"]).ToString();
                textBoxPressure.Text = textBoxPressure.Text.Replace(@",", @".");
                textPressure = textBoxPressure.Text;
            }
            conn.Close();
            checkSave = true;
            buttonOk.Enabled = false;
        }
    }
}
