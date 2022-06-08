
namespace PharmaTri2
{
    partial class FormDechets
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
            this.txtSearchDechet = new System.Windows.Forms.TextBox();
            this.dataGridViewDechet = new System.Windows.Forms.DataGridView();
            this.Recherche = new System.Windows.Forms.Label();
            this.Laboratoire = new System.Windows.Forms.Button();
            this.Déchets = new System.Windows.Forms.Button();
            this.Evolution = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DechetDateSortie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDechet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchDechet
            // 
            this.txtSearchDechet.Location = new System.Drawing.Point(834, 52);
            this.txtSearchDechet.Name = "txtSearchDechet";
            this.txtSearchDechet.Size = new System.Drawing.Size(244, 22);
            this.txtSearchDechet.TabIndex = 6;
            this.txtSearchDechet.TextChanged += new System.EventHandler(this.txtSearchLaboratoire_TextChanged);
            // 
            // dataGridViewDechet
            // 
            this.dataGridViewDechet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDechet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.DechetDateSortie,
            this.Provenance});
            this.dataGridViewDechet.Location = new System.Drawing.Point(374, 197);
            this.dataGridViewDechet.Name = "dataGridViewDechet";
            this.dataGridViewDechet.RowHeadersWidth = 51;
            this.dataGridViewDechet.RowTemplate.Height = 24;
            this.dataGridViewDechet.Size = new System.Drawing.Size(806, 415);
            this.dataGridViewDechet.TabIndex = 5;
            this.dataGridViewDechet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDechet_CellClick);
            this.dataGridViewDechet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLaboratoire_CellContentClick);
            // 
            // Recherche
            // 
            this.Recherche.AutoSize = true;
            this.Recherche.Location = new System.Drawing.Point(640, 55);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(160, 17);
            this.Recherche.TabIndex = 8;
            this.Recherche.Text = "Tapez votre recherche :";
            this.Recherche.Click += new System.EventHandler(this.label1_Click);
            // 
            // Laboratoire
            // 
            this.Laboratoire.Location = new System.Drawing.Point(12, 12);
            this.Laboratoire.Name = "Laboratoire";
            this.Laboratoire.Size = new System.Drawing.Size(160, 51);
            this.Laboratoire.TabIndex = 9;
            this.Laboratoire.Text = "Laboratoire";
            this.Laboratoire.UseVisualStyleBackColor = true;
            this.Laboratoire.Click += new System.EventHandler(this.Laboratoire_Click);
            // 
            // Déchets
            // 
            this.Déchets.Location = new System.Drawing.Point(12, 69);
            this.Déchets.Name = "Déchets";
            this.Déchets.Size = new System.Drawing.Size(160, 51);
            this.Déchets.TabIndex = 10;
            this.Déchets.Text = "Déchets";
            this.Déchets.UseVisualStyleBackColor = true;
            this.Déchets.Click += new System.EventHandler(this.Déchets_Click);
            // 
            // Evolution
            // 
            this.Evolution.Location = new System.Drawing.Point(12, 126);
            this.Evolution.Name = "Evolution";
            this.Evolution.Size = new System.Drawing.Size(159, 52);
            this.Evolution.TabIndex = 11;
            this.Evolution.Text = "Evolution recyclage";
            this.Evolution.UseVisualStyleBackColor = true;
            this.Evolution.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "LABOId";
            this.Column1.HeaderText = "Identifiant";
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
            // Column4
            // 
            this.Column4.DataPropertyName = "DECHETDateEntree";
            this.Column4.HeaderText = "Date d\'entrée du déchet";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // DechetDateSortie
            // 
            this.DechetDateSortie.DataPropertyName = "DECHETDateSortie";
            this.DechetDateSortie.HeaderText = "Date de sortie du déchet";
            this.DechetDateSortie.MinimumWidth = 6;
            this.DechetDateSortie.Name = "DechetDateSortie";
            this.DechetDateSortie.Width = 125;
            // 
            // Provenance
            // 
            this.Provenance.DataPropertyName = "LABOId";
            this.Provenance.HeaderText = "Provenance";
            this.Provenance.MinimumWidth = 6;
            this.Provenance.Name = "Provenance";
            this.Provenance.Width = 125;
            // 
            // FormDechets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 624);
            this.Controls.Add(this.Evolution);
            this.Controls.Add(this.Déchets);
            this.Controls.Add(this.Laboratoire);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.dataGridViewDechet);
            this.Controls.Add(this.txtSearchDechet);
            this.Name = "FormDechets";
            this.Text = "Dechets";
            this.Shown += new System.EventHandler(this.FormDechets_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDechet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchDechet;
        private System.Windows.Forms.DataGridView dataGridViewDechet;
        private System.Windows.Forms.Label Recherche;
        private System.Windows.Forms.Button Laboratoire;
        private System.Windows.Forms.Button Déchets;
        private System.Windows.Forms.Button Evolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DechetDateSortie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provenance;
    }
}