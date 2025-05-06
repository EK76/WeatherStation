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
            labelText.Text = "Table settings - Where some of the application's settings are stored.\n\nTable weatherdata - Store all messuarements from the sensors.\n\nTable weathererrorlog - Where the faulty messuarements are stored.\n\nTable delaylog - Where the delay time is stored after every change, according it's own .";
        }
    }
}
