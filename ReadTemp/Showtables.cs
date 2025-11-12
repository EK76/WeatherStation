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
        public static bool doChange;
        public static bool checkTwice = false;
        public static string tableName;
        public static int selectedItemIndex;
        public static int selectedIndex;

        void createTable()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(FormShowData.connString);
                conn.Open();

                MySqlCommand command = new MySqlCommand("select * from tabledatecreated order by datecreated;", conn);
                MySqlDataReader reader = command.ExecuteReader();
                listViewShowTables.Items.Clear();
                while (reader.Read())
                {
                   counterItems++;
                   listViewShowTables.Items.Add(new ListViewItem(new string[] { reader.GetString("tablename").ToString(), reader.GetDateTime("datecreated").ToString() }));
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

            createTable();
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


        private void listViewShowTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSetText.Enabled =listViewShowTables.SelectedItems.Count > 0;
        }

        private void listViewShowTables_DoubleClick(object sender, EventArgs e)
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
            FormRenameTable showRenameTable = new FormRenameTable();
            showRenameTable.ShowDialog();
        }


        private void FormShowTables_Activated(object sender, EventArgs e)
        {
            if (checkTwice == true)
            {
                createTable();
            }
            checkTwice = false;
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
        }
    }
}
