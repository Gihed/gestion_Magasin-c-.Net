
namespace PojectTransaction
{
    partial class ListeClients
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retour = new System.Windows.Forms.Button();
            this.Titre1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeclient,
            this.nomc,
            this.prenomc,
            this.emailc,
            this.telephonec,
            this.adressec});
            this.dataGridView1.Location = new System.Drawing.Point(-4, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 265);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codeclient
            // 
            this.codeclient.HeaderText = "Code";
            this.codeclient.MinimumWidth = 6;
            this.codeclient.Name = "codeclient";
            this.codeclient.Width = 125;
            // 
            // nomc
            // 
            this.nomc.HeaderText = "Nom";
            this.nomc.MinimumWidth = 6;
            this.nomc.Name = "nomc";
            this.nomc.Width = 125;
            // 
            // prenomc
            // 
            this.prenomc.HeaderText = "Prenom";
            this.prenomc.MinimumWidth = 6;
            this.prenomc.Name = "prenomc";
            this.prenomc.Width = 125;
            // 
            // emailc
            // 
            this.emailc.HeaderText = "Email";
            this.emailc.MinimumWidth = 6;
            this.emailc.Name = "emailc";
            this.emailc.Width = 125;
            // 
            // telephonec
            // 
            this.telephonec.HeaderText = "Téléphone";
            this.telephonec.MinimumWidth = 6;
            this.telephonec.Name = "telephonec";
            this.telephonec.Width = 125;
            // 
            // adressec
            // 
            this.adressec.HeaderText = "Adresse";
            this.adressec.MinimumWidth = 6;
            this.adressec.Name = "adressec";
            this.adressec.Width = 125;
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retour.Location = new System.Drawing.Point(648, 390);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(123, 48);
            this.Retour.TabIndex = 3;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Titre1
            // 
            this.Titre1.AutoSize = true;
            this.Titre1.BackColor = System.Drawing.SystemColors.Control;
            this.Titre1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Titre1.Location = new System.Drawing.Point(311, 30);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(207, 43);
            this.Titre1.TabIndex = 39;
            this.Titre1.Text = "Liste des clients";
            // 
            // ListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListeClients";
            this.Text = "Liste Des Clients";
            this.Load += new System.EventHandler(this.ListeClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomc;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomc;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailc;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonec;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressec;
        private System.Windows.Forms.Label Titre1;
    }
}