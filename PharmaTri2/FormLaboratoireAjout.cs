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
    public partial class FormLaboratoireAjout : Form
    {
        private readonly FormLaboratoire _parent;
        public string LABOId, LABOLocalisation, LABONom;

        public FormLaboratoireAjout(FormLaboratoire parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateLaboratoire()
        {
            btnEnregistrerLabo.Text = "Mettre à jour";
            txtIDLabo.Text = LABOId;
            txtLocalisationLabo.Text = LABOLocalisation;
            txtNomLabo.Text = LABONom;
        }

        private void btnEnregistrerLabo_Click(object sender, EventArgs e)
        {
            if(btnEnregistrerLabo.Text == "Ajouter")
            {
                Laboratoire labo = new Laboratoire(txtIDLabo.Text.Trim(), txtLocalisationLabo.Text.Trim(), txtNomLabo.Text.Trim());
                DB_Laboratoire.AddLaboratoire(labo);
                Clear();
            }

            if (btnEnregistrerLabo.Text == "Mettre à jour")
            {
                Laboratoire labo = new Laboratoire(txtIDLabo.Text.Trim(), txtLocalisationLabo.Text.Trim(), txtNomLabo.Text.Trim());
                DB_Laboratoire.UpdateLaboratoire(labo, LABOId);
            }
            _parent.Display();
        }

        private void LaboratoireAjout_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void SaveLaboratoire()
        {
            btnEnregistrerLabo.Text = "Ajouter";
        }

        public void Clear()
        {
            txtIDLabo.Text = txtLocalisationLabo.Text = txtNomLabo.Text = string.Empty;
        }

    }
}
