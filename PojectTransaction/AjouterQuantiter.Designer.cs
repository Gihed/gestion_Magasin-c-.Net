
namespace PojectTransaction
{
    partial class AjouterQuantiter
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
            this.labelnom = new System.Windows.Forms.Label();
            this.codeProduit = new System.Windows.Forms.TextBox();
            this.Retour = new System.Windows.Forms.Button();
            this.maj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quantite = new System.Windows.Forms.TextBox();
            this.Titre1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnom.Location = new System.Drawing.Point(136, 116);
            this.labelnom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(124, 17);
            this.labelnom.TabIndex = 35;
            this.labelnom.Text = "Code du produit";
            this.labelnom.Click += new System.EventHandler(this.labelnom_Click);
            // 
            // codeProduit
            // 
            this.codeProduit.Location = new System.Drawing.Point(256, 112);
            this.codeProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeProduit.Multiline = true;
            this.codeProduit.Name = "codeProduit";
            this.codeProduit.Size = new System.Drawing.Size(222, 27);
            this.codeProduit.TabIndex = 34;
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.Location = new System.Drawing.Point(384, 212);
            this.Retour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(92, 39);
            this.Retour.TabIndex = 33;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // maj
            // 
            this.maj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.maj.Location = new System.Drawing.Point(256, 213);
            this.maj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maj.Name = "maj";
            this.maj.Size = new System.Drawing.Size(113, 39);
            this.maj.TabIndex = 32;
            this.maj.Text = "Mettre à jour";
            this.maj.UseVisualStyleBackColor = true;
            this.maj.Click += new System.EventHandler(this.maj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Quantité";
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(256, 154);
            this.quantite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantite.Multiline = true;
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(222, 27);
            this.quantite.TabIndex = 36;
            // 
            // Titre1
            // 
            this.Titre1.AutoSize = true;
            this.Titre1.BackColor = System.Drawing.SystemColors.Control;
            this.Titre1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Titre1.Location = new System.Drawing.Point(206, 38);
            this.Titre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(243, 35);
            this.Titre1.TabIndex = 38;
            this.Titre1.Text = "AJOUTER QUANTITE";
            // 
            // AjouterQuantiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.codeProduit);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.maj);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AjouterQuantiter";
            this.Text = "AjouterQuantiter";
            this.Load += new System.EventHandler(this.AjouterQuantiter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.TextBox codeProduit;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Button maj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.Label Titre1;
    }
}