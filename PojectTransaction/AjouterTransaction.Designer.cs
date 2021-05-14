
namespace PojectTransaction
{
    partial class AjouterTransaction
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
            this.codeClient = new System.Windows.Forms.Label();
            this.codeC = new System.Windows.Forms.TextBox();
            this.labelnom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.quantiteSavon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantiteShampoo = new System.Windows.Forms.TextBox();
            this.quantiteEau = new System.Windows.Forms.TextBox();
            this.quantiteChamia = new System.Windows.Forms.TextBox();
            this.dataGridViewNouvelleTransaction = new System.Windows.Forms.DataGridView();
            this.DGCodeProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGAchatProduit = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Retour = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Titre1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNouvelleTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // codeClient
            // 
            this.codeClient.AutoSize = true;
            this.codeClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeClient.Location = new System.Drawing.Point(328, 105);
            this.codeClient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeClient.Name = "codeClient";
            this.codeClient.Size = new System.Drawing.Size(44, 15);
            this.codeClient.TabIndex = 19;
            this.codeClient.Text = "Client";
            this.codeClient.Click += new System.EventHandler(this.labelprenom_Click);
            // 
            // codeC
            // 
            this.codeC.Location = new System.Drawing.Point(380, 102);
            this.codeC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeC.Multiline = true;
            this.codeC.Name = "codeC";
            this.codeC.Size = new System.Drawing.Size(144, 19);
            this.codeC.TabIndex = 18;
            // 
            // labelnom
            // 
            this.labelnom.AutoSize = true;
            this.labelnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnom.Location = new System.Drawing.Point(106, 105);
            this.labelnom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelnom.Name = "labelnom";
            this.labelnom.Size = new System.Drawing.Size(37, 15);
            this.labelnom.TabIndex = 17;
            this.labelnom.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(153, 102);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Produit";
            // 
            // quantiteSavon
            // 
            this.quantiteSavon.Location = new System.Drawing.Point(368, 191);
            this.quantiteSavon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantiteSavon.Name = "quantiteSavon";
            this.quantiteSavon.Size = new System.Drawing.Size(79, 20);
            this.quantiteSavon.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Quantité";
            // 
            // quantiteShampoo
            // 
            this.quantiteShampoo.Location = new System.Drawing.Point(368, 206);
            this.quantiteShampoo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantiteShampoo.Name = "quantiteShampoo";
            this.quantiteShampoo.Size = new System.Drawing.Size(79, 20);
            this.quantiteShampoo.TabIndex = 33;
            this.quantiteShampoo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quantiteEau
            // 
            this.quantiteEau.Location = new System.Drawing.Point(368, 223);
            this.quantiteEau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantiteEau.Name = "quantiteEau";
            this.quantiteEau.Size = new System.Drawing.Size(79, 20);
            this.quantiteEau.TabIndex = 34;
            // 
            // quantiteChamia
            // 
            this.quantiteChamia.Location = new System.Drawing.Point(368, 240);
            this.quantiteChamia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.quantiteChamia.Name = "quantiteChamia";
            this.quantiteChamia.Size = new System.Drawing.Size(79, 20);
            this.quantiteChamia.TabIndex = 35;
            // 
            // dataGridViewNouvelleTransaction
            // 
            this.dataGridViewNouvelleTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNouvelleTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGCodeProduit,
            this.DGProduit,
            this.DGAchatProduit,
            this.DGQuantite});
            this.dataGridViewNouvelleTransaction.Location = new System.Drawing.Point(94, 150);
            this.dataGridViewNouvelleTransaction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewNouvelleTransaction.Name = "dataGridViewNouvelleTransaction";
            this.dataGridViewNouvelleTransaction.RowHeadersWidth = 51;
            this.dataGridViewNouvelleTransaction.RowTemplate.Height = 24;
            this.dataGridViewNouvelleTransaction.Size = new System.Drawing.Size(446, 122);
            this.dataGridViewNouvelleTransaction.TabIndex = 36;
            this.dataGridViewNouvelleTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // DGCodeProduit
            // 
            this.DGCodeProduit.HeaderText = "Code Produit";
            this.DGCodeProduit.MinimumWidth = 6;
            this.DGCodeProduit.Name = "DGCodeProduit";
            this.DGCodeProduit.Width = 125;
            // 
            // DGProduit
            // 
            this.DGProduit.HeaderText = "Produit";
            this.DGProduit.MinimumWidth = 6;
            this.DGProduit.Name = "DGProduit";
            this.DGProduit.Width = 125;
            // 
            // DGAchatProduit
            // 
            this.DGAchatProduit.HeaderText = "Acheter ?";
            this.DGAchatProduit.MinimumWidth = 6;
            this.DGAchatProduit.Name = "DGAchatProduit";
            this.DGAchatProduit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGAchatProduit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGAchatProduit.Width = 125;
            // 
            // DGQuantite
            // 
            this.DGQuantite.HeaderText = "Quantité";
            this.DGQuantite.MinimumWidth = 6;
            this.DGQuantite.Name = "DGQuantite";
            this.DGQuantite.Width = 125;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Savon Vert",
            "johnson shampoo",
            "Eeau Minérale Melliti",
            "Chamia Pipillon"});
            this.checkedListBox1.Location = new System.Drawing.Point(184, 191);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(152, 64);
            this.checkedListBox1.TabIndex = 31;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retour.Location = new System.Drawing.Point(430, 291);
            this.Retour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(92, 39);
            this.Retour.TabIndex = 15;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ajouter.Location = new System.Drawing.Point(325, 291);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(92, 39);
            this.Ajouter.TabIndex = 14;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Titre1
            // 
            this.Titre1.AutoSize = true;
            this.Titre1.BackColor = System.Drawing.SystemColors.Control;
            this.Titre1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Titre1.Location = new System.Drawing.Point(182, 37);
            this.Titre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(249, 35);
            this.Titre1.TabIndex = 37;
            this.Titre1.Text = "AJOUTER UN CLIENT";
            // 
            // AjouterTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.dataGridViewNouvelleTransaction);
            this.Controls.Add(this.quantiteChamia);
            this.Controls.Add(this.quantiteEau);
            this.Controls.Add(this.quantiteShampoo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantiteSavon);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.codeClient);
            this.Controls.Add(this.codeC);
            this.Controls.Add(this.labelnom);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Ajouter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AjouterTransaction";
            this.Text = "AjouterTransaction";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AjouterTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNouvelleTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label codeClient;
        private System.Windows.Forms.TextBox codeC;
        private System.Windows.Forms.Label labelnom;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantiteSavon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantiteShampoo;
        private System.Windows.Forms.TextBox quantiteEau;
        private System.Windows.Forms.TextBox quantiteChamia;
        private System.Windows.Forms.DataGridView dataGridViewNouvelleTransaction;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGCodeProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGProduit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGAchatProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGQuantite;
        private System.Windows.Forms.Label Titre1;
    }
}