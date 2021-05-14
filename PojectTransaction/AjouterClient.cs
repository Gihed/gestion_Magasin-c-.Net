using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PojectTransaction
{
    public partial class AjouterClient : Form
    {
        
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");

        public AjouterClient()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ajouter_Click(object sender, EventArgs e)
        { 
            if (Validation.VerificationTexte(nom.Text) && Validation.VerificationTexte(prenom.Text) && Validation.VerificationEmail(email.Text)
                && Validation.VerificationTelephone(telephone.Text) && Validation.VerificationTexte(adresse.Text))
            {
                MySqlCommand commandDB = new MySqlCommand("insert into Client (nomc, prenomc, emailc, telephonec, adressec) values ( '" + nom.Text + "','" + prenom.Text + "','" + email.Text + "','" + telephone.Text + "','" + adresse.Text + "')", databaseConnection);
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDB.ExecuteReader();
                    MessageBox.Show("Le Client a été ajouté avec succès ! ");

                }
                catch (Exception excep)
                {
                    MessageBox.Show("Erreur Vérifier Votre code SQL " + excep.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Accueil to = new Accueil();
            to.Show();
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
