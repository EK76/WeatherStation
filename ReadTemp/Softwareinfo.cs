using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
using System.Windows;
using Windows.UI.Composition;
using MySqlX.XDevAPI;


namespace ReadTemp
{
    public partial class FormSoftwareInfo : Form
    {
        public FormSoftwareInfo()
        {
            InitializeComponent();
        }

        bool code = true, database = true;
        string codeText, databaseText, desc;
        int check2, intervall, intervall2;

        void saveFiles(int check)
        {
            string filename = "";
            SaveFileDialog saveContent = new SaveFileDialog();

            saveContent.Title = "Save Data";
            saveContent.Filter = "Text File (.txt) | *.txt| Word Document (.doc) | *.doc";

            try
            {
                if (saveContent.ShowDialog() == DialogResult.OK)
                {
                    filename = saveContent.FileName.ToString();
                    if (filename != "")
                    {
                        if (check == 0)
                        {
                            richTextBoxCode.SaveFile(filename, RichTextBoxStreamType.PlainText);
                        }
                        else
                        {
                            richTextBoxDatabase.SaveFile(filename, RichTextBoxStreamType.PlainText);
                        }
                        MessageBox.Show("File " + filename + " is susccessfully saved!");
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        void printFiles(int check)
        {

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSoftwareInfo_Load(object sender, EventArgs e)
        {
            buttonCopy.Image = Image.FromFile(@"Pictures\Technical\copy4.png");
            buttonCopy2.Image = Image.FromFile(@"Pictures\Technical\copy4.png");

            if (File.Exists(@"Files\temp.py"))
            {
                System.IO.StreamReader readCode = new System.IO.StreamReader(@"Files\temp.py");
                richTextBoxCode.Text = readCode.ReadToEnd();
                readCode.Close();
            }
            else
            {
                code = false;
            }

            if (File.Exists(@"Files\database.txt"))
            {
                System.IO.StreamReader readDatabase = new System.IO.StreamReader(@"Files\database.txt");
                richTextBoxDatabase.Text = readDatabase.ReadToEnd();
                readDatabase.Close();
            }
            else
            {
                database = false;
            }

            if ((code == false) || (database == false))
            {
                if (code == false)
                {
                    codeText = "temp.py";
                }

                if (database == false)
                {
                    databaseText = "database.txt";
                }

                MessageBox.Show("File(s) does not exist!\n" + codeText + "\n" + databaseText);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void codeSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFiles(0);
        }

        private void databasesSaveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            saveFiles(1);
        }

        private void codePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check2 = 0;
            printDocument1.Print();
        }

        private void linkLabelCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (check2 == 0)
            {
                e.Graphics.DrawString(richTextBoxCode.Text, new Font("Segoe UI", 9, FontStyle.Regular), Brushes.Black, new Point(100, 100));
            }
            else
            {
                e.Graphics.DrawString(richTextBoxDatabase.Text, new Font("Segoe UI", 9, FontStyle.Regular), Brushes.Black, new Point(100, 100));
            }
        }

        private void databasePrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check2 = 1;
            printDocument1.Print();
        }

        private void buttonDesc_Click(object sender, EventArgs e)
        {
            FormDesc description = new FormDesc();
            description.ShowDialog();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBoxDatabase.Text);
            toolTip1.SetToolTip(buttonCopy, "Copied.");
            buttonCopy.Image = Image.FromFile(@"Pictures\Technical\ok.png");
            timerCopy.Start();
            intervall = 0;
        }

        private void buttonCopy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBoxCode.Text);
            toolTip1.SetToolTip(buttonCopy2, "Copied.");
            buttonCopy2.Image = Image.FromFile(@"Pictures\Technical\ok.png");
            timerCopy2.Start();
            intervall2 = 0;
        }

        private void timerCopy_Tick(object sender, EventArgs e)
        {
            if (intervall == 4)
            {
                buttonCopy.Image = Image.FromFile(@"Pictures\Technical\copy4.png");
                timerCopy.Stop();
            }
            intervall++;
        }

        private void timerCopy2_Tick(object sender, EventArgs e)
        {
            if (intervall2 == 4)
            {
                buttonCopy2.Image = Image.FromFile(@"Pictures\Technical\copy4.png");
                timerCopy2.Stop();
            }
            intervall2++;
        }
    }
}
