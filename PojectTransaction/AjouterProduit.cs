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

namespace PojectTransaction
{
    public partial class AjouterProduit : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");

        public AjouterProduit()
        {
            InitializeComponent();
        }

        private void Titre1_Click(object sender, EventArgs e)
        {

        }

        private void labelnom_Click(object sender, EventArgs e)
        {

        }

        private void labelprenom_Click(object sender, EventArgs e)
        {

        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Produit_Click(object sender, EventArgs e)
        {
            if ( 
                Validation.VerificationTexte(nomProduit.Text) && Validation.VerificationTexte(MarqueProduit.Text) 
                && Validation.VerificationFloat(prixUnitaire.Text) && Validation.VerificationFloat(tva.Text) &&
                Validation.VerificationTVA(float.Parse(tva.Text)) )
            {
                MySqlCommand commandDB = new MySqlCommand("insert into Produit (nom, marque, prix_unitaire , tva, quantite) values ( '" + nomProduit.Text + "','" + MarqueProduit.Text +"','" + prixUnitaire.Text + "','" +tva.Text + "','"+ 0 +"')", databaseConnection);
               try 
               {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDB.ExecuteReader();
                    MessageBox.Show("Votre produit a été ajouté avec succès! ");

                }catch (Exception excep)
                {
                    MessageBox.Show("Erreur Vérifier Votre code SQL " + excep.Message);
                }
            }
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Accueil to = new Accueil();
            to.Show();
            this.Close();
        }

        private void AjouterProduit_Load(object sender, EventArgs e)
        {

        }
    }
}
