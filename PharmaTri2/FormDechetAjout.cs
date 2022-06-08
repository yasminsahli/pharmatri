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
    public partial class FormDechetAjout : Form
    {

        private readonly FormDechets _parent;
        public string DECHETId, DECHETLibelle, LABOId, DECHETComposition, DECHETDateEntree, DECHETDateSortie;

        private void btnEnregistrerDechet_Click(object sender, EventArgs e)
        {
            if (btnEnregistrerDechet.Text == "Ajouter")
            {
                Dechet dechet = new Dechet(Int32.Parse(txtIDDechet.Text), txtLibelleDechet.Text.Trim(), txtCompositionLabo.Text.Trim(), txtDateEntreeDechet.Text.Trim(), txtDateSortieDechet.Text.Trim());
                DB_Dechet.AddDechet(dechet);
                //Clear();
            }

            if (btnEnregistrerDechet.Text == "Mettre à jour")
            {
                Dechet dechet = new Dechet(Int32.Parse(txtIDDechet.Text), txtLibelleDechet.Text.Trim(), txtCompositionLabo.Text.Trim(), txtDateEntreeDechet.Text.Trim(), txtDateSortieDechet.Text.Trim());
                DB_Dechet.UpdateDechet(dechet, DECHETId);
            }
            _parent.Display();
        }

        public FormDechetAjout(FormDechets parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateDechet()
        {
            btnEnregistrerDechet.Text = "Mettre à jour";
            txtIDDechet.Text = DECHETId;
            txtLibelleDechet.Text = DECHETLibelle;
            txtCompositionLabo.Text = DECHETComposition;
            txtDateEntreeDechet.Text = DECHETDateEntree;
            txtDateSortieDechet.Text = DECHETDateSortie;
        }

        private void btnEnregistrerLabo_Click(object sender, EventArgs e)
        {
            if (btnEnregistrerDechet.Text == "Ajouter")
            {
                Dechet dechet = new Dechet(Int32.Parse(txtIDDechet.Text), txtLibelleDechet.Text.Trim(), txtCompositionLabo.Text.Trim(), txtDateEntreeDechet.Text.Trim(), txtDateSortieDechet.Text.Trim());
                DB_Dechet.AddDechet(dechet);
                // Clear();
            }

            if (btnEnregistrerDechet.Text == "Mettre à jour")
            {
                Dechet dechet = new Dechet(Int32.Parse(txtIDDechet.Text), txtLibelleDechet.Text.Trim(), txtCompositionLabo.Text.Trim(), txtDateEntreeDechet.Text.Trim(), txtDateSortieDechet.Text.Trim());
                DB_Dechet.UpdateDechet(dechet, DECHETId);
            }
            _parent.Display();
        }

        public void SaveLaboratoire()
        {
            btnEnregistrerDechet.Text = "Ajouter";
        }
    }
}
