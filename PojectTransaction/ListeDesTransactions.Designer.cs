
namespace PojectTransaction
{
    partial class ListeDesTransactions
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
            this.dataGridViewListeTr = new System.Windows.Forms.DataGridView();
            this.codetr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeproduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteproduitvendu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retour = new System.Windows.Forms.Button();
            this.Titre1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeTr)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListeTr
            // 
            this.dataGridViewListeTr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListeTr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codetr,
            this.datetr,
            this.codeclient,
            this.codeproduit,
            this.qteproduitvendu});
            this.dataGridViewListeTr.Location = new System.Drawing.Point(-1, 99);
            this.dataGridViewListeTr.Name = "dataGridViewListeTr";
            this.dataGridViewListeTr.RowHeadersWidth = 51;
            this.dataGridViewListeTr.RowTemplate.Height = 24;
            this.dataGridViewListeTr.Size = new System.Drawing.Size(801, 273);
            this.dataGridViewListeTr.TabIndex = 0;
            this.dataGridViewListeTr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // codetr
            // 
            this.codetr.HeaderText = "Code Transaction";
            this.codetr.MinimumWidth = 6;
            this.codetr.Name = "codetr";
            this.codetr.Width = 125;
            // 
            // datetr
            // 
            this.datetr.HeaderText = "Date";
            this.datetr.MinimumWidth = 6;
            this.datetr.Name = "datetr";
            this.datetr.Width = 125;
            // 
            // codeclient
            // 
            this.codeclient.HeaderText = "Code Client";
            this.codeclient.MinimumWidth = 6;
            this.codeclient.Name = "codeclient";
            this.codeclient.Width = 125;
            // 
            // codeproduit
            // 
            this.codeproduit.HeaderText = "Code Produit";
            this.codeproduit.MinimumWidth = 6;
            this.codeproduit.Name = "codeproduit";
            this.codeproduit.Width = 125;
            // 
            // qteproduitvendu
            // 
            this.qteproduitvendu.HeaderText = "Quantite des produits vendu";
            this.qteproduitvendu.MinimumWidth = 6;
            this.qteproduitvendu.Name = "qteproduitvendu";
            this.qteproduitvendu.Width = 125;
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retour.Location = new System.Drawing.Point(674, 378);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(123, 48);
            this.Retour.TabIndex = 6;
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
            this.Titre1.Location = new System.Drawing.Point(247, 29);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(286, 43);
            this.Titre1.TabIndex = 39;
            this.Titre1.Text = "Liste des Transactions";
            // 
            // ListeDesTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.dataGridViewListeTr);
            this.Name = "ListeDesTransactions";
            this.Text = "ListeDesTransactions";
            this.Load += new System.EventHandler(this.ListeDesTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListeTr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListeTr;
        private System.Windows.Forms.DataGridViewTextBoxColumn codetr;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetr;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteproduitvendu;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Label Titre1;
    }
}