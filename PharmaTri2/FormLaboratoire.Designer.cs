
namespace PharmaTri2
{
    partial class FormLaboratoire
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewLaboratoire = new System.Windows.Forms.DataGridView();
            this.txtSearchLaboratoire = new System.Windows.Forms.TextBox();
            this.btnAjouterLabo = new System.Windows.Forms.Button();
            this.Laboratoire = new System.Windows.Forms.Button();
            this.Déchets = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboratoire)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLaboratoire
            // 
            this.dataGridViewLaboratoire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLaboratoire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridViewLaboratoire.Location = new System.Drawing.Point(173, 193);
            this.dataGridViewLaboratoire.Name = "dataGridViewLaboratoire";
            this.dataGridViewLaboratoire.RowHeadersWidth = 51;
            this.dataGridViewLaboratoire.RowTemplate.Height = 24;
            this.dataGridViewLaboratoire.Size = new System.Drawing.Size(915, 425);
            this.dataGridViewLaboratoire.TabIndex = 1;
            this.dataGridViewLaboratoire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLaboratoire_CellClick);
            // 
            // txtSearchLaboratoire
            // 
            this.txtSearchLaboratoire.Location = new System.Drawing.Point(769, 61);
            this.txtSearchLaboratoire.Name = "txtSearchLaboratoire";
            this.txtSearchLaboratoire.Size = new System.Drawing.Size(300, 22);
            this.txtSearchLaboratoire.TabIndex = 2;
            this.txtSearchLaboratoire.TextChanged += new System.EventHandler(this.txtSearchLaboratoire_TextChanged);
            // 
            // btnAjouterLabo
            // 
            this.btnAjouterLabo.Location = new System.Drawing.Point(599, 136);
            this.btnAjouterLabo.Name = "btnAjouterLabo";
            this.btnAjouterLabo.Size = new System.Drawing.Size(154, 41);
            this.btnAjouterLabo.TabIndex = 3;
            this.btnAjouterLabo.Text = "Ajouter un laboratoire";
            this.btnAjouterLabo.UseVisualStyleBackColor = true;
            this.btnAjouterLabo.Click += new System.EventHandler(this.btnAjouterLabo_Click);
            // 
            // Laboratoire
            // 
            this.Laboratoire.Location = new System.Drawing.Point(12, 12);
            this.Laboratoire.Name = "Laboratoire";
            this.Laboratoire.Size = new System.Drawing.Size(176, 52);
            this.Laboratoire.TabIndex = 4;
            this.Laboratoire.Text = "Laboratoire";
            this.Laboratoire.UseVisualStyleBackColor = true;
            this.Laboratoire.Click += new System.EventHandler(this.Laboratoire_Click);
            // 
            // Déchets
            // 
            this.Déchets.Location = new System.Drawing.Point(12, 70);
            this.Déchets.Name = "Déchets";
            this.Déchets.Size = new System.Drawing.Size(176, 56);
            this.Déchets.TabIndex = 5;
            this.Déchets.Text = "Déchets";
            this.Déchets.UseVisualStyleBackColor = true;
            this.Déchets.Click += new System.EventHandler(this.Déchets_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 55);
            this.button1.TabIndex = 6;
            this.button1.Text = "Evolution recyclage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tapez votre recherche";
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
            this.Column2.DataPropertyName = "LABOLocalisation";
            this.Column2.HeaderText = "Localisation";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LABONom";
            this.Column3.HeaderText = "Nom";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Modification";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Text = "Modifier";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Suppression";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Text = "Supprimer";
            this.Column6.UseColumnTextForButtonValue = true;
            this.Column6.Width = 125;
            // 
            // FormLaboratoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Déchets);
            this.Controls.Add(this.Laboratoire);
            this.Controls.Add(this.btnAjouterLabo);
            this.Controls.Add(this.txtSearchLaboratoire);
            this.Controls.Add(this.dataGridViewLaboratoire);
            this.Name = "FormLaboratoire";
            this.Text = "Les laboratoires";
            this.Shown += new System.EventHandler(this.FormLaboratoire_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLaboratoire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewLaboratoire;
        private System.Windows.Forms.TextBox txtSearchLaboratoire;
        private System.Windows.Forms.Button btnAjouterLabo;
        private System.Windows.Forms.Button Laboratoire;
        private System.Windows.Forms.Button Déchets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}

