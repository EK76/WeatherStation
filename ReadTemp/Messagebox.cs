using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using ExcelLibrary.BinaryFileFormat;
using Locations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ReadTemp
{
    public partial class FormMessageBox : Form
    {
        public FormMessageBox()
        {
            InitializeComponent();
        }

        public static string textValue;
        public static bool addChoice;

        private void buttonOk_Click(object sender, EventArgs e)
        {
            addChoice = true;
            textValue = textBoxName.Text;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            addChoice = false;
            Close();
        }

        private void FormMessageBox_Load(object sender, EventArgs e)
        {
            labelText.Text = FormShowData.setLabelText;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^\\d";

            if (Regex.IsMatch(textBoxName.Text, pattern))
            {
                buttonOk.Enabled = false;
                MessageBox.Show("false");
            }
            else
            {
                buttonOk.Enabled = true;
                MessageBox.Show("true");
            }

        }
    }
}
