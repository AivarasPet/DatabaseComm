using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBaseCommunication
{
    public partial class Form1 : Form
    {

        private const String SERVER = "remotemysql.com";
        private const String DATABASE = "6yB9lb51hG";
        private const String UID = "6yB9lb51hG";
        private const String PASSWORD = "bf0c06IkQX";

        public static MySqlConnection dbConnection;
        List<KurasItem> listas;
        public MenuItem deleteBtn;

        public Form1()
        {
            InitializeComponent();
            InitialiseDB();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if(DateTextBox.Text != "" && FuelTypeTextBox.Text != "" && FuelPriceTextBox.Text != "")
            {
                Insert(FuelTypeTextBox.Text, FuelPriceTextBox.Text, DateTextBox.Text);
                DateTextBox.Text = ""; FuelPriceTextBox.Text = ""; FuelTypeTextBox.Text = "";
            }
        }


        public static void InitialiseDB()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = SERVER;
            sb.UserID = UID;
            sb.Password = PASSWORD;
            sb.Database = DATABASE;

            String connectionString = sb.ToString();
            sb = null;
            dbConnection = new MySqlConnection(connectionString);

        }

        private void LoadAll(String filter="")
        {
            listView1.Clear();
            listView1.GridLines = true;
            listView1.View = View.Details;

            listView1.Columns.Add("Type", 150);
            listView1.Columns.Add("Price", 150);
            listView1.Columns.Add("Date", 150);
            listas = new List<KurasItem>();
            String komanda = "SELECT * FROM Kuras"+filter;
            MySqlCommand cmd = new MySqlCommand(komanda, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                String type = reader["Type"].ToString();
                String price = reader["Price"].ToString();
                String date = reader["Date"].ToString();

                KurasItem kurasItem = new KurasItem();
                kurasItem.KurasSet(type, price, date);
                listas.Add(kurasItem);
            }
            dbConnection.Close();

            foreach (KurasItem k in listas)
            {
                ListViewItem item = new ListViewItem(k.Type);
                item.SubItems.Add(k.Price);
                item.SubItems.Add(k.Date);

                item.Tag = k;

                String a = item.ToString();
                listView1.Items.Add(item);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            String date = (DateTime.Today).ToString("yyyy/MM/dd");
            if (!checkIfExists(date)) // tikrina ar yra esamos dienos data databasee
            {
                doDownloadData();
            }
        }

        async void doDownloadData()
        {
                DownloadAverage average = new DownloadAverage();
                average.AverageDownloaded += this.OnDataDownloaded;
                String a = await average.doIT();
        }

        void OnDataDownloaded(object sender, MyEventArgs args)
        {
            //  MessageBox.Show(args.data); 2, 4 , 6, 8 , 10 yra saibos

            String[] pav = { "Dyzelinas", "Benzinas 95", "Benzinas 98", "Dujos LPG", "Nafta" };
            var splitted = args.data.Split('\n');
            var data = (DateTime.Today).ToString("yyyy/MM/dd");
            for (int x = 0; x < 5; x++)
            {
                Insert(pav[x],splitted[2*x] , data);
            }
            this.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadAll();

        }

        public static void Insert(String type, String price, String date)  {
            String query = string.Format("INSERT INTO Kuras(Type, Price, Date) VALUES ('{0}', '{1}', '{2}')", type, price, date);
            MySqlCommand cmd = new MySqlCommand(query, dbConnection);

            dbConnection.Open();
            cmd.ExecuteNonQuery();
            dbConnection.Close();


        }

        private void ListView1_MouseDown(object sender, MouseEventArgs e)
        {
            bool match = false;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Bounds.Contains(new Point(e.X, e.Y)))
                    {
                        match = true;
                        //break;
                    }
                }
                if (match)
                {

                    Point pt = listView1.PointToScreen(e.Location);
                    contextMenuStrip1.Show(pt);

                }

            }
        }


        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deleteElement("");
            DialogResult dialogResult = MessageBox.Show("Are you sure about deleting this?", "???", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes) {
                var selected = listView1.SelectedIndices[0];
                var item = listView1.SelectedItems[0];
                deleteElement(item.Text, item.SubItems[2].Text);
                LoadAll();
            }
        }

        void deleteElement(String type, String value)
        {
            String query = string.Format("DELETE FROM Kuras WHERE Type like '%{0}%' AND Date like '%{1}%'", type, value);
            MySqlCommand cmd = new MySqlCommand(query, dbConnection);

            dbConnection.Open();
            cmd.ExecuteNonQuery();
            dbConnection.Close();
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                e.Cancel = true;
        }

        private bool checkIfExists(String date)
        {
            String komanda = string.Format("select * from Kuras WHERE Date LIKE '%{0}%'", date);
            MySqlCommand cmd = new MySqlCommand(komanda, dbConnection);
            dbConnection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                dbConnection.Close();
                return true;
            }
            dbConnection.Close();
            return false;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            String date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            String query = string.Format(" WHERE Date like '%{0}%'", date);
            LoadAll(query);
        }

        private void FilterTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                String query = string.Format(" WHERE Type like '%{0}%'", filterTextbox.Text);
                LoadAll(query);
            }
        }

        private void FilterTextbox_MouseClick(object sender, MouseEventArgs e)
        {
            filterTextbox.Text = "";
        }
    }
}
