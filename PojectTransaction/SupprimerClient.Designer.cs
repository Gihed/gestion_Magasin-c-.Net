
namespace PojectTransaction
{
    partial class SupprimerClient
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
            this.Retour = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.labelnom = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.Titre1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retour.Location = new System.Drawing.Point(432, 265);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(110, 58);
            this.Retour.TabIndex = 28;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // supprimer
            // 
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supprimer.Location = new System.Drawing.Point(277, 266);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(136, 58);
            this.supprimer.TabIndex = 27;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnom.Location = new System.Drawing.Point(248, 175);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(48, 18);
            this.labelnom.TabIndex = 30;
            this.labelnom.Text = "Code";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(322, 170);
            this.code.Multiline = true;
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(265, 28);
            this.code.TabIndex = 29;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // Titre1
            // 
            this.Titre1.AutoSize = true;
            this.Titre1.BackColor = System.Drawing.SystemColors.Control;
            this.Titre1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Titre1.Location = new System.Drawing.Point(302, 55);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(229, 43);
            this.Titre1.TabIndex = 86;
            this.Titre1.Text = "Supprimer Client";
            // 
            // SupprimerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.code);
            this.Name = "SupprimerClient";
            this.Text = "Supprimer Client";
            this.Load += new System.EventHandler(this.SupprimerClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label Titre1;
    }
}