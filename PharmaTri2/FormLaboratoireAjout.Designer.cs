
namespace PharmaTri2
{
    partial class FormLaboratoireAjout
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
            this.identifiantlabo = new System.Windows.Forms.Label();
            this.txtIDLabo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocalisationLabo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomLabo = new System.Windows.Forms.TextBox();
            this.btnEnregistrerLabo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // identifiantlabo
            // 
            this.identifiantlabo.AutoSize = true;
            this.identifiantlabo.Location = new System.Drawing.Point(409, 39);
            this.identifiantlabo.Name = "identifiantlabo";
            this.identifiantlabo.Size = new System.Drawing.Size(169, 17);
            this.identifiantlabo.TabIndex = 0;
            this.identifiantlabo.Text = "Identifiant du laboratoire :";
            this.identifiantlabo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIDLabo
            // 
            this.txtIDLabo.Location = new System.Drawing.Point(356, 78);
            this.txtIDLabo.Name = "txtIDLabo";
            this.txtIDLabo.Size = new System.Drawing.Size(278, 22);
            this.txtIDLabo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Localisation :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLocalisationLabo
            // 
            this.txtLocalisationLabo.Location = new System.Drawing.Point(356, 170);
            this.txtLocalisationLabo.Name = "txtLocalisationLabo";
            this.txtLocalisationLabo.Size = new System.Drawing.Size(278, 22);
            this.txtLocalisationLabo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom :";
            // 
            // txtNomLabo
            // 
            this.txtNomLabo.Location = new System.Drawing.Point(356, 260);
            this.txtNomLabo.Name = "txtNomLabo";
            this.txtNomLabo.Size = new System.Drawing.Size(278, 22);
            this.txtNomLabo.TabIndex = 1;
            // 
            // btnEnregistrerLabo
            // 
            this.btnEnregistrerLabo.Location = new System.Drawing.Point(356, 317);
            this.btnEnregistrerLabo.Name = "btnEnregistrerLabo";
            this.btnEnregistrerLabo.Size = new System.Drawing.Size(278, 61);
            this.btnEnregistrerLabo.TabIndex = 2;
            this.btnEnregistrerLabo.Text = "Ajouter un laboratoire";
            this.btnEnregistrerLabo.UseVisualStyleBackColor = true;
            this.btnEnregistrerLabo.Click += new System.EventHandler(this.btnEnregistrerLabo_Click);
            // 
            // LaboratoireAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 454);
            this.Controls.Add(this.btnEnregistrerLabo);
            this.Controls.Add(this.txtNomLabo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocalisationLabo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDLabo);
            this.Controls.Add(this.identifiantlabo);
            this.Name = "LaboratoireAjout";
            this.Text = "LaboratoireAjout";
            this.Load += new System.EventHandler(this.LaboratoireAjout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label identifiantlabo;
        private System.Windows.Forms.TextBox txtIDLabo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLocalisationLabo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomLabo;
        private System.Windows.Forms.Button btnEnregistrerLabo;
    }
}