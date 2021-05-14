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
    public partial class CAClient : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");
        public CAClient()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CAClient_Load(object sender, EventArgs e)
        {
            MySqlCommand commandDB = new MySqlCommand("select c.prenomc, SUM(p.prix_unitaire*(1+p.tva)*t.qteavendre) AS Total from transaction t inner join produit p on t.codeproduit = p.code inner join client c on c.codec = t.codeclient GROUP BY c.codec", databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDB.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        dataGridView1.Rows.Add(myReader.GetString(0), myReader.GetFloat(1));
                        graphe.Series["revenu"].Points.AddXY(myReader.GetValue(0).ToString(), myReader.GetValue(1).ToString());
                    }
                }
                myReader.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Erreurr " + excep.Message);
            }

        }

        
        private void chart1_Click(object sender, EventArgs e)
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
