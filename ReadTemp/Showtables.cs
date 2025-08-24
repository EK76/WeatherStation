using DocumentFormat.OpenXml.Spreadsheet;
using MySql.Data.MySqlClient;
using Windows.UI.Xaml;

namespace ReadTemp
{
    public partial class FormShowTables : Form
    {
        public FormShowTables()
        {
            InitializeComponent();
        }
        int counterItems, checkTable = 0;
        bool addTable = true;
        public static bool doChange;
        public static string tableName;
        string newTableName, renameTable;
        int selectedIndex;

        string[] excludeTables = { "delaylog", "settings", "weathercurrent", "weatherdata", "weathererrorlog" };
        private void FormShowTables_Load(object sender, EventArgs e)
        {

            buttonSetText.Text = FormShowData.setButtonText;

            if (FormShowData.multiSelect == true)
            {
                listViewShowTables.MultiSelect = true;
            }
            else
            {
                listViewShowTables.MultiSelect = false;
            }

            try
            {
                MySqlConnection conn = new MySqlConnection(FormShowData.connString);
                conn.Open();
                MySqlCommand command = new MySqlCommand("select table_name as 'table', create_time as 'date' from information_schema.tables where table_schema = 'weatherstation' order by create_time;", conn);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    counterItems++;

                    for (int i = 0; i < 5; i++)
                    {

                        if (excludeTables[i] == reader.GetString("table").ToString())
                        {
                            addTable = false;
                        }
                    }

                    if (addTable == true)
                    {
                        listViewShowTables.Items.Add(new ListViewItem(new string[] { reader.GetString("table").ToString(), reader.GetDateTime("date").ToString() }));
                    }
                    addTable = true;
                }
                if (counterItems == 0)
                {
                    MessageBox.Show("The search gave no result!", "Weather Station.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            doChange = false;
            Close();
        }

        private void buttonSetText_Click(object sender, EventArgs e)
        {
            doChange = true;
            Close();
        }

        private void listViewShowTables_Click(object sender, EventArgs e)
        {
            if (listViewShowTables.SelectedIndices.Count <= 0)
            {
                return;
            }
            selectedIndex = listViewShowTables.SelectedIndices[0];
            if (selectedIndex >= 0)
            {
                tableName = listViewShowTables.Items[selectedIndex].Text;
            }

            //  MessageBox.Show(tableName);
        }

        private void listViewShowTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(FormShowData.connString);
                conn.Open();

                //   newTableName = listViewShowTables.

                renameTable = "rename table " + tableName + " to " + newTableName + ";";
                MessageBox.Show(renameTable);
                MySqlCommand command = new MySqlCommand(renameTable, conn);
                MySqlDataReader reader = command.ExecuteReader();
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1050:
                        MessageBox.Show("Table " + newTableName + " exist already!");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }

            }
        }

        private void listViewShowTables_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
          
        }

        private void listViewShowTables_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {



        }

        private void listViewShowTables_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void listViewShowTables_BeforeLabelEdit(object sender, LabelEditEventArgs e)
        {
            newTableName = listViewShowTables.FocusedItem.Text;
            MessageBox.Show(newTableName);
        }
    }
}
