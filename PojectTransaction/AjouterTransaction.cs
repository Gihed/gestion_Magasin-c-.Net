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
    public partial class AjouterTransaction : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=jihed;password=jihed;database=gestionmagasin");
        public AjouterTransaction()
        {
            InitializeComponent();
                dataGridViewNouvelleTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewNouvelleTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewNouvelleTransaction.MultiSelect = false;  
        }

        private void AjouterTransaction_Load(object sender, EventArgs e)
        {
            MySqlCommand commandDB = new MySqlCommand("select * from Produit", databaseConnection);
            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDB.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        dataGridViewNouvelleTransaction.Rows.Add(myReader.GetString(0), myReader.GetString(1));
                    }
                }
                myReader.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show("Erreurr " + excep.Message);
            }

        }
        private void labelprenom_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Verification_Produit (object sender, EventArgs e)
        {

        }
      /*  private void Total_Click(object sender, EventArgs e)
        {
            if (Validation.VerificationCode(codeC.Text))
            {
                for (int i = 0; i < dataGridViewNouvelleTransaction.Rows.Count; i++)
                {
                    if (dataGridViewNouvelleTransaction.Rows[i].Cells[2].Selected)
                    {
                        float Total = 0;
                        int varproduit = -1;
                        var parsing = dataGridViewNouvelleTransaction.Rows[i].Cells[0].Value;
                        varproduit = int.Parse(parsing.ToString());

                        MySqlCommand comandProduit = new MySqlCommand("select * from produit where code =" + varproduit, databaseConnection);

                        try
                        {
                            MySqlDataReader myReader1 = comandProduit.ExecuteReader();
                            if (myReader1.HasRows)
                            {
                                while (myReader1.Read())
                                {
                                    int quantiteDemande = int.Parse(dataGridViewNouvelleTransaction.Rows[i].Cells[3].Value.ToString());
                                    Total = myReader1.GetFloat(3) * (1 + myReader1.GetFloat(4)) * quantiteDemande;
                                    MessageBox.Show("Le total de votre commande est de : " + Total);
                                }

                            }
                            myReader1.Close();
                        }
                        catch (Exception excep)
                        {
                            MessageBox.Show("Erreur Vérifier Votre code SQL " + excep.Message);
                        }
                    }
                }
            }
           
        } */

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (Validation.VerificationCode(codeC.Text))
            {
                for (int i = 0; i < dataGridViewNouvelleTransaction.Rows.Count; i++)
                {
                    if (dataGridViewNouvelleTransaction.Rows[i].Cells[2].Selected)
                    {
                        int idproduit = -1;
                        var parsing = dataGridViewNouvelleTransaction.Rows[i].Cells[0].Value;
                        idproduit = int.Parse(parsing.ToString());

                        MySqlCommand commandDB = new MySqlCommand("insert into Transaction (datetr, codeclient, codeproduit, qteaVendre) values ( '"
                        + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + codeC.Text + "','" + idproduit + "','" +
                         dataGridViewNouvelleTransaction.Rows[i].Cells[3].Value.ToString() +  "')", databaseConnection);

                        try
                        {
                            MySqlDataReader myReader = commandDB.ExecuteReader();
                            MessageBox.Show("La transactin a été ajoutée avec succès! ");
                          
                        }
                        catch (Exception excep)
                        {
                            MessageBox.Show("Erreur dans la sélection du produit ! " + excep.Message);
                        }


                    }
                }


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
