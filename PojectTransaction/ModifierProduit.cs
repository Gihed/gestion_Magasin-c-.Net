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
    public partial class ModifierProduit : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");

        public ModifierProduit()
        {
            InitializeComponent();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Accueil to = new Accueil();
            to.Show();
            this.Close();
        }

        private void modifier_Click(object sender, EventArgs e)
        { 
            if (Validation.VerificationTexte(nomProduit.Text) && Validation.VerificationTexte(marqueProduit.Text)
              && Validation.VerificationFloat(prixUnitaire.Text) && Validation.VerificationFloat(tva.Text) &&
              Validation.VerificationTVA(float.Parse(tva.Text)))
            {

                    String x = "UPDATE Produit SET nom ='" + nomProduit.Text + "', marque = '" + marqueProduit.Text + "', prix_unitaire = '" + prixUnitaire.Text + "', quantite = '" + quantite.Text + "' where code=" + int.Parse(codeProduit.Text);

                    MySqlCommand commandDB = new MySqlCommand(x, databaseConnection);
                    try
                    {
                        databaseConnection.Open();
                        MySqlDataReader myReader = commandDB.ExecuteReader();
                        MessageBox.Show("Le produit a été modifié avec succès ! ");


                    }
                    catch (Exception excep)
                    {
                        MessageBox.Show("Erreurr " + excep.Message);
                    }
                
            }

        }

        private void ModifierProduit_Load(object sender, EventArgs e)
        {

        }
    }
}
