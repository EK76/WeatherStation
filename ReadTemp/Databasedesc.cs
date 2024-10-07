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
    public partial class FormDesc : Form
    {
        public FormDesc()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDesc_Load(object sender, EventArgs e)
        {
            labelText.Text = "Database settings - Where some of the application's settings are stored.\n\nDatabase weatherdata - Store all messuarements from the sensors.\n\nDatabase weathererrorlog - Where the faulty messuarements are stored.";
        }
    }
}
