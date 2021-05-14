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
    public partial class AjouterQuantiter : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");

        public AjouterQuantiter()
        {
            InitializeComponent();
        }

        private void labelnom_Click(object sender, EventArgs e)
        {

        }

        private void maj_Click(object sender, EventArgs e)
        {
            if (Validation.VerificationCode(codeProduit.Text) && Validation.VerificationQuantite(quantite.Text))
            { String x = "UPDATE Produit SET quantite ="+ int.Parse(quantite.Text) +" where code=" + int.Parse(codeProduit.Text);
                MySqlCommand commandDB = new MySqlCommand(x, databaseConnection);
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDB.ExecuteReader();
                    MessageBox.Show("La quantité a été mise à jour avec succès.");

                }
                catch (Exception excep)
                {
                    MessageBox.Show("Erreurr " + excep.Message);
                }
            }

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Accueil to = new Accueil();
            to.Show();
            this.Close();
        }

        private void AjouterQuantiter_Load(object sender, EventArgs e)
        {

        }
    }
}
