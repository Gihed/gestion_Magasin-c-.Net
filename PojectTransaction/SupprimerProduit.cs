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
    public partial class SupprimerProduit : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");

        public SupprimerProduit()
        {
            InitializeComponent();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (Validation.VerificationCode(codeProduit.Text))
            {
                MySqlCommand commandDB = new MySqlCommand("delete from Produit where code=" + codeProduit.Text, databaseConnection);
                try
                {
                    databaseConnection.Open();
                    if (commandDB.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Le produit a été supprimer !!! ");
                    }
                    else
                    {
                        MessageBox.Show("Le produit n'a pas été supprimer !!! ");
                    }

                }
                catch (Exception excep)
                {
                    MessageBox.Show("Erreurr " + excep.Message);
                }
            }
        }

        private void codeProduit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Accueil to = new Accueil();
            to.Show();
            this.Close();
        }

        private void labelnom_Click(object sender, EventArgs e)
        {

        }

        private void Titremodification_Click(object sender, EventArgs e)
        {

        }

        private void SupprimerProduit_Load(object sender, EventArgs e)
        {

        }
    }
}
