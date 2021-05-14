
namespace PojectTransaction
{
    partial class SupprimerTransaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.codeTr = new System.Windows.Forms.TextBox();
            this.Titre1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retour.Location = new System.Drawing.Point(339, 217);
            this.Retour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(82, 47);
            this.Retour.TabIndex = 38;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // supprimer
            // 
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supprimer.Location = new System.Drawing.Point(223, 217);
            this.supprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(102, 47);
            this.supprimer.TabIndex = 37;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 63;
            this.label1.Text = "Code";
            // 
            // codeTr
            // 
            this.codeTr.Location = new System.Drawing.Point(242, 138);
            this.codeTr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeTr.Multiline = true;
            this.codeTr.Name = "codeTr";
            this.codeTr.Size = new System.Drawing.Size(200, 24);
            this.codeTr.TabIndex = 62;
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
            this.Titre1.Size = new System.Drawing.Size(179, 35);
            this.Titre1.TabIndex = 87;
            this.Titre1.Text = "Supprimer Client";
            // 
            // SupprimerTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeTr);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.supprimer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SupprimerTransaction";
            this.Text = "SupprimerTransaction";
            this.Load += new System.EventHandler(this.SupprimerTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTr;
        private System.Windows.Forms.Label Titre1;
    }
}