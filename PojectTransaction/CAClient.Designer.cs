
namespace PojectTransaction
{
    partial class CAClient
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
            this.prenomClientDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Retour.Location = new System.Drawing.Point(500, 320);
            this.Retour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(92, 39);
            this.Retour.TabIndex = 60;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prenomClientDG,
            this.revenu});
            this.dataGridView1.Location = new System.Drawing.Point(9, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(237, 219);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prenomClientDG
            // 
            this.prenomClientDG.HeaderText = "Prenom Client";
            this.prenomClientDG.MinimumWidth = 6;
            this.prenomClientDG.Name = "prenomClientDG";
            this.prenomClientDG.Width = 125;
            // 
            // revenu
            // 
            this.revenu.DataPropertyName = "codetr";
            this.revenu.HeaderText = "Revenu";
            this.revenu.MinimumWidth = 6;
            this.revenu.Name = "revenu";
            this.revenu.Width = 125;
            // 
            // graphe
            // 
            chartArea1.Name = "ChartArea1";
            this.graphe.ChartAreas.Add(chartArea1);
            this.graphe.Location = new System.Drawing.Point(243, 97);
            this.graphe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.graphe.Name = "graphe";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Name = "revenu";
            this.graphe.Series.Add(series1);
            this.graphe.Size = new System.Drawing.Size(357, 219);
            this.graphe.TabIndex = 64;
            this.graphe.Text = "Repartition par client";
            this.graphe.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Titre1
            // 
            this.Titre1.AutoSize = true;
            this.Titre1.BackColor = System.Drawing.SystemColors.Control;
            this.Titre1.Font = new System.Drawing.Font("Perpetua", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre1.ForeColor = System.Drawing.Color.DarkBlue;
            this.Titre1.Location = new System.Drawing.Point(175, 32);
            this.Titre1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titre1.Name = "Titre1";
            this.Titre1.Size = new System.Drawing.Size(311, 35);
            this.Titre1.TabIndex = 65;
            this.Titre1.Text = "Répartition du chiffre d\'affaire";
            // 
            // CAClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Titre1);
            this.Controls.Add(this.graphe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Retour);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CAClient";
            this.Text = "CAClient";
            this.Load += new System.EventHandler(this.CAClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphe;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomClientDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn revenu;
        private System.Windows.Forms.Label Titre1;
    }
}