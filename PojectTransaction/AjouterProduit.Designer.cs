
namespace PojectTransaction
{
    partial class AjouterProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelprenom = new System.Windows.Forms.Label();
            this.MarqueProduit = new System.Windows.Forms.TextBox();
            this.labelnom = new System.Windows.Forms.Label();
            this.nomProduit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prixUnitaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tva = new System.Windows.Forms.TextBox();
            this.Retour = new System.Windows.Forms.Button();
            this.Produit = new System.Windows.Forms.Button();
            this.Titre1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelprenom
            // 
            this.labelprenom.AutoSize = true;
            this.labelprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprenom.Location = new System.Drawing.Point(156, 158);
            this.labelprenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelprenom.Name = "labelprenom";
            this.labelprenom.Size = new System.Drawing.Size(62, 17);
            this.labelprenom.TabIndex = 19;
            this.labelprenom.Text = "Marque";
            this.labelprenom.Click += new System.EventHandler(this.labelprenom_Click);
            // 
            // MarqueProduit
            // 
            this.MarqueProduit.Location = new System.Drawing.Point(232, 152);
            this.MarqueProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MarqueProduit.Multiline = true;
            this.MarqueProduit.Name = "MarqueProduit";
            this.MarqueProduit.Size = new System.Drawing.Size(222, 27);
            this.MarqueProduit.TabIndex = 18;
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnom.Location = new System.Drawing.Point(163, 115);
            this.labelnom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(40, 17);
            this.labelnom.TabIndex = 17;
            this.labelnom.Text = "Nom";
            this.labelnom.Click += new System.EventHandler(this.labelnom_Click);
            // 
            // nomProduit
            // 
            this.nomProduit.Location = new System.Drawing.Point(232, 110);
            this.nomProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomProduit.Multiline = true;
            this.nomProduit.Name = "nomProduit";
            this.nomProduit.Size = new System.Drawing.Size(222, 27);
            this.nomProduit.TabIndex = 16;
            this.nomProduit.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Prix Unitaire";
            // 
            // prixUnitaire
            // 
            this.prixUnitaire.Location = new System.Drawing.Point(233, 194);
            this.prixUnitaire.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prixUnitaire.Multiline = true;
            this.prixUnitaire.Name = "prixUnitaire";
            this.prixUnitaire.Size = new System.Drawing.Size(222, 27);
            this.prixUnitaire.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "TVA";
            // 
            // tva
            // 
            this.tva.Location = new System.Drawing.Point(233, 236);
            this.tva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tva.Multiline = true;
            this.tva.Name = "tva";
            this.tva.Size = new System.Drawing.Size(222, 27);
            this.tva.TabIndex = 49;
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retour.Location = new System.Drawing.Point(362, 278);
            this.Retour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(92, 39);
            this.Retour.TabIndex = 15;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Produit
            // 
            this.Produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Produit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Produit.Location = new System.Drawing.Point(260, 279);
            this.Produit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Produit.Name = "Produit";
            this.Produit.Size = new System.Drawing.Size(92, 39);
            this.Produit.TabIndex = 14;
            this.Produit.Text = "Ajouter";
            this.Produit.UseVisualStyleBackColor = true;
            this.Produit.Click += new System.EventHandler(this.Produit_Click);
            // 
            // Titre1
            // 
            this.Titre1.AutoSize = true;
            this.Titre1.BackColor = System.Drawing.SystemColors.Control;
            this.Titre1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Titre1.Location = new System.Drawing.Point(208, 37);
            this.Titre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(269, 35);
            this.Titre1.TabIndex = 55;
            this.Titre1.Text = "AJOUTER UN PRODUIT";
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prixUnitaire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tva);
            this.Controls.Add(this.labelprenom);
            this.Controls.Add(this.MarqueProduit);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.nomProduit);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Produit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AjouterProduit";
            this.Text = "AjouterProduit";
            this.Load += new System.EventHandler(this.AjouterProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.TextBox MarqueProduit;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.TextBox nomProduit;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Button Produit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prixUnitaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tva;
        private System.Windows.Forms.Label Titre1;
    }
}