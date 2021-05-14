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
    public partial class AjouterEmployer : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");

        public AjouterEmployer()
        {
            InitializeComponent();
        }

        private void Titre1_Click(object sender, EventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
           /* if (Validation.VerificationCode(codeEmp.Text) && Validation.VerificationTexte(nomEmp.Text) && Validation.VerificationFonction(fonctionEmp.Text) && Validation.VerificationSalaire(salaireEmp.Text) )
            {
                MySqlCommand commandDB = new MySqlCommand("insert into employe (codeemp, nomemp, fonction, salaire) values ( '" + codeEmp.Text + "','" + nomEmp.Text + "','" + fonctionEmp.Text + "','" + salaireEmp.Text + "')", databaseConnection);
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDB.ExecuteReader();
                    MessageBox.Show("L'employer a été ajouté avec succès. ");

                }
                catch (Exception excep)
                {
                    MessageBox.Show("Erreur Vérifier Votre code SQL " + excep.Message);
                }
            }*/
        }

        private void Retour_Click(object sender, EventArgs e)
        {

        }

        private void AjouterEmployer_Load(object sender, EventArgs e)
        {

        }
    }
}
