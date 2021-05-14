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
using System.Text.RegularExpressions;

namespace PojectTransaction
{
  

    public partial class ModifierClient : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");
        public ModifierClient()
        {
            InitializeComponent();
        }

        private void Titre1_Click(object sender, EventArgs e)
        {

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Accueil to = new Accueil();
            to.Show();
            this.Close();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (Validation.VerificationCode(code.Text) && Validation.VerificationTexte(nom.Text) &&  Validation.VerificationTexte(prenom.Text) && Validation.VerificationEmail(email.Text)
                
                && Validation.VerificationTelephone(telephone.Text) && Validation.VerificationTexte(adresse.Text))
            {

                String x = "UPDATE Client SET nomc ='" + nom.Text + "', prenomc = '" + prenom.Text + "', emailc = '" + email.Text + "', telephonec = " + int.Parse(telephone.Text) + ", adressec = '" + adresse.Text + "' where codec=" + int.Parse(code.Text);
                MySqlCommand commandDB = new MySqlCommand(x, databaseConnection);

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDB.ExecuteReader();
                    MessageBox.Show("Le Client a été modifié avec succès ! ");


                }
                catch (Exception excep)
                {
                    MessageBox.Show("Erreurr " + excep.Message);
                }
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelemail_Click(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModifierClient_Load(object sender, EventArgs e)
        {

        }
    }
}
  

