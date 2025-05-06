using Locations;
using MySql.Data.MySqlClient;
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
    public partial class FormDelayTimeLog : Form
    {
        public FormDelayTimeLog()
        {
            InitializeComponent();
        }

        string[] chooseDatabase = File.ReadAllLines(@"configdb.txt");
        string[] inputPass = File.ReadAllLines(@"input.txt");
        string checkString;
        string connString;
        string passwordString;
        int loc = 20;
        private void FormDelayTimeLog_Load(object sender, EventArgs e)
        {
            connString = chooseDatabase[0];
            int index = 0; 
            passwordString = Choice.decrypt(inputPass[0], "weather");
            connString = connString + passwordString + ";";

        //    Label[] label = new Label[50];
      

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            checkString = "select delayvalue, logdate from delaylog limit 15;";
            MySqlCommand command = new MySqlCommand(checkString, conn);
            MySqlDataReader reader = command.ExecuteReader();
            Label label = new Label();
            label.Location = new System.Drawing.Point(18, loc);
            label.Visible = true;
            label.AutoSize = true;
            label.Font = new Font("Arial",18);
            label.Text = "Delay Time Log.";
            loc += 25;
            this.Controls.Add(label);
            loc = loc + 10;

            while (reader.Read())
            {
               Label label2 = new Label();
               label2.Location = new System.Drawing.Point(18, loc);
               label2.Visible = true;
               label2.AutoSize = true;
               label2 .Font = new Font("Arial", 14);
               label2.Text = "Delay value: " + reader.GetDecimal("delayvalue").ToString() + " minutes  " + reader.GetDateTime("logdate").ToString();
               loc += 25;
               this.Controls.Add(label2);
            }
            conn.Close();
        }
    }
}
