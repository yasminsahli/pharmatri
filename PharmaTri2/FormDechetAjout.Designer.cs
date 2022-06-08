
namespace PharmaTri2
{
    partial class FormDechetAjout
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
            this.btnEnregistrerDechet = new System.Windows.Forms.Button();
            this.txtCompositionLabo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLibelleDechet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDDechet = new System.Windows.Forms.TextBox();
            this.identifiantldechet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDateEntreeDechet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateSortieDechet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEnregistrerDechet
            // 
            this.btnEnregistrerDechet.Location = new System.Drawing.Point(277, 376);
            this.btnEnregistrerDechet.Name = "btnEnregistrerDechet";
            this.btnEnregistrerDechet.Size = new System.Drawing.Size(278, 45);
            this.btnEnregistrerDechet.TabIndex = 9;
            this.btnEnregistrerDechet.Text = "Ajouter un déchet";
            this.btnEnregistrerDechet.UseVisualStyleBackColor = true;
            this.btnEnregistrerDechet.Click += new System.EventHandler(this.btnEnregistrerDechet_Click);
            // 
            // txtCompositionLabo
            // 
            this.txtCompositionLabo.Location = new System.Drawing.Point(277, 189);
            this.txtCompositionLabo.Name = "txtCompositionLabo";
            this.txtCompositionLabo.Size = new System.Drawing.Size(278, 22);
            this.txtCompositionLabo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Composition :";
            // 
            // txtLibelleDechet
            // 
            this.txtLibelleDechet.Location = new System.Drawing.Point(277, 121);
            this.txtLibelleDechet.Name = "txtLibelleDechet";
            this.txtLibelleDechet.Size = new System.Drawing.Size(278, 22);
            this.txtLibelleDechet.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libelle : ";
            // 
            // txtIDDechet
            // 
            this.txtIDDechet.Location = new System.Drawing.Point(277, 63);
            this.txtIDDechet.Name = "txtIDDechet";
            this.txtIDDechet.Size = new System.Drawing.Size(278, 22);
            this.txtIDDechet.TabIndex = 8;
            // 
            // identifiantldechet
            // 
            this.identifiantldechet.AutoSize = true;
            this.identifiantldechet.Location = new System.Drawing.Point(346, 43);
            this.identifiantldechet.Name = "identifiantldechet";
            this.identifiantldechet.Size = new System.Drawing.Size(144, 17);
            this.identifiantldechet.TabIndex = 5;
            this.identifiantldechet.Text = "Identifiant du déchet :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date d\'entrée :";
            // 
            // txtDateEntreeDechet
            // 
            this.txtDateEntreeDechet.Location = new System.Drawing.Point(277, 258);
            this.txtDateEntreeDechet.Name = "txtDateEntreeDechet";
            this.txtDateEntreeDechet.Size = new System.Drawing.Size(278, 22);
            this.txtDateEntreeDechet.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date de sortie : ";
            // 
            // txtDateSortieDechet
            // 
            this.txtDateSortieDechet.Location = new System.Drawing.Point(277, 327);
            this.txtDateSortieDechet.Name = "txtDateSortieDechet";
            this.txtDateSortieDechet.Size = new System.Drawing.Size(278, 22);
            this.txtDateSortieDechet.TabIndex = 13;
            // 
            // FormDechetAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDateSortieDechet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateEntreeDechet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnregistrerDechet);
            this.Controls.Add(this.txtCompositionLabo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLibelleDechet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDDechet);
            this.Controls.Add(this.identifiantldechet);
            this.Name = "FormDechetAjout";
            this.Text = "FormDechetAjout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrerDechet;
        private System.Windows.Forms.TextBox txtCompositionLabo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLibelleDechet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDDechet;
        private System.Windows.Forms.Label identifiantldechet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateEntreeDechet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateSortieDechet;
    }
}