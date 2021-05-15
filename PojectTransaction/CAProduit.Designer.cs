
namespace PojectTransaction
{
    partial class CAProduit
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Retour = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nomproduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graphe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Titre1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphe)).BeginInit();
            this.SuspendLayout();
            // 
            // Retour
            // 
            this.Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Retour.Location = new System.Drawing.Point(500, 321);
            this.Retour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(92, 39);
            this.Retour.TabIndex = 67;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomproduit,
            this.revenu});
            this.dataGridView1.Location = new System.Drawing.Point(9, 99);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(242, 217);
            this.dataGridView1.TabIndex = 72;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nomproduit
            // 
            this.Nomproduit.HeaderText = "Nom produit";
            this.Nomproduit.MinimumWidth = 6;
            this.Nomproduit.Name = "Nomproduit";
            this.Nomproduit.Width = 125;
            // 
            // revenu
            // 
            this.revenu.HeaderText = "Revenu";
            this.revenu.MinimumWidth = 6;
            this.revenu.Name = "revenu";
            this.revenu.Width = 125;
            // 
            // graphe
            // 
            chartArea1.Name = "ChartArea1";
            this.graphe.ChartAreas.Add(chartArea1);
            this.graphe.Location = new System.Drawing.Point(249, 99);
            this.graphe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graphe.Name = "graphe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Name = "revenu";
            series1.YValuesPerPoint = 4;
            this.graphe.Series.Add(series1);
            this.graphe.Size = new System.Drawing.Size(351, 217);
            this.graphe.TabIndex = 73;
            this.graphe.Text = "Repartition par client";
            // 
            // Titre1
            // 
            this.Titre1.AutoSize = true;
            this.Titre1.BackColor = System.Drawing.SystemColors.Control;
            this.Titre1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Titre1.Location = new System.Drawing.Point(110, 32);
            this.Titre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(428, 35);
            this.Titre1.TabIndex = 74;
            this.Titre1.Text = "Répartition du chiffre d\'affaire par produit";
            this.Titre1.Click += new System.EventHandler(this.Titre1_Click);
            // 
            // CAProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.graphe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Retour);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CAProduit";
            this.Text = "CAProduit";
            this.Load += new System.EventHandler(this.CAProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomproduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenu;
        private System.Windows.Forms.Label Titre1;
    }
}