
namespace PojectTransaction
{
    partial class AjouterClient
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
            this.nom = new System.Windows.Forms.TextBox();
            this.labelnom = new System.Windows.Forms.Label();
            this.labelprenom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.labeltelephone = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.Retour = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.adresse = new System.Windows.Forms.TextBox();
            this.labeladresse = new System.Windows.Forms.Label();
            this.Titre1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(305, 111);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(295, 32);
            this.nom.TabIndex = 3;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnom.Location = new System.Drawing.Point(222, 119);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(47, 20);
            this.labelnom.TabIndex = 4;
            this.labelnom.Text = "Nom";
            this.labelnom.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelprenom
            // 
            this.labelprenom.AutoSize = true;
            this.labelprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprenom.Location = new System.Drawing.Point(213, 167);
            this.labelprenom.Name = "labelprenom";
            this.labelprenom.Size = new System.Drawing.Size(73, 20);
            this.labelprenom.TabIndex = 6;
            this.labelprenom.Text = "Prénom";
            this.labelprenom.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(305, 163);
            this.prenom.Multiline = true;
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(295, 32);
            this.prenom.TabIndex = 5;
            this.prenom.TextChanged += new System.EventHandler(this.prenom_TextChanged);
            // 
            // labeltelephone
            // 
            this.labeltelephone.AutoSize = true;
            this.labeltelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelephone.Location = new System.Drawing.Point(187, 265);
            this.labeltelephone.Name = "labeltelephone";
            this.labeltelephone.Size = new System.Drawing.Size(95, 20);
            this.labeltelephone.TabIndex = 10;
            this.labeltelephone.Text = "Téléphone";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(305, 258);
            this.telephone.Multiline = true;
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(295, 32);
            this.telephone.TabIndex = 9;
            this.telephone.TextChanged += new System.EventHandler(this.telephone_TextChanged);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(217, 214);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(56, 20);
            this.labelemail.TabIndex = 8;
            this.labelemail.Text = "Email";
            this.labelemail.Click += new System.EventHandler(this.label2_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(305, 211);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(295, 32);
            this.email.TabIndex = 7;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retour.Location = new System.Drawing.Point(463, 362);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(123, 48);
            this.Retour.TabIndex = 2;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(321, 362);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(123, 48);
            this.Ajouter.TabIndex = 1;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(305, 306);
            this.adresse.Multiline = true;
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(295, 32);
            this.adresse.TabIndex = 11;
            // 
            // labeladresse
            // 
            this.labeladresse.AutoSize = true;
            this.labeladresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladresse.Location = new System.Drawing.Point(203, 310);
            this.labeladresse.Name = "labeladresse";
            this.labeladresse.Size = new System.Drawing.Size(78, 20);
            this.labeladresse.TabIndex = 12;
            this.labeladresse.Text = "Adresse";
            this.labeladresse.Click += new System.EventHandler(this.label3_Click);
            // 
            // Titre1
            // 
            this.Titre1.AutoSize = true;
            this.Titre1.BackColor = System.Drawing.SystemColors.Control;
            this.Titre1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Titre1.Location = new System.Drawing.Point(286, 36);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(314, 43);
            this.Titre1.TabIndex = 13;
            this.Titre1.Text = "AJOUTER UN CLIENT";
            // 
            // AjouterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.labeladresse);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.labeltelephone);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.labelprenom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Ajouter);
            this.Name = "AjouterClient";
            this.Text = "Ajouter Client";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label labeltelephone;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label labeladresse;
        private System.Windows.Forms.Label Titre1;
    }
}