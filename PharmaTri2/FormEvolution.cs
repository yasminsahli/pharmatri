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
    public partial class FormEvolution : Form
    {
        public FormEvolution()
        {
            InitializeComponent();
        }

        private void Laboratoire_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLaboratoire labo = new FormLaboratoire();
            labo.Show();
        }

        private void Déchets_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDechets dechet = new FormDechets();
            dechet.Show();
        }

        private void Evolution_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEvolution evolution = new FormEvolution();
            evolution.Show();
        }

        public void Display()
        {
            DB_Evolution.DisplayAndSearch("SELECT dechets.DECHETId, DECHETComposition, DECHETLibelle, DECHETDateEntree, ETATId FROM detail_dechet, dechets, traitement WHERE dechets.DECHETId = detail_dechet.DECHETId AND dechets.DECHETId = traitement.DECHETId", dataGridViewDechet);
        }

        private void FormEvolution_Shown(object sender, EventArgs e)
        {
            Display();
        }
    }
}
