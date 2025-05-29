using Locations;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTemp
{
    public partial class FormChangePassword : Form
    {
        public FormChangePassword()
        {
            InitializeComponent();
        }

        string[] chooseDatabase = File.ReadAllLines("configdb.txt");
        string[] inputPass = File.ReadAllLines("input.txt");
        string oldPassword, newPassword, newPassword2, connString, passwordQuery;

        public string Encrypt(string source, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] data = Encoding.Unicode.GetBytes(source);
                    return Convert.ToBase64String(tripleDESCryptoService.CreateEncryptor().TransformFinalBlock(data, 0, data.Length));
                }
            }
        }

        public static string Decrypt(string encrypt, string key)
        {
            using (TripleDESCryptoServiceProvider tripleDESCryptoService = new TripleDESCryptoServiceProvider())
            {
                using (MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider())
                {
                    byte[] byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                    tripleDESCryptoService.Key = byteHash;
                    tripleDESCryptoService.Mode = CipherMode.ECB;//CBC, CFB
                    byte[] byteBuff = Convert.FromBase64String(encrypt);
                    return Encoding.Unicode.GetString(tripleDESCryptoService.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                }
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            connString = chooseDatabase[0];
            oldPassword = textBoxOldPassword.Text;
            newPassword = textBoxNewPassword.Text;
            newPassword2 = textBoxNewPassword2.Text;
            connString = connString + oldPassword + ";";
           
            try
            {
                MySqlConnection conn = new MySqlConnection(connString);
                conn.Open();
                
                if (newPassword == newPassword2)
                {
                    passwordQuery = "alter user 'ken'@'%' identified by '" + newPassword2 + "'";
                    MySqlCommand command = new MySqlCommand(passwordQuery, conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    conn.Close();

                    newPassword2 = Encrypt(newPassword2, "weather");
                    File.WriteAllText(System.Environment.CurrentDirectory + "\\input.txt", newPassword2);
                    FormShowData.connString = FormShowData.connString + newPassword;
                    MessageBox.Show("New password set!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Password was incorrectly retyped!");
                }
            }
            catch
            {
                MessageBox.Show("Current password was incorrectly typed or database settings were incorrect!");
            }
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked == true)
            {
                textBoxOldPassword.PasswordChar = '\0';
                textBoxNewPassword.PasswordChar = '\0';
                textBoxNewPassword2.PasswordChar = '\0';
            }
            else
            {
                textBoxOldPassword.PasswordChar = '*';
                textBoxNewPassword.PasswordChar = '*';
                textBoxNewPassword2.PasswordChar = '*';
            }
        }

        private void textBoxOldPassword_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxOldPassword.Text == "") || (textBoxNewPassword.Text == "") || (textBoxNewPassword2.Text == ""))
            {
                buttonSave.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = true;
            }
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxOldPassword.Text == "") || (textBoxNewPassword.Text == "") || (textBoxNewPassword2.Text == ""))
            {
                buttonSave.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = true;
            }
        }

        private void textBoxNewPassword2_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxOldPassword.Text == "") || (textBoxNewPassword.Text == "") || (textBoxNewPassword2.Text == ""))
            {
                buttonSave.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = true;
            }
        }

        private void FormChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
