
namespace PojectTransaction
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.approvisionnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableauDeBordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.répartitionDeChiffreDaffaireParClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.répartitionDeChiffreDaffaireParProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListeTransaction = new System.Windows.Forms.Button();
            this.btnListeProduits = new System.Windows.Forms.Button();
            this.btnListeClients = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.tableauDeBordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 70);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.listerToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(68, 66);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // listerToolStripMenuItem
            // 
            this.listerToolStripMenuItem.Name = "listerToolStripMenuItem";
            this.listerToolStripMenuItem.Size = new System.Drawing.Size(173, 28);
            this.listerToolStripMenuItem.Text = "Lister";
            this.listerToolStripMenuItem.Click += new System.EventHandler(this.listerToolStripMenuItem_Click);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem1,
            this.supprimerToolStripMenuItem1,
            this.listerToolStripMenuItem1,
            this.approvisionnerToolStripMenuItem});
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(80, 66);
            this.produitToolStripMenuItem.Text = "Produit";
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(210, 28);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterToolStripMenuItem1_Click);
            // 
            // modifierToolStripMenuItem1
            // 
            this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
            this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(210, 28);
            this.modifierToolStripMenuItem1.Text = "Modifier";
            this.modifierToolStripMenuItem1.Click += new System.EventHandler(this.modifierToolStripMenuItem1_Click);
            // 
            // supprimerToolStripMenuItem1
            // 
            this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
            this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(210, 28);
            this.supprimerToolStripMenuItem1.Text = "Supprimer";
            this.supprimerToolStripMenuItem1.Click += new System.EventHandler(this.supprimerToolStripMenuItem1_Click);
            // 
            // listerToolStripMenuItem1
            // 
            this.listerToolStripMenuItem1.Name = "listerToolStripMenuItem1";
            this.listerToolStripMenuItem1.Size = new System.Drawing.Size(210, 28);
            this.listerToolStripMenuItem1.Text = "Lister";
            this.listerToolStripMenuItem1.Click += new System.EventHandler(this.listerToolStripMenuItem1_Click);
            // 
            // approvisionnerToolStripMenuItem
            // 
            this.approvisionnerToolStripMenuItem.Name = "approvisionnerToolStripMenuItem";
            this.approvisionnerToolStripMenuItem.Size = new System.Drawing.Size(210, 28);
            this.approvisionnerToolStripMenuItem.Text = "Approvisionner";
            this.approvisionnerToolStripMenuItem.Click += new System.EventHandler(this.approvisionnerToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem2,
            this.supprimerToolStripMenuItem2,
            this.modifierToolStripMenuItem2,
            this.listerToolStripMenuItem2});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(111, 66);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(173, 28);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            this.ajouterToolStripMenuItem2.Click += new System.EventHandler(this.ajouterToolStripMenuItem2_Click);
            // 
            // supprimerToolStripMenuItem2
            // 
            this.supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
            this.supprimerToolStripMenuItem2.Size = new System.Drawing.Size(173, 28);
            this.supprimerToolStripMenuItem2.Text = "Supprimer";
            this.supprimerToolStripMenuItem2.Click += new System.EventHandler(this.supprimerToolStripMenuItem2_Click);
            // 
            // modifierToolStripMenuItem2
            // 
            this.modifierToolStripMenuItem2.Name = "modifierToolStripMenuItem2";
            this.modifierToolStripMenuItem2.Size = new System.Drawing.Size(173, 28);
            this.modifierToolStripMenuItem2.Text = "Modifier";
            this.modifierToolStripMenuItem2.Click += new System.EventHandler(this.modifierToolStripMenuItem2_Click);
            // 
            // listerToolStripMenuItem2
            // 
            this.listerToolStripMenuItem2.Name = "listerToolStripMenuItem2";
            this.listerToolStripMenuItem2.Size = new System.Drawing.Size(173, 28);
            this.listerToolStripMenuItem2.Text = "Lister";
            this.listerToolStripMenuItem2.Click += new System.EventHandler(this.listerToolStripMenuItem2_Click);
            // 
            // tableauDeBordToolStripMenuItem
            // 
            this.tableauDeBordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.répartitionDeChiffreDaffaireParClientToolStripMenuItem,
            this.répartitionDeChiffreDaffaireParProduitToolStripMenuItem});
            this.tableauDeBordToolStripMenuItem.Name = "tableauDeBordToolStripMenuItem";
            this.tableauDeBordToolStripMenuItem.Size = new System.Drawing.Size(147, 66);
            this.tableauDeBordToolStripMenuItem.Text = "Tableau de Bord";
            // 
            // répartitionDeChiffreDaffaireParClientToolStripMenuItem
            // 
            this.répartitionDeChiffreDaffaireParClientToolStripMenuItem.Name = "répartitionDeChiffreDaffaireParClientToolStripMenuItem";
            this.répartitionDeChiffreDaffaireParClientToolStripMenuItem.Size = new System.Drawing.Size(416, 28);
            this.répartitionDeChiffreDaffaireParClientToolStripMenuItem.Text = "Répartition de chiffre d\'affaire par client";
            this.répartitionDeChiffreDaffaireParClientToolStripMenuItem.Click += new System.EventHandler(this.répartitionDeChiffreDaffaireParClientToolStripMenuItem_Click);
            // 
            // répartitionDeChiffreDaffaireParProduitToolStripMenuItem
            // 
            this.répartitionDeChiffreDaffaireParProduitToolStripMenuItem.Name = "répartitionDeChiffreDaffaireParProduitToolStripMenuItem";
            this.répartitionDeChiffreDaffaireParProduitToolStripMenuItem.Size = new System.Drawing.Size(416, 28);
            this.répartitionDeChiffreDaffaireParProduitToolStripMenuItem.Text = "Répartition de chiffre d\'affaire par produit";
            this.répartitionDeChiffreDaffaireParProduitToolStripMenuItem.Click += new System.EventHandler(this.répartitionDeChiffreDaffaireParProduitToolStripMenuItem_Click);
            // 
            // btnListeTransaction
            // 
            this.btnListeTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeTransaction.Location = new System.Drawing.Point(180, 310);
            this.btnListeTransaction.Name = "btnListeTransaction";
            this.btnListeTransaction.Size = new System.Drawing.Size(418, 86);
            this.btnListeTransaction.TabIndex = 10;
            this.btnListeTransaction.Text = "Liste des Transations";
            this.btnListeTransaction.UseVisualStyleBackColor = true;
            this.btnListeTransaction.Click += new System.EventHandler(this.btnListeTransaction_Click);
            // 
            // btnListeProduits
            // 
            this.btnListeProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeProduits.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListeProduits.Location = new System.Drawing.Point(180, 204);
            this.btnListeProduits.Name = "btnListeProduits";
            this.btnListeProduits.Size = new System.Drawing.Size(418, 86);
            this.btnListeProduits.TabIndex = 9;
            this.btnListeProduits.Text = "Liste des Produits";
            this.btnListeProduits.UseVisualStyleBackColor = true;
            this.btnListeProduits.Click += new System.EventHandler(this.btnListeProduits_Click);
            // 
            // btnListeClients
            // 
            this.btnListeClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeClients.Location = new System.Drawing.Point(179, 101);
            this.btnListeClients.Name = "btnListeClients";
            this.btnListeClients.Size = new System.Drawing.Size(419, 86);
            this.btnListeClients.TabIndex = 8;
            this.btnListeClients.Text = "Liste des Clients";
            this.btnListeClients.UseVisualStyleBackColor = true;
            this.btnListeClients.Click += new System.EventHandler(this.btnListeClients_Click);
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.btnListeTransaction);
            this.Controls.Add(this.btnListeProduits);
            this.Controls.Add(this.btnListeClients);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.Text = "Gestion De Transactions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem2;
        private System.Windows.Forms.Button btnListeTransaction;
        private System.Windows.Forms.Button btnListeProduits;
        private System.Windows.Forms.Button btnListeClients;
        private System.Windows.Forms.ToolStripMenuItem approvisionnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableauDeBordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem répartitionDeChiffreDaffaireParClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem répartitionDeChiffreDaffaireParProduitToolStripMenuItem;
    }
}

