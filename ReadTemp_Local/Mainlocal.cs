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
using Locations;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using iTextSharp.text.pdf;
using iTextSharp.text;
using ReadTemp;
using ReadTemp.Properties;
using Font = System.Drawing.Font;


namespace ReadTemp_Local
{
    public partial class FormShowData2 : Form
    {
        public FormShowData2()
        {
            InitializeComponent();
        }

        public static int checkForward, counterItems = 0, countItems = -1;
        public static bool localData = false;
        string line = "", firstItem, lastItem,saveFile;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void graphViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewGraph showGraph = new FormViewGraph();
            showGraph.Show();
        }

        private void FormShowData2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            listViewShowData.Font = new Font(listViewShowData.Font.FontFamily, trackBarSize.Value);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Choice.localData = true;
            countItems = -1;
            counterItems = 0;

            OpenFileDialog openContent = new OpenFileDialog();
            openContent.Title = "Open Data";
            openContent.Filter = "Weather File (.whf) | *.whf";

            try
            {
                listViewShowData.Items.Clear();
                if (openContent.ShowDialog() == DialogResult.OK)
                {
                    StreamReader fileName = new StreamReader(openContent.FileName.ToString());
                    if (openContent.SafeFileName.Contains(".whf"))
                    {
                        while ((line = fileName.ReadLine()) != null)
                        {
                            counterItems++;
                            countItems++;
                            var itemAdd = new ListViewItem(new[] { line.ToString().Split(';')[0].ToString(), line.ToString().Split(';')[1].ToString(),
                            line.ToString().Split(';')[2].ToString(), line.ToString().Split(';')[3].ToString() });
                            listViewShowData.Items.Add(itemAdd);
                        }
                        fileName.Close();
                        MessageBox.Show("File " + openContent.FileName.ToString() + " is susccessfully imported!");
                        graphViewToolStripMenuItem.Enabled = true;

                        Choice.firstItem = listViewShowData.Items[0].SubItems[3].Text;
                        Choice.lastItem = listViewShowData.Items[countItems].SubItems[3].Text;
                        Choice.fileName2 = openContent.FileName.ToString();
                        //saveFile 0
                        labelRows.Text = "Numbers of rows: " + counterItems.ToString();
                    }
                    else
                    {
                        MessageBox.Show(("This application supports only whf files"));
                    }
                }
                if (listViewShowData.Items.Count > 0)
                {
                    clearDataToolStripMenuItem.Enabled = true;
                    printStripMenuItem.Enabled = true;
                    reportToolStripMenuItem.Enabled = true;
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Error message:" + i.Message);
            }
        }

        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear data?", "Confirm clear", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                deleteRowsToolStripMenuItem.Enabled = false;
                clearDataToolStripMenuItem.Enabled = false;
                printStripMenuItem.Enabled = false;
                reportToolStripMenuItem.Enabled = false;
                listViewShowData.Items.Clear();
                labelRows.Text = "Numbers of rows: 0";
            }
        }

        private void deleteRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete selected rows?", "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem deleteValue in listViewShowData.Items)
                {
                    if (deleteValue.Selected)
                    {
                        this.listViewShowData.Items.Remove(deleteValue);

                    }
                }
            }

            labelRows.Text = "Numbers of rows: " + listViewShowData.Items.Count;

            deleteRowsToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = true;

            if (listViewShowData.Items.Count > 1)
            {
                printStripMenuItem.Enabled = true;
                reportToolStripMenuItem.Enabled = true;
            }
            else
            {
                printStripMenuItem.Enabled = false;
                reportToolStripMenuItem.Enabled = false;
            }
        }

        private void listViewShowData_Click(object sender, EventArgs e)
        {
            if (listViewShowData.SelectedItems.Count == 0)
            {
                deleteRowsToolStripMenuItem.Enabled = false;
            }
            else
            {
                deleteRowsToolStripMenuItem.Enabled = true;
            }
        }

        private void printStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewPrinter1.PrintPreview();
        }

        private void aboutWeatherInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(listViewShowData.Columns.Count);
            pdfTable.DefaultCell.Padding = 5;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            SaveFileDialog savePDF = new SaveFileDialog();
            savePDF.Filter = "PDF ´files (*.pdf)|*.pdf";
            savePDF.FileName = "Data_" + DateTime.Now.ToString("dd.MM.yyyy") + ".pdf";

            if (savePDF.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Export was aborted!");
            }
            else
            {
                foreach (ColumnHeader column in listViewShowData.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                    pdfTable.AddCell(cell);

                }

                foreach (ListViewItem itemRow in listViewShowData.Items)
                {
                    for (int i = 0; i < itemRow.SubItems.Count; i++)
                    {
                        pdfTable.AddCell(itemRow.SubItems[i].Text);
                    }
                }
                try
                {
                    using (FileStream stream = new FileStream(savePDF.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
                    MessageBox.Show("Data exported to PDF file" + savePDF.FileName + " was successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem to export data to PDF file! " + ex.Message.ToString());
                }
            }
        }

        private void listViewShowData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                if (Choice.fileName2 != "")
                {
                    using (StreamWriter sw = new StreamWriter(Choice.fileName2))
                    {
                        foreach (ListViewItem item in listViewShowData.Items)
                        {
                            sw.WriteLine("{0}{1}{2}{3}", item.SubItems[0].Text + ";", item.SubItems[1].Text + ";", item.SubItems[2].Text + ";", item.SubItems[3].Text + ";");
                        }
                    }
                }
                MessageBox.Show("File " + Choice.fileName2 + " is susccessfully saved!");
                saveToolStripMenuItem.Enabled = false;
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }
    }
}
