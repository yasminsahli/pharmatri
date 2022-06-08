
namespace PharmaTri2
{
    partial class FormEvolution
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
            this.dataGridViewDechet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchEvolution = new System.Windows.Forms.TextBox();
            this.Evolution = new System.Windows.Forms.Button();
            this.Déchets = new System.Windows.Forms.Button();
            this.Laboratoire = new System.Windows.Forms.Button();
            this.Recherche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDechet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDechet
            // 
            this.dataGridViewDechet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDechet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Date_debut,
            this.Column4});
            this.dataGridViewDechet.Location = new System.Drawing.Point(261, 199);
            this.dataGridViewDechet.Name = "dataGridViewDechet";
            this.dataGridViewDechet.RowHeadersWidth = 51;
            this.dataGridViewDechet.RowTemplate.Height = 24;
            this.dataGridViewDechet.Size = new System.Drawing.Size(930, 415);
            this.dataGridViewDechet.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DECHETId";
            this.Column1.HeaderText = "Identifiant déchet";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DECHETLibelle";
            this.Column2.HeaderText = "Libelle";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DECHETComposition";
            this.Column3.HeaderText = "Composition";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Date_debut
            // 
            this.Date_debut.DataPropertyName = "DECHETDateEntree";
            this.Date_debut.HeaderText = "Date début du traitement";
            this.Date_debut.MinimumWidth = 6;
            this.Date_debut.Name = "Date_debut";
            this.Date_debut.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ETATId";
            this.Column4.HeaderText = "Etat";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // txtSearchEvolution
            // 
            this.txtSearchEvolution.Location = new System.Drawing.Point(845, 54);
            this.txtSearchEvolution.Name = "txtSearchEvolution";
            this.txtSearchEvolution.Size = new System.Drawing.Size(244, 22);
            this.txtSearchEvolution.TabIndex = 13;
            // 
            // Evolution
            // 
            this.Evolution.Location = new System.Drawing.Point(23, 128);
            this.Evolution.Name = "Evolution";
            this.Evolution.Size = new System.Drawing.Size(159, 52);
            this.Evolution.TabIndex = 18;
            this.Evolution.Text = "Evolution recyclage";
            this.Evolution.UseVisualStyleBackColor = true;
            this.Evolution.Click += new System.EventHandler(this.Evolution_Click);
            // 
            // Déchets
            // 
            this.Déchets.Location = new System.Drawing.Point(23, 71);
            this.Déchets.Name = "Déchets";
            this.Déchets.Size = new System.Drawing.Size(160, 51);
            this.Déchets.TabIndex = 17;
            this.Déchets.Text = "Déchets";
            this.Déchets.UseVisualStyleBackColor = true;
            this.Déchets.Click += new System.EventHandler(this.Déchets_Click);
            // 
            // Laboratoire
            // 
            this.Laboratoire.Location = new System.Drawing.Point(23, 14);
            this.Laboratoire.Name = "Laboratoire";
            this.Laboratoire.Size = new System.Drawing.Size(160, 51);
            this.Laboratoire.TabIndex = 16;
            this.Laboratoire.Text = "Laboratoire";
            this.Laboratoire.UseVisualStyleBackColor = true;
            this.Laboratoire.Click += new System.EventHandler(this.Laboratoire_Click);
            // 
            // Recherche
            // 
            this.Recherche.AutoSize = true;
            this.Recherche.Location = new System.Drawing.Point(651, 57);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(160, 17);
            this.Recherche.TabIndex = 15;
            this.Recherche.Text = "Tapez votre recherche :";
            // 
            // FormEvolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 639);
            this.Controls.Add(this.dataGridViewDechet);
            this.Controls.Add(this.txtSearchEvolution);
            this.Controls.Add(this.Evolution);
            this.Controls.Add(this.Déchets);
            this.Controls.Add(this.Laboratoire);
            this.Controls.Add(this.Recherche);
            this.Name = "FormEvolution";
            this.Text = "FormEvolution";
            this.Shown += new System.EventHandler(this.FormEvolution_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDechet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDechet;
        private System.Windows.Forms.TextBox txtSearchEvolution;
        private System.Windows.Forms.Button Evolution;
        private System.Windows.Forms.Button Déchets;
        private System.Windows.Forms.Button Laboratoire;
        private System.Windows.Forms.Label Recherche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}