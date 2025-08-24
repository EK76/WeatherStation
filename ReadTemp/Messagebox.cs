using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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

            if (Regex.IsMatch(textBoxName.Text, @"^\d"))
            {
                buttonOk.Enabled = false;
                MessageBox.Show("The table name can't begin with number!");
                textBoxName.SelectAll();
            }
            else
            {
                buttonOk.Enabled = true;
            }

        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
