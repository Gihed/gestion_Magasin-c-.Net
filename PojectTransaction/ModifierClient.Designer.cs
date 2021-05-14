
namespace PojectTransaction
{
    partial class ModifierClient
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
            this.labeladresse = new System.Windows.Forms.Label();
            this.adresse = new System.Windows.Forms.TextBox();
            this.labeltelephone = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.labelprenom = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.labelnom = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.Retour = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.codeLabel = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.Titre1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeladresse
            // 
            this.labeladresse.AutoSize = true;
            this.labeladresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladresse.Location = new System.Drawing.Point(316, 238);
            this.labeladresse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeladresse.Name = "labeladresse";
            this.labeladresse.Size = new System.Drawing.Size(58, 15);
            this.labeladresse.TabIndex = 25;
            this.labeladresse.Text = "Adresse";
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(314, 262);
            this.adresse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adresse.Multiline = true;
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(200, 24);
            this.adresse.TabIndex = 24;
            // 
            // labeltelephone
            // 
            this.labeltelephone.AutoSize = true;
            this.labeltelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelephone.Location = new System.Drawing.Point(86, 238);
            this.labeltelephone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeltelephone.Name = "labeltelephone";
            this.labeltelephone.Size = new System.Drawing.Size(75, 15);
            this.labeltelephone.TabIndex = 23;
            this.labeltelephone.Text = "Téléphone";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(83, 262);
            this.telephone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telephone.Multiline = true;
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(200, 24);
            this.telephone.TabIndex = 22;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.Location = new System.Drawing.Point(86, 173);
            this.labelemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(44, 15);
            this.labelemail.TabIndex = 21;
            this.labelemail.Text = "Email";
            this.labelemail.Click += new System.EventHandler(this.labelemail_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(85, 201);
            this.email.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 24);
            this.email.TabIndex = 20;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // labelprenom
            // 
            this.labelprenom.AutoSize = true;
            this.labelprenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprenom.Location = new System.Drawing.Point(316, 173);
            this.labelprenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelprenom.Name = "labelprenom";
            this.labelprenom.Size = new System.Drawing.Size(57, 15);
            this.labelprenom.TabIndex = 19;
            this.labelprenom.Text = "Prénom";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(314, 201);
            this.prenom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prenom.Multiline = true;
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(200, 24);
            this.prenom.TabIndex = 18;
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnom.Location = new System.Drawing.Point(316, 106);
            this.labelnom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(37, 15);
            this.labelnom.TabIndex = 17;
            this.labelnom.Text = "Nom";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(314, 135);
            this.nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nom.Multiline = true;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(200, 24);
            this.nom.TabIndex = 16;
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retour.Location = new System.Drawing.Point(428, 311);
            this.Retour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(86, 39);
            this.Retour.TabIndex = 15;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // modifier
            // 
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modifier.Location = new System.Drawing.Point(327, 311);
            this.modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(86, 39);
            this.modifier.TabIndex = 14;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLabel.Location = new System.Drawing.Point(86, 106);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(40, 15);
            this.codeLabel.TabIndex = 27;
            this.codeLabel.Text = "Code";
            this.codeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(84, 135);
            this.code.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(200, 24);
            this.code.TabIndex = 26;
            // 
            // Titre1
            // 
            this.Titre1.AutoSize = true;
            this.Titre1.BackColor = System.Drawing.SystemColors.Control;
            this.Titre1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Titre1.Location = new System.Drawing.Point(226, 45);
            this.Titre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(162, 35);
            this.Titre1.TabIndex = 39;
            this.Titre1.Text = "Modifier Client";
            // 
            // ModifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.code);
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
            this.Controls.Add(this.modifier);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifierClient";
            this.Text = "Modifier Client";
            this.Load += new System.EventHandler(this.ModifierClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeladresse;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.Label labeltelephone;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label Titre1;
    }
}