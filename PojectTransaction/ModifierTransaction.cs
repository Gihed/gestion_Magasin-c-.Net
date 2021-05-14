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
  
    public partial class ModifierTransaction : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");

        public ModifierTransaction()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modifier_Click(object sender, EventArgs e)
        {
            if (Validation.VerificationCode(codeTR.Text) && Validation.VerificationCode(codeClientTr.Text) &&
               Validation.VerificationCode(codeProduitTr.Text))
            {

                String x = "UPDATE Transaction SET datetr = '"+dateTimePickerTr.Value.ToString("yyyy-MM-dd HH:mm:ss") +"', codeclient = '" + codeClientTr.Text + "', codeproduit = '" + codeProduitTr.Text +"', qteaVendre = '" + QteVendu.Text + "' where codetr=" + int.Parse(codeTR.Text);


                MySqlCommand commandDB = new MySqlCommand(x, databaseConnection);
                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDB.ExecuteReader();
                    MessageBox.Show("La transaction a été modifié avec succès ! ");
                    databaseConnection.Close();

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

        private void ModifierTransaction_Load(object sender, EventArgs e)
        {

        }
    }
}
