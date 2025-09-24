using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTemp
{
    public partial class FormRenameTable : Form
    {
        public FormRenameTable()
        {
            InitializeComponent();
        }

        string renameTable, newTableName;
        int newSelectedIndex;
        private void buttonRename_Click(object sender, EventArgs e)
        {
            newTableName = textBoxRename.Text;
            try
            {
                MySqlConnection conn = new MySqlConnection(FormShowData.connString);
                conn.Open();
                newSelectedIndex = FormShowTables.selectedIndex;
                renameTable = "rename table " + FormShowTables.tableName + " to " + newTableName + ";";
                MySqlCommand command = new MySqlCommand(renameTable, conn);
                MySqlDataReader reader = command.ExecuteReader();
                conn.Close();
                FormShowTables.checkTwice = true;
                Close();
               
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1050:
                        MessageBox.Show("Table " + newTableName + " exist already!");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxRename_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void FormRenameTable_Load(object sender, EventArgs e)
        {
            textBoxRename.Text = FormShowTables.tableName;
        }
    }
}
