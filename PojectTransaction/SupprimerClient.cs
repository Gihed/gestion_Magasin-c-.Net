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
   
    public partial class SupprimerClient : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");

        public SupprimerClient()
        {
            InitializeComponent();
        }

        private void SupprimerClient_Load(object sender, EventArgs e)
        {
                  
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            Accueil to = new Accueil();
            to.Show();
            this.Close();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if (Validation.VerificationCode(code.Text))
            {
                MySqlCommand commandDB = new MySqlCommand("delete from Client where codec=" + code.Text, databaseConnection);
                try
                {
                    databaseConnection.Open();
                    if (commandDB.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Le client a été supprimer !!! ");
                    }
                    else
                    {
                        MessageBox.Show("Le client n'a pas été supprimer !!! ");
                    }

                }
                catch (Exception excep)
                {
                    MessageBox.Show("Erreurr " + excep.Message);
                }
            }
        }

        private void code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
