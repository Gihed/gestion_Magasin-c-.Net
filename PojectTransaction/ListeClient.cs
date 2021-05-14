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
    public partial class ListeClients : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");
        public ListeClients()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

        private void ListeClients_Load(object sender, EventArgs e)
        {
            MySqlCommand commandDB = new MySqlCommand("select * from client", databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDB.ExecuteReader();
                
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        dataGridView1.Rows.Add(myReader.GetString(0), myReader.GetString(1), myReader.GetString(2), myReader.GetString(3), myReader.GetString(4), myReader.GetString(5));
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
    }
}
