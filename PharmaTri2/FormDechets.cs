using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmaTri2
{
    public partial class FormDechets : Form
    {
        FormDechetAjout form;

        public FormDechets()
        {
            InitializeComponent();
            form = new FormDechetAjout(this);
        }

        private void btnAjouterLabo_Click(object sender, EventArgs e)
        {
            form.SaveLaboratoire();
            form.ShowDialog();
        }

        public void Display()
        {
            DB_Dechet.DisplayAndSearch("SELECT dechets.DECHETId, DECHETLibelle, LABOId, DECHETComposition, DECHETDateEntree, DECHETDateSortie FROM dechets, detail_dechet WHERE dechets.DECHETId = detail_dechet.DECHETId", dataGridViewDechet);
        }


        private void dataGridViewLaboratoire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormEvolution evolution = new FormEvolution();
            evolution.Show();
        }

        private void Laboratoire_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLaboratoire labo = new FormLaboratoire();
            labo.Show();
        }

        private void txtSearchLaboratoire_TextChanged(object sender, EventArgs e)
        {

        }

        private void Déchets_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDechets dechet = new FormDechets();
            dechet.Show();
        }

        private void FormDechets_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridViewDechet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // BOUTON EDIT 
            if (e.ColumnIndex == 1)
            {
                form.DECHETId = dataGridViewDechet.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.DECHETLibelle = dataGridViewDechet.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.DECHETComposition = dataGridViewDechet.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.UpdateDechet();
                form.ShowDialog();
                return;
            }

            // BOUTON DELETE
            if (e.ColumnIndex == 2)
            {
                if (MessageBox.Show("Supprimer les informations de ce laboratoire ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DB_Dechet.DeleteDechet(dataGridViewDechet.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
