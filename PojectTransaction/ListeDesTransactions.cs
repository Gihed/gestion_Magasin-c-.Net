using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PojectTransaction
{
    public partial class ListeDesTransactions : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin; convert zero datetime=True");

        public ListeDesTransactions()
        {
            InitializeComponent();
            dataGridViewListeTr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListeTr.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListeTr.MultiSelect = false;

        }

        private void ListeDesTransactions_Load(object sender, EventArgs e)
        {
            MySqlCommand commandDB = new MySqlCommand("select * from transaction", databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDB.ExecuteReader();
                
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        dataGridViewListeTr.Rows.Add(myReader.GetString(0), myReader.GetDateTime(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4));
                    }
                }
            }
            catch (Exception excep)
            {
                MessageBox.Show("Erreurr " + excep.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Accueil to = new Accueil();
            to.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
