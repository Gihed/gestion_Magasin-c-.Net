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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        //partie client 
        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterClient to = new AjouterClient();
            to.Show();
            this.Hide();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupprimerClient to = new SupprimerClient();
            to.Show();
            this.Hide();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifierClient to = new ModifierClient();
            to.Show();
            this.Hide();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClients to = new ListeClients();
            to.Show();
            this.Hide();
        }
        // fin partie client 

        private void btnListeTransaction_Click(object sender, EventArgs e)
        {
            ListeDesTransactions to = new ListeDesTransactions();
            to.Show();
            this.Hide();
        }
        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnListeClients_Click(object sender, EventArgs e)
        {
            ListeClients to = new ListeClients();
            to.Show();
            this.Hide();
        }

      /*  private void btnAddClt_Click(object sender, EventArgs e)
        {
            AjouterClient to = new AjouterClient();
            to.Show();
            this.Hide();
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            ModifierClient to = new ModifierClient();
            to.Show();
            this.Hide();
        }

        private void btnSupClient_Click(object sender, EventArgs e)
        {
            SupprimerClient to = new SupprimerClient();
            to.Show();
            this.Hide();
        }*/

        //partie produit
        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AjouterProduit to = new AjouterProduit();
            to.Show();
            this.Hide();
        }

        private void modifierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifierProduit to = new ModifierProduit();
            to.Show();
            this.Hide();
        }

        private void supprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SupprimerProduit to = new SupprimerProduit();
            to.Show();
            this.Hide();
        }

        private void listerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListeProduit2 to = new ListeProduit2();
            to.Show();
            this.Hide();
        }

        private void approvisionnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterQuantiter to = new AjouterQuantiter();
            to.Show();
            this.Hide();
        }
        //fin produit

        //Transaction
        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AjouterTransaction to = new AjouterTransaction();
            to.Show();
            this.Hide();
        }

        private void supprimerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SupprimerTransaction to = new SupprimerTransaction();
            to.Show();
            this.Hide();
        }

        private void modifierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ModifierTransaction to = new ModifierTransaction();
            to.Show();
            this.Hide();
        }

        private void listerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListeDesTransactions to = new ListeDesTransactions();
            to.Show();
            this.Hide();
        }
        //fin transaction

      /*  private void btnAddTransaction_Click(object sender, EventArgs e)
        {
           AjouterTransaction to = new AjouterTransaction();
            to.Show();
            this.Hide();
        }

        private void btnModifierTransaction_Click(object sender, EventArgs e)
        {
            ModifierTransaction to = new ModifierTransaction();
            to.Show();
            this.Hide();
        }

        private void btnSupTransaction_Click(object sender, EventArgs e)
        {
            SupprimerTransaction to = new SupprimerTransaction();
            to.Show();
            this.Hide();
        }*/

        private void btnListeProduits_Click(object sender, EventArgs e)
        {
            ListeProduit2 to = new ListeProduit2();
            to.Show();
            this.Hide();
        }

        private void quantitéToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

     

       /* private void button1_Click(object sender, EventArgs e)
        {
            CAClient to = new CAClient();
            to.Show();
            this.Hide();
        }
       */
  

      /*  private void btnAddProduit_Click(object sender, EventArgs e)
        {
            AjouterProduit to = new AjouterProduit();
            to.Show();
            this.Hide();
        }*/

        /*private void btnModifierProduit_Click(object sender, EventArgs e)
        {
            ModifierProduit to = new ModifierProduit();
            to.Show();
            this.Hide();
        }*/

       /* private void btnSupProduit_Click(object sender, EventArgs e)
        {
            SupprimerProduit to = new SupprimerProduit();
            to.Show();
            this.Hide();
        }*/

        //tableau de bord

        private void répartitionDeChiffreDaffaireParClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAClient to = new CAClient();
            to.Show();
            this.Hide();
        }

        private void répartitionDeChiffreDaffaireParProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CAProduit to = new CAProduit();
            to.Show();
            this.Close();
        }

        // fin tableau de bord

     /*   private void CAparProduit_Click(object sender, EventArgs e)
        {
            CAProduit to = new CAProduit();
            to.Show();
            this.Close();
        }*/

    }
    
}
