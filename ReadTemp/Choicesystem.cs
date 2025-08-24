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
    public partial class FormChoiceSystem : Form
    {
        public static bool choiceSystem;
        public FormChoiceSystem()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
  
            if (radioButtonDatabase.Checked)
            {
                choiceSystem = true;
            }
            else 
            { 
                choiceSystem = false;
            }
            this.Hide();
            var showData = new FormShowData();
            showData.Closed += (s, args) => this.Close();
            showData.Show();
        }
     }
}
