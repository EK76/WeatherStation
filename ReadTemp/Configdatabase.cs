using DocumentFormat.OpenXml.Math;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTemp
{
    public partial class FormConfigDatabase : Form
    {
        public FormConfigDatabase()
        {
            InitializeComponent();
        }

        string[] values;
        string readConfig, saveString, passWordString;

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

        private void FormConfigDatabase_Load(object sender, EventArgs e)
        {

            readConfig = File.ReadAllText(@"configdb.txt");
            passWordString = File.ReadAllText(@"input.txt");
            string[] newlines = { ";" };
            values = readConfig.Split(newlines, StringSplitOptions.None);
            values[0] = values[0].Remove(0, 7);
            textBoxServer.Text = values[0];
            values[2] = values[2].Remove(0, 4);
            textBoxUser.Text = values[2];

            try
            {
                textBoxPassword.Text = Decrypt(passWordString, "weather");
            }
            catch
            {
                textBoxPassword.Text = passWordString;
            }       
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string newPassword;

            saveString = "SERVER=" + textBoxServer.Text + ";DATABASE=weatherstation;UID=" + textBoxUser.Text + ";PASSWORD=";
            newPassword = textBoxPassword.Text;
            textBoxPassword.Text = Encrypt(textBoxPassword.Text, "weather");
            File.WriteAllText(System.Environment.CurrentDirectory + "\\configdb.txt", saveString);
            File.WriteAllText(System.Environment.CurrentDirectory + "\\input.txt", textBoxPassword.Text);
            FormShowData.connString = saveString + newPassword;
            Close();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked == true)
            {
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void textBoxServer_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxServer.Text == "") || (textBoxUser.Text == "") || (textBoxPassword.Text == ""))
            {
                buttonSave.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = true;
            }
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxServer.Text == "") || (textBoxUser.Text == "") || (textBoxPassword.Text == ""))
            {
                buttonSave.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = true;
            } 
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxServer.Text == "") || (textBoxUser.Text == "") || (textBoxPassword.Text == ""))
            {
                buttonSave.Enabled = false;
            }
            else
            {
                buttonSave.Enabled = true;
            }
        }
    }
}
