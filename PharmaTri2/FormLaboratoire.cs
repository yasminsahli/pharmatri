using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace PharmaTri2
{
    public partial class FormLaboratoire : Form
    {
        FormLaboratoireAjout form;

        public FormLaboratoire()
        {
            InitializeComponent();
            form = new FormLaboratoireAjout(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connexion = new MySqlConnection("Server = localhost; User = root; Database = pharmatri2; Port = 3306; Password =; SSL Mode = None");

            try
            {
                connexion.Open();
                MessageBox.Show("Connexion établie");
                connexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Display()
        {
            DB_Laboratoire.DisplayAndSearch("SELECT * FROM laboratoire", dataGridViewLaboratoire);
        }

        private void FormLaboratoire_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearchLaboratoire_TextChanged(object sender, EventArgs e)
        {
            DB_Laboratoire.DisplayAndSearch("SELECT * FROM laboratoire WHERE LABOLocalisation LIKE '%" + txtSearchLaboratoire.Text + "%'", dataGridViewLaboratoire);
        }

        private void dataGridViewLaboratoire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // BOUTON EDIT 
            if (e.ColumnIndex == 0)
            {
                form.LABOId = dataGridViewLaboratoire.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.LABOLocalisation = dataGridViewLaboratoire.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.LABONom = dataGridViewLaboratoire.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.UpdateLaboratoire();
                form.ShowDialog();
                return;
            }

            // BOUTON DELETE
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Supprimer les informations de ce laboratoire ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DB_Laboratoire.DeleteLaboratoire(dataGridViewLaboratoire.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void btnAjouterLabo_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveLaboratoire();
            form.ShowDialog();
        }

        private void Déchets_Click(object sender, EventArgs e)
        {

                this.Hide();
                FormDechets dechet = new FormDechets();
                dechet.Show();

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
    }
}
